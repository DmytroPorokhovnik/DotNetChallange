namespace FizzBuzz.Rules
{
  public class RuleResult
  {
    #region Fields

    private readonly string _replacement;

    #endregion

    #region Properties

    public bool IsMatched { get; }

    public string Replacement
    {
      get => IsMatched ? _replacement : string.Empty;
      private init => _replacement = value;
    }

    #endregion

    #region Constructor

    public RuleResult(bool isMatched, string replacement = "")
    {
      Replacement = replacement;
      IsMatched = isMatched;
    }

    #endregion
  }
}
