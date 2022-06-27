using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zipper
{
    public class NodeHuf
    {
        public readonly byte symbol;
        public readonly int frec;
        public readonly NodeHuf bit0;
        public readonly NodeHuf bit1;


        public NodeHuf(NodeHuf bit0, NodeHuf bit1 , int frec)
        {
            this.bit0 = bit0;
            this.bit1 = bit1;
            this.frec = frec;
        }

        public NodeHuf (byte symbol , int frec)
        {
            this.symbol = symbol;
            this.frec = frec;
        }
    }
}
