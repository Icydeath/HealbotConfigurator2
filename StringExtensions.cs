namespace HealbotConfigurator2
{
  public static class StringExtensions
  {
    public static string UcFirst(this string input)
    {
      if (input == null || input == "")
        return input;
      
      return input[0].ToString().ToUpper() + input.Substring(1);
    }

    public static bool IsNumeric(this string @this)
    {
      return int.TryParse(@this, out _);
    }

    //static readonly Regex _isNumericRegex =
    //new Regex("^(" +
    //            /*Hex*/ @"0x[0-9a-f]+" + "|" +
    //            /*Bin*/ @"0b[01]+" + "|" +
    //            /*Oct*/ @"0[0-7]*" + "|" +
    //            /*Dec*/ @"((?!0)|[-+]|(?=0+\.))(\d*\.)?\d+(e\d+)?" +
    //            ")$");
    //public static bool IsNumeric(this string @this)
    //{
    //  return _isNumericRegex.IsMatch(@this);
    //}
  }
}
