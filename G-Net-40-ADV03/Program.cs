using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System.Xml.Linq;
using G_Net_40_ADV03.Collection_Helper;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
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

            #region Exercise 2

            // Exercise 2: Leaderboard
            // Create a leaderboard that automatically sorts players by score.

            // 1)Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            // 2)Print all entries(they should be sorted by score automatically)
            // 3)Access the first key and first value
            // 4)Check if score 500 exists
            // 5)Safely get the player with score 999
            // 6)Remove the player with score 200 and print the updated list

            //---------------------------------------------------------------------------------------------------------

            // 1)Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"

            //SortedList<int, string> leaderboard = new SortedList<int, string>
            //{
            //    [500] = "Ahmed" ,
            //    [200] = "Sara" ,
            //    [800] = "Ali" ,
            //    [350] = "Mona" 
            //};

            //---------------------------------------------------------------------------------------------------------

            // 2)Print all entries(they should be sorted by score automatically)
            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            //}

            //---------------------------------------------------------------------------------------------------------
            // 3)Access the first key and first value
            //Console.WriteLine(leaderboard.Keys[0]);
            //Console.WriteLine(leaderboard.Values[0]);
            //---------------------------------------------------------------------------------------------------------

            // 4)Check if score 500 exists

            //bool score500Exists = leaderboard.TryGetValue(500, out string playerName);
            //Console.WriteLine(score500Exists);
            //Console.WriteLine($"Player name if exist :{playerName}");

            //---------------------------------------------------------------------------------------------------------

            // 5)Safely get the player with score 999

            //bool score999Exists = leaderboard.TryGetValue(999, out string playerName999);
            //Console.WriteLine(score999Exists ? playerName999 : score999Exists);

            //---------------------------------------------------------------------------------------------------------

            // 6)Remove the player with score 200 and print the updated list

            //leaderboard.Remove(200);

            //CollectionHelper.PrintCollection("Updated Leaderboard", leaderboard.Select(p => $"(Score: {p.Key}, Player: {p.Value})"));

            //---------------------------------------------------------------------------------------------------------


            #endregion

            #region Exercise 3

            //   // Exercise 3: Phone Book
            //   // Build a phone book application.

            //   // 1) Create a Collection with 4 contacts(name → phone number)
            //   // 2) Add a new contact using [] syntax (add or update)
            //   // 3) Try adding a duplicate using .Add() — catch the exception and print the error
            //   // 4) Try adding a duplicate using .TryAdd() — print whether it succeeded
            //   // 5) Search for a contact that doesn’t exist
            //   // 6) Get a contact with a fallback of "Not Found"
            //   // 7) Print all Keys on one line, then all Values on another line

            //   //---------------------------------------------------------------------------------------------------------


            //   // 1) Create a Collection with 4 contacts(name → phone number)

            //   Dictionary<string, int> phoneBook = new()
            //   {
            //       ["Ahmed"] = 100345677,
            //       ["Sara"] = 101222444,
            //       ["Ali"] = 10567458,
            //       ["Mona"] = 103457890
            //   };

            //  // ---------------------------------------------------------------------------------------------------------

            //  //  2) Add a new contact using [] syntax (add or update)

            //   phoneBook["Omar"] = 109876543;

            //   CollectionHelper.PrintCollection("Phone Book", phoneBook);

            //  // ---------------------------------------------------------------------------------------------------------

            //   // 3) Try adding a duplicate using .Add() — catch the exception and print the error

            //   try
            //   {
            //       phoneBook.Add("Ahmed", 12288837);
            //   }
            //   catch (Exception ex)
            //   {
            //       Console.WriteLine($"adding a duplicate Key! {ex}");
            //   }

            // //  ---------------------------------------------------------------------------------------------------------

            ////    4) Try adding a duplicate using .TryAdd() — print whether it succeeded

            //   bool added = phoneBook.TryAdd("Ahmed", 122148998);
            //   Console.WriteLine(added ? "TryAdd succeeded: Ahmed → 0999 was added" : "TryAdd failed: Ahmed already exists");

            ////   ---------------------------------------------------------------------------------------------------------

            // //   5) Search for a contact that doesn’t exist

            //   bool tryGet = phoneBook.TryGetValue("Yara", out int phoneNumberYara);
            //   Console.WriteLine(tryGet ? $"Yara's phone number: {phoneNumberYara}" : "Yara not found in the phone book");

            // //  ---------------------------------------------------------------------------------------------------------

            ////    6) Get a contact with a fallback of "Not Found"

            //   string phoneNumber = phoneBook.TryGetValue("Ahmed", out int number) ? number.ToString() : "Not Found";
            //   Console.WriteLine(phoneNumber);

            //  // ---------------------------------------------------------------------------------------------------------

            // //   7) Print all Keys on one line, then all Values on another line

            //   CollectionHelper.PrintCollection("Contact Names ", phoneBook.Keys);
            //   CollectionHelper.PrintCollection("Contact Numbers ", phoneBook.Values);

            //  // ---------------------------------------------------------------------------------------------------------

            #endregion

            #region Exercise 4

            // Exercise 4: Unique Email Validator

            // Use Collection to manage unique email addresses.

            // 1) Create a HashSet<string> with a case -insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            // 2) Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            // 3) Print Count — how many are actually stored? Explain why.
            // 4) Create two sets: Set A = { 1, 2, 3, 4, 5 } and Set B = { 4,5,6,7,8}
            // 5) Print the result of: UnionWith, IntersectWith, ExceptWith
            // 6) Use IsSubsetOf to check if { 1,2} is a subset of Set A

            //---------------------------------------------------------------------------------------------------------

            // 1) Create a HashSet<string> with a case -insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)

            //HashSet<string> emailSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //----------------------------------------------------------------------------------------------------------

            // 2) Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"

            //emailSet.Add("ahmed@test.com");
            //emailSet.Add("AHMED@test.com");
            //emailSet.Add("sara@test.com");
            //emailSet.Add("Sara@Test.Com");

            //----------------------------------------------------------------------------------------------------------

            // 3) Print Count — how many are actually stored? Explain why.

            //Console.WriteLine($"Count of unique emails: {emailSet.Count}");

            //CollectionHelper.PrintCollection("Email Set", emailSet);

            // HashSet<T> stores unique elements only. Perfect for removing duplicates and fast membership testing with O(1) lookup.
            // Because the HashSet was created with: StringComparer.OrdinalIgnoreCase 
            // this makes the collection ignore letter casing when comparing strings.
            // So:
            // "ahmed@test.com" and "AHMED@test.com" are considered the same value
            // "sara@test.com" and "Sara@Test.Com" are also considered the same value
            // Since a HashSet only stores unique values, duplicates are automatically ignored.

            //-----------------------------------------------------------------------------------------------------------

            // 4) Create two sets: Set A = { 1, 2, 3, 4, 5 } and Set B = { 4,5,6,7,8}

            //HashSet<int> setA =  [ 1, 2, 3, 4, 5 ];
            //HashSet<int> setB =  [ 4, 5, 6, 7, 8 ];

            //CollectionHelper.PrintCollection("Set A", setA);
            //CollectionHelper.PrintCollection("Set B", setB);
            //-----------------------------------------------------------------------------------------------------------

            // 5) Print the result of: UnionWith, IntersectWith, ExceptWith

            // UnionWith

            //HashSet<int> resultSet = new(setA);

            //resultSet.UnionWith(setB);
            //CollectionHelper.PrintCollection<int>("Result union with ", resultSet);

            // IntersectWith

            //HashSet<int> resultSet = new(setA);

            //resultSet.IntersectWith(setB);
            //CollectionHelper.PrintCollection<int>("Result Intersect with ", resultSet);

            // ExceptWith

            //HashSet<int> resultSet = new(setA);

            //resultSet.ExceptWith(setB);
            //CollectionHelper.PrintCollection<int>("Result Except With ", resultSet);

            //-----------------------------------------------------------------------------------------------------------

            // 6) Use IsSubsetOf to check if { 1,2} is a subset of Set A

            //bool isSubset = new HashSet<int> { 1, 2 }.IsSubsetOf(setA);
            //Console.WriteLine($"{{1,2}} IsSubsetOf SetA: {isSubset}");

            //------------------------------------------------------------------------------------------------------------


            #endregion

            #region Exercise 5

          //  // Exercise 5: Print Queue Simulator
          //  // Simulate a printer queue
          //  // Create a Queue<string> and enqueue 5 documents: "Report.pdf", "Invoice.pdf", "Letter.docx", "Resume.pdf", "Photo.jpg"

          //  // 1) Print the queue contents and Count
          //  // 2) Use Peek to see which document will print next(without removing)
          //  // 3) Process the queue: Dequeue each document and print "Printing: [name]"
          //  // 4) Try TryDequeue on the now - empty queue — what happens?

          //  //---------------------------------------------------------------------------------------------------------

          //  // Fifo => First In First Out

          //  // 1) Print the queue contents and Count

          //  Queue<string> QueueDoc = new Queue<string>();

          //  QueueDoc.Enqueue("Report.pdf");
          //  QueueDoc.Enqueue("Invoice.pdf");
          //  QueueDoc.Enqueue("Letter.docx");
          //  QueueDoc.Enqueue("Resume.pdf");
          //  QueueDoc.Enqueue("Photo.jpg");


          //  //CollectionHelper.PrintCollection("Queue Contents ", QueueDoc);
          //  //Console.WriteLine($"Queue Count: {QueueDoc.Count}");

          //  //---------------------------------------------------------------------------------------------------------

          //  // 2) Use Peek to see which document will print next(without removing)

          //  //  Console.WriteLine(QueueDoc.Peek());
          //  //---------------------------------------------------------------------------------------------------------

          //  // 3) Process the queue: Dequeue each document and print "Printing: [name]"

          //  //while (QueueDoc.Count > 0)
          //  //{
          //  //    Console.WriteLine($"Printing: {QueueDoc.Dequeue()}");
          //  //}
          //  //----------------------------------------------------------------------------------------------------------

          //  // 4) Try TryDequeue on the now - empty queue — what happens?

          ////  bool isQueueEmpty = QueueDoc.TryDequeue(out string docName);
          ////  Console.WriteLine(isQueueEmpty ? $"Dequeued document: {docName}" : "Queue is empty, no document to dequeue");

          //  //what happens?

          //  // bool isQueueEmpty = QueueDoc.TryDequeue(out string docName);
          //  // isQueueEmpty = false
          //  // docName = null

          //  // why ?  Because the queue was already emptied by:

          //  //while (QueueDoc.Count > 0)
          //  //{
          //  //    Console.WriteLine($"Printing: {QueueDoc.Dequeue()}");
          //  //}

          //  // So when TryDequeue runs:
          //  // There is nothing left to remove
          //  // It does NOT throw an exception
          //  // It safely returns false

          // // Queue is empty, no document to dequeue



          //  //----------------------------------------------------------------------------------------------------------
            #endregion



        }
    }
}
