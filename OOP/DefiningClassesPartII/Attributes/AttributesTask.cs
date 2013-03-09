using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
    AllowMultiple = true)]
    public class VersionAttribute : System.Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }

    [VersionAttribute(1, 2)]
    [VersionAttribute(2, 1)]
    [VersionAttribute(3, 4)]
    [VersionAttribute(4, 3)]
    class AttributesTask
    {
        static void Main(string[] args)
        {
            Type type = typeof(AttributesTask);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute version in allAttributes)
            {
                Console.WriteLine("Version : {0}.{1}",
                    version.Major, version.Minor);
            }
        }
    }
}
