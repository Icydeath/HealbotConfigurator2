using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealbotConfigurator2
{
  public partial class PotencyPrioritiesForm : MetroSetForm
  {
    private string CurrentValue = string.Empty;
    private List<string> Jobs = new List<string>() { "WAR", "MNK", "WHM", "BLM", "RDM", "THF", "PLD", "DRK", "BST", "BRD", "RNG", "SAM", "NIN", "DRG", "SMN", "BLU", "COR", "PUP", "DNC", "SCH", "GEO", "RUN" };
    private Dictionary<string, Dictionary<string, List<int>>> DefaultPotencies = new Dictionary<string, Dictionary<string, List<int>>>();

    public PotencyPrioritiesForm()
    {
      InitializeComponent();
      
      tabcontrol_Main.SelectedIndex = 0;
      lbl_Saved.Hide();

      DefaultPotencies.Add(string.Empty, new Dictionary<string, List<int>>());
      DefaultPotencies[string.Empty].Add("cure", new List<int> { 110, 250, 550, 1000, 1210, 1520 });
      DefaultPotencies[string.Empty].Add("curaga", new List<int> { 190, 353, 696, 1225, 1510 });
      DefaultPotencies[string.Empty].Add("waltz", new List<int> { 190, 325, 581, 887, 1156 });
      DefaultPotencies[string.Empty].Add("waltzga", new List<int> { 210, 521 });

      //foreach(var item in MainForm._HealbotData.CurePotencySets.Where(x => x.Key == "default").Select(x => x.Value).FirstOrDefault())
      //  DefaultPotencies.Add(item.Key, item.Value);
    }

    private void PotencyPrioritiesForm_Load(object sender, EventArgs e)
    {
      SetupPotencyControls();
      SetupPriorityControls();
    }

    private void btn_Close_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void cb_Priorities_SelectedIndexChanged(object sender, EventArgs e)
    {
      gv_Priorities.Rows.Clear();

      var selectedList = cb_Priorities.SelectedItem != null ? (string)cb_Priorities.SelectedItem : string.Empty;
      if (string.IsNullOrEmpty(selectedList))
        return;
      
      var priorties = MainForm._HealbotData.PrioritySets.Where(x => x.Key == selectedList).Select(x => x.Value).FirstOrDefault();
      if (priorties == null)
        return;

      foreach(var entry in priorties)
      {
        gv_Priorities.Rows.Add(new string[] { entry.Key, entry.Value.ToString()});
      }

      gv_Priorities.AllowUserToAddRows = false;
      gv_Priorities.RowHeadersVisible = false;
      //gv_Priorities.UserDeletingRow -= Gv_Priorities_UserDeletingRow;
      if (selectedList.ToLower() == "players")
      {
        gv_Priorities.AllowUserToAddRows = true;
        gv_Priorities.RowHeadersVisible = true;
        gv_Priorities.UserDeletingRow += Gv_Priorities_UserDeletingRow;
      }

      gv_Priorities.Refresh();
    }

    private void Gv_Priorities_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
      var selectedList = cb_Priorities.SelectedItem != null ? (string)cb_Priorities.SelectedItem : string.Empty;
      //if (selectedList.ToLower() != "players")
      //  return;

      var player = e.Row.Cells[0].Value != null ? e.Row.Cells[0].Value.ToString() : string.Empty;
      if (string.IsNullOrEmpty(player))
        return;
      player = player.UcFirst();
      
      MainForm._HealbotData.PrioritySets[selectedList].Remove(player);
    }

    private void gv_Priorities_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
      var selectedList = cb_Priorities.SelectedItem != null ? (string)cb_Priorities.SelectedItem : string.Empty;
      if (gv_Priorities.CurrentCell.ColumnIndex == 0 && selectedList.ToLower() != "players")
        e.Cancel = true;

      if (gv_Priorities.CurrentCell != null && gv_Priorities.CurrentCell.Value != null && gv_Priorities.CurrentCell.ColumnIndex != 0)
        CurrentValue = gv_Priorities.CurrentCell.Value.ToString();
    }

    private void gv_Priorities_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      var selectedList = cb_Priorities.SelectedItem != null ? (string)cb_Priorities.SelectedItem : string.Empty;
      var priorties = MainForm._HealbotData.PrioritySets.Where(x => x.Key == selectedList).Select(x => x.Value).FirstOrDefault();

      if (gv_Priorities.CurrentCell == null || gv_Priorities.CurrentCell.Value == null)
        return;

      if (gv_Priorities.CurrentCell.ColumnIndex == 1)
      {
        if (!gv_Priorities.CurrentCell.Value.ToString().IsNumeric())
        {
          gv_Priorities.CurrentCell.Value = CurrentValue;
          return;
        }

        CurrentValue = gv_Priorities.CurrentCell.Value.ToString();
        if (gv_Priorities.CurrentRow.Cells[0].Value != null)
        {
          var cell0 = gv_Priorities.CurrentRow.Cells[0].Value.ToString();
          if (selectedList.ToLower() == "players")
          {
            gv_Priorities.CurrentRow.Cells[0].Value = cell0.UcFirst();
            priorties[cell0.UcFirst()] = int.Parse(CurrentValue);
          }
          else
            priorties[cell0] = int.Parse(CurrentValue);
        }
      }
      else if (selectedList.ToLower() == "players")
      {
        var player = gv_Priorities.CurrentCell.Value != null ? gv_Priorities.CurrentCell.Value.ToString() : string.Empty;
        if (!string.IsNullOrEmpty(player))
        {
          player = player.UcFirst();
          gv_Priorities.CurrentCell.Value = player;
          if (!priorties.ContainsKey(player))
          {
            var p = 0;
            if (gv_Priorities.CurrentRow.Cells[1].Value != null && gv_Priorities.CurrentRow.Cells[1].Value.ToString().IsNumeric())
              p = int.Parse(gv_Priorities.CurrentRow.Cells[1].Value.ToString());
            priorties.Add(player, p);
          }
        }
      }
      
    }

    private void btn_SavePriority_Click(object sender, EventArgs e)
    {
      MainForm._HealbotData.SavePrioritySets();
      ShowSaved();
    }

    private void cb_PotencySetsJobs_SelectedIndexChanged(object sender, EventArgs e)
    {
      ClearPotencyTextBoxes();

      var selectedList = cb_PotencySets.SelectedItem != null ? (string)cb_PotencySets.SelectedItem : string.Empty;
      if (string.IsNullOrEmpty(selectedList))
        return;

      var selectedJob = cb_PotencySetsJobs.SelectedItem != null ? (string)cb_PotencySetsJobs.SelectedItem : string.Empty;
      if (string.IsNullOrEmpty(selectedJob))
        return;

      var potencyList = MainForm._HealbotData.CurePotencySets.Where(x => x.Key == selectedList).Select(x => x.Value).FirstOrDefault();
      if (potencyList == null)
        return;

      var potencies = potencyList.Where(x => x.Key == selectedJob).Select(x => x.Value).FirstOrDefault();
      if (potencies == null)
        return;

      if (potencies.ContainsKey("cure"))
      {
        txt_Cure1.Text = potencies["cure"][0].ToString();
        txt_Cure2.Text = potencies["cure"][1].ToString();
        txt_Cure3.Text = potencies["cure"][2].ToString();
        txt_Cure4.Text = potencies["cure"][3].ToString();
        txt_Cure5.Text = potencies["cure"][4].ToString();
        txt_Cure6.Text = potencies["cure"][5].ToString();
      }

      if (potencies.ContainsKey("curaga"))
      {
        txt_Curaga1.Text = potencies["curaga"][0].ToString();
        txt_Curaga2.Text = potencies["curaga"][1].ToString();
        txt_Curaga3.Text = potencies["curaga"][2].ToString();
        txt_Curaga4.Text = potencies["curaga"][3].ToString();
        txt_Curaga5.Text = potencies["curaga"][4].ToString();
      }

      if (potencies.ContainsKey("waltz"))
      {
        txt_Waltz1.Text = potencies["waltz"][0].ToString();
        txt_Waltz2.Text = potencies["waltz"][1].ToString();
        txt_Waltz3.Text = potencies["waltz"][2].ToString();
        txt_Waltz4.Text = potencies["waltz"][3].ToString();
        txt_Waltz5.Text = potencies["waltz"][4].ToString();
      }

      if (potencies.ContainsKey("waltzga"))
      {
        txt_Waltzga1.Text = potencies["waltzga"][0].ToString();
        txt_Waltzga2.Text = potencies["waltzga"][1].ToString();
      }
    }

    private void cb_PotencySets_SelectedIndexChanged(object sender, EventArgs e)
    {
      ClearPotencyTextBoxes();

      var selectedList = cb_PotencySets.SelectedItem != null ? (string)cb_PotencySets.SelectedItem : string.Empty;
      if (string.IsNullOrEmpty(selectedList))
        return;

      var potencies = MainForm._HealbotData.CurePotencySets.Where(x => x.Key == selectedList).Select(x => x.Value).FirstOrDefault();
      if (potencies == null)
        return;

      cb_PotencySetsJobs.Items.Clear();
      var setJobs = potencies.Select(x => x.Key);
      cb_PotencySetsJobs.Items.AddRange(setJobs.ToArray());

      if (setJobs.Count() == 1 && setJobs.FirstOrDefault() == string.Empty)
      {
        cb_PotencySetsJobs.Enabled = false;

        var job = setJobs.FirstOrDefault();
        if (potencies[job].ContainsKey("cure"))
        {
          txt_Cure1.Text = potencies[job]["cure"][0].ToString();
          txt_Cure2.Text = potencies[job]["cure"][1].ToString();
          txt_Cure3.Text = potencies[job]["cure"][2].ToString();
          txt_Cure4.Text = potencies[job]["cure"][3].ToString();
          txt_Cure5.Text = potencies[job]["cure"][4].ToString();
          txt_Cure6.Text = potencies[job]["cure"][5].ToString();
        }

        if (potencies[job].ContainsKey("curaga"))
        {
          txt_Curaga1.Text = potencies[job]["curaga"][0].ToString();
          txt_Curaga2.Text = potencies[job]["curaga"][1].ToString();
          txt_Curaga3.Text = potencies[job]["curaga"][2].ToString();
          txt_Curaga4.Text = potencies[job]["curaga"][3].ToString();
          txt_Curaga5.Text = potencies[job]["curaga"][4].ToString();
        }

        if (potencies[job].ContainsKey("waltz"))
        {
          txt_Waltz1.Text = potencies[job]["waltz"][0].ToString();
          txt_Waltz2.Text = potencies[job]["waltz"][1].ToString();
          txt_Waltz3.Text = potencies[job]["waltz"][2].ToString();
          txt_Waltz4.Text = potencies[job]["waltz"][3].ToString();
          txt_Waltz5.Text = potencies[job]["waltz"][4].ToString();
        }

        if (potencies[job].ContainsKey("waltzga"))
        {
          txt_Waltzga1.Text = potencies[job]["waltzga"][0].ToString();
          txt_Waltzga2.Text = potencies[job]["waltzga"][1].ToString();
        }
        return;
      }

      cb_PotencySetsJobs.Enabled = true;
    }

    private void btn_SaveSet_Click(object sender, EventArgs e)
    {
      var selectedList = cb_PotencySets.SelectedItem != null ? (string)cb_PotencySets.SelectedItem : string.Empty;
      if (string.IsNullOrEmpty(selectedList))
        return;

      var selectedJob = cb_PotencySetsJobs.SelectedItem != null ? (string)cb_PotencySetsJobs.SelectedItem : string.Empty;
      if (cb_PotencySetsJobs.Enabled && string.IsNullOrEmpty(selectedJob))
        return;

      if (!MainForm._HealbotData.CurePotencySets.ContainsKey(selectedList))
        return;

      Dictionary<string, List<int>> potencies;
      if (MainForm._HealbotData.CurePotencySets.ContainsKey(selectedList) 
            && !string.IsNullOrEmpty(selectedJob) 
            && MainForm._HealbotData.CurePotencySets[selectedList].ContainsKey(selectedJob))
      {
        potencies = MainForm._HealbotData.CurePotencySets[selectedList][selectedJob];
      }
      else
        potencies = MainForm._HealbotData.CurePotencySets[selectedList].FirstOrDefault().Value;
      

      if (potencies == null)
        return;

      if (potencies.ContainsKey("cure"))
      {
        potencies["cure"][0] = int.Parse(txt_Cure1.Text != "" ? txt_Cure1.Text : "60");
        potencies["cure"][1] = int.Parse(txt_Cure2.Text != "" ? txt_Cure2.Text : "160");
        potencies["cure"][2] = int.Parse(txt_Cure3.Text != "" ? txt_Cure3.Text : "240");
        potencies["cure"][3] = int.Parse(txt_Cure4.Text != "" ? txt_Cure4.Text : "380");
        potencies["cure"][4] = int.Parse(txt_Cure5.Text != "" ? txt_Cure5.Text : "500");
        potencies["cure"][5] = int.Parse(txt_Cure6.Text != "" ? txt_Cure6.Text : "800");
      }

      if (potencies.ContainsKey("curaga"))
      {
        potencies["curaga"][0] = int.Parse(txt_Curaga1.Text != "" ? txt_Curaga1.Text : "120");
        potencies["curaga"][1] = int.Parse(txt_Curaga2.Text != "" ? txt_Curaga2.Text : "260");
        potencies["curaga"][2] = int.Parse(txt_Curaga3.Text != "" ? txt_Curaga3.Text : "340");
        potencies["curaga"][3] = int.Parse(txt_Curaga4.Text != "" ? txt_Curaga4.Text : "580");
        potencies["curaga"][4] = int.Parse(txt_Curaga5.Text != "" ? txt_Curaga5.Text : "700");
      }

      if (potencies.ContainsKey("waltz"))
      {
        potencies["waltz"][0] = int.Parse(txt_Waltz1.Text != "" ? txt_Waltz1.Text : "70");
        potencies["waltz"][1] = int.Parse(txt_Waltz2.Text != "" ? txt_Waltz2.Text : "180");
        potencies["waltz"][2] = int.Parse(txt_Waltz3.Text != "" ? txt_Waltz3.Text : "360");
        potencies["waltz"][3] = int.Parse(txt_Waltz4.Text != "" ? txt_Waltz4.Text : "540");
        potencies["waltz"][4] = int.Parse(txt_Waltz5.Text != "" ? txt_Waltz5.Text : "740");
      }

      if (potencies.ContainsKey("waltzga"))
      {
        potencies["waltzga"][0] = int.Parse(txt_Waltzga1.Text != "" ? txt_Waltzga1.Text : "260");
        potencies["waltzga"][1] = int.Parse(txt_Waltzga2.Text != "" ? txt_Waltzga2.Text : "520");
      }

      MainForm._HealbotData.SaveCurePotencySets();
      ShowSaved();
    }

    private void btn_AddNewSet_Click(object sender, EventArgs e)
    {
      var setname = txt_NewSetName.Text;
      var job = cb_NewSet_Job.SelectedItem != null ? (string)cb_NewSet_Job.SelectedItem : string.Empty;
      if (string.IsNullOrWhiteSpace(setname))
        setname = "None";

      if (MainForm._HealbotData.CurePotencySets.ContainsKey(setname) && string.IsNullOrWhiteSpace(job))
        return;

      if (MainForm._HealbotData.CurePotencySets.ContainsKey(setname) && !string.IsNullOrWhiteSpace(job))
      {
        if (MainForm._HealbotData.CurePotencySets[setname].ContainsKey(job))
          return;

        if (MainForm._HealbotData.CurePotencySets[setname].ContainsKey(string.Empty))
          MainForm._HealbotData.CurePotencySets[setname].Remove(string.Empty);

        MainForm._HealbotData.CurePotencySets[setname].Add(job, new Dictionary<string, List<int>>());
        foreach (var item in DefaultPotencies.FirstOrDefault().Value)
        {
          MainForm._HealbotData.CurePotencySets[setname][job].Add(item.Key, item.Value);
        }
      }
      else if (!MainForm._HealbotData.CurePotencySets.ContainsKey(setname) && string.IsNullOrWhiteSpace(job))
      {
        MainForm._HealbotData.CurePotencySets.Add(setname, new Dictionary<string, Dictionary<string, List<int>>> {
          { string.Empty, new Dictionary<string, List<int>>()}
        });
        foreach (var item in DefaultPotencies[job])
        {
          MainForm._HealbotData.CurePotencySets[setname][job].Add(item.Key, item.Value);
        }
      }
      else if (!MainForm._HealbotData.CurePotencySets.ContainsKey(setname) && !string.IsNullOrWhiteSpace(job))
      {
        MainForm._HealbotData.CurePotencySets.Add(setname, new Dictionary<string, Dictionary<string, List<int>>>
        {
          { job, new Dictionary<string, List<int>>() }
        });

        foreach (var item in DefaultPotencies.FirstOrDefault().Value)
        {
          MainForm._HealbotData.CurePotencySets[setname][job].Add(item.Key, item.Value);
        }
      }

      MainForm._HealbotData.SaveCurePotencySets();
      SetupPotencyControls();
      ShowSaved();
    }

    private void btn_PotencyDelete_Click(object sender, EventArgs e)
    {
      var selectedList = cb_PotencySets.SelectedItem != null ? (string)cb_PotencySets.SelectedItem : string.Empty;
      if (string.IsNullOrEmpty(selectedList))
        return;

      var msg = $"Are you sure you want to DELETE [{selectedList}]\n and all of it's subsets?";
      var selectedJob = cb_PotencySetsJobs.SelectedItem != null ? (string)cb_PotencySetsJobs.SelectedItem : string.Empty;
      if (!string.IsNullOrEmpty(selectedJob))
        msg = $"Are you sure you want\n to DELETE [{selectedList}]'s subset [{selectedJob}]?";

      if (MetroSetMessageBox.Show(this, msg, " N O T I C E ", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        if (MainForm._HealbotData.CurePotencySets.ContainsKey(selectedList))
        {
          if (string.IsNullOrEmpty(selectedJob))
            MainForm._HealbotData.CurePotencySets.Remove(selectedList);
          else if (MainForm._HealbotData.CurePotencySets[selectedList].ContainsKey(selectedJob))
          {
            if (MainForm._HealbotData.CurePotencySets[selectedList].Keys.Count == 1)
              MainForm._HealbotData.CurePotencySets.Remove(selectedList);
            else
              MainForm._HealbotData.CurePotencySets[selectedList].Remove(selectedJob);
          }
          else
            return;

          MainForm._HealbotData.SaveCurePotencySets();
          SetupPotencyControls();
          ShowSaved();
        }
      }
    }

    public void ShowSaved()
    {
      lbl_Saved.Show();
      Timer timer = new Timer { Interval = 3000 };
      timer.Tick += (object sender, EventArgs e) =>
      {
        lbl_Saved.Hide();
        timer.Stop();
      }; 
      timer.Start();
    }

    private void SetupPriorityControls()
    {
      cb_Priorities.Items.AddRange(MainForm._HealbotData.PrioritySets.Select(x => x.Key).ToArray());
      gv_Priorities.ForeColor = Color.Black;
      //gv_Priorities.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
      gv_Priorities.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
      gv_Priorities.ColumnHeadersDefaultCellStyle.Font = new Font(gv_Priorities.Font, FontStyle.Bold);
      //gv_Priorities.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
      gv_Priorities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      gv_Priorities.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      gv_Priorities.CellBorderStyle = DataGridViewCellBorderStyle.Single;
      gv_Priorities.GridColor = Color.Black;
      gv_Priorities.RowHeadersVisible = false;
      gv_Priorities.AllowUserToAddRows = false;
      gv_Priorities.MultiSelect = false;

      gv_Priorities.ColumnCount = 2;
      gv_Priorities.Columns[0].Name = "Name";
      gv_Priorities.Columns[1].Name = "Priority";
    }

    private void SetupPotencyControls()
    {
      txt_NewSetName.Text = string.Empty;
      cb_NewSet_Job.Items.Clear();
      cb_PotencySets.Items.Clear();
      cb_PotencySetsJobs.Items.Clear();
      
      cb_NewSet_Job.Items.Add(string.Empty);
      cb_NewSet_Job.Items.AddRange(Jobs.ToArray());
      cb_PotencySets.Items.AddRange(MainForm._HealbotData.CurePotencySets.Select(x => x.Key).ToArray());
    }

    private void ClearPotencyTextBoxes()
    {
      txt_Cure1.Text = string.Empty;
      txt_Cure2.Text = string.Empty;
      txt_Cure3.Text = string.Empty;
      txt_Cure4.Text = string.Empty;
      txt_Cure5.Text = string.Empty;
      txt_Cure6.Text = string.Empty;

      txt_Curaga1.Text = string.Empty;
      txt_Curaga2.Text = string.Empty;
      txt_Curaga3.Text = string.Empty;
      txt_Curaga4.Text = string.Empty;
      txt_Curaga5.Text = string.Empty;

      txt_Waltz1.Text = string.Empty;
      txt_Waltz2.Text = string.Empty;
      txt_Waltz3.Text = string.Empty;
      txt_Waltz4.Text = string.Empty;
      txt_Waltz5.Text = string.Empty;
      
      txt_Waltzga1.Text = string.Empty;
      txt_Waltzga2.Text = string.Empty;
    }


  }
}