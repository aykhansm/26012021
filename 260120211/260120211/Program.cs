using System.Text;
using System;





namespace ConsoleApp26012020
{
    class Program
    {
        static void Main(string[] args)
        {


            string str = "Ayxan Ismayilzade burdadirmi?";
            str.Trim();
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
                Console.WriteLine(str);
                return;
            }
            str1 = str.Substring(0, str.IndexOf(' ')) + str.Substring(str.LastIndexOf(' '));
            Console.WriteLine(str1);


            #region 2ci mesele






            #endregion
        }
    }
}

