// See https://aka.ms/new-console-template for more information
using LeetcodeTest._Not_Complete_Problems;
using LeetcodeTest._Not_Complete_Problems.Easy;
using LeetcodeTest._Not_Complete_Problems.Medium;

//
Console.WriteLine("Hello, World!");

//
var sol = new Problem_3606.Solution();

string[] code = ["MI", "b_"];
string[] businessLine = ["pharmacy", "pharmacy"];
bool[] isActive = [true, true];

Console.WriteLine(sol.ValidateCoupons(code, businessLine, isActive));
//Console.WriteLine(1 ^ 3);

//
Console.ReadLine();
