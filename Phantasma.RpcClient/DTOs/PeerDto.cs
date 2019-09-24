using Newtonsoft.Json;

namespace Phantasma.RpcClient.DTOs
{
    public class PeerDto
    {
        [JsonProperty("Url")]
        public string Url;

        [JsonProperty("flags")]
        public string Flags;

        [JsonProperty("fee")]
        public string Fee;

        [JsonProperty("pow")]
        public uint Pow;
    }
}
