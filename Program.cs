using Methods;
using MethodApp;

String UserName = ConsoleMessages.GetUserName();

Console.WriteLine($"Your name is {UserName}");

Console.WriteLine("x = ?");
double x = Double.Parse( Console.ReadLine() );

Console.WriteLine("y = ?");
double y = Double.Parse( Console.ReadLine() );

double result = MathShorcuts.Add( x, y );
Console.WriteLine($"Value of add is {result}"); 


double[] vals = new double[] { 2, 5, 6, 14, 78, 95 };
MathShorcuts.AddAll(vals);