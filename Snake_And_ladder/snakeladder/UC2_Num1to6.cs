using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeladder
{
    internal class UC2_Num1to6
    {
        public void die()
        {
            Random random = new Random();
            int position = random.Next(1, 7);
            Console.WriteLine(position);
        }
    }
}

