
namespace HealbotConfigurator2
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.panel_Toggles = new MetroSet_UI.Controls.MetroSetPanel();
      this.cb_Spam = new System.Windows.Forms.ComboBox();
      this.num_FollowDistance = new System.Windows.Forms.NumericUpDown();
      this.toggle_Spam = new MetroSet_UI.Controls.MetroSetSwitch();
      this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
      this.num_MinCuraga = new System.Windows.Forms.NumericUpDown();
      this.cb_Follow = new System.Windows.Forms.ComboBox();
      this.cb_Assist = new System.Windows.Forms.ComboBox();
      this.num_MinCure = new System.Windows.Forms.NumericUpDown();
      this.toggle_Follow = new MetroSet_UI.Controls.MetroSetSwitch();
      this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
      this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
      this.toggle_IgnoreTrusts = new MetroSet_UI.Controls.MetroSetSwitch();
      this.toggle_Assist = new MetroSet_UI.Controls.MetroSetSwitch();
      this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
      this.metroSetLabel14 = new MetroSet_UI.Controls.MetroSetLabel();
      this.toggle_Debuffs = new MetroSet_UI.Controls.MetroSetSwitch();
      this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
      this.toggle_Buffs = new MetroSet_UI.Controls.MetroSetSwitch();
      this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
      this.toggle_Erase = new MetroSet_UI.Controls.MetroSetSwitch();
      this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
      this.toggle_Na = new MetroSet_UI.Controls.MetroSetSwitch();
      this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
      this.toggle_Curaga = new MetroSet_UI.Controls.MetroSetSwitch();
      this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
      this.toggle_Cure = new MetroSet_UI.Controls.MetroSetSwitch();
      this.toggle_WaitFor = new MetroSet_UI.Controls.MetroSetSwitch();
      this.toggle_Attack = new MetroSet_UI.Controls.MetroSetSwitch();
      this.toggle_Weaponskill = new MetroSet_UI.Controls.MetroSetSwitch();
      this.metroSetSetToolTip1 = new MetroSet_UI.Components.MetroSetSetToolTip();
      this.btn_HealbotOn = new MetroSet_UI.Controls.MetroSetButton();
      this.btn_HealbotOff = new MetroSet_UI.Controls.MetroSetButton();
      this.btn_HealbotRefresh = new MetroSet_UI.Controls.MetroSetButton();
      this.btn_LoadBuffList = new MetroSet_UI.Controls.MetroSetLink();
      this.btn_SaveBuffList = new MetroSet_UI.Controls.MetroSetLink();
      this.lb_Buffs = new MetroSet_UI.Controls.MetroSetListBox();
      this.cb_BuffSpell = new System.Windows.Forms.ComboBox();
      this.cb_BuffPlayer = new System.Windows.Forms.ComboBox();
      this.cb_MonitorIgnorePlayer = new System.Windows.Forms.ComboBox();
      this.lb_MonitorsIgnores = new MetroSet_UI.Controls.MetroSetListBox();
      this.btn_Buff = new MetroSet_UI.Controls.MetroSetButton();
      this.btn_Monitor = new MetroSet_UI.Controls.MetroSetButton();
      this.btn_Ignore = new MetroSet_UI.Controls.MetroSetButton();
      this.btn_SetWindowerPath = new FontAwesome.Sharp.IconButton();
      this.btn_LoadSettings = new FontAwesome.Sharp.IconButton();
      this.btn_SaveSettings = new FontAwesome.Sharp.IconButton();
      this.lb_Debuff = new MetroSet_UI.Controls.MetroSetListBox();
      this.cb_DebuffSpell = new System.Windows.Forms.ComboBox();
      this.btn_Debuff = new MetroSet_UI.Controls.MetroSetButton();
      this.btn_HealbotLoad = new MetroSet_UI.Controls.MetroSetLink();
      this.btn_HealbotUnload = new MetroSet_UI.Controls.MetroSetLink();
      this.btn_CollapseExpand = new FontAwesome.Sharp.IconButton();
      this.btn_Close = new FontAwesome.Sharp.IconButton();
      this.btn_Minimize = new FontAwesome.Sharp.IconButton();
      this.btn_PotencyPriority = new MetroSet_UI.Controls.MetroSetLink();
      this.btn_ClearBuffs = new MetroSet_UI.Controls.MetroSetLink();
      this.btn_ClearMonitorsIgnores = new MetroSet_UI.Controls.MetroSetLink();
      this.cb_WaitFor = new System.Windows.Forms.ComboBox();
      this.cb_WeaponskillHpOperator = new System.Windows.Forms.ComboBox();
      this.cb_Weaponskill = new System.Windows.Forms.ComboBox();
      this.lbl_WaitForToggle = new MetroSet_UI.Controls.MetroSetLabel();
      this.num_WeaponskillHpPercent = new System.Windows.Forms.NumericUpDown();
      this.metroSetLabel11 = new MetroSet_UI.Controls.MetroSetLabel();
      this.lbl_WeaponskillToggle = new MetroSet_UI.Controls.MetroSetLabel();
      this.num_WaitFor = new System.Windows.Forms.NumericUpDown();
      this.metroSetLabel13 = new MetroSet_UI.Controls.MetroSetLabel();
      this.metroSetPanel6 = new MetroSet_UI.Controls.MetroSetPanel();
      this.metroSetPanel7 = new MetroSet_UI.Controls.MetroSetPanel();
      this.metroSetPanel8 = new MetroSet_UI.Controls.MetroSetPanel();
      this.btn_ClearDebuffs = new MetroSet_UI.Controls.MetroSetLink();
      this.lbl_EngageToggle = new MetroSet_UI.Controls.MetroSetLabel();
      this.metroSetLabel17 = new MetroSet_UI.Controls.MetroSetLabel();
      this.panel_Combat = new MetroSet_UI.Controls.MetroSetPanel();
      this.cb_SelectCharacter = new System.Windows.Forms.ComboBox();
      this.img_Warning = new FontAwesome.Sharp.IconPictureBox();
      this.lbl_Warning = new System.Windows.Forms.Label();
      this.panel_Toggles.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.num_FollowDistance)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.num_MinCuraga)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.num_MinCure)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.num_WeaponskillHpPercent)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.num_WaitFor)).BeginInit();
      this.metroSetPanel6.SuspendLayout();
      this.metroSetPanel7.SuspendLayout();
      this.metroSetPanel8.SuspendLayout();
      this.panel_Combat.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_Warning)).BeginInit();
      this.SuspendLayout();
      // 
      // panel_Toggles
      // 
      this.panel_Toggles.BackgroundColor = System.Drawing.Color.White;
      this.panel_Toggles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
      this.panel_Toggles.BorderThickness = 1;
      this.panel_Toggles.Controls.Add(this.cb_Spam);
      this.panel_Toggles.Controls.Add(this.num_FollowDistance);
      this.panel_Toggles.Controls.Add(this.toggle_Spam);
      this.panel_Toggles.Controls.Add(this.metroSetLabel9);
      this.panel_Toggles.Controls.Add(this.num_MinCuraga);
      this.panel_Toggles.Controls.Add(this.cb_Follow);
      this.panel_Toggles.Controls.Add(this.cb_Assist);
      this.panel_Toggles.Controls.Add(this.num_MinCure);
      this.panel_Toggles.Controls.Add(this.toggle_Follow);
      this.panel_Toggles.Controls.Add(this.metroSetLabel8);
      this.panel_Toggles.Controls.Add(this.metroSetLabel7);
      this.panel_Toggles.Controls.Add(this.toggle_IgnoreTrusts);
      this.panel_Toggles.Controls.Add(this.toggle_Assist);
      this.panel_Toggles.Controls.Add(this.metroSetLabel6);
      this.panel_Toggles.Controls.Add(this.metroSetLabel14);
      this.panel_Toggles.Controls.Add(this.toggle_Debuffs);
      this.panel_Toggles.Controls.Add(this.metroSetLabel5);
      this.panel_Toggles.Controls.Add(this.toggle_Buffs);
      this.panel_Toggles.Controls.Add(this.metroSetLabel4);
      this.panel_Toggles.Controls.Add(this.toggle_Erase);
      this.panel_Toggles.Controls.Add(this.metroSetLabel3);
      this.panel_Toggles.Controls.Add(this.toggle_Na);
      this.panel_Toggles.Controls.Add(this.metroSetLabel2);
      this.panel_Toggles.Controls.Add(this.toggle_Curaga);
      this.panel_Toggles.Controls.Add(this.metroSetLabel1);
      this.panel_Toggles.Controls.Add(this.toggle_Cure);
      this.panel_Toggles.IsDerivedStyle = true;
      this.panel_Toggles.Location = new System.Drawing.Point(2, 72);
      this.panel_Toggles.Name = "panel_Toggles";
      this.panel_Toggles.Size = new System.Drawing.Size(261, 292);
      this.panel_Toggles.Style = MetroSet_UI.Enums.Style.Light;
      this.panel_Toggles.StyleManager = null;
      this.panel_Toggles.TabIndex = 2;
      this.panel_Toggles.ThemeAuthor = "Narwin";
      this.panel_Toggles.ThemeName = "MetroLight";
      // 
      // cb_Spam
      // 
      this.cb_Spam.FormattingEnabled = true;
      this.cb_Spam.Location = new System.Drawing.Point(121, 260);
      this.cb_Spam.Name = "cb_Spam";
      this.cb_Spam.Size = new System.Drawing.Size(127, 24);
      this.cb_Spam.TabIndex = 30;
      this.cb_Spam.SelectedIndexChanged += new System.EventHandler(this.cb_Feature_SelectedIndexChanged);
      // 
      // num_FollowDistance
      // 
      this.num_FollowDistance.Location = new System.Drawing.Point(225, 204);
      this.num_FollowDistance.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
      this.num_FollowDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.num_FollowDistance.Name = "num_FollowDistance";
      this.num_FollowDistance.Size = new System.Drawing.Size(30, 22);
      this.num_FollowDistance.TabIndex = 17;
      this.metroSetSetToolTip1.SetToolTip(this.num_FollowDistance, "Minimum Curaga");
      this.num_FollowDistance.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // toggle_Spam
      // 
      this.toggle_Spam.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Spam.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Spam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Spam.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Spam.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Spam.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Spam.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Spam.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Spam.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Spam.IsDerivedStyle = true;
      this.toggle_Spam.Location = new System.Drawing.Point(8, 260);
      this.toggle_Spam.Name = "toggle_Spam";
      this.toggle_Spam.Size = new System.Drawing.Size(58, 22);
      this.toggle_Spam.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Spam.StyleManager = null;
      this.toggle_Spam.Switched = false;
      this.toggle_Spam.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Spam.TabIndex = 15;
      this.toggle_Spam.Text = "metroSetSwitch9";
      this.toggle_Spam.ThemeAuthor = "Narwin";
      this.toggle_Spam.ThemeName = "MetroLight";
      this.toggle_Spam.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Spam.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // metroSetLabel9
      // 
      this.metroSetLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel9.IsDerivedStyle = true;
      this.metroSetLabel9.Location = new System.Drawing.Point(72, 261);
      this.metroSetLabel9.Name = "metroSetLabel9";
      this.metroSetLabel9.Size = new System.Drawing.Size(47, 23);
      this.metroSetLabel9.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel9.StyleManager = null;
      this.metroSetLabel9.TabIndex = 2;
      this.metroSetLabel9.Text = "Spam";
      this.metroSetLabel9.ThemeAuthor = "Narwin";
      this.metroSetLabel9.ThemeName = "MetroLight";
      // 
      // num_MinCuraga
      // 
      this.num_MinCuraga.Location = new System.Drawing.Point(137, 35);
      this.num_MinCuraga.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.num_MinCuraga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.num_MinCuraga.Name = "num_MinCuraga";
      this.num_MinCuraga.Size = new System.Drawing.Size(30, 22);
      this.num_MinCuraga.TabIndex = 16;
      this.metroSetSetToolTip1.SetToolTip(this.num_MinCuraga, "Minimum Curaga");
      this.num_MinCuraga.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // cb_Follow
      // 
      this.cb_Follow.FormattingEnabled = true;
      this.cb_Follow.Location = new System.Drawing.Point(121, 203);
      this.cb_Follow.Name = "cb_Follow";
      this.cb_Follow.Size = new System.Drawing.Size(100, 24);
      this.cb_Follow.TabIndex = 29;
      this.cb_Follow.SelectedIndexChanged += new System.EventHandler(this.cb_Feature_SelectedIndexChanged);
      // 
      // cb_Assist
      // 
      this.cb_Assist.FormattingEnabled = true;
      this.cb_Assist.Location = new System.Drawing.Point(121, 231);
      this.cb_Assist.Name = "cb_Assist";
      this.cb_Assist.Size = new System.Drawing.Size(127, 24);
      this.cb_Assist.TabIndex = 30;
      this.cb_Assist.SelectedIndexChanged += new System.EventHandler(this.cb_Feature_SelectedIndexChanged);
      // 
      // num_MinCure
      // 
      this.num_MinCure.Location = new System.Drawing.Point(137, 7);
      this.num_MinCure.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
      this.num_MinCure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.num_MinCure.Name = "num_MinCure";
      this.num_MinCure.Size = new System.Drawing.Size(30, 22);
      this.num_MinCure.TabIndex = 15;
      this.metroSetSetToolTip1.SetToolTip(this.num_MinCure, "Minimum Cure");
      this.num_MinCure.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // toggle_Follow
      // 
      this.toggle_Follow.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Follow.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Follow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Follow.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Follow.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Follow.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Follow.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Follow.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Follow.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Follow.IsDerivedStyle = true;
      this.toggle_Follow.Location = new System.Drawing.Point(8, 204);
      this.toggle_Follow.Name = "toggle_Follow";
      this.toggle_Follow.Size = new System.Drawing.Size(58, 22);
      this.toggle_Follow.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Follow.StyleManager = null;
      this.toggle_Follow.Switched = false;
      this.toggle_Follow.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Follow.TabIndex = 15;
      this.toggle_Follow.Text = "metroSetSwitch8";
      this.toggle_Follow.ThemeAuthor = "Narwin";
      this.toggle_Follow.ThemeName = "MetroLight";
      this.toggle_Follow.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Follow.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // metroSetLabel8
      // 
      this.metroSetLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel8.IsDerivedStyle = true;
      this.metroSetLabel8.Location = new System.Drawing.Point(72, 205);
      this.metroSetLabel8.Name = "metroSetLabel8";
      this.metroSetLabel8.Size = new System.Drawing.Size(47, 23);
      this.metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel8.StyleManager = null;
      this.metroSetLabel8.TabIndex = 2;
      this.metroSetLabel8.Text = "Follow";
      this.metroSetLabel8.ThemeAuthor = "Narwin";
      this.metroSetLabel8.ThemeName = "MetroLight";
      // 
      // metroSetLabel7
      // 
      this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel7.IsDerivedStyle = true;
      this.metroSetLabel7.Location = new System.Drawing.Point(72, 176);
      this.metroSetLabel7.Name = "metroSetLabel7";
      this.metroSetLabel7.Size = new System.Drawing.Size(95, 23);
      this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel7.StyleManager = null;
      this.metroSetLabel7.TabIndex = 14;
      this.metroSetLabel7.Text = "Ignore Trusts";
      this.metroSetLabel7.ThemeAuthor = "Narwin";
      this.metroSetLabel7.ThemeName = "MetroLight";
      // 
      // toggle_IgnoreTrusts
      // 
      this.toggle_IgnoreTrusts.BackColor = System.Drawing.Color.Transparent;
      this.toggle_IgnoreTrusts.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_IgnoreTrusts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_IgnoreTrusts.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_IgnoreTrusts.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_IgnoreTrusts.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_IgnoreTrusts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_IgnoreTrusts.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_IgnoreTrusts.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_IgnoreTrusts.IsDerivedStyle = true;
      this.toggle_IgnoreTrusts.Location = new System.Drawing.Point(8, 176);
      this.toggle_IgnoreTrusts.Name = "toggle_IgnoreTrusts";
      this.toggle_IgnoreTrusts.Size = new System.Drawing.Size(58, 22);
      this.toggle_IgnoreTrusts.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_IgnoreTrusts.StyleManager = null;
      this.toggle_IgnoreTrusts.Switched = false;
      this.toggle_IgnoreTrusts.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_IgnoreTrusts.TabIndex = 13;
      this.toggle_IgnoreTrusts.Text = "metroSetSwitch7";
      this.toggle_IgnoreTrusts.ThemeAuthor = "Narwin";
      this.toggle_IgnoreTrusts.ThemeName = "MetroLight";
      this.toggle_IgnoreTrusts.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_IgnoreTrusts.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // toggle_Assist
      // 
      this.toggle_Assist.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Assist.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Assist.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Assist.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Assist.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Assist.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Assist.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Assist.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Assist.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Assist.IsDerivedStyle = true;
      this.toggle_Assist.Location = new System.Drawing.Point(8, 232);
      this.toggle_Assist.Name = "toggle_Assist";
      this.toggle_Assist.Size = new System.Drawing.Size(58, 22);
      this.toggle_Assist.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Assist.StyleManager = null;
      this.toggle_Assist.Switched = false;
      this.toggle_Assist.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Assist.TabIndex = 15;
      this.toggle_Assist.Text = "metroSetSwitch11";
      this.toggle_Assist.ThemeAuthor = "Narwin";
      this.toggle_Assist.ThemeName = "MetroLight";
      this.toggle_Assist.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Assist.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // metroSetLabel6
      // 
      this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel6.IsDerivedStyle = true;
      this.metroSetLabel6.Location = new System.Drawing.Point(72, 148);
      this.metroSetLabel6.Name = "metroSetLabel6";
      this.metroSetLabel6.Size = new System.Drawing.Size(59, 23);
      this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel6.StyleManager = null;
      this.metroSetLabel6.TabIndex = 12;
      this.metroSetLabel6.Text = "Debuffs";
      this.metroSetLabel6.ThemeAuthor = "Narwin";
      this.metroSetLabel6.ThemeName = "MetroLight";
      // 
      // metroSetLabel14
      // 
      this.metroSetLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel14.IsDerivedStyle = true;
      this.metroSetLabel14.Location = new System.Drawing.Point(72, 233);
      this.metroSetLabel14.Name = "metroSetLabel14";
      this.metroSetLabel14.Size = new System.Drawing.Size(47, 23);
      this.metroSetLabel14.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel14.StyleManager = null;
      this.metroSetLabel14.TabIndex = 2;
      this.metroSetLabel14.Text = "Assist";
      this.metroSetLabel14.ThemeAuthor = "Narwin";
      this.metroSetLabel14.ThemeName = "MetroLight";
      // 
      // toggle_Debuffs
      // 
      this.toggle_Debuffs.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Debuffs.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Debuffs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Debuffs.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Debuffs.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Debuffs.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Debuffs.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Debuffs.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Debuffs.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Debuffs.IsDerivedStyle = true;
      this.toggle_Debuffs.Location = new System.Drawing.Point(8, 148);
      this.toggle_Debuffs.Name = "toggle_Debuffs";
      this.toggle_Debuffs.Size = new System.Drawing.Size(58, 22);
      this.toggle_Debuffs.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Debuffs.StyleManager = null;
      this.toggle_Debuffs.Switched = false;
      this.toggle_Debuffs.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Debuffs.TabIndex = 11;
      this.toggle_Debuffs.Text = "metroSetSwitch6";
      this.toggle_Debuffs.ThemeAuthor = "Narwin";
      this.toggle_Debuffs.ThemeName = "MetroLight";
      this.toggle_Debuffs.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Debuffs.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // metroSetLabel5
      // 
      this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel5.IsDerivedStyle = true;
      this.metroSetLabel5.Location = new System.Drawing.Point(72, 120);
      this.metroSetLabel5.Name = "metroSetLabel5";
      this.metroSetLabel5.Size = new System.Drawing.Size(55, 23);
      this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel5.StyleManager = null;
      this.metroSetLabel5.TabIndex = 10;
      this.metroSetLabel5.Text = "Buffs";
      this.metroSetLabel5.ThemeAuthor = "Narwin";
      this.metroSetLabel5.ThemeName = "MetroLight";
      // 
      // toggle_Buffs
      // 
      this.toggle_Buffs.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Buffs.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Buffs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Buffs.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Buffs.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Buffs.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Buffs.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Buffs.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Buffs.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Buffs.IsDerivedStyle = true;
      this.toggle_Buffs.Location = new System.Drawing.Point(8, 120);
      this.toggle_Buffs.Name = "toggle_Buffs";
      this.toggle_Buffs.Size = new System.Drawing.Size(58, 22);
      this.toggle_Buffs.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Buffs.StyleManager = null;
      this.toggle_Buffs.Switched = false;
      this.toggle_Buffs.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Buffs.TabIndex = 9;
      this.toggle_Buffs.Text = "metroSetSwitch5";
      this.toggle_Buffs.ThemeAuthor = "Narwin";
      this.toggle_Buffs.ThemeName = "MetroLight";
      this.toggle_Buffs.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Buffs.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // metroSetLabel4
      // 
      this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel4.IsDerivedStyle = true;
      this.metroSetLabel4.Location = new System.Drawing.Point(72, 92);
      this.metroSetLabel4.Name = "metroSetLabel4";
      this.metroSetLabel4.Size = new System.Drawing.Size(55, 23);
      this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel4.StyleManager = null;
      this.metroSetLabel4.TabIndex = 8;
      this.metroSetLabel4.Text = "Erase";
      this.metroSetLabel4.ThemeAuthor = "Narwin";
      this.metroSetLabel4.ThemeName = "MetroLight";
      // 
      // toggle_Erase
      // 
      this.toggle_Erase.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Erase.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Erase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Erase.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Erase.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Erase.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Erase.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Erase.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Erase.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Erase.IsDerivedStyle = true;
      this.toggle_Erase.Location = new System.Drawing.Point(8, 92);
      this.toggle_Erase.Name = "toggle_Erase";
      this.toggle_Erase.Size = new System.Drawing.Size(58, 22);
      this.toggle_Erase.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Erase.StyleManager = null;
      this.toggle_Erase.Switched = false;
      this.toggle_Erase.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Erase.TabIndex = 7;
      this.toggle_Erase.Text = "metroSetSwitch4";
      this.toggle_Erase.ThemeAuthor = "Narwin";
      this.toggle_Erase.ThemeName = "MetroLight";
      this.toggle_Erase.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Erase.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // metroSetLabel3
      // 
      this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel3.IsDerivedStyle = true;
      this.metroSetLabel3.Location = new System.Drawing.Point(72, 64);
      this.metroSetLabel3.Name = "metroSetLabel3";
      this.metroSetLabel3.Size = new System.Drawing.Size(68, 23);
      this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel3.StyleManager = null;
      this.metroSetLabel3.TabIndex = 6;
      this.metroSetLabel3.Text = "Na Spells";
      this.metroSetLabel3.ThemeAuthor = "Narwin";
      this.metroSetLabel3.ThemeName = "MetroLight";
      // 
      // toggle_Na
      // 
      this.toggle_Na.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Na.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Na.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Na.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Na.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Na.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Na.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Na.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Na.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Na.IsDerivedStyle = true;
      this.toggle_Na.Location = new System.Drawing.Point(8, 64);
      this.toggle_Na.Name = "toggle_Na";
      this.toggle_Na.Size = new System.Drawing.Size(58, 22);
      this.toggle_Na.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Na.StyleManager = null;
      this.toggle_Na.Switched = false;
      this.toggle_Na.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Na.TabIndex = 5;
      this.toggle_Na.Text = "metroSetSwitch3";
      this.toggle_Na.ThemeAuthor = "Narwin";
      this.toggle_Na.ThemeName = "MetroLight";
      this.toggle_Na.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Na.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // metroSetLabel2
      // 
      this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel2.IsDerivedStyle = true;
      this.metroSetLabel2.Location = new System.Drawing.Point(72, 36);
      this.metroSetLabel2.Name = "metroSetLabel2";
      this.metroSetLabel2.Size = new System.Drawing.Size(55, 23);
      this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel2.StyleManager = null;
      this.metroSetLabel2.TabIndex = 4;
      this.metroSetLabel2.Text = "Curaga";
      this.metroSetLabel2.ThemeAuthor = "Narwin";
      this.metroSetLabel2.ThemeName = "MetroLight";
      // 
      // toggle_Curaga
      // 
      this.toggle_Curaga.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Curaga.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Curaga.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Curaga.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Curaga.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Curaga.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Curaga.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Curaga.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Curaga.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Curaga.IsDerivedStyle = true;
      this.toggle_Curaga.Location = new System.Drawing.Point(8, 36);
      this.toggle_Curaga.Name = "toggle_Curaga";
      this.toggle_Curaga.Size = new System.Drawing.Size(58, 22);
      this.toggle_Curaga.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Curaga.StyleManager = null;
      this.toggle_Curaga.Switched = false;
      this.toggle_Curaga.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Curaga.TabIndex = 3;
      this.toggle_Curaga.Text = "metroSetSwitch2";
      this.toggle_Curaga.ThemeAuthor = "Narwin";
      this.toggle_Curaga.ThemeName = "MetroLight";
      this.toggle_Curaga.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Curaga.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // metroSetLabel1
      // 
      this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel1.IsDerivedStyle = true;
      this.metroSetLabel1.Location = new System.Drawing.Point(72, 8);
      this.metroSetLabel1.Name = "metroSetLabel1";
      this.metroSetLabel1.Size = new System.Drawing.Size(42, 23);
      this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel1.StyleManager = null;
      this.metroSetLabel1.TabIndex = 1;
      this.metroSetLabel1.Text = "Cure";
      this.metroSetLabel1.ThemeAuthor = "Narwin";
      this.metroSetLabel1.ThemeName = "MetroLight";
      // 
      // toggle_Cure
      // 
      this.toggle_Cure.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Cure.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Cure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Cure.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Cure.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Cure.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Cure.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Cure.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Cure.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Cure.IsDerivedStyle = true;
      this.toggle_Cure.Location = new System.Drawing.Point(8, 8);
      this.toggle_Cure.Name = "toggle_Cure";
      this.toggle_Cure.Size = new System.Drawing.Size(58, 22);
      this.toggle_Cure.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Cure.StyleManager = null;
      this.toggle_Cure.Switched = false;
      this.toggle_Cure.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Cure.TabIndex = 0;
      this.toggle_Cure.Text = "metroSetSwitch1";
      this.toggle_Cure.ThemeAuthor = "Narwin";
      this.toggle_Cure.ThemeName = "MetroLight";
      this.toggle_Cure.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Cure.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // toggle_WaitFor
      // 
      this.toggle_WaitFor.BackColor = System.Drawing.Color.Transparent;
      this.toggle_WaitFor.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_WaitFor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_WaitFor.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_WaitFor.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_WaitFor.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_WaitFor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_WaitFor.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_WaitFor.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_WaitFor.IsDerivedStyle = true;
      this.toggle_WaitFor.Location = new System.Drawing.Point(6, 61);
      this.toggle_WaitFor.Name = "toggle_WaitFor";
      this.toggle_WaitFor.Size = new System.Drawing.Size(58, 22);
      this.toggle_WaitFor.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_WaitFor.StyleManager = null;
      this.toggle_WaitFor.Switched = false;
      this.toggle_WaitFor.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_WaitFor.TabIndex = 37;
      this.toggle_WaitFor.Text = "metroSetSwitch13";
      this.toggle_WaitFor.ThemeAuthor = "Narwin";
      this.toggle_WaitFor.ThemeName = "MetroLight";
      this.toggle_WaitFor.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_WaitFor.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // toggle_Attack
      // 
      this.toggle_Attack.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Attack.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Attack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Attack.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Attack.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Attack.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Attack.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Attack.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Attack.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Attack.IsDerivedStyle = true;
      this.toggle_Attack.Location = new System.Drawing.Point(6, 33);
      this.toggle_Attack.Name = "toggle_Attack";
      this.toggle_Attack.Size = new System.Drawing.Size(58, 22);
      this.toggle_Attack.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Attack.StyleManager = null;
      this.toggle_Attack.Switched = false;
      this.toggle_Attack.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Attack.TabIndex = 33;
      this.toggle_Attack.Text = "metroSetSwitch12";
      this.toggle_Attack.ThemeAuthor = "Narwin";
      this.toggle_Attack.ThemeName = "MetroLight";
      this.toggle_Attack.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Attack.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // toggle_Weaponskill
      // 
      this.toggle_Weaponskill.BackColor = System.Drawing.Color.Transparent;
      this.toggle_Weaponskill.BackgroundColor = System.Drawing.Color.Empty;
      this.toggle_Weaponskill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
      this.toggle_Weaponskill.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Weaponskill.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
      this.toggle_Weaponskill.Cursor = System.Windows.Forms.Cursors.Hand;
      this.toggle_Weaponskill.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Weaponskill.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.toggle_Weaponskill.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
      this.toggle_Weaponskill.IsDerivedStyle = true;
      this.toggle_Weaponskill.Location = new System.Drawing.Point(6, 5);
      this.toggle_Weaponskill.Name = "toggle_Weaponskill";
      this.toggle_Weaponskill.Size = new System.Drawing.Size(58, 22);
      this.toggle_Weaponskill.Style = MetroSet_UI.Enums.Style.Light;
      this.toggle_Weaponskill.StyleManager = null;
      this.toggle_Weaponskill.Switched = false;
      this.toggle_Weaponskill.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
      this.toggle_Weaponskill.TabIndex = 18;
      this.toggle_Weaponskill.Text = "toggle_Weaponskill";
      this.toggle_Weaponskill.ThemeAuthor = "Narwin";
      this.toggle_Weaponskill.ThemeName = "MetroLight";
      this.toggle_Weaponskill.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.toggle_Weaponskill.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.toggle_SwitchedChanged);
      // 
      // metroSetSetToolTip1
      // 
      this.metroSetSetToolTip1.BackColor = System.Drawing.Color.White;
      this.metroSetSetToolTip1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
      this.metroSetSetToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
      this.metroSetSetToolTip1.IsDerivedStyle = true;
      this.metroSetSetToolTip1.OwnerDraw = true;
      this.metroSetSetToolTip1.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetSetToolTip1.StyleManager = null;
      this.metroSetSetToolTip1.ThemeAuthor = "Narwin";
      this.metroSetSetToolTip1.ThemeName = "MetroLite";
      // 
      // btn_HealbotOn
      // 
      this.btn_HealbotOn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_HealbotOn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_HealbotOn.DisabledForeColor = System.Drawing.Color.Gray;
      this.btn_HealbotOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.btn_HealbotOn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(164)))), ((int)(((byte)(92)))));
      this.btn_HealbotOn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(164)))), ((int)(((byte)(92)))));
      this.btn_HealbotOn.HoverTextColor = System.Drawing.Color.White;
      this.btn_HealbotOn.IsDerivedStyle = false;
      this.btn_HealbotOn.Location = new System.Drawing.Point(139, 45);
      this.btn_HealbotOn.Name = "btn_HealbotOn";
      this.btn_HealbotOn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(190)))), ((int)(((byte)(122)))));
      this.btn_HealbotOn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(190)))), ((int)(((byte)(122)))));
      this.btn_HealbotOn.NormalTextColor = System.Drawing.Color.White;
      this.btn_HealbotOn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(190)))), ((int)(((byte)(122)))));
      this.btn_HealbotOn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(190)))), ((int)(((byte)(122)))));
      this.btn_HealbotOn.PressTextColor = System.Drawing.Color.White;
      this.btn_HealbotOn.Size = new System.Drawing.Size(30, 23);
      this.btn_HealbotOn.Style = MetroSet_UI.Enums.Style.Light;
      this.btn_HealbotOn.StyleManager = null;
      this.btn_HealbotOn.TabIndex = 22;
      this.btn_HealbotOn.Text = "ON";
      this.btn_HealbotOn.ThemeAuthor = "Narwin";
      this.btn_HealbotOn.ThemeName = "MetroLight";
      this.metroSetSetToolTip1.SetToolTip(this.btn_HealbotOn, "Turn on healbot");
      this.btn_HealbotOn.Click += new System.EventHandler(this.btn_HealbotOn_Click);
      // 
      // btn_HealbotOff
      // 
      this.btn_HealbotOff.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_HealbotOff.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_HealbotOff.DisabledForeColor = System.Drawing.Color.Gray;
      this.btn_HealbotOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.btn_HealbotOff.HoverBorderColor = System.Drawing.Color.Red;
      this.btn_HealbotOff.HoverColor = System.Drawing.Color.Red;
      this.btn_HealbotOff.HoverTextColor = System.Drawing.Color.White;
      this.btn_HealbotOff.IsDerivedStyle = false;
      this.btn_HealbotOff.Location = new System.Drawing.Point(175, 45);
      this.btn_HealbotOff.Name = "btn_HealbotOff";
      this.btn_HealbotOff.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
      this.btn_HealbotOff.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
      this.btn_HealbotOff.NormalTextColor = System.Drawing.Color.White;
      this.btn_HealbotOff.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
      this.btn_HealbotOff.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
      this.btn_HealbotOff.PressTextColor = System.Drawing.Color.White;
      this.btn_HealbotOff.Size = new System.Drawing.Size(37, 23);
      this.btn_HealbotOff.Style = MetroSet_UI.Enums.Style.Light;
      this.btn_HealbotOff.StyleManager = null;
      this.btn_HealbotOff.TabIndex = 23;
      this.btn_HealbotOff.Text = "OFF";
      this.btn_HealbotOff.ThemeAuthor = "Narwin";
      this.btn_HealbotOff.ThemeName = "MetroLight";
      this.metroSetSetToolTip1.SetToolTip(this.btn_HealbotOff, "Turn off healbot");
      this.btn_HealbotOff.Click += new System.EventHandler(this.btn_HealbotOff_Click);
      // 
      // btn_HealbotRefresh
      // 
      this.btn_HealbotRefresh.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_HealbotRefresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_HealbotRefresh.DisabledForeColor = System.Drawing.Color.Gray;
      this.btn_HealbotRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.btn_HealbotRefresh.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(150)))), ((int)(((byte)(184)))));
      this.btn_HealbotRefresh.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(150)))), ((int)(((byte)(184)))));
      this.btn_HealbotRefresh.HoverTextColor = System.Drawing.Color.White;
      this.btn_HealbotRefresh.IsDerivedStyle = false;
      this.btn_HealbotRefresh.Location = new System.Drawing.Point(269, 45);
      this.btn_HealbotRefresh.Name = "btn_HealbotRefresh";
      this.btn_HealbotRefresh.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(129)))), ((int)(((byte)(159)))));
      this.btn_HealbotRefresh.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(129)))), ((int)(((byte)(159)))));
      this.btn_HealbotRefresh.NormalTextColor = System.Drawing.Color.White;
      this.btn_HealbotRefresh.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(129)))), ((int)(((byte)(159)))));
      this.btn_HealbotRefresh.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(129)))), ((int)(((byte)(159)))));
      this.btn_HealbotRefresh.PressTextColor = System.Drawing.Color.White;
      this.btn_HealbotRefresh.Size = new System.Drawing.Size(75, 23);
      this.btn_HealbotRefresh.Style = MetroSet_UI.Enums.Style.Light;
      this.btn_HealbotRefresh.StyleManager = null;
      this.btn_HealbotRefresh.TabIndex = 22;
      this.btn_HealbotRefresh.Text = "REFRESH";
      this.btn_HealbotRefresh.ThemeAuthor = "Narwin";
      this.btn_HealbotRefresh.ThemeName = "MetroLight";
      this.metroSetSetToolTip1.SetToolTip(this.btn_HealbotRefresh, "Refresh healbot config");
      this.btn_HealbotRefresh.Click += new System.EventHandler(this.btn_HealbotRefresh_Click);
      // 
      // btn_LoadBuffList
      // 
      this.btn_LoadBuffList.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_LoadBuffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_LoadBuffList.IsDerivedStyle = true;
      this.btn_LoadBuffList.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.btn_LoadBuffList.Location = new System.Drawing.Point(8, 7);
      this.btn_LoadBuffList.Name = "btn_LoadBuffList";
      this.btn_LoadBuffList.Size = new System.Drawing.Size(41, 23);
      this.btn_LoadBuffList.Style = MetroSet_UI.Enums.Style.Dark;
      this.btn_LoadBuffList.StyleManager = null;
      this.btn_LoadBuffList.TabIndex = 26;
      this.btn_LoadBuffList.TabStop = true;
      this.btn_LoadBuffList.Text = "Load";
      this.btn_LoadBuffList.ThemeAuthor = "Narwin";
      this.btn_LoadBuffList.ThemeName = "MetroLite";
      this.metroSetSetToolTip1.SetToolTip(this.btn_LoadBuffList, "Load a buff list");
      this.btn_LoadBuffList.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
      this.btn_LoadBuffList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_LoadBuffList_LinkClicked);
      // 
      // btn_SaveBuffList
      // 
      this.btn_SaveBuffList.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_SaveBuffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_SaveBuffList.IsDerivedStyle = true;
      this.btn_SaveBuffList.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.btn_SaveBuffList.Location = new System.Drawing.Point(8, 74);
      this.btn_SaveBuffList.Name = "btn_SaveBuffList";
      this.btn_SaveBuffList.Size = new System.Drawing.Size(41, 20);
      this.btn_SaveBuffList.Style = MetroSet_UI.Enums.Style.Dark;
      this.btn_SaveBuffList.StyleManager = null;
      this.btn_SaveBuffList.TabIndex = 27;
      this.btn_SaveBuffList.TabStop = true;
      this.btn_SaveBuffList.Text = "Save";
      this.btn_SaveBuffList.ThemeAuthor = "Narwin";
      this.btn_SaveBuffList.ThemeName = "MetroLite";
      this.metroSetSetToolTip1.SetToolTip(this.btn_SaveBuffList, "Save buffs");
      this.btn_SaveBuffList.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
      this.btn_SaveBuffList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_SaveBuffList_LinkClicked);
      // 
      // lb_Buffs
      // 
      this.lb_Buffs.BackColor = System.Drawing.Color.White;
      this.lb_Buffs.BorderColor = System.Drawing.Color.Gray;
      this.lb_Buffs.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
      this.lb_Buffs.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      this.lb_Buffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lb_Buffs.HoveredItemBackColor = System.Drawing.Color.LightGray;
      this.lb_Buffs.HoveredItemColor = System.Drawing.Color.DimGray;
      this.lb_Buffs.IsDerivedStyle = false;
      this.lb_Buffs.ItemHeight = 14;
      this.lb_Buffs.Location = new System.Drawing.Point(51, 32);
      this.lb_Buffs.MultiSelect = false;
      this.lb_Buffs.Name = "lb_Buffs";
      this.lb_Buffs.SelectedIndex = -1;
      this.lb_Buffs.SelectedItem = null;
      this.lb_Buffs.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.lb_Buffs.SelectedItemColor = System.Drawing.Color.White;
      this.lb_Buffs.SelectedText = null;
      this.lb_Buffs.SelectedValue = null;
      this.lb_Buffs.ShowBorder = true;
      this.lb_Buffs.ShowScrollBar = true;
      this.lb_Buffs.Size = new System.Drawing.Size(248, 61);
      this.lb_Buffs.Style = MetroSet_UI.Enums.Style.Light;
      this.lb_Buffs.StyleManager = null;
      this.lb_Buffs.TabIndex = 23;
      this.lb_Buffs.ThemeAuthor = "Narwin";
      this.lb_Buffs.ThemeName = "MetroLite";
      this.metroSetSetToolTip1.SetToolTip(this.lb_Buffs, "Double click to remove.");
      this.lb_Buffs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDoubleClick);
      // 
      // cb_BuffSpell
      // 
      this.cb_BuffSpell.FormattingEnabled = true;
      this.cb_BuffSpell.Location = new System.Drawing.Point(178, 4);
      this.cb_BuffSpell.Name = "cb_BuffSpell";
      this.cb_BuffSpell.Size = new System.Drawing.Size(121, 24);
      this.cb_BuffSpell.TabIndex = 18;
      this.metroSetSetToolTip1.SetToolTip(this.cb_BuffSpell, "Select or enter a buff.");
      // 
      // cb_BuffPlayer
      // 
      this.cb_BuffPlayer.FormattingEnabled = true;
      this.cb_BuffPlayer.Location = new System.Drawing.Point(51, 4);
      this.cb_BuffPlayer.Name = "cb_BuffPlayer";
      this.cb_BuffPlayer.Size = new System.Drawing.Size(121, 24);
      this.cb_BuffPlayer.TabIndex = 0;
      this.metroSetSetToolTip1.SetToolTip(this.cb_BuffPlayer, "Type or select a char.");
      // 
      // cb_MonitorIgnorePlayer
      // 
      this.cb_MonitorIgnorePlayer.FormattingEnabled = true;
      this.cb_MonitorIgnorePlayer.Location = new System.Drawing.Point(5, 4);
      this.cb_MonitorIgnorePlayer.Name = "cb_MonitorIgnorePlayer";
      this.cb_MonitorIgnorePlayer.Size = new System.Drawing.Size(114, 24);
      this.cb_MonitorIgnorePlayer.TabIndex = 23;
      this.metroSetSetToolTip1.SetToolTip(this.cb_MonitorIgnorePlayer, "Type or select a char.");
      // 
      // lb_MonitorsIgnores
      // 
      this.lb_MonitorsIgnores.BackColor = System.Drawing.Color.White;
      this.lb_MonitorsIgnores.BorderColor = System.Drawing.Color.Gray;
      this.lb_MonitorsIgnores.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
      this.lb_MonitorsIgnores.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      this.lb_MonitorsIgnores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lb_MonitorsIgnores.HoveredItemBackColor = System.Drawing.Color.LightGray;
      this.lb_MonitorsIgnores.HoveredItemColor = System.Drawing.Color.DimGray;
      this.lb_MonitorsIgnores.IsDerivedStyle = false;
      this.lb_MonitorsIgnores.ItemHeight = 14;
      this.lb_MonitorsIgnores.Location = new System.Drawing.Point(5, 31);
      this.lb_MonitorsIgnores.MultiSelect = false;
      this.lb_MonitorsIgnores.Name = "lb_MonitorsIgnores";
      this.lb_MonitorsIgnores.SelectedIndex = -1;
      this.lb_MonitorsIgnores.SelectedItem = null;
      this.lb_MonitorsIgnores.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.lb_MonitorsIgnores.SelectedItemColor = System.Drawing.Color.White;
      this.lb_MonitorsIgnores.SelectedText = null;
      this.lb_MonitorsIgnores.SelectedValue = null;
      this.lb_MonitorsIgnores.ShowBorder = true;
      this.lb_MonitorsIgnores.ShowScrollBar = true;
      this.lb_MonitorsIgnores.Size = new System.Drawing.Size(114, 64);
      this.lb_MonitorsIgnores.Style = MetroSet_UI.Enums.Style.Light;
      this.lb_MonitorsIgnores.StyleManager = null;
      this.lb_MonitorsIgnores.TabIndex = 29;
      this.lb_MonitorsIgnores.ThemeAuthor = "Narwin";
      this.lb_MonitorsIgnores.ThemeName = "MetroLite";
      this.metroSetSetToolTip1.SetToolTip(this.lb_MonitorsIgnores, "Double click to remove.");
      this.lb_MonitorsIgnores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDoubleClick);
      // 
      // btn_Buff
      // 
      this.btn_Buff.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Buff.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Buff.DisabledForeColor = System.Drawing.Color.Gray;
      this.btn_Buff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_Buff.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_Buff.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_Buff.HoverTextColor = System.Drawing.Color.White;
      this.btn_Buff.IsDerivedStyle = true;
      this.btn_Buff.Location = new System.Drawing.Point(302, 4);
      this.btn_Buff.Name = "btn_Buff";
      this.btn_Buff.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Buff.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Buff.NormalTextColor = System.Drawing.Color.White;
      this.btn_Buff.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_Buff.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_Buff.PressTextColor = System.Drawing.Color.White;
      this.btn_Buff.Size = new System.Drawing.Size(44, 24);
      this.btn_Buff.Style = MetroSet_UI.Enums.Style.Light;
      this.btn_Buff.StyleManager = null;
      this.btn_Buff.TabIndex = 22;
      this.btn_Buff.Text = "Buff";
      this.btn_Buff.ThemeAuthor = "Narwin";
      this.btn_Buff.ThemeName = "MetroLight";
      this.metroSetSetToolTip1.SetToolTip(this.btn_Buff, "Add Buff");
      this.btn_Buff.Click += new System.EventHandler(this.btn_Buff_Click);
      // 
      // btn_Monitor
      // 
      this.btn_Monitor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Monitor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Monitor.DisabledForeColor = System.Drawing.Color.Gray;
      this.btn_Monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      this.btn_Monitor.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_Monitor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_Monitor.HoverTextColor = System.Drawing.Color.White;
      this.btn_Monitor.IsDerivedStyle = true;
      this.btn_Monitor.Location = new System.Drawing.Point(122, 4);
      this.btn_Monitor.Name = "btn_Monitor";
      this.btn_Monitor.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Monitor.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Monitor.NormalTextColor = System.Drawing.Color.White;
      this.btn_Monitor.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_Monitor.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_Monitor.PressTextColor = System.Drawing.Color.White;
      this.btn_Monitor.Size = new System.Drawing.Size(47, 24);
      this.btn_Monitor.Style = MetroSet_UI.Enums.Style.Light;
      this.btn_Monitor.StyleManager = null;
      this.btn_Monitor.TabIndex = 31;
      this.btn_Monitor.Text = "Monitor";
      this.btn_Monitor.ThemeAuthor = "Narwin";
      this.btn_Monitor.ThemeName = "MetroLight";
      this.metroSetSetToolTip1.SetToolTip(this.btn_Monitor, "Add Monitor");
      this.btn_Monitor.Click += new System.EventHandler(this.btn_Monitor_Click);
      // 
      // btn_Ignore
      // 
      this.btn_Ignore.DisabledBackColor = System.Drawing.Color.Silver;
      this.btn_Ignore.DisabledBorderColor = System.Drawing.Color.Silver;
      this.btn_Ignore.DisabledForeColor = System.Drawing.Color.Gray;
      this.btn_Ignore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      this.btn_Ignore.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.btn_Ignore.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.btn_Ignore.HoverTextColor = System.Drawing.Color.White;
      this.btn_Ignore.IsDerivedStyle = false;
      this.btn_Ignore.Location = new System.Drawing.Point(122, 31);
      this.btn_Ignore.Name = "btn_Ignore";
      this.btn_Ignore.NormalBorderColor = System.Drawing.Color.Silver;
      this.btn_Ignore.NormalColor = System.Drawing.Color.Silver;
      this.btn_Ignore.NormalTextColor = System.Drawing.Color.White;
      this.btn_Ignore.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.btn_Ignore.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.btn_Ignore.PressTextColor = System.Drawing.Color.White;
      this.btn_Ignore.Size = new System.Drawing.Size(47, 23);
      this.btn_Ignore.Style = MetroSet_UI.Enums.Style.Light;
      this.btn_Ignore.StyleManager = null;
      this.btn_Ignore.TabIndex = 24;
      this.btn_Ignore.Text = "Ignore";
      this.btn_Ignore.ThemeAuthor = "Narwin";
      this.btn_Ignore.ThemeName = "MetroLight";
      this.metroSetSetToolTip1.SetToolTip(this.btn_Ignore, "Add Ignore");
      this.btn_Ignore.Click += new System.EventHandler(this.btn_Ignore_Click);
      // 
      // btn_SetWindowerPath
      // 
      this.btn_SetWindowerPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_SetWindowerPath.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_SetWindowerPath.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
      this.btn_SetWindowerPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_SetWindowerPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_SetWindowerPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_SetWindowerPath.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
      this.btn_SetWindowerPath.ForeColor = System.Drawing.Color.White;
      this.btn_SetWindowerPath.IconChar = FontAwesome.Sharp.IconChar.Search;
      this.btn_SetWindowerPath.IconColor = System.Drawing.Color.White;
      this.btn_SetWindowerPath.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btn_SetWindowerPath.IconSize = 18;
      this.btn_SetWindowerPath.Location = new System.Drawing.Point(269, 10);
      this.btn_SetWindowerPath.Name = "btn_SetWindowerPath";
      this.btn_SetWindowerPath.Size = new System.Drawing.Size(142, 23);
      this.btn_SetWindowerPath.TabIndex = 31;
      this.btn_SetWindowerPath.Text = "Set Windower Path";
      this.btn_SetWindowerPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.metroSetSetToolTip1.SetToolTip(this.btn_SetWindowerPath, "Set windower path");
      this.btn_SetWindowerPath.UseVisualStyleBackColor = false;
      this.btn_SetWindowerPath.Click += new System.EventHandler(this.btn_SetWindowerPath_Click);
      // 
      // btn_LoadSettings
      // 
      this.btn_LoadSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_LoadSettings.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_LoadSettings.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
      this.btn_LoadSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_LoadSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_LoadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_LoadSettings.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
      this.btn_LoadSettings.ForeColor = System.Drawing.Color.White;
      this.btn_LoadSettings.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
      this.btn_LoadSettings.IconColor = System.Drawing.Color.White;
      this.btn_LoadSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btn_LoadSettings.IconSize = 18;
      this.btn_LoadSettings.Location = new System.Drawing.Point(417, 10);
      this.btn_LoadSettings.Name = "btn_LoadSettings";
      this.btn_LoadSettings.Size = new System.Drawing.Size(63, 23);
      this.btn_LoadSettings.TabIndex = 32;
      this.btn_LoadSettings.Text = "Load";
      this.btn_LoadSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.metroSetSetToolTip1.SetToolTip(this.btn_LoadSettings, "Load settings");
      this.btn_LoadSettings.UseVisualStyleBackColor = false;
      this.btn_LoadSettings.Click += new System.EventHandler(this.btn_LoadSettings_Click);
      // 
      // btn_SaveSettings
      // 
      this.btn_SaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_SaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_SaveSettings.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
      this.btn_SaveSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_SaveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_SaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_SaveSettings.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
      this.btn_SaveSettings.ForeColor = System.Drawing.Color.White;
      this.btn_SaveSettings.IconChar = FontAwesome.Sharp.IconChar.Save;
      this.btn_SaveSettings.IconColor = System.Drawing.Color.White;
      this.btn_SaveSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btn_SaveSettings.IconSize = 18;
      this.btn_SaveSettings.Location = new System.Drawing.Point(486, 10);
      this.btn_SaveSettings.Name = "btn_SaveSettings";
      this.btn_SaveSettings.Size = new System.Drawing.Size(62, 23);
      this.btn_SaveSettings.TabIndex = 33;
      this.btn_SaveSettings.Text = "Save";
      this.btn_SaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.metroSetSetToolTip1.SetToolTip(this.btn_SaveSettings, "Save settings");
      this.btn_SaveSettings.UseVisualStyleBackColor = false;
      this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
      // 
      // lb_Debuff
      // 
      this.lb_Debuff.BackColor = System.Drawing.Color.White;
      this.lb_Debuff.BorderColor = System.Drawing.Color.Gray;
      this.lb_Debuff.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
      this.lb_Debuff.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      this.lb_Debuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lb_Debuff.HoveredItemBackColor = System.Drawing.Color.LightGray;
      this.lb_Debuff.HoveredItemColor = System.Drawing.Color.DimGray;
      this.lb_Debuff.IsDerivedStyle = false;
      this.lb_Debuff.ItemHeight = 14;
      this.lb_Debuff.Location = new System.Drawing.Point(6, 31);
      this.lb_Debuff.MultiSelect = false;
      this.lb_Debuff.Name = "lb_Debuff";
      this.lb_Debuff.SelectedIndex = -1;
      this.lb_Debuff.SelectedItem = null;
      this.lb_Debuff.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.lb_Debuff.SelectedItemColor = System.Drawing.Color.White;
      this.lb_Debuff.SelectedText = null;
      this.lb_Debuff.SelectedValue = null;
      this.lb_Debuff.ShowBorder = true;
      this.lb_Debuff.ShowScrollBar = true;
      this.lb_Debuff.Size = new System.Drawing.Size(113, 64);
      this.lb_Debuff.Style = MetroSet_UI.Enums.Style.Light;
      this.lb_Debuff.StyleManager = null;
      this.lb_Debuff.TabIndex = 29;
      this.lb_Debuff.ThemeAuthor = "Narwin";
      this.lb_Debuff.ThemeName = "MetroLite";
      this.metroSetSetToolTip1.SetToolTip(this.lb_Debuff, "Double click to remove.");
      this.lb_Debuff.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDoubleClick);
      // 
      // cb_DebuffSpell
      // 
      this.cb_DebuffSpell.FormattingEnabled = true;
      this.cb_DebuffSpell.Location = new System.Drawing.Point(6, 4);
      this.cb_DebuffSpell.Name = "cb_DebuffSpell";
      this.cb_DebuffSpell.Size = new System.Drawing.Size(113, 24);
      this.cb_DebuffSpell.TabIndex = 30;
      this.metroSetSetToolTip1.SetToolTip(this.cb_DebuffSpell, "Type or select a char.");
      // 
      // btn_Debuff
      // 
      this.btn_Debuff.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Debuff.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Debuff.DisabledForeColor = System.Drawing.Color.Gray;
      this.btn_Debuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_Debuff.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_Debuff.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_Debuff.HoverTextColor = System.Drawing.Color.White;
      this.btn_Debuff.IsDerivedStyle = true;
      this.btn_Debuff.Location = new System.Drawing.Point(122, 4);
      this.btn_Debuff.Name = "btn_Debuff";
      this.btn_Debuff.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Debuff.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Debuff.NormalTextColor = System.Drawing.Color.White;
      this.btn_Debuff.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_Debuff.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_Debuff.PressTextColor = System.Drawing.Color.White;
      this.btn_Debuff.Size = new System.Drawing.Size(49, 24);
      this.btn_Debuff.Style = MetroSet_UI.Enums.Style.Light;
      this.btn_Debuff.StyleManager = null;
      this.btn_Debuff.TabIndex = 32;
      this.btn_Debuff.Text = "Debuff";
      this.btn_Debuff.ThemeAuthor = "Narwin";
      this.btn_Debuff.ThemeName = "MetroLight";
      this.metroSetSetToolTip1.SetToolTip(this.btn_Debuff, "Add Debuff");
      this.btn_Debuff.Click += new System.EventHandler(this.btn_Debuff_Click);
      // 
      // btn_HealbotLoad
      // 
      this.btn_HealbotLoad.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_HealbotLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_HealbotLoad.IsDerivedStyle = true;
      this.btn_HealbotLoad.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.btn_HealbotLoad.Location = new System.Drawing.Point(359, 46);
      this.btn_HealbotLoad.Name = "btn_HealbotLoad";
      this.btn_HealbotLoad.Size = new System.Drawing.Size(40, 23);
      this.btn_HealbotLoad.Style = MetroSet_UI.Enums.Style.Dark;
      this.btn_HealbotLoad.StyleManager = null;
      this.btn_HealbotLoad.TabIndex = 29;
      this.btn_HealbotLoad.TabStop = true;
      this.btn_HealbotLoad.Text = "Load";
      this.btn_HealbotLoad.ThemeAuthor = "Narwin";
      this.btn_HealbotLoad.ThemeName = "MetroLite";
      this.metroSetSetToolTip1.SetToolTip(this.btn_HealbotLoad, "Load Healbot");
      this.btn_HealbotLoad.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
      this.btn_HealbotLoad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_HealbotLoad_LinkClicked);
      // 
      // btn_HealbotUnload
      // 
      this.btn_HealbotUnload.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_HealbotUnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_HealbotUnload.IsDerivedStyle = true;
      this.btn_HealbotUnload.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.btn_HealbotUnload.Location = new System.Drawing.Point(403, 46);
      this.btn_HealbotUnload.Name = "btn_HealbotUnload";
      this.btn_HealbotUnload.Size = new System.Drawing.Size(54, 23);
      this.btn_HealbotUnload.Style = MetroSet_UI.Enums.Style.Dark;
      this.btn_HealbotUnload.StyleManager = null;
      this.btn_HealbotUnload.TabIndex = 39;
      this.btn_HealbotUnload.TabStop = true;
      this.btn_HealbotUnload.Text = "Unload";
      this.btn_HealbotUnload.ThemeAuthor = "Narwin";
      this.btn_HealbotUnload.ThemeName = "MetroLite";
      this.metroSetSetToolTip1.SetToolTip(this.btn_HealbotUnload, "Unload Healbot");
      this.btn_HealbotUnload.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
      this.btn_HealbotUnload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_HealbotUnload_LinkClicked);
      // 
      // btn_CollapseExpand
      // 
      this.btn_CollapseExpand.BackColor = System.Drawing.Color.Transparent;
      this.btn_CollapseExpand.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_CollapseExpand.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
      this.btn_CollapseExpand.FlatAppearance.BorderSize = 0;
      this.btn_CollapseExpand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.btn_CollapseExpand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.btn_CollapseExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_CollapseExpand.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
      this.btn_CollapseExpand.ForeColor = System.Drawing.Color.Gray;
      this.btn_CollapseExpand.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
      this.btn_CollapseExpand.IconColor = System.Drawing.Color.DimGray;
      this.btn_CollapseExpand.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btn_CollapseExpand.IconSize = 21;
      this.btn_CollapseExpand.Location = new System.Drawing.Point(584, 47);
      this.btn_CollapseExpand.Name = "btn_CollapseExpand";
      this.btn_CollapseExpand.Size = new System.Drawing.Size(18, 18);
      this.btn_CollapseExpand.TabIndex = 40;
      this.btn_CollapseExpand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.metroSetSetToolTip1.SetToolTip(this.btn_CollapseExpand, "Collapse/Expand");
      this.btn_CollapseExpand.UseVisualStyleBackColor = false;
      this.btn_CollapseExpand.Click += new System.EventHandler(this.btn_CollapseExpand_Click);
      // 
      // btn_Close
      // 
      this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Close.ForeColor = System.Drawing.Color.Transparent;
      this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.Times;
      this.btn_Close.IconColor = System.Drawing.Color.DimGray;
      this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btn_Close.IconSize = 20;
      this.btn_Close.Location = new System.Drawing.Point(588, 0);
      this.btn_Close.Name = "btn_Close";
      this.btn_Close.Size = new System.Drawing.Size(26, 41);
      this.btn_Close.TabIndex = 40;
      this.metroSetSetToolTip1.SetToolTip(this.btn_Close, "Close");
      this.btn_Close.UseVisualStyleBackColor = false;
      this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
      // 
      // btn_Minimize
      // 
      this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Minimize.ForeColor = System.Drawing.Color.Transparent;
      this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
      this.btn_Minimize.IconColor = System.Drawing.Color.DimGray;
      this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btn_Minimize.IconSize = 20;
      this.btn_Minimize.Location = new System.Drawing.Point(562, 0);
      this.btn_Minimize.Name = "btn_Minimize";
      this.btn_Minimize.Size = new System.Drawing.Size(26, 41);
      this.btn_Minimize.TabIndex = 41;
      this.metroSetSetToolTip1.SetToolTip(this.btn_Minimize, "Minimize");
      this.btn_Minimize.UseVisualStyleBackColor = false;
      this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
      // 
      // btn_PotencyPriority
      // 
      this.btn_PotencyPriority.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_PotencyPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_PotencyPriority.IsDerivedStyle = true;
      this.btn_PotencyPriority.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.btn_PotencyPriority.Location = new System.Drawing.Point(468, 46);
      this.btn_PotencyPriority.Name = "btn_PotencyPriority";
      this.btn_PotencyPriority.Size = new System.Drawing.Size(107, 23);
      this.btn_PotencyPriority.Style = MetroSet_UI.Enums.Style.Dark;
      this.btn_PotencyPriority.StyleManager = null;
      this.btn_PotencyPriority.TabIndex = 42;
      this.btn_PotencyPriority.TabStop = true;
      this.btn_PotencyPriority.Text = "Potency/Priority";
      this.btn_PotencyPriority.ThemeAuthor = "Narwin";
      this.btn_PotencyPriority.ThemeName = "MetroLite";
      this.metroSetSetToolTip1.SetToolTip(this.btn_PotencyPriority, "Edit Potency/Priority");
      this.btn_PotencyPriority.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
      this.btn_PotencyPriority.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_PotencyPriority_LinkClicked);
      // 
      // btn_ClearBuffs
      // 
      this.btn_ClearBuffs.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_ClearBuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_ClearBuffs.IsDerivedStyle = true;
      this.btn_ClearBuffs.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.btn_ClearBuffs.Location = new System.Drawing.Point(302, 73);
      this.btn_ClearBuffs.Name = "btn_ClearBuffs";
      this.btn_ClearBuffs.Size = new System.Drawing.Size(44, 21);
      this.btn_ClearBuffs.Style = MetroSet_UI.Enums.Style.Dark;
      this.btn_ClearBuffs.StyleManager = null;
      this.btn_ClearBuffs.TabIndex = 28;
      this.btn_ClearBuffs.TabStop = true;
      this.btn_ClearBuffs.Text = "Clear";
      this.btn_ClearBuffs.ThemeAuthor = "Narwin";
      this.btn_ClearBuffs.ThemeName = "MetroLite";
      this.btn_ClearBuffs.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
      this.btn_ClearBuffs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_ClearBuffs_LinkClicked);
      // 
      // btn_ClearMonitorsIgnores
      // 
      this.btn_ClearMonitorsIgnores.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_ClearMonitorsIgnores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_ClearMonitorsIgnores.IsDerivedStyle = true;
      this.btn_ClearMonitorsIgnores.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.btn_ClearMonitorsIgnores.Location = new System.Drawing.Point(122, 75);
      this.btn_ClearMonitorsIgnores.Name = "btn_ClearMonitorsIgnores";
      this.btn_ClearMonitorsIgnores.Size = new System.Drawing.Size(44, 23);
      this.btn_ClearMonitorsIgnores.Style = MetroSet_UI.Enums.Style.Dark;
      this.btn_ClearMonitorsIgnores.StyleManager = null;
      this.btn_ClearMonitorsIgnores.TabIndex = 29;
      this.btn_ClearMonitorsIgnores.TabStop = true;
      this.btn_ClearMonitorsIgnores.Text = "Clear";
      this.btn_ClearMonitorsIgnores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btn_ClearMonitorsIgnores.ThemeAuthor = "Narwin";
      this.btn_ClearMonitorsIgnores.ThemeName = "MetroLite";
      this.btn_ClearMonitorsIgnores.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
      this.btn_ClearMonitorsIgnores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_ClearMonitorsIgnores_LinkClicked);
      // 
      // cb_WaitFor
      // 
      this.cb_WaitFor.FormattingEnabled = true;
      this.cb_WaitFor.Location = new System.Drawing.Point(132, 60);
      this.cb_WaitFor.Name = "cb_WaitFor";
      this.cb_WaitFor.Size = new System.Drawing.Size(117, 24);
      this.cb_WaitFor.TabIndex = 30;
      this.cb_WaitFor.SelectedIndexChanged += new System.EventHandler(this.cb_Feature_SelectedIndexChanged);
      // 
      // cb_WeaponskillHpOperator
      // 
      this.cb_WeaponskillHpOperator.FormattingEnabled = true;
      this.cb_WeaponskillHpOperator.Location = new System.Drawing.Point(229, 29);
      this.cb_WeaponskillHpOperator.Name = "cb_WeaponskillHpOperator";
      this.cb_WeaponskillHpOperator.Size = new System.Drawing.Size(52, 24);
      this.cb_WeaponskillHpOperator.TabIndex = 31;
      this.cb_WeaponskillHpOperator.SelectedIndexChanged += new System.EventHandler(this.cb_Feature_SelectedIndexChanged);
      // 
      // cb_Weaponskill
      // 
      this.cb_Weaponskill.FormattingEnabled = true;
      this.cb_Weaponskill.Location = new System.Drawing.Point(132, 4);
      this.cb_Weaponskill.Name = "cb_Weaponskill";
      this.cb_Weaponskill.Size = new System.Drawing.Size(210, 24);
      this.cb_Weaponskill.TabIndex = 32;
      this.cb_Weaponskill.SelectedIndexChanged += new System.EventHandler(this.cb_Feature_SelectedIndexChanged);
      // 
      // lbl_WaitForToggle
      // 
      this.lbl_WaitForToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lbl_WaitForToggle.IsDerivedStyle = true;
      this.lbl_WaitForToggle.Location = new System.Drawing.Point(66, 59);
      this.lbl_WaitForToggle.Name = "lbl_WaitForToggle";
      this.lbl_WaitForToggle.Size = new System.Drawing.Size(57, 24);
      this.lbl_WaitForToggle.Style = MetroSet_UI.Enums.Style.Light;
      this.lbl_WaitForToggle.StyleManager = null;
      this.lbl_WaitForToggle.TabIndex = 21;
      this.lbl_WaitForToggle.Text = "Wait for";
      this.lbl_WaitForToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lbl_WaitForToggle.ThemeAuthor = "Narwin";
      this.lbl_WaitForToggle.ThemeName = "MetroLight";
      // 
      // num_WeaponskillHpPercent
      // 
      this.num_WeaponskillHpPercent.Location = new System.Drawing.Point(283, 30);
      this.num_WeaponskillHpPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.num_WeaponskillHpPercent.Name = "num_WeaponskillHpPercent";
      this.num_WeaponskillHpPercent.Size = new System.Drawing.Size(45, 22);
      this.num_WeaponskillHpPercent.TabIndex = 17;
      this.num_WeaponskillHpPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // metroSetLabel11
      // 
      this.metroSetLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      this.metroSetLabel11.IsDerivedStyle = true;
      this.metroSetLabel11.Location = new System.Drawing.Point(182, 29);
      this.metroSetLabel11.Name = "metroSetLabel11";
      this.metroSetLabel11.Size = new System.Drawing.Size(46, 22);
      this.metroSetLabel11.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel11.StyleManager = null;
      this.metroSetLabel11.TabIndex = 20;
      this.metroSetLabel11.Text = "Mob HP";
      this.metroSetLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.metroSetLabel11.ThemeAuthor = "Narwin";
      this.metroSetLabel11.ThemeName = "MetroLight";
      // 
      // lbl_WeaponskillToggle
      // 
      this.lbl_WeaponskillToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      this.lbl_WeaponskillToggle.IsDerivedStyle = true;
      this.lbl_WeaponskillToggle.Location = new System.Drawing.Point(66, 9);
      this.lbl_WeaponskillToggle.Name = "lbl_WeaponskillToggle";
      this.lbl_WeaponskillToggle.Size = new System.Drawing.Size(65, 17);
      this.lbl_WeaponskillToggle.Style = MetroSet_UI.Enums.Style.Light;
      this.lbl_WeaponskillToggle.StyleManager = null;
      this.lbl_WeaponskillToggle.TabIndex = 17;
      this.lbl_WeaponskillToggle.Text = "Weaponskill";
      this.lbl_WeaponskillToggle.ThemeAuthor = "Narwin";
      this.lbl_WeaponskillToggle.ThemeName = "MetroLight";
      // 
      // num_WaitFor
      // 
      this.num_WaitFor.Location = new System.Drawing.Point(290, 61);
      this.num_WaitFor.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
      this.num_WaitFor.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.num_WaitFor.Name = "num_WaitFor";
      this.num_WaitFor.Size = new System.Drawing.Size(52, 22);
      this.num_WaitFor.TabIndex = 18;
      this.num_WaitFor.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // metroSetLabel13
      // 
      this.metroSetLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      this.metroSetLabel13.IsDerivedStyle = true;
      this.metroSetLabel13.Location = new System.Drawing.Point(252, 60);
      this.metroSetLabel13.Name = "metroSetLabel13";
      this.metroSetLabel13.Size = new System.Drawing.Size(35, 22);
      this.metroSetLabel13.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel13.StyleManager = null;
      this.metroSetLabel13.TabIndex = 26;
      this.metroSetLabel13.Text = "TP >";
      this.metroSetLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.metroSetLabel13.ThemeAuthor = "Narwin";
      this.metroSetLabel13.ThemeName = "MetroLight";
      // 
      // metroSetPanel6
      // 
      this.metroSetPanel6.BackgroundColor = System.Drawing.Color.White;
      this.metroSetPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
      this.metroSetPanel6.BorderThickness = 1;
      this.metroSetPanel6.Controls.Add(this.lb_Buffs);
      this.metroSetPanel6.Controls.Add(this.btn_Buff);
      this.metroSetPanel6.Controls.Add(this.btn_ClearBuffs);
      this.metroSetPanel6.Controls.Add(this.cb_BuffSpell);
      this.metroSetPanel6.Controls.Add(this.cb_BuffPlayer);
      this.metroSetPanel6.Controls.Add(this.btn_LoadBuffList);
      this.metroSetPanel6.Controls.Add(this.btn_SaveBuffList);
      this.metroSetPanel6.IsDerivedStyle = true;
      this.metroSetPanel6.Location = new System.Drawing.Point(263, 72);
      this.metroSetPanel6.Name = "metroSetPanel6";
      this.metroSetPanel6.Size = new System.Drawing.Size(350, 99);
      this.metroSetPanel6.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetPanel6.StyleManager = null;
      this.metroSetPanel6.TabIndex = 24;
      this.metroSetPanel6.ThemeAuthor = "Narwin";
      this.metroSetPanel6.ThemeName = "MetroLite";
      // 
      // metroSetPanel7
      // 
      this.metroSetPanel7.BackgroundColor = System.Drawing.Color.White;
      this.metroSetPanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
      this.metroSetPanel7.BorderThickness = 1;
      this.metroSetPanel7.Controls.Add(this.btn_ClearMonitorsIgnores);
      this.metroSetPanel7.Controls.Add(this.lb_MonitorsIgnores);
      this.metroSetPanel7.Controls.Add(this.btn_Monitor);
      this.metroSetPanel7.Controls.Add(this.btn_Ignore);
      this.metroSetPanel7.Controls.Add(this.cb_MonitorIgnorePlayer);
      this.metroSetPanel7.IsDerivedStyle = true;
      this.metroSetPanel7.Location = new System.Drawing.Point(440, 171);
      this.metroSetPanel7.Name = "metroSetPanel7";
      this.metroSetPanel7.Size = new System.Drawing.Size(173, 100);
      this.metroSetPanel7.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetPanel7.StyleManager = null;
      this.metroSetPanel7.TabIndex = 29;
      this.metroSetPanel7.ThemeAuthor = "Narwin";
      this.metroSetPanel7.ThemeName = "MetroLite";
      // 
      // metroSetPanel8
      // 
      this.metroSetPanel8.BackgroundColor = System.Drawing.Color.White;
      this.metroSetPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
      this.metroSetPanel8.BorderThickness = 1;
      this.metroSetPanel8.Controls.Add(this.btn_ClearDebuffs);
      this.metroSetPanel8.Controls.Add(this.btn_Debuff);
      this.metroSetPanel8.Controls.Add(this.cb_DebuffSpell);
      this.metroSetPanel8.Controls.Add(this.lb_Debuff);
      this.metroSetPanel8.IsDerivedStyle = true;
      this.metroSetPanel8.Location = new System.Drawing.Point(263, 171);
      this.metroSetPanel8.Name = "metroSetPanel8";
      this.metroSetPanel8.Size = new System.Drawing.Size(176, 100);
      this.metroSetPanel8.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetPanel8.StyleManager = null;
      this.metroSetPanel8.TabIndex = 30;
      this.metroSetPanel8.ThemeAuthor = "Narwin";
      this.metroSetPanel8.ThemeName = "MetroLite";
      // 
      // btn_ClearDebuffs
      // 
      this.btn_ClearDebuffs.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_ClearDebuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_ClearDebuffs.IsDerivedStyle = true;
      this.btn_ClearDebuffs.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.btn_ClearDebuffs.Location = new System.Drawing.Point(121, 74);
      this.btn_ClearDebuffs.Name = "btn_ClearDebuffs";
      this.btn_ClearDebuffs.Size = new System.Drawing.Size(44, 23);
      this.btn_ClearDebuffs.Style = MetroSet_UI.Enums.Style.Dark;
      this.btn_ClearDebuffs.StyleManager = null;
      this.btn_ClearDebuffs.TabIndex = 32;
      this.btn_ClearDebuffs.TabStop = true;
      this.btn_ClearDebuffs.Text = "Clear";
      this.btn_ClearDebuffs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btn_ClearDebuffs.ThemeAuthor = "Narwin";
      this.btn_ClearDebuffs.ThemeName = "MetroLite";
      this.btn_ClearDebuffs.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
      this.btn_ClearDebuffs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_ClearDebuffs_LinkClicked);
      // 
      // lbl_EngageToggle
      // 
      this.lbl_EngageToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lbl_EngageToggle.IsDerivedStyle = true;
      this.lbl_EngageToggle.Location = new System.Drawing.Point(66, 34);
      this.lbl_EngageToggle.Name = "lbl_EngageToggle";
      this.lbl_EngageToggle.Size = new System.Drawing.Size(57, 21);
      this.lbl_EngageToggle.Style = MetroSet_UI.Enums.Style.Light;
      this.lbl_EngageToggle.StyleManager = null;
      this.lbl_EngageToggle.TabIndex = 34;
      this.lbl_EngageToggle.Text = "Engage";
      this.lbl_EngageToggle.ThemeAuthor = "Narwin";
      this.lbl_EngageToggle.ThemeName = "MetroLight";
      // 
      // metroSetLabel17
      // 
      this.metroSetLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      this.metroSetLabel17.IsDerivedStyle = true;
      this.metroSetLabel17.Location = new System.Drawing.Point(330, 29);
      this.metroSetLabel17.Name = "metroSetLabel17";
      this.metroSetLabel17.Size = new System.Drawing.Size(18, 22);
      this.metroSetLabel17.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel17.StyleManager = null;
      this.metroSetLabel17.TabIndex = 36;
      this.metroSetLabel17.Text = "%";
      this.metroSetLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.metroSetLabel17.ThemeAuthor = "Narwin";
      this.metroSetLabel17.ThemeName = "MetroLight";
      // 
      // panel_Combat
      // 
      this.panel_Combat.BackgroundColor = System.Drawing.Color.White;
      this.panel_Combat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
      this.panel_Combat.BorderThickness = 1;
      this.panel_Combat.Controls.Add(this.lbl_WaitForToggle);
      this.panel_Combat.Controls.Add(this.toggle_WaitFor);
      this.panel_Combat.Controls.Add(this.cb_Weaponskill);
      this.panel_Combat.Controls.Add(this.lbl_EngageToggle);
      this.panel_Combat.Controls.Add(this.cb_WaitFor);
      this.panel_Combat.Controls.Add(this.metroSetLabel11);
      this.panel_Combat.Controls.Add(this.metroSetLabel17);
      this.panel_Combat.Controls.Add(this.metroSetLabel13);
      this.panel_Combat.Controls.Add(this.num_WeaponskillHpPercent);
      this.panel_Combat.Controls.Add(this.num_WaitFor);
      this.panel_Combat.Controls.Add(this.toggle_Attack);
      this.panel_Combat.Controls.Add(this.cb_WeaponskillHpOperator);
      this.panel_Combat.Controls.Add(this.toggle_Weaponskill);
      this.panel_Combat.Controls.Add(this.lbl_WeaponskillToggle);
      this.panel_Combat.IsDerivedStyle = true;
      this.panel_Combat.Location = new System.Drawing.Point(263, 271);
      this.panel_Combat.Name = "panel_Combat";
      this.panel_Combat.Size = new System.Drawing.Size(350, 93);
      this.panel_Combat.Style = MetroSet_UI.Enums.Style.Light;
      this.panel_Combat.StyleManager = null;
      this.panel_Combat.TabIndex = 36;
      this.panel_Combat.ThemeAuthor = "Narwin";
      this.panel_Combat.ThemeName = "MetroLite";
      // 
      // cb_SelectCharacter
      // 
      this.cb_SelectCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cb_SelectCharacter.FormattingEnabled = true;
      this.cb_SelectCharacter.Location = new System.Drawing.Point(5, 45);
      this.cb_SelectCharacter.Name = "cb_SelectCharacter";
      this.cb_SelectCharacter.Size = new System.Drawing.Size(128, 24);
      this.cb_SelectCharacter.TabIndex = 38;
      this.cb_SelectCharacter.SelectedIndexChanged += new System.EventHandler(this.cb_SelectCharacter_SelectedIndexChanged);
      // 
      // img_Warning
      // 
      this.img_Warning.BackColor = System.Drawing.Color.Transparent;
      this.img_Warning.ForeColor = System.Drawing.Color.Yellow;
      this.img_Warning.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
      this.img_Warning.IconColor = System.Drawing.Color.Yellow;
      this.img_Warning.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.img_Warning.IconSize = 18;
      this.img_Warning.Location = new System.Drawing.Point(31, 27);
      this.img_Warning.Name = "img_Warning";
      this.img_Warning.Size = new System.Drawing.Size(18, 18);
      this.img_Warning.TabIndex = 43;
      this.img_Warning.TabStop = false;
      this.img_Warning.Visible = false;
      // 
      // lbl_Warning
      // 
      this.lbl_Warning.AutoSize = true;
      this.lbl_Warning.BackColor = System.Drawing.Color.Transparent;
      this.lbl_Warning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_Warning.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
      this.lbl_Warning.ForeColor = System.Drawing.Color.Yellow;
      this.lbl_Warning.Location = new System.Drawing.Point(46, 27);
      this.lbl_Warning.Name = "lbl_Warning";
      this.lbl_Warning.Size = new System.Drawing.Size(144, 15);
      this.lbl_Warning.TabIndex = 44;
      this.lbl_Warning.Text = "NOT RUNNING AS ADMIN";
      this.lbl_Warning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lbl_Warning.Visible = false;
      // 
      // MainForm
      // 
      this.AllowResize = false;
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BorderThickness = 3F;
      this.ClientSize = new System.Drawing.Size(732, 441);
      this.ControlBox = false;
      this.Controls.Add(this.lbl_Warning);
      this.Controls.Add(this.btn_PotencyPriority);
      this.Controls.Add(this.btn_CollapseExpand);
      this.Controls.Add(this.btn_Minimize);
      this.Controls.Add(this.btn_Close);
      this.Controls.Add(this.btn_HealbotUnload);
      this.Controls.Add(this.btn_HealbotLoad);
      this.Controls.Add(this.cb_SelectCharacter);
      this.Controls.Add(this.panel_Combat);
      this.Controls.Add(this.btn_SaveSettings);
      this.Controls.Add(this.btn_LoadSettings);
      this.Controls.Add(this.btn_SetWindowerPath);
      this.Controls.Add(this.metroSetPanel8);
      this.Controls.Add(this.metroSetPanel7);
      this.Controls.Add(this.metroSetPanel6);
      this.Controls.Add(this.btn_HealbotRefresh);
      this.Controls.Add(this.btn_HealbotOff);
      this.Controls.Add(this.btn_HealbotOn);
      this.Controls.Add(this.panel_Toggles);
      this.Controls.Add(this.img_Warning);
      this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(2, 70, 2, 2);
      this.ShowBorder = true;
      this.ShowHeader = true;
      this.ShowLeftRect = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "HEALBOT CONFIGURATOR 2";
      this.TextColor = System.Drawing.Color.White;
      this.ThemeName = "MetroLight";
      this.Shown += new System.EventHandler(this.MainForm_Shown);
      this.panel_Toggles.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.num_FollowDistance)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.num_MinCuraga)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.num_MinCure)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.num_WeaponskillHpPercent)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.num_WaitFor)).EndInit();
      this.metroSetPanel6.ResumeLayout(false);
      this.metroSetPanel7.ResumeLayout(false);
      this.metroSetPanel8.ResumeLayout(false);
      this.panel_Combat.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.img_Warning)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MetroSet_UI.Controls.MetroSetPanel panel_Toggles;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Cure;
    private MetroSet_UI.Components.MetroSetSetToolTip metroSetSetToolTip1;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_IgnoreTrusts;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Debuffs;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Buffs;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Erase;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Na;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Curaga;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Follow;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel13;
    private MetroSet_UI.Controls.MetroSetLabel lbl_WaitForToggle;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel11;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Weaponskill;
    private MetroSet_UI.Controls.MetroSetLabel lbl_WeaponskillToggle;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Spam;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Assist;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel14;
    private System.Windows.Forms.NumericUpDown num_MinCure;
    private System.Windows.Forms.NumericUpDown num_WeaponskillHpPercent;
    private System.Windows.Forms.NumericUpDown num_WaitFor;
    private System.Windows.Forms.NumericUpDown num_MinCuraga;
    private MetroSet_UI.Controls.MetroSetButton btn_HealbotRefresh;
    private MetroSet_UI.Controls.MetroSetButton btn_HealbotOff;
    private MetroSet_UI.Controls.MetroSetButton btn_HealbotOn;
    private MetroSet_UI.Controls.MetroSetPanel metroSetPanel6;
    private MetroSet_UI.Controls.MetroSetLink btn_LoadBuffList;
    private MetroSet_UI.Controls.MetroSetLink btn_SaveBuffList;
    private MetroSet_UI.Controls.MetroSetLink btn_ClearBuffs;
    private MetroSet_UI.Controls.MetroSetListBox lb_Buffs;
    private MetroSet_UI.Controls.MetroSetButton btn_Buff;
    private System.Windows.Forms.ComboBox cb_BuffSpell;
    private System.Windows.Forms.ComboBox cb_BuffPlayer;
    private System.Windows.Forms.ComboBox cb_Follow;
    private System.Windows.Forms.ComboBox cb_Spam;
    private System.Windows.Forms.ComboBox cb_WaitFor;
    private System.Windows.Forms.ComboBox cb_WeaponskillHpOperator;
    private System.Windows.Forms.ComboBox cb_Weaponskill;
    private System.Windows.Forms.ComboBox cb_Assist;
    private MetroSet_UI.Controls.MetroSetPanel metroSetPanel7;
    private MetroSet_UI.Controls.MetroSetLink btn_ClearMonitorsIgnores;
    private MetroSet_UI.Controls.MetroSetListBox lb_MonitorsIgnores;
    private MetroSet_UI.Controls.MetroSetButton btn_Monitor;
    private MetroSet_UI.Controls.MetroSetButton btn_Ignore;
    private System.Windows.Forms.ComboBox cb_MonitorIgnorePlayer;
    private MetroSet_UI.Controls.MetroSetPanel metroSetPanel8;
    private FontAwesome.Sharp.IconButton btn_SetWindowerPath;
    private MetroSet_UI.Controls.MetroSetLink btn_ClearDebuffs;
    private MetroSet_UI.Controls.MetroSetButton btn_Debuff;
    private System.Windows.Forms.ComboBox cb_DebuffSpell;
    private MetroSet_UI.Controls.MetroSetListBox lb_Debuff;
    private FontAwesome.Sharp.IconButton btn_LoadSettings;
    private FontAwesome.Sharp.IconButton btn_SaveSettings;
    private MetroSet_UI.Controls.MetroSetLabel lbl_EngageToggle;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_Attack;
    private System.Windows.Forms.NumericUpDown num_FollowDistance;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel17;
    private MetroSet_UI.Controls.MetroSetPanel panel_Combat;
    private MetroSet_UI.Controls.MetroSetSwitch toggle_WaitFor;
    private System.Windows.Forms.ComboBox cb_SelectCharacter;
    private MetroSet_UI.Controls.MetroSetLink btn_HealbotLoad;
    private MetroSet_UI.Controls.MetroSetLink btn_HealbotUnload;
    private FontAwesome.Sharp.IconButton btn_CollapseExpand;
    private FontAwesome.Sharp.IconButton btn_Close;
    private FontAwesome.Sharp.IconButton btn_Minimize;
    private MetroSet_UI.Controls.MetroSetLink btn_PotencyPriority;
    private FontAwesome.Sharp.IconPictureBox img_Warning;
    private System.Windows.Forms.Label lbl_Warning;
  }
}

