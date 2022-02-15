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
  public partial class SaveBuffListForm : MetroSetForm
  {
    public SaveBuffListForm()
    {
      InitializeComponent();
    }

    private void SaveBuffListForm_Load(object sender, EventArgs e)
    {
      cb_BuffLists.Text = "buffs";

      if (MainForm._ELITEAPI == null)
        return;

      foreach (var blist in MainForm._HealbotData.BuffLists)
        cb_BuffLists.Items.Add(blist.Name);

      var mainjob = MainForm._Resources.Jobs.Where(x => x.Id == MainForm._ELITEAPI.Player.MainJob).FirstOrDefault();
      var subjob = MainForm._Resources.Jobs.Where(x => x.Id == MainForm._ELITEAPI.Player.SubJob).FirstOrDefault();
      if (mainjob != null && subjob != null)
        cb_BuffLists.Text = $"{mainjob.Name}/{subjob.Name}".ToLower();
 
    }

    private void btn_Close_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btn_SaveBuffList_Click(object sender, EventArgs e)
    {
      if (Save())
        Close();
    }

    private void btn_Delete_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(cb_BuffLists.Text))
        return;

      MainForm._HealbotData.RemoveBuffList(cb_BuffLists.Text, string.Empty);
      cb_BuffLists.Items.Remove(cb_BuffLists.Text);
      cb_BuffLists.SelectedIndex = 0;
    }

    private void cb_BuffLists_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != (char)Keys.Enter)
        return;

      if (Save())
        Close();
    }

    private bool Save()
    {
      if (string.IsNullOrWhiteSpace(cb_BuffLists.Text))
        return false;

      var newBuffList = new BuffList() { Name = cb_BuffLists.Text };
      newBuffList.List = new Dictionary<string, List<string>>
      {
        { "", MainForm.Buffs }
      };

      MainForm._HealbotData.SaveBuffList(newBuffList);

      return true;
    }
  }
}
