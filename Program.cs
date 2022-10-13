// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Lua!");
String?[] NameArray = new string[5];
var Fivenames = 5;
System.Console.WriteLine("------Using Arrays EX1----- ");

for (var i = 0; i < Fivenames; i++)
    {

        System.Console.WriteLine("Please enter a name: ");
        NameArray[i]= Console.ReadLine();
        Console.WriteLine("Hello " + NameArray [i]);
    }

int[] Tennumbers = new int[10];
var Tennumberss = 10;
var Tennumbertotal = 0;

System.Console.WriteLine("------Using Arrays EX2----- ");

for (var t = 0; t < Tennumberss; t++)
    {

        System.Console.WriteLine("Please enter a number: ");
        Tennumbers[t]= Convert.ToInt32(Console.ReadLine());
        // Do I have to change var to int? 그냥 했을때 오류 지림
    }
foreach (var num in Tennumbers) 
    {
        Tennumbertotal += num;
    }
        System.Console.WriteLine("Your total number is " + Tennumbertotal);

System.Console.WriteLine("=================Using List Ex1 =========================");
List<int> anynum = new List<int>();
while (anynum.Count < 5)
    {

        System.Console.WriteLine("Please enter your number: ");
        int numb = Convert.ToInt32(Console.ReadLine());
        if (anynum.Contains(numb))
        {
            System.Console.WriteLine("You have entered the same number. Enter a different number");
        }
        anynum.Add(numb);
    }
anynum.Sort();
foreach (int i in anynum)
    {
        Console.WriteLine(i);
    }


System.Console.WriteLine("=================Using List Ex2 =========================");
        var result = anynum.GroupBy(x => x)
                        .Where(g => g.Count() > 1)
                        .Select(x => new {Count = x.Count() })
                        .ToList();
Console.WriteLine(String.Join(", ", result));




System.Console.WriteLine("=================Using List Ex3 =========================");

List<string?> anywords = new List<string?>();
var STOP = "stop";
var neverstop = 1;
while (neverstop != 2) 
    {
        System.Console.WriteLine("Please enter any word:  or EXIT for stop");

        anywords.Add(Console.ReadLine());

        if (Console.ReadLine() == STOP)
        {
            neverstop++;
        }
    }
// 그냥 정렬
//anywords.Sort();
//Console.WriteLine(string.Join(",", anywords));
//anywords.ForEach(w => Console.WriteLine(w));
anywords.Reverse();
//Console.WriteLine(string.Join(",", anywords));
//anywords.ForEach(w => Console.WriteLine(w));

foreach (var words in anywords)
    {
        System.Console.WriteLine(words);
    }

System.Console.WriteLine("That is it.");
