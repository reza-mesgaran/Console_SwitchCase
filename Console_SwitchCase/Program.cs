using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_SwitchCase
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth dates: YYYY/MM/DD");
            string BirthDate = Console.ReadLine();

            string y = BirthDate.Substring(0, 4);
            string m = BirthDate.Substring(5, 2);
            string d = BirthDate.Substring(8, 2);

            Console.WriteLine("Your BirthDay is {0}", DateC(y, m, d));
            Console.ReadKey();
        }

        public static string DateC(string Y, string M, string D)
        {
            switch (M)
            {

                case "01":
                    M = "Jan";
                    break;

                case "02":
                    M = "Feb";
                    break;

                case "03":
                    M = "Mar";
                    break;

                case "04":
                    M = "Apr";
                    break;

                case "05":
                    M = "May";
                    break;

                case "06":
                    M = "Jun";
                    break;

                case "07":
                    M = "Jul";
                    break;

                case "08":
                    M = "Aug";
                    break;

                case "09":
                    M = "Sep";
                    break;

                case "10":
                    M = "Oct";
                    break;

                case "11":
                    M = "Nov";
                    break;

                case "12":
                    M = "Dec";
                    break;
            }

            string FinalDate = Y + "/" + M + "/" + D;
            return (FinalDate);
        }


    }
}
