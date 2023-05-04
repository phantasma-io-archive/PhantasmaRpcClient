using Phantasma.RPC.Sharp.Client;
using Phantasma.RPC.Sharp.Model;
using RestSharp;

namespace Phantasma.RPC.Sharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokenApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="iDtext"></param>
        /// <param name="extended"></param>
        /// <returns>TokenDataResult</returns>
        TokenDataResult ApiV1GetNFTGet (string symbol, string iDtext, bool? extended);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="iDText"></param>
        /// <param name="extended"></param>
        /// <returns>List&lt;TokenDataResult&gt;</returns>
        List<TokenDataResult> ApiV1GetNFTsGet (string symbol, string iDText, bool? extended);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="account"></param>
        /// <param name="tokenSymbol"></param>
        /// <param name="chainInput"></param>
        /// <returns>BalanceResult</returns>
        BalanceResult ApiV1GetTokenBalanceGet (string account, string tokenSymbol, string chainInput);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="iDtext"></param>
        /// <returns>TokenDataResult</returns>
        TokenDataResult ApiV1GetTokenDataGet (string symbol, string iDtext);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="extended"></param>
        /// <returns>TokenResult</returns>
        TokenResult ApiV1GetTokenGet (string symbol, bool? extended);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="extended"></param>
        /// <returns>List&lt;TokenResult&gt;</returns>
        List<TokenResult> ApiV1GetTokensGet (bool? extended);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TokenApi : ITokenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TokenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokenApi(String basePath)
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
        /// <param name="symbol"></param>
        /// <param name="iDtext"></param>
        /// <param name="extended"></param>
        /// <returns>TokenDataResult</returns>
        public TokenDataResult ApiV1GetNFTGet (string symbol, string iDtext, bool? extended)
        {
    
            var path = "/api/v1/GetNFT";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (symbol != null) queryParams.Add("symbol", ApiClient.ParameterToString(symbol)); // query parameter
 if (iDtext != null) queryParams.Add("IDtext", ApiClient.ParameterToString(iDtext)); // query parameter
 if (extended != null) queryParams.Add("extended", ApiClient.ParameterToString(extended)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetNFTGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetNFTGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TokenDataResult) ApiClient.Deserialize(response.Content, typeof(TokenDataResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="iDText"></param>
        /// <param name="extended"></param>
        /// <returns>List&lt;TokenDataResult&gt;</returns>
        public List<TokenDataResult> ApiV1GetNFTsGet (string symbol, string iDText, bool? extended)
        {
    
            var path = "/api/v1/GetNFTs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (symbol != null) queryParams.Add("symbol", ApiClient.ParameterToString(symbol)); // query parameter
 if (iDText != null) queryParams.Add("IDText", ApiClient.ParameterToString(iDText)); // query parameter
 if (extended != null) queryParams.Add("extended", ApiClient.ParameterToString(extended)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetNFTsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetNFTsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TokenDataResult>) ApiClient.Deserialize(response.Content, typeof(List<TokenDataResult>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="account"></param>
        /// <param name="tokenSymbol"></param>
        /// <param name="chainInput"></param>
        /// <returns>BalanceResult</returns>
        public BalanceResult ApiV1GetTokenBalanceGet (string account, string tokenSymbol, string chainInput)
        {
    
            var path = "/api/v1/GetTokenBalance";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (account != null) queryParams.Add("account", ApiClient.ParameterToString(account)); // query parameter
 if (tokenSymbol != null) queryParams.Add("tokenSymbol", ApiClient.ParameterToString(tokenSymbol)); // query parameter
 if (chainInput != null) queryParams.Add("chainInput", ApiClient.ParameterToString(chainInput)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetTokenBalanceGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetTokenBalanceGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BalanceResult) ApiClient.Deserialize(response.Content, typeof(BalanceResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="iDtext"></param>
        /// <returns>TokenDataResult</returns>
        public TokenDataResult ApiV1GetTokenDataGet (string symbol, string iDtext)
        {
    
            var path = "/api/v1/GetTokenData";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (symbol != null) queryParams.Add("symbol", ApiClient.ParameterToString(symbol)); // query parameter
 if (iDtext != null) queryParams.Add("IDtext", ApiClient.ParameterToString(iDtext)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetTokenDataGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetTokenDataGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TokenDataResult) ApiClient.Deserialize(response.Content, typeof(TokenDataResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="extended"></param>
        /// <returns>TokenResult</returns>
        public TokenResult ApiV1GetTokenGet (string symbol, bool? extended)
        {
    
            var path = "/api/v1/GetToken";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (symbol != null) queryParams.Add("symbol", ApiClient.ParameterToString(symbol)); // query parameter
 if (extended != null) queryParams.Add("extended", ApiClient.ParameterToString(extended)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetTokenGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetTokenGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TokenResult) ApiClient.Deserialize(response.Content, typeof(TokenResult), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="extended"></param>
        /// <returns>List&lt;TokenResult&gt;</returns>
        public List<TokenResult> ApiV1GetTokensGet (bool? extended)
        {
    
            var path = "/api/v1/GetTokens";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (extended != null) queryParams.Add("extended", ApiClient.ParameterToString(extended)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetTokensGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetTokensGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TokenResult>) ApiClient.Deserialize(response.Content, typeof(List<TokenResult>), response.Headers);
        }
    
    }
}
