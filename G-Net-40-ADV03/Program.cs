using System.Collections.Generic;
using G_Net_40_ADV03.Collection_Helper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_Net_40_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            // Exercise 1: Student Grade Manager
            // Create a program that manages student grades using One Of Collections

            // 1) Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            // 2) Print the collection, Count, first and last grade
            // 3) Sort the grades ascending, then print
            // 4) Get the first grade above 90
            // 5) Get all grades below 75(failing grades)
            // 6) Remove all failing grades(below 75)
            // 7) Check if any grade equals 100
            // 8) Create a List<string> where each grade becomes "Grade: X"


            //---------------------------------------------------------------------------------------------------------


            // 1) Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            // List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //----------------------------------------------------------------------------------------------------


            // 2) Print the collection, Count, first and last grade
            //Console.WriteLine($"Collection Count = { grades.Count}");
            //Console.WriteLine($"First Grade = {grades[0]}");
            //Console.WriteLine($"Last Grade = {grades[^1]}");

            //----------------------------------------------------------------------------------------------------

            // 3) Sort the grades ascending, then print
            //grades.Sort();
            //CollectionHelper.PrintCollection("Sorted Grades", grades);

            //----------------------------------------------------------------------------------------------------


            // 4) Get the first grade above 90
            //int firstGradeAbove90 = grades.FirstOrDefault(g => g > 90);
            //Console.WriteLine(firstGradeAbove90);

            //----------------------------------------------------------------------------------------------------

            // 5) Get all grades below 75(failing grades)
            //List<int> gradesBelow75 = grades.FindAll(g => g < 75);
            //CollectionHelper.PrintCollection("Grades Below(75) ", gradesBelow75);

            //----------------------------------------------------------------------------------------------------

            // 6) Remove all failing grades(below 75)
            //List<int> failinggradesBelow75 = grades.FindAll(g => g < 75);
            //grades.RemoveAll(g => g < 75);
            //CollectionHelper.PrintCollection("Grades After Removing Failing Grades", grades);

            //----------------------------------------------------------------------------------------------------

            // 7) Check if any grade equals 100
            //bool Check = grades.Exists(g => g == 100);
            //Console.WriteLine(Check);

            //----------------------------------------------------------------------------------------------------

            // 8) Create a List<string> where each grade becomes "Grade: X"
            //List<string> gradeStrings = grades.ConvertAll(x => $"Grade: {x}");
            //CollectionHelper.PrintCollection("Grade Strings", gradeStrings);

            #endregion


        }
    }
}
