using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {
            prepare_input(10, 1024, "1 0 0 0 0 0 0 1 0 0 1");
            Console.ReadKey();
            
        }

        private static void prepare_input(int first, int last,string bInput)
        {
            StreamWriter sw = new StreamWriter("C:/Users/Naser Sadeghi/Desktop/file.txt");
            
            for (int i = first; i < last; i++)
            {
                string a = "a = gf([1";
                for (int j = 1; j < i; j++)
                {
                    a += " 0";
                }
                a += " 1]);";
                string b = "b = gf([" + bInput + "]);";
                sw.WriteLine(a);
                sw.WriteLine(b);
                sw.WriteLine("[q,r] = deconv(a,b);\nif(any(r))\n    fprintf(\"Not divisible for degree %d\", length(a) - 1);\nelse\n    fprintf(\"Divisible for degree %d\", length(a) - 1);\n    quit();\nend");
            }
            sw.Close();
            Console.WriteLine("Done");
        }



    };
}
