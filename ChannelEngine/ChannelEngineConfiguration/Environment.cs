using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineConfiguration
{

    public sealed class Environment
    {
        public Environment(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            Name = name;
        }
        public string Name { get; }
        public static readonly Environment DEV = new Environment("DEV");
        public static readonly Environment QA = new Environment("QA");
        public static readonly Environment UAT = new Environment("UAT");
        public static readonly Environment PROD = new Environment("PROD");
    }
}
