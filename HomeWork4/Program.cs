using System.Collections;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace HomeWork4
{
    public  class Program
    {     
      public  class Student
        {
          public string name;
          

      } 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total student count:");
            int StudentCount = int.Parse(Console.ReadLine());
           
            Student[] Student = new Student[StudentCount];

            for (int i = 0; i < StudentCount; i++)
            {
                Student[i] = new Student();
                Console.WriteLine("Enter Student name:");
                Student[i].name = Console.ReadLine();
                Console.WriteLine("Enter Sudent grade:");
                int Studentgrade = int.Parse(Console.ReadLine());

                if ( Studentgrade >= 0)
                {
                    Console.WriteLine(StatisticsHelper.GetAverageGrade);
                }
                if (Studentgrade >=30 )
                {
                    Console.WriteLine(StatisticsHelper.GetHighestGrade);
                }
                if (Studentgrade >= 50)
                {
                    Console.WriteLine(StatisticsHelper.GetLowestGrade);
                }
            }
            
        }
  
    }
}