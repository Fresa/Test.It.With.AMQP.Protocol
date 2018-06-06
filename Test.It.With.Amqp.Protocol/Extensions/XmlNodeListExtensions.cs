using System.Collections.Generic;
using System.Xml;

namespace Test.It.With.Amqp.Protocol.Extensions
{
    internal static class XmlNodeListExtensions
    {
        public static IEnumerable<T> CastOrEmptyList<T>(this XmlNodeList list)
            where T : XmlNode
        {
            if (list == null || list.Count == 0)
            {
                yield break;
            }

            foreach (T node in list)
            {
                yield return node;
            }
        }
    }
}