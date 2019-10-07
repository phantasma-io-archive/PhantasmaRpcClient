using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class PeerDto
    {
        [JsonProperty("Url")]
        public string Url;

        [JsonProperty("version")]
        public string Version;

        [JsonProperty("flags")]
        public string Flags;

        [JsonProperty("fee")]
        public string Fee;

        [JsonProperty("pow")]
        public uint Pow;
    }
}
