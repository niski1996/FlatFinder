using System.Reflection;

string name = "Kevin";
var stringType = name.GetType();
Console.WriteLine(stringType);
var currentAssembly = Assembly.GetExecutingAssembly();
var tfr = currentAssembly.GetTypes();
foreach (var item in tfr)
{
    Console.WriteLine(item.Name);
}
var TMP = currentAssembly.GetType("ReflectionSample.Person");
Console.WriteLine(TMP.Name);

var external = Assembly.Load("System.Text.Json");
var typ = external.GetTypes();
foreach (var item in typ)
{
    Console.WriteLine(item.Name );
}
