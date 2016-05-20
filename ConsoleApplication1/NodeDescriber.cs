using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NodeDescriber : INodeDescriber
    {
        private string _result { get; set; }
        private const int _increment = 4;
        private int _indentSpace;

        public string Describe(Node node)
        {
            if (node != null)
            {
                var t = node.GetType();

                if (t == typeof(SingleChildNode))
                {
                    if (Indent(_result))
                    {
                        _indentSpace += _increment;
                        _result += String.Empty.PadRight(_indentSpace);
                    }

                    _result += GetFormat(t, node);

                    var singleChildNode = node as SingleChildNode;

                    Describe(singleChildNode.Child);
                }
                else if (t == typeof(TwoChildrenNode))
                {
                    if (Indent(_result))
                    {
                        _indentSpace += _increment;
                        _result += String.Empty.PadRight(_indentSpace);
                    }

                    _result += GetFormat(t, node);

                    var twoChildrenNode = node as TwoChildrenNode;

                    var indent = Indent(_result);
                    var space = _indentSpace;
                    if (indent)
                    {
                        _indentSpace += _increment;
                        space = _indentSpace;
                        _result += String.Empty.PadRight(_indentSpace);
                    }

                    Describe(twoChildrenNode.FirstChild);

                    if (indent)
                    {
                        _indentSpace = space;
                        _result += String.Empty.PadRight(_indentSpace);
                    }

                    Describe(twoChildrenNode.SecondChild);
                }
                else if (t == typeof(NoChildrenNode))
                {
                    if (Indent(_result))
                    {
                        _indentSpace += _increment;
                        _result += String.Empty.PadRight(_indentSpace);
                    }

                    _result += GetFormat(t, node);
                }
            }

            return _result;
        }

        private string GetFormat(Type t, Node node)
        {
            
            return String.Format("new {0}(\"{1}\",{2}", t.Name, node.Name, "\n");
        }

        private bool Indent(string result)
        {
            return result != null && (result.LastIndexOf(" ") - result.LastIndexOf("\n") <= 0);
        }
    }
}
