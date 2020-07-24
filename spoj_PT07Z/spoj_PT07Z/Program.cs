using System;
using System.Collections.Generic;

namespace spoj_PT07Z
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int[]> nodes = new List<int[]>();
            // step 1: read
            int totalNode = int.Parse(Console.ReadLine());
            for (int i = 0; i < totalNode - 1; i++)
            {
                nodes.Add(new int[2]);
                string line = Console.ReadLine();
                var strNums = line.Split();
                int num0 = int.Parse(strNums[0]);
                int num1 = int.Parse(strNums[1]);
                
                if(num0 < num1)
                {
                    nodes[i][0] = num0;
                    nodes[i][1] = num1;
                }
                else
                {
                    nodes[i][1] = num0;
                    nodes[i][0] = num1;
                }
            }
        }
    }
}
