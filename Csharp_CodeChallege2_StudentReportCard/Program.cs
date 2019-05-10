using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_CodeChallege2_StudentReportCard
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Requirements
            Each student has three subjects(English, Math and Computer).
            Ram
            Engligh Math Computer

            Application will save each student’s marks along with student’s name.
            Application will calculate total marks.
            Application will show position and report card in descending order.

            UI:
            1. Enter total no of Students
            2. Enter Students Name :
            3. Enter english marks
            4. Enter Math Marks
            5. Enter Computer Marks

            Report :

            *Report Card*******************
            ****************************************
            Student Name: Ali Asad, Position: 1, Total: 160/300
            ****************************************
            Student Name: Lakhtey, Position: 2, Total: 140/300
            */

            Screen s = new Screen();
            s.showScreen();
            Console.ReadLine();
        }
    }
}
