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



