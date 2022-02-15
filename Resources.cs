using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteMMO.API;
using MoonSharp.Interpreter;

namespace HealbotConfigurator2
{
  public class Resources
  {
    public List<ResourceItem> Weaponskills { get; set; }
    public List<ResourceItem> Spells { get; set; }
    public List<ResourceItem> BuffSpells { get; set; }
    public List<ResourceItem> BuffAbilities { get; set; }
    public List<ResourceItem> Jobs { get; set; }

    private EliteAPI _EliteAPI;
    private string WindowerPath { get; set; }

    private int MainJobId { get; set; }
    private int MainJobLevel { get; set; }
    private int SubJobId { get; set; }
    private int SubJobLevel { get; set; }

    public Resources(string windowerpath, EliteAPI api)
    {
      if (string.IsNullOrEmpty(windowerpath) || api == null)
        return;

      WindowerPath = windowerpath;
      _EliteAPI = api;

      MainJobId = int.Parse(_EliteAPI.Player.MainJob.ToString());
      MainJobLevel = int.Parse(_EliteAPI.Player.MainJobLevel.ToString());
      SubJobId = int.Parse(_EliteAPI.Player.SubJob.ToString());
      SubJobLevel = int.Parse(_EliteAPI.Player.SubJobLevel.ToString());

      GetWeaponskills();
      GetSpells();
      GetBuffAbilities();
      GetJobs();
    }

    private void GetJobs()
    {
      Jobs = new List<ResourceItem>();
      var path = Path.Combine(WindowerPath, "res\\jobs.lua");
      string luaItems = File.ReadAllText(path);
      Script script = new Script();
      DynValue res = script.DoString(luaItems);
      foreach (DynValue dv in res.ToScalar().Table.Values)
      {
        Jobs.Add(new ResourceItem((double)dv.Table["id"], (string)dv.Table["ens"]));
      }
    }

    private void GetBuffAbilities()
    {
      BuffAbilities = new List<ResourceItem>();
      string luaItems = File.ReadAllText(Path.Combine(WindowerPath, @"res\job_abilities.lua"));
      Script script = new Script();
      DynValue res = script.DoString(luaItems);
      foreach (DynValue dv in res.ToScalar().Table.Values
        .Where(d => d.Table["type"] != null
        && !((string)d.Table["type"]).StartsWith("BloodPact") && (string)d.Table["type"] != "Monster"
        && d.Table["status"] != null
        //&& _EliteAPI.Player.HasAbility(uint.Parse(d.Table["id"].ToString()))
        ))
      {
        BuffAbilities.Add(new ResourceItem((double)dv.Table["id"], (string)dv.Table["en"]));
      }
    }

    private void GetSpells()
    {
      Spells = new List<ResourceItem>();
      BuffSpells = new List<ResourceItem>();

      string luaItems = File.ReadAllText(Path.Combine(WindowerPath, @"res\spells.lua"));
      Script script = new Script();
      DynValue res = script.DoString(luaItems);
      foreach (DynValue dv in res.ToScalar().Table.Values
        .Where(d => d.Table["type"] != null
          && d.Table["unlearnable"] == null
          && (string)d.Table["type"] != "SummonerPact"
          && (string)d.Table["type"] != "Trust"
          && _EliteAPI.Player.HasSpell(uint.Parse(d.Table["id"].ToString()))
          && (((Table)d.Table["levels"])[MainJobId] != null && (double)((Table)d.Table["levels"])[MainJobId] <= MainJobLevel ||
               ((Table)d.Table["levels"])[SubJobId] != null && (double)((Table)d.Table["levels"])[SubJobId] <= SubJobLevel)))
      {
        Spells.Add(new ResourceItem((double)dv.Table["id"], (string)dv.Table["en"]));

        if (dv.Table["status"] != null)
        {
          BuffSpells.Add(new ResourceItem((double)dv.Table["id"], (string)dv.Table["en"]));
        }
      }
    }

    private void GetWeaponskills()
    {
      Weaponskills = new List<ResourceItem>();
      var path = Path.Combine(WindowerPath, "res\\weapon_skills.lua");
      string luaItems = File.ReadAllText(path);
      Script script = new Script();
      DynValue res = script.DoString(luaItems);
      foreach (DynValue dv in res.ToScalar().Table.Values.Where(d => (double)d.Table["id"] < 241 && _EliteAPI.Player.HasWeaponSkill(uint.Parse(d.Table["id"].ToString())))) //.OrderBy(x => x.Table["id"])
      {
        Weaponskills.Add(new ResourceItem((double)dv.Table["id"], (string)dv.Table["en"]));
      }
    }
  }

  public class ResourceItem
  {
    public double Id { get; set; }
    public string Name { get; set; }
    public ResourceItem() {}
    public ResourceItem(double id, string name)
    {
      Id = id;
      Name = name;
    }
  }
}
