using Phantasma.RPC.Sharp.Client;
using Phantasma.RPC.Sharp.Model;
using RestSharp;

namespace Phantasma.RPC.Sharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPlatformApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <returns>List&lt;PlatformResult&gt;</returns>
        List<PlatformResult> ApiV1GetPlatformsGet ();
        
        PlatformResult ApiV1GetPlatform (string platform);
        
        PlatformResult ApiV1GetInterop (string platform);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PlatformApi : IPlatformApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PlatformApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlatformApi(String basePath)
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
        /// <returns>List&lt;PlatformResult&gt;</returns>
        public List<PlatformResult> ApiV1GetPlatformsGet ()
        {
            var path = "/api/v1/GetPlatforms";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetPlatformsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetPlatformsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PlatformResult>) ApiClient.Deserialize(response.Content, typeof(List<PlatformResult>), response.Headers);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <returns>List&lt;PlatformResult&gt;</returns>
        public PlatformResult ApiV1GetPlatform (string platform)
        {
            var path = "/api/v1/GetPlatform";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            if (platform != null) queryParams.Add("platform", ApiClient.ParameterToString(platform)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetPlatformsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetPlatformsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PlatformResult) ApiClient.Deserialize(response.Content, typeof(PlatformResult), response.Headers);
        }
        
        /// <summary>
        ///  
        /// </summary>
        /// <returns>List&lt;PlatformResult&gt;</returns>
        public PlatformResult ApiV1GetInterop (string platform)
        {
            var path = "/api/v1/GetInterop";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            if (platform != null) queryParams.Add("platform", ApiClient.ParameterToString(platform)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
             RestResponseBase response = ( RestResponseBase) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetInterop: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiV1GetInterop: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PlatformResult) ApiClient.Deserialize(response.Content, typeof(PlatformResult), response.Headers);
        }
    
    }
}
