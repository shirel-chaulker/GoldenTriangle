using MyApp.Utilities;
using System;
using System.Linq;


namespace MyApp
{
    public class Program
    {
        private static string path = @"C:\Users\shire\source\repos\GoldenTriangle\MyApp\AppData\";
        private static FilesIO fileIO = new FilesIO(path);
        
        static void Main(string[] args)
        {
            int choice = fileIO.ReadText("app-menu.txt").ElementAt(20) - '0'; // convrt to int 
            SelectFromMenu(choice);
        }

        public static void SelectFromMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    CallReverseNumber();
                    break;
                case 2:
                    CallCalculateFacturial();
                    break;
                case 3:
                    CallLongestWord();
                    break;
                default:
                    throw new ArgumentException("wrong choice number");
            }

        }

        public static void CallReverseNumber()
        {
          int content = Int32.Parse(fileIO.ReadText("app-num-input.txt"));
          string txt = Implementations.ReverseNumbers(content).ToString();
            fileIO.WriteText("app-results.txt", txt);
        }

        public static void CallCalculateFacturial()
        {
            int content = Int32.Parse(fileIO.ReadText("app-num-input.txt"));
            string txt = Implementations.CalculateFacturial(content).ToString();
            fileIO.WriteText("app-results.txt", txt);
        }

        public static void CallLongestWord()
        {
            string content = fileIO.ReadText("app-text-input.txt");
             string[] contentArray =content.Split(' ');
            string txt = Implementations.LogestWord(contentArray).ToString();
            fileIO.WriteText("app-results.txt", txt);
        }
    }

        //application introsuction
        /*
        AppContext-menu.txt  = menu for selecting a logic method
        app-results.txt = file which holds the results
        app-num-input.txt = input file with numbers
        app-text-input.txt = input file with text 
        */
}

