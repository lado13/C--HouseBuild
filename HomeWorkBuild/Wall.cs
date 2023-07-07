using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBuild
{
    internal class Wall : IBuilding
    {
        public void Build()
        {
            Console.WriteLine("The wall was build");
        }
    }
}
