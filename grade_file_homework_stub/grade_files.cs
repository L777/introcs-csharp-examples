using System;
using System.IO;

namespace IntroCS
{
   class GradeFiles
   {
      /// Process grade files based on a class abbreviation
      /// on the command line, or provided interactively.
      public static void Main(string[] args)
      {
                 //18.7.3:  - prompt course abreviation from the user
         Console.WriteLine ("Enter course abreviation(e.g.Comp150,Comp170 etc): ");
         string abreviation = Console.ReadLine ();

         // creates the two master files name as a string values // we will use these values during files creation
         string categories_name = ("categories_" + abreviation + ".txt");
         string students_name = ("students_" + abreviation + ".txt");

         //    Console.WriteLine (categories_name + "\n " + students_name);

         StreamWriter writer = new StreamWriter (categories_name);
         StreamWriter writer2 = new StreamWriter (students_name);



         string pathToCatFile = LocatePathToFile (categories_name);
         string pathToStudentFile = LocatePathToFile (students_name);

         Console.WriteLine (pathToCatFile);
         Console.WriteLine (pathToStudentFile);

         writer.WriteLine ("Exam, Lab, Homework, Project, Class Participation");
         writer.WriteLine ("40, 15, 15, 20, 10");
         writer.WriteLine ("2, 5, 3, 1, 2");

         writer2.WriteLine ("P12345678, Doe, John");
         writer2.WriteLine ("P00000001, Hernandez, Maria");
        
         writer.Close ();
         writer2.Close ();



      }


         public static string LocatePathToFile(string filename)
         {
          string[] paths = { ".", "..", Path.Combine("..", "..") }; //added th path

            foreach (string dir in paths) {
               string filePath = Path.Combine(dir, filename);
               if (File.Exists(filePath))
                  return filePath;
            }
            return null;
         }


         // TEMPORARY line to get oriented to the file system:
        // Console.WriteLine("Current directory: " +Directory.GetCurrentDirectory());
      }
   /*                                        // codeIndex chunk                                          
      /// Take the first letter code for a catagory, and 
      /// return the index of that category in categories.
      static int codeIndex(string code, string[] categories)
      {
         for (int i = 0; i < categories.Length; i++) {
            if (categories[i].Trim().StartsWith(code)) {
               return i;
            }
         }
         return -1; //required by compiler: shouldn't reach
      }
   }  
   // end codeIndex chunk
*/
}
