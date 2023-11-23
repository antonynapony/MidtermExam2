//using System.Text;

//namespace MidtermExam2
//{
//    public static class IntExtension
//    {
//        private static readonly string[] _words = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
//        public static string GetWords(this int number)
//        {
//            var resultBuilder = new StringBuilder();
//            number = Math.Abs(number);
//            var numberStr = number.ToString();
//            foreach (var symbol in numberStr)
//            {
//                int index = int.Parse(symbol.ToString());
//                resultBuilder.Append(_words[index]);
//                resultBuilder.Append(" ");
//            }

//            return resultBuilder.ToString().TrimEnd();
//        }
//    }
//}

using System.Text;

namespace MidtermExam2
{
    public static class IntExtension
    {
        private static readonly Dictionary<char, string> _words = new Dictionary<char, string>()
        {
            ['0'] = "ноль",
            ['1'] = "один",
            ['2'] = "два",
            ['3'] = "три",
            ['4'] = "четыре",
            ['5'] = "пять",
            ['6'] = "шесть",
            ['7'] = "семь",
            ['8'] = "восемь",
            ['9'] = "девять",
            ['-'] = "минус"
        };
        public static string GetWords(this int number)
        {
            var resultBuilder = new StringBuilder(32);
            var numberStr = number.ToString();
            foreach (var symbol in numberStr)
            {
                resultBuilder.Append(_words[symbol]);
                resultBuilder.Append(" ");
            }

            return resultBuilder.ToString().TrimEnd();
        }

    }
}