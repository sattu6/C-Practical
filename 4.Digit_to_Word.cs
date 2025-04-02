using System;

class GfG
{
    static string ConvertToWords(int n)
    {
        if (n == 0)
            return "Zero";

        string[] units = {
            "",        "One",       "Two",      "Three",
            "Four",    "Five",      "Six",      "Seven",
            "Eight",   "Nine",      "Ten",      "Eleven",
            "Twelve",  "Thirteen",  "Fourteen", "Fifteen",
            "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };
        
        string[] tens = {
            "",     "",     "Twenty",  "Thirty", "Forty",
            "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

        string[] multiplier =
                    {"", "Thousand", "lac", "crore", " arab"};

        string res = "";
        int group = 0;

        while (n > 0)
        {
            if (n % 1000 != 0)
            {

                int value = n % 1000;
                string temp = "";

                if (value >= 100)
                {
                    temp = units[value / 100] + " Hundred ";
                    value %= 100;
                }

                if (value >= 20)
                {
                    temp += tens[value / 10] + " ";
                    value %= 10;
                }

                if (value > 0)
                {
                    temp += units[value] + " ";
                }

                temp += multiplier[group] + " ";

                res = temp + res;
            }
            n /= 1000;
            group++;
        }

        return res.Trim();
    }
    static void Main()
    {
        int n = 2000000;
        Console.WriteLine(ConvertToWords(n));
    }
}