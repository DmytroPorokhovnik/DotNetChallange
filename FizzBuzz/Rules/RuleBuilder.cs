using System;
using System.Collections.Generic;

namespace FizzBuzz.Rules
{
  internal class RuleBuilder<T>
  {
    #region Fields

    private readonly List<IRule<T>> _rules;

    #endregion

    #region Constructor

    public RuleBuilder()
    {
      _rules = new List<IRule<T>>();
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Adds a rule to a builder
    /// </summary>
    /// <param name="lambda">lambda that represents a rule</param>
    /// <returns>Updated rule builder</returns>
    public RuleBuilder<T> AddRule(Func<T, RuleResult> lambda)
    {
      _rules.Add(new ValidationRule<T>(lambda));

      return this;
    }

    /// <summary>
    /// Builds all rules all together
    /// </summary>
    /// <returns>all built rules</returns>
    public IEnumerable<IRule<T>> Build()
    {
      return _rules;
    }

    #endregion
  }
}
