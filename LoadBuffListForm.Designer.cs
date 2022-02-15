
namespace HealbotConfigurator2
{
  partial class LoadBuffListForm
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
      this.cb_BuffLists = new MetroSet_UI.Controls.MetroSetComboBox();
      this.lb_Buffs = new MetroSet_UI.Controls.MetroSetListBox();
      this.btn_Close = new FontAwesome.Sharp.IconButton();
      this.btn_LoadBuffList = new MetroSet_UI.Controls.MetroSetButton();
      this.btn_Cancel = new MetroSet_UI.Controls.MetroSetButton();
      this.cb_Player = new System.Windows.Forms.ComboBox();
      this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
      this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
      this.SuspendLayout();
      // 
      // cb_BuffLists
      // 
      this.cb_BuffLists.AllowDrop = true;
      this.cb_BuffLists.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
      this.cb_BuffLists.BackColor = System.Drawing.Color.Transparent;
      this.cb_BuffLists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
      this.cb_BuffLists.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
      this.cb_BuffLists.CausesValidation = false;
      this.cb_BuffLists.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
      this.cb_BuffLists.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
      this.cb_BuffLists.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      this.cb_BuffLists.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.cb_BuffLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cb_BuffLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
      this.cb_BuffLists.FormattingEnabled = true;
      this.cb_BuffLists.IsDerivedStyle = true;
      this.cb_BuffLists.ItemHeight = 20;
      this.cb_BuffLists.Location = new System.Drawing.Point(5, 74);
      this.cb_BuffLists.Name = "cb_BuffLists";
      this.cb_BuffLists.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.cb_BuffLists.SelectedItemForeColor = System.Drawing.Color.White;
      this.cb_BuffLists.Size = new System.Drawing.Size(118, 26);
      this.cb_BuffLists.Style = MetroSet_UI.Enums.Style.Light;
      this.cb_BuffLists.StyleManager = null;
      this.cb_BuffLists.TabIndex = 0;
      this.cb_BuffLists.ThemeAuthor = "Narwin";
      this.cb_BuffLists.ThemeName = "MetroLite";
      this.cb_BuffLists.SelectedIndexChanged += new System.EventHandler(this.cb_BuffLists_SelectedIndexChanged);
      // 
      // lb_Buffs
      // 
      this.lb_Buffs.BackColor = System.Drawing.Color.White;
      this.lb_Buffs.BorderColor = System.Drawing.Color.LightGray;
      this.lb_Buffs.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
      this.lb_Buffs.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      this.lb_Buffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lb_Buffs.HoveredItemBackColor = System.Drawing.Color.LightGray;
      this.lb_Buffs.HoveredItemColor = System.Drawing.Color.DimGray;
      this.lb_Buffs.IsDerivedStyle = true;
      this.lb_Buffs.ItemHeight = 14;
      this.lb_Buffs.Location = new System.Drawing.Point(5, 106);
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
      this.lb_Buffs.Size = new System.Drawing.Size(238, 175);
      this.lb_Buffs.Style = MetroSet_UI.Enums.Style.Light;
      this.lb_Buffs.StyleManager = null;
      this.lb_Buffs.TabIndex = 1;
      this.lb_Buffs.ThemeAuthor = "Narwin";
      this.lb_Buffs.ThemeName = "MetroLite";
      this.lb_Buffs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_Buffs_MouseDoubleClick);
      // 
      // btn_Close
      // 
      this.btn_Close.BackColor = System.Drawing.Color.Transparent;
      this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Close.FlatAppearance.BorderSize = 0;
      this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Close.ForeColor = System.Drawing.Color.Transparent;
      this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.Times;
      this.btn_Close.IconColor = System.Drawing.Color.DimGray;
      this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btn_Close.IconSize = 20;
      this.btn_Close.Location = new System.Drawing.Point(218, 4);
      this.btn_Close.Name = "btn_Close";
      this.btn_Close.Size = new System.Drawing.Size(26, 27);
      this.btn_Close.TabIndex = 41;
      this.btn_Close.UseVisualStyleBackColor = false;
      this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
      // 
      // btn_LoadBuffList
      // 
      this.btn_LoadBuffList.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_LoadBuffList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_LoadBuffList.DisabledForeColor = System.Drawing.Color.Gray;
      this.btn_LoadBuffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_LoadBuffList.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_LoadBuffList.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_LoadBuffList.HoverTextColor = System.Drawing.Color.White;
      this.btn_LoadBuffList.IsDerivedStyle = true;
      this.btn_LoadBuffList.Location = new System.Drawing.Point(169, 287);
      this.btn_LoadBuffList.Name = "btn_LoadBuffList";
      this.btn_LoadBuffList.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_LoadBuffList.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_LoadBuffList.NormalTextColor = System.Drawing.Color.White;
      this.btn_LoadBuffList.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_LoadBuffList.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_LoadBuffList.PressTextColor = System.Drawing.Color.White;
      this.btn_LoadBuffList.Size = new System.Drawing.Size(75, 23);
      this.btn_LoadBuffList.Style = MetroSet_UI.Enums.Style.Light;
      this.btn_LoadBuffList.StyleManager = null;
      this.btn_LoadBuffList.TabIndex = 42;
      this.btn_LoadBuffList.Text = "LOAD";
      this.btn_LoadBuffList.ThemeAuthor = "Narwin";
      this.btn_LoadBuffList.ThemeName = "MetroLite";
      this.btn_LoadBuffList.Click += new System.EventHandler(this.btn_LoadBuffList_Click);
      // 
      // btn_Cancel
      // 
      this.btn_Cancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Cancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_Cancel.DisabledForeColor = System.Drawing.Color.Gray;
      this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_Cancel.HoverBorderColor = System.Drawing.Color.Gray;
      this.btn_Cancel.HoverColor = System.Drawing.Color.Gray;
      this.btn_Cancel.HoverTextColor = System.Drawing.Color.White;
      this.btn_Cancel.IsDerivedStyle = false;
      this.btn_Cancel.Location = new System.Drawing.Point(5, 287);
      this.btn_Cancel.Name = "btn_Cancel";
      this.btn_Cancel.NormalBorderColor = System.Drawing.Color.Gray;
      this.btn_Cancel.NormalColor = System.Drawing.Color.Gray;
      this.btn_Cancel.NormalTextColor = System.Drawing.Color.White;
      this.btn_Cancel.PressBorderColor = System.Drawing.Color.DimGray;
      this.btn_Cancel.PressColor = System.Drawing.Color.DimGray;
      this.btn_Cancel.PressTextColor = System.Drawing.Color.White;
      this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
      this.btn_Cancel.Style = MetroSet_UI.Enums.Style.Light;
      this.btn_Cancel.StyleManager = null;
      this.btn_Cancel.TabIndex = 43;
      this.btn_Cancel.Text = "CANCEL";
      this.btn_Cancel.ThemeAuthor = "Narwin";
      this.btn_Cancel.ThemeName = "MetroLite";
      this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
      // 
      // cb_Player
      // 
      this.cb_Player.FormattingEnabled = true;
      this.cb_Player.Location = new System.Drawing.Point(129, 73);
      this.cb_Player.Name = "cb_Player";
      this.cb_Player.Size = new System.Drawing.Size(114, 28);
      this.cb_Player.TabIndex = 44;
      this.cb_Player.SelectedIndexChanged += new System.EventHandler(this.cb_Player_SelectedIndexChanged);
      this.cb_Player.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Player_KeyPress);
      // 
      // metroSetLabel1
      // 
      this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel1.IsDerivedStyle = true;
      this.metroSetLabel1.Location = new System.Drawing.Point(6, 45);
      this.metroSetLabel1.Name = "metroSetLabel1";
      this.metroSetLabel1.Size = new System.Drawing.Size(117, 23);
      this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel1.StyleManager = null;
      this.metroSetLabel1.TabIndex = 45;
      this.metroSetLabel1.Text = "Buff List:";
      this.metroSetLabel1.ThemeAuthor = "Narwin";
      this.metroSetLabel1.ThemeName = "MetroLite";
      // 
      // metroSetLabel2
      // 
      this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.metroSetLabel2.IsDerivedStyle = true;
      this.metroSetLabel2.Location = new System.Drawing.Point(129, 45);
      this.metroSetLabel2.Name = "metroSetLabel2";
      this.metroSetLabel2.Size = new System.Drawing.Size(114, 23);
      this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
      this.metroSetLabel2.StyleManager = null;
      this.metroSetLabel2.TabIndex = 46;
      this.metroSetLabel2.Text = "On Player:";
      this.metroSetLabel2.ThemeAuthor = "Narwin";
      this.metroSetLabel2.ThemeName = "MetroLite";
      // 
      // LoadBuffListForm
      // 
      this.AllowResize = false;
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(248, 316);
      this.Controls.Add(this.metroSetLabel2);
      this.Controls.Add(this.metroSetLabel1);
      this.Controls.Add(this.cb_Player);
      this.Controls.Add(this.btn_Cancel);
      this.Controls.Add(this.btn_LoadBuffList);
      this.Controls.Add(this.btn_Close);
      this.Controls.Add(this.lb_Buffs);
      this.Controls.Add(this.cb_BuffLists);
      this.Name = "LoadBuffListForm";
      this.Padding = new System.Windows.Forms.Padding(2, 70, 2, 2);
      this.ShowBorder = true;
      this.ShowHeader = true;
      this.ShowLeftRect = false;
      this.Text = "LOAD BUFF LIST";
      this.TextColor = System.Drawing.Color.White;
      this.Load += new System.EventHandler(this.LoadBuffListForm_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MetroSet_UI.Controls.MetroSetComboBox cb_BuffLists;
    private MetroSet_UI.Controls.MetroSetListBox lb_Buffs;
    private FontAwesome.Sharp.IconButton btn_Close;
    private MetroSet_UI.Controls.MetroSetButton btn_LoadBuffList;
    private MetroSet_UI.Controls.MetroSetButton btn_Cancel;
    private System.Windows.Forms.ComboBox cb_Player;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
    private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
  }
}