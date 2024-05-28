using System;

namespace ConsoleApp1
{
    internal class programm
    {
        public static void Main(string[] args)
        {
            string name, rollno;
            int s1, s2, s3, s4, s5;
            double total;
            double per;
            Console.WriteLine("                     SEM RESULTS                       ");
            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("ROLL NO:");
            rollno = Console.ReadLine();
            Console.WriteLine("                                                    ");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("             3-1 SEM RESULTS                            ");
            Console.WriteLine(" ADIC  :");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" LCS  :");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" MPMC  :");
            s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" AWP  :");
            s4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" LS  :");
            s5 = Convert.ToInt32(Console.ReadLine());
            total = (s1 + s2 + s3 + s4 + s5);
            Console.WriteLine("total marks:" + total);
            per = (((total) / 500) * 100);
            Console.WriteLine("per:" + per+"%");

        }
    }
}
