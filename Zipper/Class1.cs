using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zipper
{
    public class HuffmanTree
    {
        private List<Node1> nodes = new List<Node1>();
        public Node1 Root1 { get; set; }
        public Dictionary<char, int> Frequencies = new Dictionary<char, int>();

        public void Build(string source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (!Frequencies.ContainsKey(source[i]))
                {
                    Frequencies.Add(source[i], 0);
                }

                Frequencies[source[i]]++;
            }

            foreach (KeyValuePair<char, int> symbol in Frequencies)
            {
                nodes.Add(new Node1() { Symbol1 = symbol.Key, Frequency1 = symbol.Value });
            }

            while (nodes.Count > 1)
            {
                List<Node1> orderedNodes = nodes.OrderBy(node => node.Frequency1).ToList<Node1>();

                if (orderedNodes.Count >= 2)
                {
                    // Take first two items
                    List<Node1> taken = orderedNodes.Take(2).ToList<Node1>();

                    // Create a parent node by combining the frequencies
                    Node1 parent = new Node1()
                    {
                        Symbol1 = '*',
                        Frequency1 = taken[0].Frequency1 + taken[1].Frequency1,
                        Left1 = taken[0],
                        Right1 = taken[1]
                    };

                    nodes.Remove(taken[0]);
                    nodes.Remove(taken[1]);
                    nodes.Add(parent);
                }

                this.Root1 = nodes.FirstOrDefault();

            }

        }

        public BitArray Encode(string source)
        {
            List<bool> encodedSource = new List<bool>();

            for (int i = 0; i < source.Length; i++)
            {
                List<bool> encodedSymbol = this.Root1.Traverse(source[i], new List<bool>());
                encodedSource.AddRange(encodedSymbol);
            }

            BitArray bits = new BitArray(encodedSource.ToArray());

            return bits;
        }

        public BitArray ConvertHexToBitArray(string hexData)
        {
            if (hexData == null)
                return null; // or do something else, throw, ...

            BitArray ba = new BitArray(4 * hexData.Length);
            for (int i = 0; i < hexData.Length; i++)
            {
                byte b = byte.Parse(hexData[i].ToString(), NumberStyles.HexNumber);
                for (int j = 0; j < 4; j++)
                {
                    ba.Set(i * 4 + j, (b & (1 << (3 - j))) != 0);
                }
            }
            return ba;
        }

        public string Decode(BitArray ba)
        {

            Node1 current = this.Root1;
            string decoded = "";

            foreach (bool bit in ba)
            {
                if (bit)
                {
                    if (current.Right1 != null)
                    {
                        current = current.Right1;
                    }
                }
                else
                {
                    if (current.Left1 != null)
                    {
                        current = current.Left1;
                    }
                }

                if (IsLeaf(current))
                {
                    decoded += current.Symbol1;
                    current = this.Root1;
                }
            }

            return decoded;
        }

        public bool IsLeaf(Node1 node)
        {
            return (node.Left1 == null && node.Right1 == null);
        }


    }

   
    
        
}
    

            
        

