using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GUI menu = new GUI();
            while(true)
            {
                menu.Menu();
            } 
        }
    }
}
