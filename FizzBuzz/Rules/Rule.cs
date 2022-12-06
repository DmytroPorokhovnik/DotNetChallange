using System;

namespace FizzBuzz.Rules
{
  /// <inheritdoc />
  internal class ValidationRule<T> : IRule<T>
  {
    #region Fields

    private readonly Func<T, RuleResult> _rule;

    #endregion

    #region Constructor

    public ValidationRule(Func<T, RuleResult> rule)
    {
      _rule = rule ?? throw new ArgumentNullException(nameof(rule));
    }

    #endregion

    #region Public Methods

    /// <inheritdoc />
    public RuleResult Apply(T obj)
    {
      return _rule(obj);
    }
    #endregion
  }
}