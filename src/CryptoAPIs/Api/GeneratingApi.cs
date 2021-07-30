/*
 * CryptoAPIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: developers@cryptoapis.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace CryptoAPIs.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGeneratingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate Deposit Address
        /// </summary>
        /// <remarks>
        /// Through this endpoint customers can generate a new Receiving/Deposit Addresses into their Wallet.
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="walletId">Represents the unique ID of the specific Wallet.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="generateDepositAddressRB"> (optional)</param>
        /// <returns>GenerateDepositAddressR</returns>
        GenerateDepositAddressR GenerateDepositAddress(string blockchain, string network, string walletId, string context = default(string), GenerateDepositAddressRB generateDepositAddressRB = default(GenerateDepositAddressRB));

        /// <summary>
        /// Generate Deposit Address
        /// </summary>
        /// <remarks>
        /// Through this endpoint customers can generate a new Receiving/Deposit Addresses into their Wallet.
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="walletId">Represents the unique ID of the specific Wallet.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="generateDepositAddressRB"> (optional)</param>
        /// <returns>ApiResponse of GenerateDepositAddressR</returns>
        ApiResponse<GenerateDepositAddressR> GenerateDepositAddressWithHttpInfo(string blockchain, string network, string walletId, string context = default(string), GenerateDepositAddressRB generateDepositAddressRB = default(GenerateDepositAddressRB));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGeneratingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Generate Deposit Address
        /// </summary>
        /// <remarks>
        /// Through this endpoint customers can generate a new Receiving/Deposit Addresses into their Wallet.
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="walletId">Represents the unique ID of the specific Wallet.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="generateDepositAddressRB"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GenerateDepositAddressR</returns>
        System.Threading.Tasks.Task<GenerateDepositAddressR> GenerateDepositAddressAsync(string blockchain, string network, string walletId, string context = default(string), GenerateDepositAddressRB generateDepositAddressRB = default(GenerateDepositAddressRB), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Generate Deposit Address
        /// </summary>
        /// <remarks>
        /// Through this endpoint customers can generate a new Receiving/Deposit Addresses into their Wallet.
        /// </remarks>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="walletId">Represents the unique ID of the specific Wallet.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="generateDepositAddressRB"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GenerateDepositAddressR)</returns>
        System.Threading.Tasks.Task<ApiResponse<GenerateDepositAddressR>> GenerateDepositAddressWithHttpInfoAsync(string blockchain, string network, string walletId, string context = default(string), GenerateDepositAddressRB generateDepositAddressRB = default(GenerateDepositAddressRB), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGeneratingApi : IGeneratingApiSync, IGeneratingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GeneratingApi : IGeneratingApi
    {
        private CryptoAPIs.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GeneratingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GeneratingApi(string basePath)
        {
            this.Configuration = CryptoAPIs.Client.Configuration.MergeConfigurations(
                CryptoAPIs.Client.GlobalConfiguration.Instance,
                new CryptoAPIs.Client.Configuration { BasePath = basePath }
            );
            this.Client = new CryptoAPIs.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CryptoAPIs.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = CryptoAPIs.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GeneratingApi(CryptoAPIs.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = CryptoAPIs.Client.Configuration.MergeConfigurations(
                CryptoAPIs.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new CryptoAPIs.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new CryptoAPIs.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = CryptoAPIs.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GeneratingApi(CryptoAPIs.Client.ISynchronousClient client, CryptoAPIs.Client.IAsynchronousClient asyncClient, CryptoAPIs.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = CryptoAPIs.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public CryptoAPIs.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public CryptoAPIs.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public CryptoAPIs.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CryptoAPIs.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Generate Deposit Address Through this endpoint customers can generate a new Receiving/Deposit Addresses into their Wallet.
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="walletId">Represents the unique ID of the specific Wallet.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="generateDepositAddressRB"> (optional)</param>
        /// <returns>GenerateDepositAddressR</returns>
        public GenerateDepositAddressR GenerateDepositAddress(string blockchain, string network, string walletId, string context = default(string), GenerateDepositAddressRB generateDepositAddressRB = default(GenerateDepositAddressRB))
        {
            CryptoAPIs.Client.ApiResponse<GenerateDepositAddressR> localVarResponse = GenerateDepositAddressWithHttpInfo(blockchain, network, walletId, context, generateDepositAddressRB);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate Deposit Address Through this endpoint customers can generate a new Receiving/Deposit Addresses into their Wallet.
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="walletId">Represents the unique ID of the specific Wallet.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="generateDepositAddressRB"> (optional)</param>
        /// <returns>ApiResponse of GenerateDepositAddressR</returns>
        public CryptoAPIs.Client.ApiResponse<GenerateDepositAddressR> GenerateDepositAddressWithHttpInfo(string blockchain, string network, string walletId, string context = default(string), GenerateDepositAddressRB generateDepositAddressRB = default(GenerateDepositAddressRB))
        {
            // verify the required parameter 'blockchain' is set
            if (blockchain == null)
                throw new CryptoAPIs.Client.ApiException(400, "Missing required parameter 'blockchain' when calling GeneratingApi->GenerateDepositAddress");

            // verify the required parameter 'network' is set
            if (network == null)
                throw new CryptoAPIs.Client.ApiException(400, "Missing required parameter 'network' when calling GeneratingApi->GenerateDepositAddress");

            // verify the required parameter 'walletId' is set
            if (walletId == null)
                throw new CryptoAPIs.Client.ApiException(400, "Missing required parameter 'walletId' when calling GeneratingApi->GenerateDepositAddress");

            CryptoAPIs.Client.RequestOptions localVarRequestOptions = new CryptoAPIs.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = CryptoAPIs.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CryptoAPIs.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("blockchain", CryptoAPIs.Client.ClientUtils.ParameterToString(blockchain)); // path parameter
            localVarRequestOptions.PathParameters.Add("network", CryptoAPIs.Client.ClientUtils.ParameterToString(network)); // path parameter
            localVarRequestOptions.PathParameters.Add("walletId", CryptoAPIs.Client.ClientUtils.ParameterToString(walletId)); // path parameter
            if (context != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "context", context));
            }
            localVarRequestOptions.Data = generateDepositAddressRB;

            // authentication (ApiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<GenerateDepositAddressR>("/wallet-as-a-service/wallets/{walletId}/{blockchain}/{network}/addresses", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GenerateDepositAddress", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Generate Deposit Address Through this endpoint customers can generate a new Receiving/Deposit Addresses into their Wallet.
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="walletId">Represents the unique ID of the specific Wallet.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="generateDepositAddressRB"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GenerateDepositAddressR</returns>
        public async System.Threading.Tasks.Task<GenerateDepositAddressR> GenerateDepositAddressAsync(string blockchain, string network, string walletId, string context = default(string), GenerateDepositAddressRB generateDepositAddressRB = default(GenerateDepositAddressRB), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            CryptoAPIs.Client.ApiResponse<GenerateDepositAddressR> localVarResponse = await GenerateDepositAddressWithHttpInfoAsync(blockchain, network, walletId, context, generateDepositAddressRB, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate Deposit Address Through this endpoint customers can generate a new Receiving/Deposit Addresses into their Wallet.
        /// </summary>
        /// <exception cref="CryptoAPIs.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</param>
        /// <param name="walletId">Represents the unique ID of the specific Wallet.</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. (optional)</param>
        /// <param name="generateDepositAddressRB"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GenerateDepositAddressR)</returns>
        public async System.Threading.Tasks.Task<CryptoAPIs.Client.ApiResponse<GenerateDepositAddressR>> GenerateDepositAddressWithHttpInfoAsync(string blockchain, string network, string walletId, string context = default(string), GenerateDepositAddressRB generateDepositAddressRB = default(GenerateDepositAddressRB), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'blockchain' is set
            if (blockchain == null)
                throw new CryptoAPIs.Client.ApiException(400, "Missing required parameter 'blockchain' when calling GeneratingApi->GenerateDepositAddress");

            // verify the required parameter 'network' is set
            if (network == null)
                throw new CryptoAPIs.Client.ApiException(400, "Missing required parameter 'network' when calling GeneratingApi->GenerateDepositAddress");

            // verify the required parameter 'walletId' is set
            if (walletId == null)
                throw new CryptoAPIs.Client.ApiException(400, "Missing required parameter 'walletId' when calling GeneratingApi->GenerateDepositAddress");


            CryptoAPIs.Client.RequestOptions localVarRequestOptions = new CryptoAPIs.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = CryptoAPIs.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = CryptoAPIs.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("blockchain", CryptoAPIs.Client.ClientUtils.ParameterToString(blockchain)); // path parameter
            localVarRequestOptions.PathParameters.Add("network", CryptoAPIs.Client.ClientUtils.ParameterToString(network)); // path parameter
            localVarRequestOptions.PathParameters.Add("walletId", CryptoAPIs.Client.ClientUtils.ParameterToString(walletId)); // path parameter
            if (context != null)
            {
                localVarRequestOptions.QueryParameters.Add(CryptoAPIs.Client.ClientUtils.ParameterToMultiMap("", "context", context));
            }
            localVarRequestOptions.Data = generateDepositAddressRB;

            // authentication (ApiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<GenerateDepositAddressR>("/wallet-as-a-service/wallets/{walletId}/{blockchain}/{network}/addresses", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GenerateDepositAddress", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
