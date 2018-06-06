using System;

namespace Test.It.With.Amqp.Protocol.Definitions
{
    public class Response
    {
        private readonly Lazy<Method> _methodResolver;

        public Response(Lazy<Method> methodResolver)
        {
            _methodResolver = methodResolver;
        }

        public Method Method => _methodResolver.Value;
    }
}