using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zipper
{
    class MAinRun
    {
        static void Run(string[] args)//Нужен ввод файла
    {    
        Console.WriteLine("Please enter the string:");
        string input = Console.ReadLine();
        HuffmanTree huffmanTree = new HuffmanTree();

        // Build the Huffman tree
        huffmanTree.Build(input);

        // Encode
        BitArray encoded = huffmanTree.Encode(input);

        Console.Write("Encoded: ");
        foreach (bool bit in encoded)
        {
            Console.Write((bit ? 1 : 0) + "");
        }
        Console.WriteLine();

        // Decode
        string decoded = huffmanTree.Decode(encoded);

        Console.WriteLine("Decoded: " + decoded);

        Console.ReadLine();
    }
}
}
