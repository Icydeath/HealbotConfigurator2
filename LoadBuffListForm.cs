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
  public partial class LoadBuffListForm : MetroSetForm
  {
    public LoadBuffListForm()
    {
      InitializeComponent();
    }

    private void LoadBuffListForm_Load(object sender, EventArgs e)
    {
      if (MainForm._ELITEAPI == null || MainForm._HealbotData == null)
      {
        return;
      }

      cb_BuffLists.Items.Clear();
      lb_Buffs.Items.Clear();

      foreach (var blist in MainForm._HealbotData.BuffLists)
        cb_BuffLists.Items.Add(blist.Name);
      
      cb_Player.Items.AddRange(MainForm.ComboboxItem_Players.ToArray());
    }

    private void btn_Close_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void lb_Buffs_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      var item = lb_Buffs.SelectedItem != null ? lb_Buffs.SelectedItem.ToString() : string.Empty;
      if (!string.IsNullOrEmpty(item))
      {
        lb_Buffs.Items.Remove(lb_Buffs.SelectedItem);
      }
    }

    private void cb_BuffLists_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (MainForm._ELITEAPI == null)
        return;

      LoadListBox();
    }

    private void btn_LoadBuffList_Click(object sender, EventArgs e)
    {
      foreach(var item in lb_Buffs.Items)
        MainForm.SelectedBuffList.Add(item.ToString());

      Close();
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
      MainForm.SelectedBuffList.Clear();
      Close();
    }

    private void cb_Player_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != (char)Keys.Enter)
        return;

      LoadListBox();
    }

    private void cb_Player_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadListBox();
    }

    private void LoadListBox()
    {
      lb_Buffs.Items.Clear();
      var sel_bufflist = cb_BuffLists.SelectedItem != null ? (string)cb_BuffLists.SelectedItem : !string.IsNullOrEmpty(cb_BuffLists.Text) ? cb_BuffLists.Text : string.Empty;
      if (string.IsNullOrEmpty(sel_bufflist))
        return;

      var splat = sel_bufflist.Split();
      var player = cb_Player.SelectedItem != null ? ((ComboboxItem)cb_Player.SelectedItem).Text : !string.IsNullOrEmpty(cb_Player.Text) ? cb_Player.Text : MainForm._ELITEAPI.Player.Name;
      var buffs = MainForm._HealbotData.BuffLists.Where(x => x.Name == splat[0]/* && x.List.ContainsKey(splat[1].Replace(player, "me"))*/).Select(x => x.List).FirstOrDefault();
      if (buffs == null)
        return;

      foreach (var buff in buffs.Values.FirstOrDefault())
      {
        var cmd = player + " → " + buff;
        if (!lb_Buffs.Items.Any(x => x.ToString() == cmd))
        {
          lb_Buffs.Items.Add(cmd);
        }
      }
    }
  }
}