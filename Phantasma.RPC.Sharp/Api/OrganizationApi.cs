using Phantasma.RPC.Sharp.Client;
using Phantasma.RPC.Sharp.Model;
using RestSharp;

namespace Phantasma.RPC.Sharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganizationApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>OrganizationResult</returns>
        OrganizationResult GetOrganization(string ID);

        /// <summary>
        ///  
        /// </summary>
        /// <returns>OrganizationResult</returns>
        IList<OrganizationResult> GetOrganizations();

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name"></param>
        /// <returns>OrganizationResult</returns>
        OrganizationResult GetOrganizationByName(string name);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrganizationApi : IOrganizationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrganizationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrganizationApi(String basePath)
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
        /// <param name="ID"></param>
        /// <returns>OrganizationResult</returns>
        public OrganizationResult GetOrganization(string ID)
        {
            var path = "/api/v1/GetOrganization";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (ID != null) queryParams.Add("ID", ApiClient.ParameterToString(ID)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
                headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetOrganizationGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetOrganizationGet: " + response.ErrorMessage, response.ErrorMessage);

            return (OrganizationResult)ApiClient.Deserialize(response.Content, typeof(OrganizationResult),
                response.Headers);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>OrganizationResult</returns>
        public OrganizationResult GetOrganizationByName(string name)
        {
            var path = "/api/v1/GetOrganizationByName";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
                headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetOrganizationByName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetOrganizationByName: " + response.ErrorMessage, response.ErrorMessage);

            return (OrganizationResult)ApiClient.Deserialize(response.Content, typeof(OrganizationResult),
                response.Headers);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>OrganizationResult</returns>
        public IList<OrganizationResult> GetOrganizations()
        {
            var path = "/api/v1/GetOrganizations";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            RestResponseBase response = (RestResponseBase)ApiClient.CallApi(path, Method.Get, queryParams, postBody,
                headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetOrganizations: " + response.Content,
                    response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode,
                    "Error calling GetOrganizations: " + response.ErrorMessage, response.ErrorMessage);

            return (IList<OrganizationResult>)ApiClient.Deserialize(response.Content, typeof(IList<OrganizationResult>),
                response.Headers);
        }
    }
}