using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_CodeChallege2_StudentReportCard
{
    class Screen
    {
        public void showScreen()
        {
            //get no of students and set all array of same size, as of 1 student all the fields would be same
            int noStudents;
            Console.WriteLine("\nPlease Enter No of Students");
            noStudents = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[noStudents];
            int[] englishMarks = new int[noStudents];
            int[] mathMarks = new int[noStudents];
            int[] computerMarks = new int[noStudents];
            int[] totalMarks = new int[noStudents];

            //to store toal ma
            for (int i=0;i<noStudents;i++)
            {
              
                Console.Write("\nEnter Student Name:"); //write will allow to write in same line as name: ....
                names[i]=Console.ReadLine();
               
                Console.Write("Enter English Marks (Out of 100):");
                englishMarks[i] = int.Parse(Console.ReadLine()); 
                Console.Write("Enter Math Marks (Out of 100) :");
                mathMarks[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Computer Marks(Out of 100) :");
                computerMarks[i] = int.Parse(Console.ReadLine());

                totalMarks[i] = englishMarks[i] + mathMarks[i] + computerMarks[i];
            }
            //now before displaying record , send the student and total marks array to sort and print the order
            new SortStudents().SortStudentByTotalMarks(names, totalMarks);

            Console.WriteLine("**************REPORT CARD***************");

            for (int i = 0; i < noStudents; i++)
                Console.WriteLine(" Student Name: {0} , Position :{1}, Total: {2}/300 ", names[i], i + 1,totalMarks[i]);

        }
    }
}
