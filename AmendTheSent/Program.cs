using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AmendTheSent
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "CodesignalIsAwesome"; // the output should be amendTheSentence(s) = "codesignal is awesome";
            string s = "Hello"; //the output should be amendTheSentence(s) = "hello"

            var textTransform = new Transformation();
            string result = textTransform.AmendTheSentence(s);
                       
            //Console.WriteLine("{0}", s);

            Console.ReadLine();
        }
    }
}
