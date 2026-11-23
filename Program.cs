using HelloWorld;

string name = "Guest!";
Console.WriteLine(Greeter.Greet(name));
Console.WriteLine("Version: " + typeof(Program).Assembly.GetName().Version);