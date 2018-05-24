using System;
using System.Xml.XPath;
using Test.It.With.Amqp.Protocol.Extensions;

namespace Test.It.With.Amqp.Protocol.Exceptions
{
    internal class MissingXmlNodesException : Exception
    {
        public MissingXmlNodesException(string name, IXPathNavigable currentNode)
            : base(BuildMessage(name, currentNode))
        {
        }

        private static string BuildMessage(string name, IXPathNavigable currentNode)
        {
            return $"Missing nodes: {currentNode.CreateNavigator().GetPath()}/{name}";
        }
    }
}