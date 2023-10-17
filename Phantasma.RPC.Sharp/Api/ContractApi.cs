using Phantasma.RPC.Sharp.Client;
using Phantasma.RPC.Sharp.Model;
using RestSharp;

namespace Phantasma.RPC.Sharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContractApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="contractName"></param>
        /// <returns>ContractResult</returns>
        ContractResult GetContract(string chainAddressOrName, string contractName);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="contractName"></param>
        /// <returns>ContractResult</returns>
        ContractResult GetContractByAddress(string chainAddressOrName, string contractAddress);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <returns>ContractResult</returns>
        IList<ContractResult> GetContracts(string chainAddressOrName);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContractApi : IContractApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContractApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContractApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="contractName"></param>
        /// <returns>ContractResult</returns>
        public ContractResult GetContract(string chainAddressOrName, string contractName)
        {
            var path = "/api/v1/GetContract";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (chainAddressOrName != null)
                queryParams.Add("chainAddressOrName",
                    ApiClient.ParameterToString(chainAddressOrName)); // query parameter
            if (contractName != null)
                queryParams.Add("contractName", ApiClient.ParameterToString(contractName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
                headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetContractGet: " + response.Content,
                    response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetContractGet: " + response.ErrorMessage, response.ErrorMessage);

            return (ContractResult)ApiClient.Deserialize(response.Content, typeof(ContractResult), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="contractName"></param>
        /// <returns>ContractResult</returns>
        public ContractResult GetContractByAddress(string chainAddressOrName, string contractAddress)
        {
            var path = "/api/v1/GetContractByAddress";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (chainAddressOrName != null)
                queryParams.Add("chainAddressOrName",
                    ApiClient.ParameterToString(chainAddressOrName)); // query parameter
            if (contractAddress != null)
                queryParams.Add("contractAddress", ApiClient.ParameterToString(contractAddress)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
                headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetContractGet: " + response.Content,
                    response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetContractGet: " + response.ErrorMessage, response.ErrorMessage);

            return (ContractResult)ApiClient.Deserialize(response.Content, typeof(ContractResult), response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="contractName"></param>
        /// <returns>ContractResult</returns>
        public IList<ContractResult> GetContracts(string chainAddressOrName)
        {
            var path = "/api/v1/GetContracts";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (chainAddressOrName != null)
                queryParams.Add("chainAddressOrName",
                    ApiClient.ParameterToString(chainAddressOrName)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
                headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetContractsGet: " + response.Content,
                    response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetContractsGet: " + response.ErrorMessage, response.ErrorMessage);

            return (IList<ContractResult>)ApiClient.Deserialize(response.Content, typeof(IList<ContractResult>),
                response.Headers);
        }
    }
}