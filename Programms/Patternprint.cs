using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programms
{
    public class Patternprint
    {

        public void Pyramid()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
}
