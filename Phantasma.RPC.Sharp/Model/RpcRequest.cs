using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Phantasma.RPC.Sharp.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RpcRequest
    {
        /// <summary>
        /// Gets or Sets Jsonrpc
        /// </summary>
        [DataMember(Name = "jsonrpc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "jsonrpc")]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name = "params", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "params")]
        public List<object> Params { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RpcRequest {\n");
            sb.Append("  Jsonrpc: ").Append(Jsonrpc).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}