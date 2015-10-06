using System.Configuration;

namespace GesRunner
{
    public class EventStoreServiceConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("serviceName", IsRequired = true)]
        public string ServiceName
        {
            get { return (string)this["serviceName"]; }
            set { this["serviceName"] = value; }
        }

        [ConfigurationProperty("executable", IsRequired = true)]
        public string Executable
        {
            get { return (string)this["executable"]; }
            set { this["executable"] = value; }
        }

        [ConfigurationProperty("description", IsRequired = false, DefaultValue = "Event Store")]
        public string Description
        {
            get { return (string)this["description"]; }
            set { this["description"] = value; }
        }

        [ConfigurationProperty("esconfigPath", IsRequired = true)]
        public string ConfigPath
        {
            get { return (string)this["esconfigPath"]; }
            set { this["esconfigPath"] = value; }
        }
    }
}
