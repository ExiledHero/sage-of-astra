using SageOfAstra.Services;

namespace SageOfAstra.Configs
{
    public class AliasTrackingConfig
    {
        public bool Enabled { get; set; }

        public AliasTrackingConfig()
        {

        }

        public AliasTrackingConfig(AliasTrackingService service)
        {
            Enabled = service.Enabled;
        }
    }
}
