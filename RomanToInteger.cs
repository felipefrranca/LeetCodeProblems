internal class RomanToInteger
{
    private static void Main(string[] args)
    {
        while (true)
        {
            string s = Console.ReadLine();

            Console.WriteLine(RomanToInt(s));
        }
    }

    public static int RomanToInt(string s)
    {
        int totalValue = 0;

        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i].ToString())
            {
                case "I":
                    if (i < (s.Length - 1) && s.Substring(i, 2) == "IV")
                    {
                        i++;
                        totalValue += 4;
                    }
                    else if (i < (s.Length - 1) && s.Substring(i, 2) == "IX")
                    {
                        i++;
                        totalValue += 9;
                    }
                    else
                        totalValue += 1;
                    break;
                case "V":
                    totalValue += 5;
                    break;
                case "X":
                    if (i < (s.Length - 1) && s.Substring(i, 2) == "XL")
                    {
                        i++;
                        totalValue += 40;
                    }
                    else if (i < (s.Length - 1) && s.Substring(i, 2) == "XC")
                    {
                        i++;
                        totalValue += 90;
                    }
                    else
                        totalValue += 10;
                    break;
                case "L":
                    totalValue += 50;
                    break;
                case "C":
                    if (i < (s.Length - 1) && s.Substring(i, 2) == "CD")
                    {
                        i++;
                        totalValue += 400;
                    }
                    else if (i < (s.Length - 1) && s.Substring(i, 2) == "CM")
                    {
                        i++;
                        totalValue += 900;
                    }
                    else
                        totalValue += 100;
                    break;
                case "D":
                    totalValue += 500;
                    break;
                case "M":
                    totalValue += 1000;
                    break;
                default:
                    break;
            }
        }

        return totalValue;
    }
}