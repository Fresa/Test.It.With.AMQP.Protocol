using System;
using System.Xml;
using Test.It.With.Amqp.Protocol.Exceptions;

namespace Test.It.With.Amqp.Protocol.Extensions
{
    internal static class XmlElementExtensions
    {
        public static TType GetMandatoryAttribute<TType>(this XmlElement xmlElement, string name)
        {
            var value = xmlElement.GetAttribute(name);
            if (string.IsNullOrEmpty(value))
            {
                throw new MissingXmlAttributeException(name, xmlElement);
            }
            return (TType)Convert.ChangeType(value, typeof(TType));
        }

        public static TType GetOptionalAttribute<TType>(this XmlElement xmlElement, string name)
        {
            if (xmlElement.HasAttribute(name))
            {
                return xmlElement.GetMandatoryAttribute<TType>(name);
            }
            return default(TType);
        }
    }
}