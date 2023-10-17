using Phantasma.RPC.Sharp.Client;
using Phantasma.RPC.Sharp.Model;
using RestSharp;

namespace Phantasma.RPC.Sharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBlockApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="blockHash"></param>
        /// <returns>BlockResult</returns>
        BlockResult GetBlockByHash (string blockHash);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainInput"></param>
        /// <param name="height"></param>
        /// <returns>BlockResult</returns>
        BlockResult GetBlockByHeight (string chainInput, int? height);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainInput"></param>
        /// <returns>string</returns>
        string GetBlockHeight (string chainInput);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="blockHash"></param>
        /// <returns>int?</returns>
        int? GetBlockTransactionCountByHash (string chainAddressOrName, string blockHash);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="blockHash"></param>
        /// <returns>string</returns>
        string GetRawBlockByHash (string blockHash);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainInput"></param>
        /// <param name="height"></param>
        /// <returns>string</returns>
        string GetRawBlockByHeight (string chainInput, int? height);
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainInput"></param>
        /// <returns>BlockResult</returns>
        BlockResult GetLatestBlock (string chainInput);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainInput"></param>
        /// <returns>string</returns>
        string GetRawLatestBlock (string chainInput);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BlockApi : IBlockApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BlockApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BlockApi(String basePath)
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
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="blockHash"></param>
        /// <returns>BlockResult</returns>
        public BlockResult GetBlockByHash (string blockHash)
        {
    
            var path = "/api/v1/GetBlockByHash";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (blockHash != null) queryParams.Add("blockHash", ApiClient.ParameterToString(blockHash)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlockByHashGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlockByHashGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BlockResult) ApiClient.Deserialize(response.Content, typeof(BlockResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainInput"></param>
        /// <param name="height"></param>
        /// <returns>BlockResult</returns>
        public BlockResult GetBlockByHeight (string chainInput, int? height)
        {
    
            var path = "/api/v1/GetBlockByHeight";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (chainInput != null) queryParams.Add("chainInput", ApiClient.ParameterToString(chainInput)); // query parameter
 if (height != null) queryParams.Add("height", ApiClient.ParameterToString(height)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlockByHeightGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlockByHeightGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BlockResult) ApiClient.Deserialize(response.Content, typeof(BlockResult), response.Headers);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainInput"></param>
        /// <param name="height"></param>
        /// <returns>BlockResult</returns>
        public BlockResult GetLatestBlock (string chainInput)
        {
    
            var path = "/api/v1/GetBlockByHeight";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            if (chainInput != null) queryParams.Add("chainInput", ApiClient.ParameterToString(chainInput)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlockByHeightGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlockByHeightGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BlockResult) ApiClient.Deserialize(response.Content, typeof(BlockResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainInput"></param>
        /// <returns>string</returns>
        public string GetBlockHeight (string chainInput)
        {
    
            var path = "/api/v1/GetBlockHeight";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (chainInput != null) queryParams.Add("chainInput", ApiClient.ParameterToString(chainInput)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlockHeightGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlockHeightGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="blockHash"></param>
        /// <returns>int?</returns>
        public int? GetBlockTransactionCountByHash (string chainAddressOrName, string blockHash)
        {
    
            var path = "/api/v1/GetBlockTransactionCountByHash";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (chainAddressOrName != null) queryParams.Add("chainAddressOrName", ApiClient.ParameterToString(chainAddressOrName)); // query parameter
 if (blockHash != null) queryParams.Add("blockHash", ApiClient.ParameterToString(blockHash)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlockTransactionCountByHashGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBlockTransactionCountByHashGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="blockHash"></param>
        /// <returns>string</returns>
        public string GetRawBlockByHash (string blockHash)
        {
    
            var path = "/api/v1/GetRawBlockByHash";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (blockHash != null) queryParams.Add("blockHash", ApiClient.ParameterToString(blockHash)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRawBlockByHashGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRawBlockByHashGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainInput"></param>
        /// <param name="height"></param>
        /// <returns>string</returns>
        public string GetRawBlockByHeight (string chainInput, int? height)
        {
    
            var path = "/api/v1/GetRawBlockByHeight";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (chainInput != null) queryParams.Add("chainInput", ApiClient.ParameterToString(chainInput)); // query parameter
 if (height != null) queryParams.Add("height", ApiClient.ParameterToString(height)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRawBlockByHeightGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRawBlockByHeightGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainInput"></param>
        /// <param name="height"></param>
        /// <returns>string</returns>
        public string GetRawLatestBlock (string chainInput)
        {
    
            var path = "/api/v1/GetRawBlockByHeight";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            if (chainInput != null) queryParams.Add("chainInput", ApiClient.ParameterToString(chainInput)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRawBlockByHeightGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRawBlockByHeightGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
    }
}
