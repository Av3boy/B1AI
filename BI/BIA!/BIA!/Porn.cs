using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{
    class Porn
    {
        public static void Pornoo()
        {
            Console.WriteLine("Select Category:");
            Console.WriteLine("MILF");
            Console.WriteLine("Gay");
            Console.WriteLine("Lesbian");
            string searchInput = Console.ReadLine();
            Process.Start("https://www.pornhub.com/video/search?search=" + searchInput);
        }
    }
}
