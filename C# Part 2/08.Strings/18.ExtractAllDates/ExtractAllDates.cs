using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ExtractAllDates
{
    class ExtractAllDates
    {
        static void Main(string[] args)
        {
            string inputText = "Lorem ipsum dolor 27.02.1988 sit amet, 27.2.1988 consectetuer" +
                " adipiscing elit 02.02.1989, sed diam nonummy nibh euismod 2.2.1988. Tincidunt ut laoreet " +
                "dolore ma.Ggna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci 02. " +
                "Tation ullamcorper 2.3. suscipit lobortis nisl 02.3 ut aliquip ex ea commodo consequat. " +
                "Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat.";
            StringBuilder word = new StringBuilder();
            List<DateTime> dates = new List<DateTime>();
            CultureInfo culture = new CultureInfo("bg-BG");
            foreach (char symbol in inputText)
            {
                if (symbol != ' ' && symbol != ',' && symbol != ';' && symbol != ':' && symbol != '.' && symbol != '!' && symbol != '?')
                {
                    word.Append(symbol);
                }
                else if (symbol == '.')
                {
                    if (IsDay(word.ToString()))
                    {
                        word.Append(symbol);
                    }
                    else if (IsMonth(word.ToString()))
                    {
                        word.Append(symbol);
                    }
                    else
                    {
                        if (word.ToString() != String.Empty)
                        {
                            if (IsDate(word.ToString()))
                            {
                                DateTime tempDate = DateTime.Parse(word.ToString(), culture);
                                dates.Add(tempDate);
                            }
                        }
                        word.Clear();
                    }
                }
                else
                {
                    if (word.ToString() != String.Empty)
                    {
                        if (IsDate(word.ToString()))
                        {
                            DateTime tempDate = DateTime.Parse(word.ToString(), culture);
                            dates.Add(tempDate);
                        }
                    }
                    word.Clear();
                }
            }
            foreach (DateTime date in dates)
            {
                string result = date.ToString(culture);
                Console.WriteLine("    {0}", result);
            }
        }

        static bool IsDay(string currentWord)
        {
            int number;
            bool attemptParse = int.TryParse(currentWord, out number);
            if (attemptParse)
            {
                if (number >= 1 && number <= 31)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        static bool IsMonth(string currentWord)
        {
            int indexOfPoint = currentWord.IndexOf('.');
            string workStr = String.Empty;
            if (indexOfPoint > 0)
            {
                workStr = currentWord.Substring(indexOfPoint + 1);
                int number;
                bool attemptParse = int.TryParse(workStr, out number);
                if (attemptParse)
                {
                    if (number >= 1 && number <= 12)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        static bool IsDate(string currentWord)
        {
            int firstPoint = currentWord.IndexOf('.');
            currentWord = currentWord.Trim('.', ' ');
            int secondPoint = -1;
            bool trueDay = false;
            bool trueMonth = false;
            if (firstPoint > 0)
            {
                string day = currentWord.Substring(0, firstPoint);
                trueDay = IsDay(day);
                if (firstPoint + 1 < currentWord.Length)
                {
                    secondPoint = currentWord.IndexOf('.', firstPoint + 1);
                }
                else
                {
                    secondPoint = -1;
                }
                if (secondPoint > firstPoint)
                {
                    string month = currentWord.Substring(0, secondPoint);
                    trueMonth = IsMonth(month);
                }
                else
                {
                    trueMonth = false;
                }
            }
            else
            {
                trueDay = false;
            }
            int lastPoint = currentWord.LastIndexOf('.');
            bool trueYear = false;
            if (lastPoint > 0)
            {
                string year = currentWord.Substring(lastPoint + 1);
                int number;
                bool attemptParse = int.TryParse(year, out number);
                if (attemptParse)
                {
                    if (number >= 1 && number <= 9999)
                    {
                        trueYear = true;
                    }
                    else
                    {
                        trueYear = false;
                    }
                }
                else
                {
                    trueYear = false;
                }
            }
            else
            {
                trueYear = false;
            }
            if (trueDay && trueMonth && trueYear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
