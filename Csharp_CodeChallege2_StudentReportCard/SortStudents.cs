using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_CodeChallege2_StudentReportCard
{
    class SortStudents
    {
        public void SortStudentByTotalMarks(string[] studentNames, int[] totalMarks)
        {
            //Sorting method for students according  to the 
            int n = totalMarks.Length;

            int totalMarksTemp = 0;
            string studentNamesTemp = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (totalMarks[i] < totalMarks[j])
                    {
                        totalMarksTemp = totalMarks[i];
                        totalMarks[i] = totalMarks[j];
                        totalMarks[j] = totalMarksTemp;

                        studentNamesTemp = studentNames[i];
                        studentNames[i] = studentNames[j];
                        studentNames[j] = studentNamesTemp;
                    }

                }

            }
        }
    }
}