using System;

/*
 
    *
   ***
  *****
 *******
*********

ACCEPTANCE CRITERIA:
Write a script to output this pyramid on console (with leading spaces)

*/
namespace Pyramid;

public class Program
{
  private const char _space = ' ';
  private const char _asterisk = '*';

  private static void Pyramid(int height)
  {
    for (var lineCounter = 0; lineCounter <= height; lineCounter++)
    {
      for (var spaceCounter = 0; spaceCounter < height - lineCounter; spaceCounter++)
      {
        Console.Write(_space);
      }

      for (var asteriskCounter = 1; asteriskCounter <= 2 * lineCounter - 1; asteriskCounter++)
      {
        Console.Write(_asterisk);
      }

      Console.Write(Environment.NewLine);
    }
  }

  public static void Main(string[] args)
  {
    Pyramid(5);
  }
}