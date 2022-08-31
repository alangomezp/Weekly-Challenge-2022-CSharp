// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using RetoNo_35;

Random numberGenerator = new();
string[] types = { Types.Water, Types.Fire, Types.Grass, Types.Electric };
string attacker;
string defender;
int atkRate = numberGenerator.Next(1, 100);
int dfsRate = numberGenerator.Next(1, 100);
int loopTimes = 0;

Console.WriteLine("Pokemon Types:");

Console.WriteLine("---------------------------");

foreach (var t in types)
{
    Console.WriteLine(t);
}

Console.WriteLine("---------------------------");

do
{
    Console.WriteLine("");

    if (loopTimes > 0)
        Console.WriteLine("The attacker or defender type must match with above ones");
    
    Console.Write("Choose an attacker:");
    attacker = Console.ReadLine()?.ToLower() ?? string.Empty;

    Console.Write("Choose an defender:");
    defender = Console.ReadLine()?.ToLower() ?? string.Empty;

    loopTimes++;

} while (!types.Contains(attacker) || !types.Contains(defender) );

DamageCalculator calculatorPkm = new (attacker, defender, atkRate, dfsRate);
var result = Math.Round(calculatorPkm.CalcDamage(), 2);

Console.WriteLine(result);
Console.ReadLine();