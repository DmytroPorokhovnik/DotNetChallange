using System;
using System.Collections.Generic;
using FizzBuzz.Rules;

namespace FizzBuzz.Engines;

internal class FizzBuzzEngine : IEngine<IEnumerable<string>>
{
  #region Fields

  private readonly IEnumerable<IRule<int>> _rules;

  #endregion

  #region Constructor

  public FizzBuzzEngine(IEnumerable<IRule<int>> rules)
  {
    _rules = rules ?? throw new ArgumentNullException(nameof(rules));
  }

  #endregion

  #region Public Methods

  /// <summary>
  /// Runs fizzbuzz
  /// </summary>
  /// <param name="limit">limit of fizzbuzz numbers</param>
  /// <returns>fizzbuzz output</returns>
  public IEnumerable<string> Run(int limit)
  {
    var result = new List<string>();

    for (int i = 1; i <= limit; i++)
    {
      result.Add(ApplyRules(i));
    }

    return result;
  }

  #endregion

  #region Private Methods

  private string ApplyRules(int number)
  {
    foreach (var rule in _rules)
    {
      var ruleResult = rule.Apply(number);

      if (ruleResult.IsMatched)
      {
        return ruleResult.Replacement;
      }
    }

    return number.ToString();
  }

  #endregion
}