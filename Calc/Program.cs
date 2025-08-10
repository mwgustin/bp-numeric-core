// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

int[][]? partitions = null;
if (args.Length < 1)
{
  Console.WriteLine("Enter Number: ");
  var x = Console.ReadLine();
  if (x.Contains(' '))
  {
    partitions = GetPartitions(x.Split(' '));
  }
  else
  {
    var parse = new Parse();
    partitions = parse.Partitions(x);
  }
}
else
{
  partitions = GetPartitions(args);
}


var calc = new NumericCoreCalc();

Console.WriteLine($"Result:  {calc.Calculate(partitions)}");


int[][] GetPartitions(string[] s)
{
  if (s.Length == 1)
  {
    var parse = new Parse();
    return parse.Partitions(s[0]);
  }

  if (s.Length == 4)
  {
    return new int[][] { s.Select(int.Parse).ToArray() };
  }
  
  throw new ArgumentException("Input must be a single string or an array of 4 strings.");
}

