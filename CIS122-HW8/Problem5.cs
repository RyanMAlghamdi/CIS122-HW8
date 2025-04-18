//Ryan Alghamdi
//April 16

//HW8 problem 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_HW8
{
    public class Solution5
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int i = 0;

            while (i < students.Length)
            {
                if (students[0] == sandwiches[0])
                {
                    students = students.Skip(1).ToArray();
                    sandwiches = sandwiches.Skip(1).ToArray();
                    i = 0;
                }
                else
                {
                    students = students.Skip(1).Append(students[0]).ToArray();
                    i++;
                }
            }

            return students.Length;
        }
    }
}
