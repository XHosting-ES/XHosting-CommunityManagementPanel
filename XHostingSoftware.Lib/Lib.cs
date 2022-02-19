using System.Collections.Generic;

namespace XHostingSoftware.Lib
{
    public class Lib : ILibs
    {
        public bool EnableLibs { get; set; } = true;
        public List<string> LibsToLoad { get; set; } = new List<string>()
        {
            "LibXML",
            "MySqlConnector",
            "XHostingSoftware",
            "EncryptLoader"
        };
    }
    public interface ILibs
    {
        bool EnableLibs { get; set; }
    }
}
