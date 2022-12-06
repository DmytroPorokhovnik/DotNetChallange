namespace FizzBuzz.Rules;

/// <summary>
/// Represents a rule
/// </summary>
/// <typeparam name="T">The type of the object the rule applies to.</typeparam>
public interface IRule<T>
{
  /// <summary>
  /// Applies the rule to the specified object.
  /// </summary>
  /// <returns></returns>
  RuleResult Apply(T obj);
}