using System;
using System.Collections.Generic;
using FizzBuzz.Engines;
using FizzBuzz.Resources;
using FizzBuzz.Rules;

/**
*
* Given is the following FizzBuzz application which counts from 1 to 100 and outputs either the corresponding
* number or the corresponding text if one of the following rules apply.
* Rules:
*  - dividable by 3 without a remainder -> Fizz
*  - dividable by 5 without a remainder -> Buzz
*  - dividable by 3 and 5 without a remainder -> FizzBuzz
*
* ACCEPTANCE CRITERIA:
* Please refactor this code so that it can be easily extended in the future with other rules, such as
* "if it is dividable by 7 without a remainder output Bar"
* "if multiplied by 10 is larger than 100 output Foo"
*
*/
namespace FizzBuzz;

public class Program
{
  private const int _engineLimit = 100;
  private const int _multiplyLargerParam = 500;

  public static void Main(string[] args)
  {
    FizzBuzzEngine engine = new FizzBuzzEngine(GetRules()); //DI can be used here in real project
    var result = engine.Run(_engineLimit);
    foreach (var output in result)
    {
      Console.WriteLine(output);
    }
  }

  private static IEnumerable<IRule<int>> GetRules()
  {
    var rulesBuilder = new RuleBuilder<int>();
    rulesBuilder
      .AddRule(i => i * 10 > _multiplyLargerParam ? new RuleResult(true, EngineResources.FooMatchOutput) : new RuleResult(false))
      .AddRule(i => i % 3 == 0 && i % 5 == 0 ? new RuleResult(true, EngineResources.FizzBuzzMatchOutput) : new RuleResult(false))
      .AddRule(i => i % 3 == 0 ? new RuleResult(true, EngineResources.FizzMatchOutput) : new RuleResult(false))
      .AddRule(i => i % 5 == 0 ? new RuleResult(true, EngineResources.BuzzMatchOutput) : new RuleResult(false))
      .AddRule(i => i % 7 == 0 ? new RuleResult(true, EngineResources.BarMatchOutput) : new RuleResult(false));
    return rulesBuilder.Build();
  }
}