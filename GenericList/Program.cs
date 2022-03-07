using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> renkler = new List<string>();

            renkler.Add("Mavi");
            renkler.Add("Kırmızı");

            foreach (var item in renkler)
            {
                Console.WriteLine(renkler);

            }
        }
    }
}
