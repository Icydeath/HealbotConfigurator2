
namespace HealbotConfigurator2
{
  partial class SaveBuffListForm
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
      this.cb_BuffLists = new System.Windows.Forms.ComboBox();
      this.btn_SaveBuffList = new MetroSet_UI.Controls.MetroSetButton();
      this.btn_Close = new FontAwesome.Sharp.IconButton();
      this.btn_Delete = new FontAwesome.Sharp.IconButton();
      this.metroSetSetToolTip1 = new MetroSet_UI.Components.MetroSetSetToolTip();
      this.SuspendLayout();
      // 
      // cb_BuffLists
      // 
      this.cb_BuffLists.FormattingEnabled = true;
      this.cb_BuffLists.Location = new System.Drawing.Point(5, 51);
      this.cb_BuffLists.Name = "cb_BuffLists";
      this.cb_BuffLists.Size = new System.Drawing.Size(235, 28);
      this.cb_BuffLists.TabIndex = 0;
      this.cb_BuffLists.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_BuffLists_KeyPress);
      // 
      // btn_SaveBuffList
      // 
      this.btn_SaveBuffList.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_SaveBuffList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_SaveBuffList.DisabledForeColor = System.Drawing.Color.Gray;
      this.btn_SaveBuffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btn_SaveBuffList.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_SaveBuffList.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
      this.btn_SaveBuffList.HoverTextColor = System.Drawing.Color.White;
      this.btn_SaveBuffList.IsDerivedStyle = true;
      this.btn_SaveBuffList.Location = new System.Drawing.Point(169, 85);
      this.btn_SaveBuffList.Name = "btn_SaveBuffList";
      this.btn_SaveBuffList.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_SaveBuffList.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
      this.btn_SaveBuffList.NormalTextColor = System.Drawing.Color.White;
      this.btn_SaveBuffList.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_SaveBuffList.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
      this.btn_SaveBuffList.PressTextColor = System.Drawing.Color.White;
      this.btn_SaveBuffList.Size = new System.Drawing.Size(71, 23);
      this.btn_SaveBuffList.Style = MetroSet_UI.Enums.Style.Light;
      this.btn_SaveBuffList.StyleManager = null;
      this.btn_SaveBuffList.TabIndex = 1;
      this.btn_SaveBuffList.Text = "Save";
      this.btn_SaveBuffList.ThemeAuthor = "Narwin";
      this.btn_SaveBuffList.ThemeName = "MetroLite";
      this.btn_SaveBuffList.Click += new System.EventHandler(this.btn_SaveBuffList_Click);
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
      this.btn_Close.Location = new System.Drawing.Point(217, 0);
      this.btn_Close.Name = "btn_Close";
      this.btn_Close.Size = new System.Drawing.Size(26, 41);
      this.btn_Close.TabIndex = 41;
      this.btn_Close.UseVisualStyleBackColor = false;
      this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
      // 
      // btn_Delete
      // 
      this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
      this.btn_Delete.FlatAppearance.BorderSize = 0;
      this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Delete.ForeColor = System.Drawing.Color.Red;
      this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
      this.btn_Delete.IconColor = System.Drawing.Color.DarkRed;
      this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
      this.btn_Delete.IconSize = 18;
      this.btn_Delete.Location = new System.Drawing.Point(5, 85);
      this.btn_Delete.Name = "btn_Delete";
      this.btn_Delete.Size = new System.Drawing.Size(31, 23);
      this.btn_Delete.TabIndex = 42;
      this.metroSetSetToolTip1.SetToolTip(this.btn_Delete, "Delete Selected List");
      this.btn_Delete.UseVisualStyleBackColor = false;
      this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
      // SaveBuffListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(245, 115);
      this.Controls.Add(this.btn_Delete);
      this.Controls.Add(this.btn_Close);
      this.Controls.Add(this.btn_SaveBuffList);
      this.Controls.Add(this.cb_BuffLists);
      this.Name = "SaveBuffListForm";
      this.Padding = new System.Windows.Forms.Padding(2, 70, 2, 2);
      this.ShowBorder = true;
      this.ShowHeader = true;
      this.ShowLeftRect = false;
      this.Text = "SAVE OR DELETE LIST";
      this.TextColor = System.Drawing.Color.White;
      this.Load += new System.EventHandler(this.SaveBuffListForm_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cb_BuffLists;
    private MetroSet_UI.Controls.MetroSetButton btn_SaveBuffList;
    private FontAwesome.Sharp.IconButton btn_Close;
    private FontAwesome.Sharp.IconButton btn_Delete;
    private MetroSet_UI.Components.MetroSetSetToolTip metroSetSetToolTip1;
  }
}