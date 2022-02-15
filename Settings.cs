using System.Collections.Generic;

namespace HealbotConfigurator2
{
  public class GlobalSettings
  {
    public string WindowerPath { get; set; }
    public bool StartCollapsed { get; set; }
    public bool KeepOnTop { get; set; }

    public GlobalSettings()
    { WindowerPath = string.Empty; }

    public GlobalSettings(string windowerPath)
    { WindowerPath = windowerPath; }
  }

  public class Settings
  {
    // TOGGLES
    public bool CureEnabled { get; set; }

    public bool CuragaEnabled { get; set; }
    public bool NaSpellsEnabled { get; set; }
    public bool EraseEnabled { get; set; }
    public bool BuffsEnabled { get; set; }
    public bool DebuffsEnabled { get; set; }
    public bool IgnoreTrustsEnabled { get; set; }
    public bool FollowEnabled { get; set; }
    public bool AssistEnabled { get; set; }
    public bool SpamEnabled { get; set; }
    public bool WeaponskillEnabled { get; set; }
    public bool EngageEnabled { get; set; }
    public bool WaitForEnabled { get; set; }

    // NUM
    public int MinCure { get; set; }

    public int MinCuraga { get; set; }
    public int FollowDistance { get; set; }
    public int WaitForTp { get; set; }
    public int WeaponskillHpPercent { get; set; }

    // COMBO BOXES
    public string FollowPlayer { get; set; }

    public string AssistPlayer { get; set; }
    public string SpamSpell { get; set; }
    public string Weaponskill { get; set; }
    public string WeaponskillHpOperator { get; set; }
    public string WaitForPlayer { get; set; }

    // LIST BOXES
    public List<string> Buffs { get; set; }

    public List<string> Debuffs { get; set; }
    public List<string> MonitorsIgnores { get; set; }

    public Settings()
    {
      CureEnabled = true;
      CuragaEnabled = true;
      NaSpellsEnabled = true;
      EraseEnabled = true;
      BuffsEnabled = true;
      DebuffsEnabled = true;
      IgnoreTrustsEnabled = false;
      FollowEnabled = false;
      AssistEnabled = false;
      SpamEnabled = false;
      WeaponskillEnabled = false;
      EngageEnabled = false;
      WaitForEnabled = false;

      MinCure = 3;
      MinCuraga = 2;
      FollowDistance = 3;
      WaitForTp = 1000;
      WeaponskillHpPercent = 1;

      FollowPlayer = string.Empty;
      AssistPlayer = string.Empty;
      SpamSpell = string.Empty;
      Weaponskill = string.Empty;
      WeaponskillHpOperator = ">";
      WaitForPlayer = string.Empty;

      Buffs = new List<string>();
      Debuffs = new List<string>();
      MonitorsIgnores = new List<string>();
    }
  }
}