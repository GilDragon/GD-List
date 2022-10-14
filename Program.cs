// See https://aka.ms/new-console-template for more information
void Arrays()
{
Console.WriteLine("Hello, Lua!");
System.Console.WriteLine("------Using Arrays EX1----- ");
String?[] NameArray = new string[5];
var Fivenames = 5;


for (var i = 0; i < Fivenames; i++)
    {

        System.Console.WriteLine("Please enter a name: ");
        NameArray[i]= Console.ReadLine();
        Console.WriteLine("Hello " + NameArray [i]);
    }

System.Console.WriteLine("------Using Arrays EX2----- ");
int [] tennumbs = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
var tennumberttal = 0;
foreach (var ttl in tennumbs)
    {
        tennumberttal += ttl;
    }
System.Console.WriteLine("Your total number is " + tennumberttal);
}
Arrays();

//int[] Tennumbers = new int[10];
//var Tennumberss = 10;
//var Tennumbertotal = 0;



//for (var t = 0; t < Tennumberss; t++)
    //{

        //System.Console.WriteLine("Please enter a number: ");
        //Tennumbers[t]= Convert.ToInt32(Console.ReadLine());
        // Do I have to change var to int? 그냥 했을때 오류 지림
    //}
//foreach (var num in Tennumbers) 
    //{
      //  Tennumbertotal += num;
    //}
      //  System.Console.WriteLine("Your total number is " + Tennumbertotal);

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


// Calling the Ex1() function so that it runs


System.Console.WriteLine("=================Using List Ex2 =========================");
         var result = anynum.GroupBy(x => x)
                         .Where(g => g.Count() > 1)
                         .Select(x => new {Count = x.Count() })
                         .ToList();
 Console.WriteLine(String.Join(", ", result));


// int dupli = 0;
// for(int i = 0; i < anynum.Count; i++) 
//     {
//         if(anynum.Contains(numb) == anynum[i])
//         dupli++;

//     }




System.Console.WriteLine("=================Using List Ex3 =========================");

List<string> anywords = new List<string>();
var STOP = "stop";

// == neverstop is better stored as a boolean
var neverstop = true;
var inputs = "";

while (neverstop) 
{
    System.Console.WriteLine("Please enter any word:  or EXIT for stop");

    inputs = Console.ReadLine();

    // anywords.Add(Console.ReadLine());
        

        // 1. Store the Console.Read in a variable - then check it for STOP

        // 2.  Add the Console.Read into the list - then check the last position in the list for STOP

    if (inputs == STOP)
    {
        break;
    } else {
        anywords.Add(inputs);
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


// var loop = true;

// while (loop) {
//     Console.WriteLine("Do you want to loop again?  (N to stop)");

//     var input = Console.ReadLine();

//     if (input.ToUpper() == "N") {
//         loop = false;
//     }  
// }