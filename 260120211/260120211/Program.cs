using System.Text;
using System;





namespace ConsoleApp26012020
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(return2words("Ayxan Ismayilzade burdadirmi?"));
           
        }
        static string return2words(string str)
        {
            
            str=str.Trim();
            string str1;
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                return str;
            }
            
                str1 = str.Substring(0, str.IndexOf(' ')) + str.Substring(str.LastIndexOf(' '));
                return str1;
            

        }
    }
}

