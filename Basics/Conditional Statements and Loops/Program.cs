int Num1 = 10;
int Num2 = 5;

if (Num1 >= Num2)
{
    Console.WriteLine(Num1 + " is greater than " + Num2);
    Num1++;
}

if (Num1 <= Num2)
{
    Console.WriteLine(Num1 + " is greater than " + Num2);
    Num1++;
} else
{
    Console.WriteLine(Num2 + " is lesser than " + Num1);
    Num2++;
}

string Str = "home";
string Str_Capitalized = "Home";

if (Str == Str_Capitalized)
{
    Console.WriteLine("They are equal");
}
else if (Str == Str_Capitalized.ToLower())
{
    Console.WriteLine("They are now equal");
}

int[] IntList = new int[] { 5, 2, 10, 23, 65, 1, 15 };
int TotalNum = 0;

for (int i = 0; i < IntList.Length; i++)
{
    TotalNum += IntList[i];
    Console.WriteLine(TotalNum);
}

TotalNum = 0;

DateTime startTime = DateTime.Now;

foreach (int IntCompressedList in IntList)
{
    TotalNum += IntCompressedList;
    Console.WriteLine(TotalNum);
}

Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

int index = 0;
TotalNum = 0;

while (index < IntList.Length)
{
    Console.WriteLine(index);
    Console.WriteLine(index < IntList.Length);
    //TotalNum += IntList[index];
    //Console.WriteLine(TotalNum);
    index++;
}

TotalNum = 0;
index = 0;

do
{

    Console.WriteLine(index);
    Console.WriteLine(index < IntList.Length);
    //TotalNum += IntList[index];
    //Console.WriteLine(TotalNum);
    index++;
    
} 
while (index < IntList.Length);
