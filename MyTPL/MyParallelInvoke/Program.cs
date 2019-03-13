using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace MyParallelInvoke
{
    class Program
    {
        #region Helper Methods
        static string[] CreateWordArr(string uri)
        {
            Console.WriteLine("Retreiving data from:{0}", uri);

        //    downliad web page
            string str = new WebClient().DownloadString(uri);

        //    write into text file
            File.WriteAllText("MyBook.txt", str);

        //    arrange text
            return str.Split(new char[] { ' ', ',', '.', '/', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

        }


        #endregion

        #region Linq Manipulation
        public static void GetWordCount(string[] words, string term)
        {
            var findWords = from book
                            in words
                            where book.ToUpper().Contains(term.ToUpper())
                            select book;

            Console.WriteLine(@"Task #: The word ""{0}"" " + 
                " Occur {1} times", term, findWords.Count());
        }

        public static void GetLongWord(string[] words)
        {
            var longWord = (from book in words
                           orderby book.Length descending
                           select book).First();
            //select book.FirstOrDefault();

            Console.WriteLine("The longest word is: {0}", longWord);
    }

        #endregion

        static void Main(string[] args)
        {
            string[] myText = CreateWordArr
                (@"http://www.gutenberg.org/files/59040/59040-0.txt");

            string[] words = CreateWordArr(@"MyBook.txt");

            GetLongWord(words);
            GetWordCount(words, "child");
            Parallel.Invoke(() => 
            {
                Console.WriteLine("First Task");
                GetLongWord(words);
            },
            ()=>
            {
                Console.WriteLine("Second Task");
                GetWordCount(words, "child");
            },
            () => 
            {
                Console.WriteLine("Read the book");
                CreateWordArr(@"http://www.gutenberg.org/files/59040/59040-0.txt");
            }
            );
        }
    }
}
