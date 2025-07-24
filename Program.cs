using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstlab
{
    class Program
    {
        static void swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            /*int n1 = int.Parse(Console.ReadLine());
            int  a=n1;
            int n2 = ++n1;
            Console.WriteLine("Pre Incrementing: ");
            Console.WriteLine("n1 = {0}  , n2 = {1} ",n1,n2);
            n1=a;
            n2 = n1++;
            Console.WriteLine("post Incrementing: ");
            Console.WriteLine("n1 = {0}  , n2 = {1} ", n1, n2);
            swap(ref n1, ref n2);
            Console.WriteLine("Swapping: ");
            Console.WriteLine("n1 = {0}  , n2 = {1} ", n1, n2);
            Console.ReadKey();*/

            /*string pass, user;
            for(int i=0;i<4;i++){
                if(i==3){
                    Console.WriteLine("You have reached Maximum Attempts Today\nTry after 24hours");
                    break;
                }
                if(i!=0)
                    Console.WriteLine("Try Again");
                Console.Write("Enter User Name: ");
                user = Console.ReadLine();
                Console.Write("Enter Password: ");
                pass = Console.ReadLine();
                if(user=="rvr" && pass=="rvr")
                {
                    Console.WriteLine("Login Successfull");
                    break;
                }
                else
                    Console.WriteLine("Incorrect username or password");
            }
            Console.ReadKey();*/


            /*Console.Write("Enter number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter digit: ");
            int n2 = int.Parse(Console.ReadLine());
            int i = 1;
            int a = n1;
            while (a > 0)
            {
                int r = a % 10;
                if (r == n2)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("One's Place");
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Ten's Place");
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("Hundred's Place");
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("Thousand's Place");
                    }
                }
                i += 1;
                a = a / 10;
            }
            if (n1.ToString().Contains(n2.ToString()))
            {
                if (n1.ToString().Length - n1.ToString().IndexOf(n2.ToString()) > 4)
                    Console.WriteLine("more than Thousand's place");
            }
            else
                Console.WriteLine("Not Found in num1");
            Console.ReadKey();*/

            /*Console.WriteLine("Enter 10 integers separated by spaces:");
            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(int.Parse).ToArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("The descending order is: ");
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine("Min Value : {0}\nMax Value : {1}", arr[arr.Length - 1], arr[0]);
            Console.WriteLine("Sum of Elements in an Array: {0}", arr.Sum());
            Console.ReadKey();*/

            /*Console.WriteLine("Enter range: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Generated random Integer: {0}", RandomHelper.randint(a, b));
            Console.WriteLine("Generated random Double: {0}", RandomHelper.randdouble(a, b));
            Console.ReadKey();*/

            Stock st = new Stock("pradeep", "lion", 5000, 6000);
            double ch = st.getChangePercentage();
            if (ch>0)
                Console.WriteLine("Incremented by Percentage: {0:F2}%", ch);
            else if(ch<0)
                Console.WriteLine("Decremented by Percentage: {0:F2}%", ch*-1);
            else
                Console.WriteLine("No Percentage Change");
            Console.ReadKey();
        }
    }
}
