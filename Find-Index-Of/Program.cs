using System;

namespace Find_Index_Of
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string strSource = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is the use of a book,' " +
                "thought Alice 'without pictures or conversation?'\n";

            Console.WriteLine(strSource);

            //Console.WriteLine("The search string is:{0}\"{1}\"{0}", Environment.NewLine, strSource);

            string strTarget = "";
            int found = 0;
            int totFinds = 0;

            do
            {
                Console.Write("Please enter a search value to look for in the above string (hit Enter to exit) ==> ");

                strTarget = Console.ReadLine();

                if (strTarget != "")
                {

                    for (int i = 0; i < strSource.Length; i++)
                    {

                        found = strSource.IndexOf(strTarget, i, StringComparison.OrdinalIgnoreCase);

                        if (found >= 0)
                        {
                            totFinds++;
                            i = found;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    return;
                }

                Console.WriteLine("{0}The search parameter '{1}' was found {2} times.{0}",
                        Environment.NewLine, strTarget, totFinds);

                totFinds = 0;
            } while (true);

        }
    }
}
