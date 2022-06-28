using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zipper
{
    public class Huffman
    {
        public void CompressFiles(string dataFilename,string archFilename)
        {
            byte[] data = File.ReadAllBytes(dataFilename);
            //SAVE
            byte[] arch = CompressBytes(data);
            File.WriteAllBytes(archFilename, arch);
        }

        public void DecompressFile(string archFilename, string dataFilename)
            {
            byte[] arch = File.ReadAllBytes(archFilename);
            byte[] data = DecompressBytes(arch);
            File.WriteAllBytes(dataFilename, data);

            }

        public byte[] DecompressBytes(byte[] arch)
        {
            ParseHeader(arch, out int dataLenght, out int startIndex, out int[] frecs);
            NodeHuf root = CreateTree(frecs);
            byte[] data = Decompress(arch, startIndex, dataLenght, root);
            return arch;
        }

        public byte[] Decompress(byte[] arch, int startIndex, int dataLenght, NodeHuf root)
        {
            int size = 0;
            NodeHuf curr = root;
            List<byte> data = new List<byte>();
            for (int i = startIndex; i < arch.Length; i++)
                for (int bit =1; bit <= 128; bit <<= 1)
                {
                    bool zero = (arch[i] & bit) == 0;
                    if (zero)
                        curr = curr.bit0;
                    else
                        curr = curr.bit1;
                    if (curr.bit0 != null)
                        continue;
                    if (size++ < dataLenght)
                        data.Add(curr.symbol);
                    curr = root;
                }
            return data.ToArray();
        }

        public void ParseHeader(byte[] arch, out int dataLenght, out int startIndex, out int[] frecs)
        {
            dataLenght = arch[0] |
                (arch[1] << 8) | 
                (arch[1] << 16) |
                (arch[1] << 24);
            frecs = new int[256];
            for (int i = 0; i < 256; i++)
                frecs[i] = arch[4 + i];

            startIndex = 4 + 256;
        }

        public byte[] CompressBytes(byte[] data)
        {
            int[] frecs = CalculateFrecs(data);
            NodeHuf root = CreateTree(frecs);
            string[] codes = CreateHuffamCodes(root);
            byte[] bits = Compress(data, codes);
            byte[] head = CreateHader(data.Length, frecs);
            return head.Concat(bits).ToArray();
        }

        public byte[] CreateHader(int datalength, int[] frecs)
        {
            List <byte> h = new List<byte>();
            h.Add((byte)(datalength     &255));
            h.Add((byte)((datalength >> 8)&255));
            h.Add((byte)((datalength >> 16)&255));
            h.Add((byte)((datalength >> 24)&255));

            for(int i = 0; i < 256; i++)
            h.Add((byte)(frecs[i]));
            return h.ToArray();
        }

        public byte[] Compress(byte[] data, string[] codes)
        {
            List<byte> bits = new List<byte>();
            byte sum = 0;
            byte bit = 1;

            foreach(byte symbol in data)
                foreach(char c in codes[symbol])
                {
                    if (c == '1')
                        sum |= bit;
                    if (bit <128)
                        bit <<=1;
                    else
                    {
                        bits.Add(sum);
                        sum = 0;
                        bit = 1;
                    }
                    
                }
            if (bit >1)
                bits.Add(sum);
            return bits.ToArray();
        }

        public string[] CreateHuffamCodes(NodeHuf root)
        {
            string[] codes = new string[256];
            Next(root, "");
            return codes;

            void Next ( NodeHuf node, string code)
            {
                if (node.bit0 == null)
                    codes [node.symbol] = code;
                else
                {
                    Next(node.bit0, code + "0");
                    Next(node.bit1, code + "1");
                }
            }
        }

        public int[] CalculateFrecs(byte[] data)
        {
            int[] frecs = new int[256];
            foreach (byte b in data)
                frecs[b]++;
            NormalizeFrecs();
            return frecs;

            void NormalizeFrecs()
            {
                int max = frecs.Max();
                if (max <= 255) return;
                for (int i = 0; i < 256; i++)
                    if (frecs[i] > 0)
                        frecs[i] = 1 + frecs[i] *256/ (max+1) ;
            }
        }
    
        public NodeHuf CreateTree(int[] frecs)
        {
            PriorityQueue<NodeHuf> pq = new PriorityQueue<NodeHuf>();
            for (int i = 0; i < 256; i++)
            {
                if ( frecs[i] > 0)
                {
                    pq.Enqueue(frecs[i], new NodeHuf((byte)i,frecs[i]));
                }
            }
            
            while (pq.Size() > 1)
            {
                NodeHuf bit0 = pq.Dequeue();
                NodeHuf bit1 = pq.Dequeue();
                int frec = bit0.frec+ bit1.frec;
                NodeHuf next = new NodeHuf(bit0,bit1,frec );
                pq.Enqueue(frec,next);
            }
            return pq.Dequeue();
        }
}   }
