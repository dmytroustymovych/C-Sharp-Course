Console.WriteLine("Hello, World!");
string[] StrArr = { "Hi", "Hello" };
string[] StrArr1 = ["Hi", "Hello"];
Console.WriteLine(StrArr + " World!");
Console.WriteLine(StrArr[0] + " World!");
Console.WriteLine(StrArr[1] + " World!");

string[] MyNewSrt = new string[2];
MyNewSrt[0] = "First";
MyNewSrt[1] = "Second";
//MyNewSrt[2] = "Third"; dosen't work - array has only 2 spaces

List<string> MyStrList = new List<string>();
MyStrList.Add("House");
MyStrList.Add("Home");
MyStrList.Add("Backyard");

foreach (string strs in MyStrList)
{
    Console.WriteLine(strs);
}

List<string> MyStrList1 = ["House", "Home"];
MyStrList1.Add("Backyard");

foreach (string strs in MyStrList1)
{
    Console.WriteLine(strs);
}

IEnumerable<string> MyStrEnum = MyStrList;
IEnumerable<string> MyStrEnum1 = MyNewSrt;

List<string> MyStrList2 = MyStrEnum.ToList();

int[,] MultiIntArr =
{
    { 0, 1, 2 },
    { 3, 4, 5 },
    { 7, 8, 9 },
};

Console.WriteLine(MultiIntArr[0, 2] + MultiIntArr[2, 1]);

Dictionary<string, int> Prices = new Dictionary<string, int>();

Prices["House"] = 1000;
Prices["Road"] = 2000;

Console.WriteLine(Prices["House"]);

string MyStr = "Hi";

MyStr += ", dude";

Console.WriteLine(MyStr);

MyStr += ", how are you";

Console.WriteLine(MyStr);

string[] MyStrArr = MyStr.Split(", ");

Console.WriteLine(MyStrArr[0]);
Console.WriteLine(MyStrArr[1]);
Console.WriteLine(MyStrArr[2]);

int MyInt1 = 5;
int MyInt2 = 10;

Console.WriteLine(MyInt1 == MyInt2);
Console.WriteLine(MyInt1 == MyInt2 / 2);
Console.WriteLine(MyInt1.Equals(MyInt2 / 2));

