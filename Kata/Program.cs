using Internal;

namespace Kata;
class Program
{
    static void Main(string[] args)
    {
        string sequence = Console.ReadLine();
        int x = sequence.Length;
        string lengthL = Console.ReadLine();
        int.TryParse(lengthL, out int l);
        string numberN = Console.ReadLine();
        int.TryParse(numberN, out int n);
        int counter = 0;
        int a = 0;
        int b = a + 2;
        //int c = 0;
        //int d = c + 2;
        int counterNum = 0;

        string sub = sequence.Substring(a, b);
        string slice = sequence[1..];

        if ((x >= 5) && (x <= 70) && (l >= 2) && (l <= 8) && (n >= 1) && (n <= 8) &&
            (sub == slice.Substring(0, 1)) && (b <= x - 1) && (counterNum <= n))
        {

            while (counter <= l)
            {
                a++;
                b++;
                // c++;
                // d++;
                counter += 1;
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(sub);
                Console.WriteLine(slice);
            }
            counterNum += 1;
        }
        Console.WriteLine(counter);
        Console.WriteLine(counterNum);
        Console.WriteLine((counter == l) && (counterNum == n));
    }
}
/*if ((x >= 5) && (x <= 70) && (l >= 2) && (l <= 8) && (n >= 1) && (n <= 8))// length, rules
{ 
        while (counter < x - 1)
        {
        a++;
        b++;
        c++;
        d++;
        counter += 1;
    }

    counterNum += 1;
}

Console.WriteLine((counter == l) && (counterNum == n) && (sub == slice.Substring(0, 2)));*/

//bool check = ((x >= 5) && (x <= 70) && (l >= 2) && (l <= 8) && (n >= 1) && (n <= 8)) ? checkTrue : checkFalse;
//Console.WriteLine(check);

//string sub1 = sequence.Substring(1, 3);
// if (sub == sub1)
//{

//    results[i] = ;
// }
//string sub = sequence.Length[l..];

/*var k = sequence[0];
  var u = sequence[i];
  if (k == u)
  {
      // for comparison
      for (int m = 0; m <= l; m++) //comparison, l
      {
          var p = sequence[m + 1];
          if (k == p)
          {
              for (int j = 0; j <= n; j++)// for calculating n;
              {

                  //Console.WriteLine(results);
                  if (results.Length == n)
                  {
                      results[j] = "check";
                      Console.WriteLine(checkTrue);
                  }
              }
}
          }
//Console.WriteLine(sequence.Remove(0));
//k++;
}}

    string sequence = Console.ReadLine();
    int x = sequence.Length;
    string lengthL = Console.ReadLine();
    int.TryParse(lengthL, out int l);
    string numberN = Console.ReadLine();
    int.TryParse(numberN, out int n);
    //bool checkTrue = true;
   // bool checkFalse = false;

    // string[] results = new string[l];

    int counter = 1;
    int a = 0;
    int b = a + 2;
    int counterNum = 0;

    string sub = sequence.Substring(a, b);
    string slice = sequence[1..];

    if ((x >= 5) && (x <= 70) && (l >= 2) && (l <= 8) && (n >= 1) && (n <= 8))
    {
        for (int i = 0; i <= x - 1; i++) // string, all length
        {
            if (sub == slice.Substring(0, 2) && (b <= x) && (counter <= l - 1) && (counterNum <= n))
            {

               while (counter != l - 1)
                {
                    a++;
                    b++;
                    counter += 1;

                    //Console.WriteLine(a);
                    //Console.WriteLine(b);
                    //Console.WriteLine(counter);
                }
                counterNum += 1;

                //Console.WriteLine(counterNum);

                //Console.WriteLine(checkTrue);
                //Console.WriteLine(counter);
            }

        }
        //Console.WriteLine(slice);
        // Console.WriteLine(sub);
        //Console.WriteLine(counter);
        //Console.WriteLine(checkFalse);
    }
    //Console.WriteLine(checkFalse);

    Console.WriteLine((counter == l) && (counterNum == n));
}
*/

//Console.WriteLine(sequence.Remove(0));
//Console.WriteLine(checkFalse);namespace Kata;
/*class Program
{
    static void Main(string[] args)
    {
        string sequence = Console.ReadLine();
        int x = sequence.Length;
        string lengthL = Console.ReadLine();
        int.TryParse(lengthL, out int l);
        string numberN = Console.ReadLine();
        int.TryParse(numberN, out int n);
        bool checkTrue = true;
        bool checkFalse = false;
  
        string[] results = new string[l];

        if ((x >= 5) && (x <= 70) && (l >= 2) && (l <= 8) && (n >= 1) && (n <= 8))
        {
            for (int i = 0; i <= x - 1; i++)// string, all length
            {
                var k = sequence[0];
                var u = sequence[i];
                if (k == u)
                {
                    // for comparison
                    for (int m = 0; m <= l; m++) //comparison, l
                    {
                        var p = sequence[m + 1];
                        if (k == p)
                        {
                            for (int j = 0; j <= n; j++)// for calculating n;
                            {

                                //Console.WriteLine(results);
                                if (results.Length == n)
                                {
                                    results[j] = "check";
                                    Console.WriteLine(checkTrue);
                                }
                            }
                        }
                    }
                }
                //Console.WriteLine(sequence.Remove(0));
                //k++;
            }
            //Console.WriteLine(sequence.Remove(0));
        //Console.WriteLine(checkFalse);
        }
        Console.WriteLine(checkFalse);
    }
}
   
        //bool check = ((x >= 5) && (x <= 70) && (l >= 2) && (l <= 8) && (n >= 1) && (n <= 8)) ? checkTrue : checkFalse;
        //Console.WriteLine(check);
*/


