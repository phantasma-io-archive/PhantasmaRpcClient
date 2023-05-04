namespace Phantasma.RPC.Sharp.Api
{
    /*/// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConnectionApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="account"></param>
        /// <returns>AccountResult</returns>
        AccountResult ApiV1GetAbciQuery(string path, string data, int height, bool prove = false);
        
        /// <summary>
        ///  
        /// </summary>
        /// <returns>List&lt;AccountResult&gt;</returns>
        List<AccountResult> ApiV1GetHealth ();
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns>List&lt;AccountResult&gt;</returns>
        List<AccountResult> ApiV1GetStatus();
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <returns>string</returns>
        List<AccountResult> ApiV1GetNetInfo();
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <returns>string</returns>
        List<AccountResult> ApiV1GetRequestBlock(int height);
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <returns>string</returns>
        List<AccountResult> ApiV1GetValidatorsSettings();

    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConnectionApi : IConnectionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConnectionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConnectionApi(String basePath)
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
        /// <returns>AccountResult</returns>
        public AccountResult ApiV1GetAccountGet (string account)
        {
    
            var path = "/api/v1/GetAccount";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (account != null) queryParams.Add("account", ApiClient.ParameterToString(account)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetAccountGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetAccountGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountResult) ApiClient.Deserialize(response.Content, typeof(AccountResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="accountText"></param>
        /// <returns>List&lt;AccountResult&gt;</returns>
        public List<AccountResult> ApiV1GetAccountsGet (string accountText)
        {
    
            var path = "/api/v1/GetAccounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountText != null) queryParams.Add("accountText", ApiClient.ParameterToString(accountText)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetAccountsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetAccountsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountResult>) ApiClient.Deserialize(response.Content, typeof(List<AccountResult>), response.Headers);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <param name="accountText"></param>
        /// <returns>List&lt;AccountResult&gt;</returns>
        public List<AccountResult> ApiV1GetAddressesBySymbol (string symbol)
        {
    
            var path = "/api/v1/GetAccounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            if (symbol != null) queryParams.Add("accountText", ApiClient.ParameterToString(symbol)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetAccountsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetAccountsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountResult>) ApiClient.Deserialize(response.Content, typeof(List<AccountResult>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <returns>string</returns>
        public string ApiV1LookUpNameGet (string name)
        {
    
            var path = "/api/v1/LookUpName";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1LookUpNameGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1LookUpNameGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
    }*/
}
