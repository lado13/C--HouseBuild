using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBuild
{
    internal class build
    {
      
        
        public static void Print()
        {
            IBuilding build;
            bool foundationBuild = false;   
            bool wallBuild = false;

            Console.WriteLine($">>>House build<<<\nFoundation(1)\nWall(2)\nRoof(3)");
            while (true)
            {
                string inp = Console.ReadLine();
                if (inp == "1")
                {
                    build = new Foundation();
                    build.Build();
                    foundationBuild = true;
                }
                else if (inp == "2")
                {
                    if (foundationBuild)
                    {
                        build = new Wall();
                        build.Build();  
                        wallBuild = true;
                    }
                    else
                    {
                        Console.WriteLine("First you need foundation !");
                    }
                }
                else if (inp == "3")
                {
                    if (foundationBuild && wallBuild)
                    {
                        build = new Roof();
                        build.Build();  
                        foundationBuild = false; 
                        wallBuild = false;
                        Console.WriteLine("----------------------");
                        Console.WriteLine("The house was built :)");
                    }
                    else
                    {
                        Console.WriteLine("First you need foundation !");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input !");
                }

            }
        }

        
    }
}
