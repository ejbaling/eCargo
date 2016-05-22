using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NodeBase
    {
        private const int _increment = 4;
        protected string _result { get; set; }
        protected int _indentSpace;

        protected void Indent(string result)
        {
            if (result != null && (result.LastIndexOf(" ") - result.LastIndexOf("\n") <= 0))
            {
                _indentSpace += _increment;
                _result += String.Empty.PadRight(_indentSpace);
            }
        }

        protected string GetFormat(Type t, Node node)
        {
            return String.Format("new {0}(\"{1}\",{2}", t.Name, node.Name, "\n");
        }
    }
}
