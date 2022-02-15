using EliteMMO.API;
using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealbotConfigurator2
{
  public partial class MainForm : MetroSetForm
  {
    public readonly string GlobalSettingsFile = "globalsettings.json";
    public readonly string DefaultSettingsFile = "defaultsettings.json";

    public static bool IsAdministrator => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
    public static EliteAPI _ELITEAPI;
    public static GlobalSettings _GlobalSettings;
    public static Settings _Settings;
    public static Resources _Resources;
    public static HealbotData _HealbotData;

    public static List<ComboboxItem> ComboboxItem_Players = new List<ComboboxItem>();
    public static List<string> SelectedBuffList = new List<string>();
    public static List<string> Buffs = new List<string>();

    #region UI Variables
    public readonly int MainForm_DefaultWidth = 615;
    public readonly int MainForm_DefaultHeight = 366;
    public readonly int MainForm_CollapseWidth = 265;

    public readonly Point CloseButton_CollapseLocation = new Point(239, 0);
    public readonly Point CloseButton_ExpandLocation = new Point(588, 0);

    public readonly Point MinimizeButton_CollapseLocation = new Point(213, 0);
    public readonly Point MinimizeButton_ExpandLocation = new Point(562, 0);

    public readonly Point CollapseExpandButton_CollapseLocation = new Point(232, 48);
    public readonly Point CollapseExpandButton_ExpandLocation = new Point(584, 47);


    public readonly Point WeaponskillToggle_CollapseLocation = new Point(133, 92);
    public readonly Point WeaponskillToggle_ExpandLocation = new Point(6, 5);

    public readonly Point EngageToggle_CollapseLocation = new Point(133, 120);
    public readonly Point EngageToggle_ExpandLocation = new Point(6, 33);

    public readonly Point WaitForToggle_CollapseLocation = new Point(133, 148);
    public readonly Point WaitForToggle_ExpandLocation = new Point(6, 61);


    public readonly Point WeaponskillLabel_CollapseLocation = new Point(191, 96);
    public readonly Point WeaponskillLabel_ExpandLocation = new Point(66, 9);

    public readonly Point EngageLabel_CollapseLocation = new Point(191, 121);
    public readonly Point EngageLabel_ExpandLocation = new Point(66, 34);

    public readonly Point WaitForLabel_CollapseLocation = new Point(191, 147);
    public readonly Point WaitForLabel_ExpandLocation = new Point(66, 59);

    public readonly ComboboxItem EmptyComboboxItem = new ComboboxItem { Text = "", Value = "" };
    #endregion

    public MainForm()
    {
      InitializeComponent();

      Width = MainForm_DefaultWidth;
      Height = MainForm_DefaultHeight;

      _GlobalSettings = new GlobalSettings();
      _Settings = new Settings();

      if (!File.Exists(DefaultSettingsFile))
        SaveSettings(DefaultSettingsFile);
    }

    #region UI Related Events
    private void btn_Close_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btn_Minimize_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    private void btn_CollapseExpand_Click(object sender, EventArgs e)
    {
      var iconName = btn_CollapseExpand.IconChar.ToString();
      if (iconName.ToLower() == "arrowcircleleft")
      {
        // Collapse the form
        Width = MainForm_CollapseWidth;
        
        btn_CollapseExpand.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
        btn_Close.Location = CloseButton_CollapseLocation;
        btn_Minimize.Location = MinimizeButton_CollapseLocation;
        btn_CollapseExpand.Location = CollapseExpandButton_CollapseLocation;

        toggle_Weaponskill.Location = WeaponskillToggle_CollapseLocation;
        lbl_WeaponskillToggle.Location = WeaponskillLabel_CollapseLocation;
        panel_Toggles.Controls.Add(toggle_Weaponskill);
        panel_Toggles.Controls.Add(lbl_WeaponskillToggle);

        toggle_Attack.Location = EngageToggle_CollapseLocation;
        lbl_EngageToggle.Location = EngageLabel_CollapseLocation;
        panel_Toggles.Controls.Add(toggle_Attack);
        panel_Toggles.Controls.Add(lbl_EngageToggle);

        toggle_WaitFor.Location = WaitForToggle_CollapseLocation;
        lbl_WaitForToggle.Location = WaitForLabel_CollapseLocation;
        panel_Toggles.Controls.Add(toggle_WaitFor);
        panel_Toggles.Controls.Add(lbl_WaitForToggle);

      }
      else
      {
        // Expand the form
        Width = MainForm_DefaultWidth;

        btn_CollapseExpand.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
        btn_Close.Location = CloseButton_ExpandLocation;
        btn_Minimize.Location = MinimizeButton_ExpandLocation;
        btn_CollapseExpand.Location = CollapseExpandButton_ExpandLocation;

        toggle_Weaponskill.Location = WeaponskillToggle_ExpandLocation;
        lbl_WeaponskillToggle.Location = WeaponskillLabel_ExpandLocation;
        panel_Combat.Controls.Add(toggle_Weaponskill);
        panel_Combat.Controls.Add(lbl_WeaponskillToggle);

        toggle_Attack.Location = EngageToggle_ExpandLocation;
        lbl_EngageToggle.Location = EngageLabel_ExpandLocation;
        panel_Combat.Controls.Add(toggle_Attack);
        panel_Combat.Controls.Add(lbl_EngageToggle);

        toggle_WaitFor.Location = WaitForToggle_ExpandLocation;
        lbl_WaitForToggle.Location = WaitForLabel_ExpandLocation;
        panel_Combat.Controls.Add(toggle_WaitFor);
        panel_Combat.Controls.Add(lbl_WaitForToggle);

      }
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
      Init();
    }

    private void btn_SetWindowerPath_Click(object sender, EventArgs e)
    {
      using (var fbd = new FolderBrowserDialog())
      {
        var result = fbd.ShowDialog();
        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
        {
          _GlobalSettings.WindowerPath = fbd.SelectedPath;
          SaveGlobalSettings();
          HideWarningText();
        }
      }
    }

    private void cb_SelectCharacter_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!IsAdministrator || string.IsNullOrEmpty(_GlobalSettings.WindowerPath))
      {
        cb_SelectCharacter.SelectedIndex = 0;
        return;
      }

      var selected = (ComboboxItem)cb_SelectCharacter.SelectedItem;
      if (string.IsNullOrEmpty(selected.Text))
        return;

      _ELITEAPI = new EliteAPI((int)selected.Value);
      _Resources = new Resources(_GlobalSettings.WindowerPath, _ELITEAPI);
      _HealbotData = new HealbotData(_GlobalSettings.WindowerPath);

      SendCommand("lua load healbot");

      InitResourceControls();
      LoadSettingsByJob();
    }

    private void btn_SaveSettings_Click(object sender, EventArgs e)
    {
      // Update Settings lists with current values
      _Settings.Buffs.Clear();
      _Settings.Debuffs.Clear();
      _Settings.MonitorsIgnores.Clear();

      _Settings.Buffs.AddRange(lb_Buffs.Items.Select(x => x.ToString().Replace("→ ", "")).ToList());
      _Settings.Debuffs.AddRange(lb_Debuff.Items.Select(x => x.ToString()).ToList());
      _Settings.MonitorsIgnores.AddRange(lb_MonitorsIgnores.Items.Select(x => x.ToString()).ToList());

      var mainjob = _Resources.Jobs.Where(x => x.Id == _ELITEAPI.Player.MainJob).FirstOrDefault().Name;
      var subjob = _Resources.Jobs.Where(x => x.Id == _ELITEAPI.Player.SubJob).FirstOrDefault().Name;

      var sfd = new SaveFileDialog
      {
        AddExtension = true,
        Filter = "Json File|*.json",
        Title = "Save configurator settings.",
        FileName = $"{_ELITEAPI.Player.Name}_{mainjob}_{subjob}.json"
      };

      if (sfd.ShowDialog() == DialogResult.Cancel)
        return;

      if (!string.IsNullOrEmpty(sfd.FileName))
      {
        SaveSettings(sfd.FileName);
      }
    }

    private void btn_LoadSettings_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog ofd = new OpenFileDialog())
      {
        ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
        ofd.Filter = "Json File|*.json";
        ofd.RestoreDirectory = true;
        ofd.Title = "Load configurator setting.";

        if (ofd.ShowDialog() == DialogResult.Cancel)
          return;
        
        if (!string.IsNullOrEmpty(ofd.FileName))
        {
          var filename = ofd.FileName;
          if (filename.Contains("globalsettings"))
          {
            MetroSetMessageBox.Show(this, $"Invalid config file: {filename}", " E R R O R ");
            return;
          }
          LoadSettings(filename);
        }
      }
    }

    private void btn_LoadBuffList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      var buffListForm = new LoadBuffListForm();
      buffListForm.FormClosed += BuffListForm_FormClosed;
      buffListForm.StartPosition = FormStartPosition.Manual;
      buffListForm.Location = new Point(Location.X + 150, Location.Y + 50);
      buffListForm.ShowDialog();
    }

    private void BuffListForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (SelectedBuffList.Count == 0)
      {
        return;
      }

      lb_Buffs.Items.Clear();
      lb_Buffs.Items.AddRange(SelectedBuffList);

      foreach (var item in lb_Buffs.Items)
      {
        SendCommand("hb buff " + item);
      }
    }

    private void btn_HealbotLoad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      SendCommand("lua load healbot");
    }

    private void btn_HealbotUnload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      SendCommand("lua unload healbot");
    }

    private void toggle_SwitchedChanged(object sender)
    {
      var toggle = (MetroSetSwitch)sender;
      var feature = toggle.Name.Split('_')[1];
      feature = feature.ToLower();
      SendCommandByFeature(feature, toggle.Switched);
    }

    private void cb_Feature_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox cb;
      if (sender.GetType() == typeof(MetroSetComboBox))
        cb = (MetroSetComboBox)sender;
      else
        cb = (ComboBox)sender;

      var feature = cb.Name.Split('_').Count() > 1 ? cb.Name.Split('_')[1] : string.Empty;
      feature = feature.ToLower();
      if (string.IsNullOrWhiteSpace(feature))
        return;
      
      var cbText = !string.IsNullOrEmpty(cb.Text) ? cb.Text : cb.SelectedItem != null ? ((ComboboxItem)cb.SelectedItem).Text : string.Empty;
      if (string.IsNullOrWhiteSpace(cbText))
        return;

      if (feature == "weaponskill")
      {
        feature = "ws";
        _Settings.Weaponskill = cbText;
        SendCommand($"hb {feature} use {cbText}");
        return;
      }

      if (feature == "weaponskillhpoperator")
      {
        feature = "ws";
        _Settings.WeaponskillHpOperator = cbText;
        SendCommand($"hb {feature} hp {cbText.Trim()} {num_WeaponskillHpPercent.Value}");
        return;
      }

      if (feature == "waitfor" && toggle_WaitFor.Switched)
      {
        _Settings.WaitForPlayer = cbText;
        _Settings.WaitForTp = (int)num_WaitFor.Value;
        SendCommand($"hb ws {feature} {cbText} {num_WaitFor.Value}");
        return;
      }

      if (feature == "assist" && toggle_Assist.Switched && cbText.ToLower() != _ELITEAPI.Player.Name.ToLower())
      {
        _Settings.AssistPlayer = cbText;
        SendCommand($"hb {feature} {cbText}");
        return;
      }

      if (feature == "follow" && toggle_Follow.Switched && cbText.ToLower() != _ELITEAPI.Player.Name.ToLower())
      {
        _Settings.FollowPlayer = cbText;
        SendCommand($"hb {feature} {cbText}");
        return;
      }

      if (feature == "spam" && toggle_Follow.Switched)
      {
        _Settings.SpamSpell = cbText;
        SendCommand($"hb {feature} {cbText}");
        return;
      }
    }

    private void btn_Buff_Click(object sender, EventArgs e)
    {
      var player = cb_BuffPlayer.SelectedItem != null ? ((ComboboxItem)cb_BuffPlayer.SelectedItem).Text : !string.IsNullOrEmpty(cb_BuffPlayer.Text) ? cb_BuffPlayer.Text : _ELITEAPI.Player.Name;
      var buff = cb_BuffSpell.SelectedItem != null ? ((ComboboxItem)cb_BuffSpell.SelectedItem).Text : !string.IsNullOrEmpty(cb_BuffSpell.Text) ? cb_BuffSpell.Text : string.Empty;
      if (string.IsNullOrEmpty(buff))
        return;

      var cmd = player + " → " + buff;
      if (lb_Buffs.Items.Any(x => x.ToString() == cmd))
        return;

      lb_Buffs.Items.Add(cmd);
      SendCommand($"hb buff {cmd.Replace("→ ", "")}");
    }

    private void btn_Debuff_Click(object sender, EventArgs e)
    {
      var debuff = cb_DebuffSpell.SelectedItem != null ? ((ComboboxItem)cb_DebuffSpell.SelectedItem).Text : !string.IsNullOrEmpty(cb_DebuffSpell.Text) ? cb_DebuffSpell.Text : string.Empty;
      if (string.IsNullOrEmpty(debuff))
        return;

      if (lb_Debuff.Items.Any(x => x.ToString() == debuff)) return;

      lb_Debuff.Items.Add(debuff);
      SendCommand($"hb debuff {debuff}");
    }

    private void btn_Monitor_Click(object sender, EventArgs e)
    {
      var player = cb_MonitorIgnorePlayer.SelectedItem != null ? ((ComboboxItem)cb_MonitorIgnorePlayer.SelectedItem).Text : !string.IsNullOrEmpty(cb_MonitorIgnorePlayer.Text) ? cb_MonitorIgnorePlayer.Text : string.Empty;
      if (string.IsNullOrEmpty(player))
        return;

      var cmd = $"watch {player}";
      if (lb_MonitorsIgnores.Items.Any(x => x.ToString() == cmd))
        return;

      lb_MonitorsIgnores.Items.Add(cmd);
      SendCommand($"hb {cmd}");
    }

    private void btn_Ignore_Click(object sender, EventArgs e)
    {
      var player = cb_MonitorIgnorePlayer.SelectedItem != null ? ((ComboboxItem)cb_MonitorIgnorePlayer.SelectedItem).Text : !string.IsNullOrEmpty(cb_MonitorIgnorePlayer.Text) ? cb_MonitorIgnorePlayer.Text : string.Empty;
      if (string.IsNullOrEmpty(player))
        return;

      var cmd = $"ignore {player}";
      if (lb_MonitorsIgnores.Items.Any(x => x.ToString() == cmd))
        return;

      lb_MonitorsIgnores.Items.Add(cmd);
      SendCommand($"hb {cmd}");
    }

    private void lb_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      var lb = (MetroSetListBox)sender;
      var feature = lb.Name.Split('_')[1].ToLower();

      var item = lb.SelectedItem != null ? lb.SelectedItem.ToString() : string.Empty;
      if (string.IsNullOrEmpty(item))
        return;

      lb.Items.Remove(lb.SelectedItem);
      if (feature == "buffs")
        SendCommand($"hb cancelbuff {item.Replace("→ ", "")}");
      else if (feature == "debuff")
        SendCommand($"hb {feature} remove {item}");
      else
        SendCommand($"hb un{item}");
    }

    private void btn_ClearDebuffs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      foreach(var item in lb_Debuff.Items)
        SendCommand($"hb debuff remove {item}");
      lb_Debuff.Items.Clear();
    }

    private void btn_ClearMonitorsIgnores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      foreach (var item in lb_MonitorsIgnores.Items)
        SendCommand($"hb un{item}");
      lb_MonitorsIgnores.Items.Clear();
    }

    private void btn_ClearBuffs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      foreach (var item in lb_Buffs.Items)
        SendCommand($"hb cancelbuff {item.ToString().Replace("→ ", "")}");
      lb_Buffs.Items.Clear();
    }

    private void btn_SaveBuffList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (_HealbotData == null)
        return;

      foreach(var item in lb_Buffs.Items)
      {
        if (!Buffs.Contains(item.ToString().Split('→')[1].Trim()))
        {
          Buffs.Add(item.ToString().Split('→')[1].Trim());
        }
      }

      var saveBuffListForm = new SaveBuffListForm();
      saveBuffListForm.StartPosition = FormStartPosition.Manual;
      saveBuffListForm.Location = new Point(Location.X + 150, Location.Y + 50);
      saveBuffListForm.ShowDialog();
    }

    private void btn_HealbotRefresh_Click(object sender, EventArgs e)
    {
      if (_ELITEAPI == null)
        return;

      SendCommand("hb refresh");
    }

    private void btn_PotencyPriority_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (_HealbotData == null) return;

      var potencyPrioritiesForm = new PotencyPrioritiesForm
      {
        StartPosition = FormStartPosition.Manual,
        Location = new Point(Location.X + 100, Location.Y - 10)
      };
      potencyPrioritiesForm.ShowDialog();
    }

    private void btn_HealbotOff_Click(object sender, EventArgs e)
    {
      SendCommand("hb off");
    }

    private void btn_HealbotOn_Click(object sender, EventArgs e)
    {
      SendCommand("hb on");
    }

    private void num_MinCure_ValueChanged(object sender, EventArgs e)
    {
      _Settings.MinCuraga = (int)num_MinCure.Value;
      SendCommand($"hb mincure {num_MinCure.Value}");
    }

    private void num_MinCuraga_ValueChanged(object sender, EventArgs e)
    {
      _Settings.MinCuraga = (int)num_MinCuraga.Value;
      SendCommand($"hb mincuraga {num_MinCuraga.Value}");
    }

    private void num_FollowDistance_ValueChanged(object sender, EventArgs e)
    {
      _Settings.FollowDistance = (int)num_FollowDistance.Value;
      SendCommand($"hb follow distance {num_FollowDistance.Value}");
    }

    private void num_WeaponskillHpPercent_ValueChanged(object sender, EventArgs e)
    {
      _Settings.WeaponskillHpPercent = (int)num_WeaponskillHpPercent.Value;

      var hpOperator = !string.IsNullOrEmpty(cb_WeaponskillHpOperator.Text) ? cb_WeaponskillHpOperator.Text : cb_WeaponskillHpOperator.SelectedItem != null ? ((ComboboxItem)cb_WeaponskillHpOperator.SelectedItem).Text : string.Empty;
      if (string.IsNullOrEmpty(hpOperator))
        return;
      SendCommand($"hb ws hp {hpOperator} {num_WeaponskillHpPercent}");
    }

    private void num_WaitFor_ValueChanged(object sender, EventArgs e)
    {
      _Settings.WaitForTp = (int)num_WaitFor.Value;

      var player = !string.IsNullOrEmpty(cb_WaitFor.Text) ? cb_WaitFor.Text : cb_WaitFor.SelectedItem != null ? ((ComboboxItem)cb_WaitFor.SelectedItem).Text : string.Empty;
      if (string.IsNullOrEmpty(player))
        return;
      SendCommand($"hb ws waitfor {player} {num_WaitFor.Value}");
    }
    #endregion

    private void Init()
    {
      if (!IsAdministrator)
      {
        lbl_Warning.Show();
        img_Warning.Show();
        MetroSetMessageBox.Show(this, "EliteMMO requires administrator rights.\n\n1. Close HealbotConfigurator2\n2. Right click 'HealbotConfigurator2.exe' -> 'Run as administrator'\n", "\t[ W A R N I N G ]");
        return;
      }

      cb_SelectCharacter.Items.Add(EmptyComboboxItem);
      cb_Follow.Items.Add(EmptyComboboxItem);
      cb_MonitorIgnorePlayer.Items.Add(EmptyComboboxItem);
      cb_BuffPlayer.Items.Add(EmptyComboboxItem);
      cb_Assist.Items.Add(EmptyComboboxItem);
      cb_WaitFor.Items.Add(EmptyComboboxItem);
      
      if (InitEliteMMOControls())
      {
        LoadGlobalConfig();
      }
    }

    private bool InitEliteMMOControls()
    {
      IEnumerable<Process> pol = Process.GetProcessesByName("pol").Union(Process.GetProcessesByName("xiloader")).Union(Process.GetProcessesByName("edenxi"));
      if (pol.Count() < 1)
      {
        MetroSetMessageBox.Show(this, "Unable to find an FFXI instance.", "\t[ W A R N I N G ]");
        return false;
      }

      for (int i = 0; i < pol.Count(); i++)
      {
        var ch = pol.ElementAt(i).MainWindowTitle;
        var cbi_Player = new ComboboxItem { Text = ch, Value = pol.ElementAt(i).Id };
        ComboboxItem_Players.Add(cbi_Player);
      }

      cb_SelectCharacter.Items.AddRange(ComboboxItem_Players.ToArray());
      cb_Follow.Items.AddRange(ComboboxItem_Players.ToArray());
      cb_MonitorIgnorePlayer.Items.AddRange(ComboboxItem_Players.ToArray());
      cb_BuffPlayer.Items.AddRange(ComboboxItem_Players.ToArray());
      cb_Assist.Items.AddRange(ComboboxItem_Players.ToArray());
      cb_WaitFor.Items.AddRange(ComboboxItem_Players.ToArray());

      return true;
    }

    private void InitResourceControls()
    {
      cb_WeaponskillHpOperator.Items.Clear();
      cb_Spam.Items.Clear();
      cb_Weaponskill.Items.Clear();
      cb_BuffSpell.Items.Clear();
      cb_DebuffSpell.Items.Clear();

      var list = new List<ComboboxItem> {EmptyComboboxItem, new ComboboxItem { Text = " > ", Value = ">" }, new ComboboxItem { Text = " < ", Value = "<" } };
      cb_WeaponskillHpOperator.Items.AddRange(list.ToArray());

      list = new List<ComboboxItem>() { EmptyComboboxItem };
      foreach(var item in _Resources.Spells)
        list.Add(new ComboboxItem { Text = item.Name, Value = item.Id });
      cb_Spam.Items.AddRange(list.ToArray());

      list = new List<ComboboxItem>() { EmptyComboboxItem };
      foreach (var item in _Resources.Weaponskills)
        list.Add(new ComboboxItem { Text = item.Name, Value = item.Id });
      cb_Weaponskill.Items.AddRange(list.ToArray());
      
      list = new List<ComboboxItem>() { EmptyComboboxItem };
      foreach (var item in _Resources.BuffSpells)
        list.Add(new ComboboxItem { Text = item.Name, Value = item.Id });
      cb_BuffSpell.Items.AddRange(list.ToArray());
      cb_DebuffSpell.Items.AddRange(list.ToArray());

      list = new List<ComboboxItem>();
      foreach (var item in _Resources.BuffAbilities)
        list.Add(new ComboboxItem { Text = item.Name, Value = item.Id });
      cb_BuffSpell.Items.AddRange(list.ToArray());
      cb_DebuffSpell.Items.AddRange(list.ToArray());
    }

    private void LoadGlobalConfig()
    {
      if (!File.Exists(GlobalSettingsFile))
      {
        string defaultsettings = JsonConvert.SerializeObject(_GlobalSettings, Formatting.Indented);
        File.WriteAllText(GlobalSettingsFile, defaultsettings);
      }
      _GlobalSettings = JsonConvert.DeserializeObject<GlobalSettings>(File.ReadAllText(GlobalSettingsFile));

      if (string.IsNullOrEmpty(_GlobalSettings.WindowerPath))
      {
        ShowWarningText("WINDOWER PATH NOT SET");
        MetroSetMessageBox.Show(this, "Windower folder path not set.\n\nPlease set the windower folder path using the 'Set Windower Path' button.", "\t[ W A R N I N G ]");
        return;
      }
    }

    private void LoadSettingsByJob()
    {
      var mainjob = _Resources.Jobs.Where(x => x.Id == _ELITEAPI.Player.MainJob).FirstOrDefault();
      var subjob = _Resources.Jobs.Where(x => x.Id == _ELITEAPI.Player.SubJob).FirstOrDefault();

      var settingsfile = _ELITEAPI != null ? $"{_ELITEAPI.Player.Name}_{mainjob.Name}_{subjob.Name}.json" : "";
      if (string.IsNullOrEmpty(settingsfile) || !File.Exists(settingsfile))
        settingsfile = DefaultSettingsFile;

      _Settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(settingsfile));
      InitSettingsControls();
    }

    private void LoadSettings(string settingsfile)
    {
      _Settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(settingsfile));
      InitSettingsControls();
    }

    private void InitSettingsControls()
    {
      toggle_Cure.Switched = _Settings.CureEnabled;
      toggle_Curaga.Switched = _Settings.CuragaEnabled;
      toggle_Na.Switched = _Settings.NaSpellsEnabled;
      toggle_Erase.Switched = _Settings.EraseEnabled;
      toggle_Buffs.Switched = _Settings.BuffsEnabled;
      toggle_Debuffs.Switched = _Settings.DebuffsEnabled;
      toggle_IgnoreTrusts.Switched = _Settings.IgnoreTrustsEnabled;
      toggle_Follow.Switched = _Settings.FollowEnabled;
      toggle_Assist.Switched = _Settings.AssistEnabled;
      toggle_Spam.Switched = _Settings.SpamEnabled;
      toggle_Weaponskill.Switched = _Settings.WeaponskillEnabled;
      toggle_Attack.Switched = _Settings.EngageEnabled;
      toggle_WaitFor.Switched = _Settings.WaitForEnabled;

      cb_Spam.Text = _Settings.SpamSpell;
      cb_Follow.Text = _Settings.FollowPlayer;
      cb_Weaponskill.Text = _Settings.Weaponskill;
      cb_WaitFor.Text = _Settings.WaitForPlayer;
      cb_WeaponskillHpOperator.Text = _Settings.WeaponskillHpOperator;


      lb_Buffs.Items.Clear();
      lb_Debuff.Items.Clear();
      lb_MonitorsIgnores.Items.Clear();

      foreach (var item in _Settings.Buffs)
        SendCommand($"hb buff {item}");
      lb_Buffs.AddItems(_Settings.Buffs.ToArray());

      foreach (var item in _Settings.Debuffs)
        SendCommand($"hb debuff {item}");
      lb_Debuff.AddItems(_Settings.Debuffs.ToArray());

      foreach (var item in _Settings.MonitorsIgnores)
        SendCommand($"hb {item}");
      lb_MonitorsIgnores.AddItems(_Settings.MonitorsIgnores.ToArray());
    }

    public void SaveGlobalSettings()
    {
      string json = JsonConvert.SerializeObject(_GlobalSettings, Formatting.Indented);
      File.WriteAllText(GlobalSettingsFile, json);
    }

    public void SaveSettings(string filename)
    {
      string json = JsonConvert.SerializeObject(_Settings, Formatting.Indented);
      File.WriteAllText(filename, json);
    }

    public void ShowWarningText(string warning)
    {
      if (!string.IsNullOrEmpty(warning))
        lbl_Warning.Text = warning;

      img_Warning.Show();
      lbl_Warning.Show();
    }

    public void HideWarningText()
    {
      lbl_Warning.Text = "";
      lbl_Warning.Hide();
      img_Warning.Hide();
    }

    private void SendCommand(string cmd)
    {
      if (_ELITEAPI == null)
        return;

      if (_GlobalSettings.Debugging)
        _ELITEAPI.ThirdParty.SendString(@"/echo " + cmd);

      _ELITEAPI.ThirdParty.SendString(@"//" + cmd);
    }

    private void SendCommandByFeature(string feature, bool on = false)
    {
      var featureCmd = on ? "enable" : "disable";
      if (feature == "ignoretrusts")
      {
        _Settings.IgnoreTrustsEnabled = on;
        featureCmd = on ? "on" : "off";
        SendCommand($"hb {feature} {featureCmd}");
        return;
      }
      
      if (feature == "follow")
      {
        _Settings.FollowEnabled = on;
        var player = cb_Follow.SelectedItem != null ? ((ComboboxItem)cb_Follow.SelectedItem).Text : cb_Follow.Text;
        if (on && !string.IsNullOrWhiteSpace(player) && player.ToLower() != _ELITEAPI.Player.Name.ToLower())
        {
          var followdistance = (int)num_FollowDistance.Value;
          _Settings.FollowPlayer = player;
          _Settings.FollowDistance = followdistance;
          SendCommand($"hb {feature} {player};hb {feature} distance {followdistance}");
        }
        else
        {
          _Settings.FollowPlayer = string.Empty;
          SendCommand($"hb {feature} off");
        }
        return;
      }
      
      if (feature == "assist")
      {
        _Settings.AssistEnabled = on;
        var player = !string.IsNullOrEmpty(cb_Assist.Text) ? cb_Assist.Text : cb_Assist.SelectedItem != null ? ((ComboboxItem)cb_Assist.SelectedItem).Text : string.Empty;
        if (on && !string.IsNullOrWhiteSpace(player) && player.ToLower() != _ELITEAPI.Player.Name.ToLower())
        {
          _Settings.AssistPlayer = player;
          SendCommand($"hb {feature} {player}");
        }
        else if (!on)
        {
          _Settings.AssistPlayer = string.Empty;
          SendCommand($"hb {feature} off"); 
        }
        return;
      }
      
      if (feature == "spam")
      {
        _Settings.SpamEnabled = on;
        var spell = !string.IsNullOrEmpty(cb_Spam.Text) ? cb_Spam.Text : cb_Spam.SelectedItem != null ? ((ComboboxItem)cb_Spam.SelectedItem).Text : string.Empty;
        if (on && !string.IsNullOrEmpty(spell))
        {
          _Settings.SpamSpell = spell;
          SendCommand($"hb {feature} {spell}");
        }
        else if (!on)
        {
          _Settings.SpamSpell = string.Empty;
          SendCommand($"hb {featureCmd} {feature}"); 
        }
        return;
      }

      if (feature == "waitfor")
      {
        _Settings.WaitForEnabled = on;
        var player = !string.IsNullOrEmpty(cb_WaitFor.Text) ? cb_WaitFor.Text : cb_WaitFor.SelectedItem != null ? ((ComboboxItem)cb_WaitFor.SelectedItem).Text : string.Empty;
        _Settings.WaitForPlayer = player;
        _Settings.WaitForTp = (int)num_WaitFor.Value;
        if (on && !string.IsNullOrWhiteSpace(player))
        {
          SendCommand($"hb ws {feature} {player} {num_WaitFor.Value}");
        }
        else if (!on)
        {
          SendCommand($"hb ws nopartner");
        }
        return;
      }
      
      if (feature == "weaponskill")
      {
        feature = "ws";
        _Settings.WeaponskillEnabled = on;

        var weaponskill = !string.IsNullOrEmpty(cb_Weaponskill.Text) ? cb_Weaponskill.Text : cb_Weaponskill.SelectedItem != null ? ((ComboboxItem)cb_Weaponskill.SelectedItem).Text : string.Empty;
        _Settings.Weaponskill = weaponskill;
        if (!string.IsNullOrEmpty(weaponskill))
        {
          SendCommand($"hb {feature} use {weaponskill}");
        }

        var hpOperator = !string.IsNullOrEmpty(cb_WeaponskillHpOperator.Text) ? cb_WeaponskillHpOperator.Text.Trim() : cb_WeaponskillHpOperator.SelectedItem != null ? ((ComboboxItem)cb_WeaponskillHpOperator.SelectedItem).Text.Trim() : string.Empty;
        var hpPercent = (int)num_WeaponskillHpPercent.Value;
        _Settings.WeaponskillHpOperator = $" {hpOperator} ";
        _Settings.WeaponskillHpPercent = hpPercent;
        if (!string.IsNullOrEmpty(hpOperator))
        {
          SendCommand($"hb {feature} hp {hpOperator} {hpPercent}");
        }

        SendCommand($"hb {featureCmd} {feature}");
        return;
      }

      if (feature == "attack")
      {
        _Settings.EngageEnabled = on;
        featureCmd = on ? "on" : "off";
        SendCommand($"hb assist {feature} {featureCmd}");
        return;
      }

      if (feature == "cure")
      {
        var mincure = (int)num_MinCure.Value;
        _Settings.CureEnabled = on;
        _Settings.MinCure = mincure;
        if (on)
        {
          SendCommand($"hb min{feature} {mincure}");
        }

        SendCommand($"hb {featureCmd} {feature}");
        return;
      }

      if (feature == "curaga")
      {
        var mincuraga = (int)num_MinCure.Value;
        _Settings.CuragaEnabled = on;
        _Settings.MinCuraga = mincuraga;
        if (on)
        {
          SendCommand($"hb min{feature} {mincuraga}");
        }

        SendCommand($"hb {featureCmd} {feature}");
        return;
      }

      if (feature == "na")
      {
        _Settings.NaSpellsEnabled = on;
        SendCommand($"hb {featureCmd} {feature}");
        return;
      }

      if (feature == "erase")
      {
        _Settings.EraseEnabled = on;
        SendCommand($"hb {featureCmd} {feature}");
        return;
      }

      if (feature == "buffs")
      {
        _Settings.BuffsEnabled = on;
        SendCommand($"hb {featureCmd} {feature}");
        return;
      }

      if (feature == "debuffs")
      {
        _Settings.DebuffsEnabled = on;
        SendCommand($"hb {featureCmd} {feature}");
        return;
      }

      SendCommand($"hb {featureCmd} {feature}");
    }
  }


  public class ComboboxItem
  {
    public string Text { get; set; }
    public object Value { get; set; }

    public override string ToString()
    {
      return Text;
    }
  }
}
