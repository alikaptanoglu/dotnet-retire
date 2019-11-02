using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RetireNet.Packages.Tool.Services
{
    public class ResourceReader
    {
        public async Task<Overrides> GetOverriddenPackages()
        {
            var xmlString = await File.ReadAllTextAsync("Services/Resources/Overrides.xml");
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(xmlString));
            var serializer = new XmlSerializer(typeof(Overrides));
            var overrides = (Overrides)serializer.Deserialize(ms);
            return overrides;
        }


    }
    public class Overrides
    {
        public AllOverrides AllOverrides { get; set; }
    }

    public class AllOverrides
    {
        public PackageConflictOverrides PackageConflictOverrides { get; set; }
    }

    public class PackageConflictOverrides
    {
        /*
         A pipe delimited package list using newline as a separator

         Example:
            Microsoft.CSharp|4.4.0;
            Microsoft.Win32.Primitives|4.3.0;
            Microsoft.Win32.Registry|4.4.0;
         */
        public string OverriddenPackages { get; set; }
    }
}
