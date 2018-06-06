using System.Collections.Generic;
using System.Linq;

namespace Test.It.With.Amqp.Protocol.Definitions
{
    public class Field
    {
        public Field(string name, Domain domain)
        {
            Name = name;
            Domain = domain;
        }

        public string Name { get; }
        public Domain Domain { get; }

        public string Label { get; set; }
        public string Documentation { get; set; }
        public IEnumerable<Rule> Rules { get; set; } = Enumerable.Empty<Rule>();
        public IEnumerable<Assert> Asserts { get; set; } = Enumerable.Empty<Assert>();
    }
}