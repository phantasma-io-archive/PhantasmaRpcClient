using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="account"></param>
        /// <param name="chainInput"></param>
        /// <returns>int?</returns>
        int? ApiV1GetAddressTransactionCountGet (string account, string chainInput);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="account"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns>PaginatedResult</returns>
        PaginatedResult ApiV1GetAddressTransactionsGet (string account, int? page, int? pageSize);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="blockHash"></param>
        /// <param name="index"></param>
        /// <returns>TransactionResult</returns>
        TransactionResult ApiV1GetTransactionByBlockHashAndIndexGet (string chainAddressOrName, string blockHash, int? index);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransactionApi : ITransactionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransactionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionApi(String basePath)
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
        /// <param name="account"></param>
        /// <param name="chainInput"></param>
        /// <returns>int?</returns>
        public int? ApiV1GetAddressTransactionCountGet (string account, string chainInput)
        {
    
            var path = "/api/v1/GetAddressTransactionCount";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (account != null) queryParams.Add("account", ApiClient.ParameterToString(account)); // query parameter
 if (chainInput != null) queryParams.Add("chainInput", ApiClient.ParameterToString(chainInput)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetAddressTransactionCountGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetAddressTransactionCountGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="account"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns>PaginatedResult</returns>
        public PaginatedResult ApiV1GetAddressTransactionsGet (string account, int? page, int? pageSize)
        {
    
            var path = "/api/v1/GetAddressTransactions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (account != null) queryParams.Add("account", ApiClient.ParameterToString(account)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetAddressTransactionsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetAddressTransactionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedResult) ApiClient.Deserialize(response.Content, typeof(PaginatedResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainAddressOrName"></param>
        /// <param name="blockHash"></param>
        /// <param name="index"></param>
        /// <returns>TransactionResult</returns>
        public TransactionResult ApiV1GetTransactionByBlockHashAndIndexGet (string chainAddressOrName, string blockHash, int? index)
        {
    
            var path = "/api/v1/GetTransactionByBlockHashAndIndex";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (chainAddressOrName != null) queryParams.Add("chainAddressOrName", ApiClient.ParameterToString(chainAddressOrName)); // query parameter
 if (blockHash != null) queryParams.Add("blockHash", ApiClient.ParameterToString(blockHash)); // query parameter
 if (index != null) queryParams.Add("index", ApiClient.ParameterToString(index)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetTransactionByBlockHashAndIndexGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetTransactionByBlockHashAndIndexGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransactionResult) ApiClient.Deserialize(response.Content, typeof(TransactionResult), response.Headers);
        }
    
    }
}
