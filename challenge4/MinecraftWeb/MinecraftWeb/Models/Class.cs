using System.Collections.Generic;

namespace MinecraftWeb.Models
{
    public class Metadata
    {
        public Metadata(string name)
        {
            this.name = name;
        }

        public string name { get; set; }
    }

    public class Port
    {
        public int port { get; set; }
        public string name { get; set; }
    }

    public class Selector
    {
        public string app { get; set; }
    }

    public class Spec
    {
        public string type { get; set; }
        public List<Port> ports { get; set; }
        public Selector selector { get; set; }
    }

    public class RootObject
    {
        public RootObject()
        {
            apiVersion = "v1";
            kind = "Service";
            metadata = new Metadata("minicraft-server-service");
        }

        public string apiVersion { get; set; }
        public string kind { get; set; }
        public Metadata metadata { get; set; }
        public Spec spec { get; set; }
    }
}
