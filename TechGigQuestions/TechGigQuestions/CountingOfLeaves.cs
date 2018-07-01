using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGigQuestions
{
    public class CountingOfLeaves
    {
        public void DataforTestcase()
        {
            var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
        public void CountingTheLeavesOfTheNode()
        {
            /*
             * You are given a tree with N nodes numbered from 0 to N-1 . 
             * You are also given a node X which you are supposed to delete. 
             * You have to tell the number of leaf nodes in the tree after deleting the given node. 
             * 
             * Note that deleting a node deletes all the nodes in its subtree.
             * 
             * 1 <= N <= 100
               -1 <= Ai <= (N-1)
               0 <= X <= (N-1)
             */
            var arr = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int nodeToDelete = 5;

        }

        public int GetTheNodeLevel(int numberOfNodes)
        {
            int level = 0;
            if (numberOfNodes > 100)
            {
                Console.WriteLine("The number of nodes cannot exceed 100. Please enter a number less than 100.");
                return 0;
            }
            else
            {
                for(int c=0;c<7;c++)
                {
                    int power = Convert.ToInt16(Math.Pow(2, c));
                    level = c;
                    if (power >= numberOfNodes)
                        break;                    
                }
            }
            return level-1;
            
        }

        public int NumberOfLeafNodesAfterDeleting(int total,int nodeToDelete)
        {
            int totalnode = total;
            bool doeschildnodeexist = true;
            int rest = 0;
            int totaltodelete = 0;
            int totallevel = GetTheNodeLevel(total); 
            int levelOfNodeToDelete = GetTheNodeLevel(nodeToDelete);
            int n = totallevel - levelOfNodeToDelete;
            if (((nodeToDelete+1) * 2) > totalnode)
                doeschildnodeexist = false;
            if (doeschildnodeexist)
            {
                totaltodelete = Convert.ToInt16(Math.Pow(2, n)) + n;
                rest = totalnode - totaltodelete;
            }
            else
            {
                rest = totalnode - 1;
            }

            return rest;
        }
    }
}
