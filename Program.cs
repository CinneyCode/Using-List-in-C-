using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_March_26
{
    class Program
    {
        //DECLARE A LIST OF INTEGERS 
        static List<int> myGrades;

        static void Main(string[] args)
        {
            myGrades = new List<int>(); ;     //instantiate - will create a space in the infrasturate for the data , () constructor 

            int curGrade = 0;
            while (curGrade!= -1) //so that you can exit the loop , if the user input -1 , it will get out of the loop 
            {
                Console.Write("Enter a grade (-1 to end) :");
                curGrade = Convert.ToInt32(Console.ReadLine());
                //
                myGrades.Add(curGrade);
            }
            myGrades.RemoveAt(myGrades.Count - 1);
            Console.WriteLine($"You entered {myGrades.Count}");

            List<int> myBetterList = DropLowest();

            Console.WriteLine("Grades after dropping lowest are: ");
            foreach (int i in DropLowest())
            {
                Console.WriteLine($"{i}");
            }

            Console.ReadKey();
        }
        static private double AverageGrades()
        {
            double sum = 0;
            //forreach (int g in my grades )
            //{
            // sum += g 
            //}
            for (int i=0; i< myGrades.Count; i++)// g is an interger that's in this list. for each item in this list (g) 
            {
                sum = sum + myGrades[i];
            }
            double avg = sum / myGrades.Count;
            //return avg;
            avg = myGrades.Average();
            return avg;
        }
        static private List<int> DropLowest() //RETURN TYPE IS THE LIST 
        {
            int min = myGrades.Min();
            int indexOf = myGrades.IndexOf(min);
            myGrades.RemoveAt(indexOf);
            return myGrades;
        }
    }
}
