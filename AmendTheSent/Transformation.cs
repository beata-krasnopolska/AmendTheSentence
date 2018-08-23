using System;
using System.Text.RegularExpressions;

namespace AmendTheSent
{
    class Transformation
    {
        public string AmendTheSentence(string s)
        {
            //StringBuilder builder = new StringBuilder();
            //foreach (char c in s)
            //{
            //    if (Char.IsUpper(c) && builder.Length > 0) builder.Append(' ');
            //    builder.Append(c);
            //}
            //s = builder.ToString();
            //return s;
            var r = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);
                       
            s = r.Replace(s, " ").ToLower();
            
            Console.WriteLine("{0}", s);
                        
            return s;
        }
    }
}
