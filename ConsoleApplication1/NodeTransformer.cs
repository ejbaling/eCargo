using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NodeTransformer : NodeBase, INodeTransformer
    {
        public string Transform(Node node)
        {
            if (node != null)
            {
                var nd = node as ManyChildrenNode;
                var childrenCount = nd.Children.Count();

                if (childrenCount == 1)
                {
                    Indent(_result);

                    _result += GetFormat(typeof(SingleChildNode), node);

                    Transform(nd.Children.SingleOrDefault());
                }
                else if (childrenCount == 2)
                {
                    Indent(_result);

                    _result += GetFormat(typeof(TwoChildrenNode), node);

                    var currentLevelSpace = _indentSpace;
                    foreach (var e in nd.Children)
                    {
                        if (e == nd.Children.First())
                        {
                            Indent(_result);
                            currentLevelSpace = _indentSpace;
                            Transform(e);
                        }
                        else
                        {
                            _indentSpace = currentLevelSpace;
                            _result += String.Empty.PadRight(_indentSpace);
                            Transform(e);
                        }
                    }
                }
                else if (childrenCount == 0)
                {
                    Indent(_result);

                    _result += GetFormat(typeof(NoChildrenNode), node);
                }
            }

            return _result;
        }
    }
}
