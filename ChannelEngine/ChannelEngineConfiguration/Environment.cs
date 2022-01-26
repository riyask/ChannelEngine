using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelEngineConfiguration
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class Environment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Environment"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <exception cref="System.ArgumentNullException">name</exception>
        public Environment(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            Name = name;
        }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; }
        /// <summary>
        /// The dev
        /// </summary>
        public static readonly Environment DEV = new Environment("DEV");
        /// <summary>
        /// The qa
        /// </summary>
        public static readonly Environment QA = new Environment("QA");
        /// <summary>
        /// The uat
        /// </summary>
        public static readonly Environment UAT = new Environment("UAT");
        /// <summary>
        /// The product
        /// </summary>
        public static readonly Environment PROD = new Environment("PROD");
    }
}
