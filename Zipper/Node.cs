using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zipper
{
        public class Node1
        {
            public char Symbol1 { get; set; }
            public int Frequency1 { get; set; }
            public Node1 Right1 { get; set; }
            public Node1 Left1 { get; set; }
            
            public List<bool> Traverse(char symbol, List<bool> data)
            {
                // Leaf
                if (Right1 == null && Left1 == null)
                {
                    if (symbol.Equals(this.Symbol1))
                    {
                        return data;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    List<bool> left = null;
                    List<bool> right = null;

                    if (Left1!= null)
                    {
                        List<bool> leftPath = new List<bool>();
                        leftPath.AddRange(data);
                        leftPath.Add(false);

                        left = Left1.Traverse(symbol, leftPath);
                    }

                    if (Right1 != null)
                    {
                        List<bool> rightPath = new List<bool>();
                        rightPath.AddRange(data);
                        rightPath.Add(true);
                        right = Right1.Traverse(symbol, rightPath);
                    }

                    if (left != null)
                    {
                        return left;
                    }
                    else
                    {
                        return right;
                    }
                }
            }
        }
    }

