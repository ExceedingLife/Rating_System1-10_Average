using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating_System1_10_Average
{
    class Program
    {
        // Array to hold causes and array to display table of ratings.
        public static string[] topics = new string[5];
        // multi-demensional array to hold responses.
        public static int[,] responses = new int[5, 10];
        // Keep track of the number of users.
        public static int userCounter = 0;
        public static double average = 0;

        static void Main(string[] args)
        {            
            topics[0] = "how important is global warming";
            topics[1] = "how important is the economy";
            topics[2] = "how important is war";
            topics[3] = "how important is health care";
            topics[4] = "how important is education";
            bool boolean = false;

            // Get users input press 1 to start rating press 0 to view results.
            while (!boolean)
            {
                string msg = "On a scale of 1-10, ";

                for(int i = 0; i < topics.Length; i++)
                {
                    Console.WriteLine(msg + topics[i] + "?");
                    Console.Write("> ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int result))
                    {                        
                        responses[i, result - 1]++; 
                    }
                }
                userCounter++;
                Console.Write("Enter more data? (1=yes, 0=no) : ");
                string toQuit = Console.ReadLine();
                if(int.TryParse(toQuit, out int display))
                {
                    if (display == 0)
                        boolean = true;
                }
            }
            PrintTable();
            Console.ReadKey();
        }

        // Display the outcome.
        public static void PrintTable()
        {
            string text;
            var totals = new List<KeyValuePair<string, double>>();
            double min = 0;
            double max = 0;
            string minKey = "";
            string maxKey = "";

            Console.WriteLine("\nTopic\t\t 1 2 3 4 5 6 7 8 9 10\tAverage");
            // Print a topic then the a row in multi-dem last average.
            for(int i = 0; i < topics.Length; i++)
            {
                text = String.Format("{0,-16}", topics[i].Replace("how important is ", ""));
                Console.Write(text + " ");
                double num = 0;
                for(int j = 0; j < 10; j++)
                {
                    Console.Write(responses[i, j] + " ");
                    text =  topics[i].Replace("how important is ", "");
                    num += responses[i, j] * (j + 1);
                    totals.Add(new KeyValuePair<string, double>(text, num));
                }
                average = num / userCounter;
                Console.Write("\t" + average.ToString("##.00"));
                Console.WriteLine();
            }
            totals.RemoveAll(r => r.Value == 0);
           // Loop through all the values and get the 'max'
            foreach (var pair in totals)
            {
                if (max < pair.Value)
                {
                    maxKey = pair.Key;
                    max = pair.Value;
                }                
            }
            min = max;
            // now loop through all the values and get the 'min'
            foreach(var pair in totals)
            {
                if (min > pair.Value)
                {
                    minKey = pair.Key;
                    min = pair.Value;
                }
            }
            Console.WriteLine("Highest points: " + maxKey + "(" + max + ")");
            Console.WriteLine("Lowest points: " + minKey + "(" + min + ")");
        }
    }
}
