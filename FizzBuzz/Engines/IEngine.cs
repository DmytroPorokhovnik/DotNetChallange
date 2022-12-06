namespace FizzBuzz.Engines;

/// <summary>
/// Represents a general engine
/// </summary>
public interface IEngine<TResult>
{
  /// <summary>
  /// Runs an engine
  /// </summary>
  TResult Run(int limit);
}