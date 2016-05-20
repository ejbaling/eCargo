using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SingleChildNode : Node
    {
        public Node Child { get; }
        public SingleChildNode(string name, Node child) : base(name)
        {
            Child = child;
        }
    }
}
