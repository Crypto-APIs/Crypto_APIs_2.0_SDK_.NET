# CryptoAPIs.Api.OmniLayerApi

All URIs are relative to *https://rest.cryptoapis.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOmniTransactionDetailsByTransactionIDTxid**](OmniLayerApi.md#getomnitransactiondetailsbytransactionidtxid) | **GET** /blockchain-data/{blockchain}/{network}/omni/transactions/{transactionId} | Get Omni Transaction Details By Transaction ID (Txid)
[**GetUnconfirmedOmniTransactionByTransactionIDTxid**](OmniLayerApi.md#getunconfirmedomnitransactionbytransactionidtxid) | **GET** /blockchain-data/{blockchain}/{network}/omni/transactions-unconfirmed/{transactionId} | Get Unconfirmed Omni Transaction By Transaction ID (Txid)
[**ListOmniTokensByAddress**](OmniLayerApi.md#listomnitokensbyaddress) | **GET** /blockchain-data/{blockchain}/{network}/omni/addresses/{address} | List Omni Tokens By Address
[**ListOmniTransactionsByAddress**](OmniLayerApi.md#listomnitransactionsbyaddress) | **GET** /blockchain-data/{blockchain}/{network}/omni/addresses/{address}/transactions | List Omni Transactions By Address
[**ListOmniTransactionsByBlockHash**](OmniLayerApi.md#listomnitransactionsbyblockhash) | **GET** /blockchain-data/{blockchain}/{network}/omni/blocks/hash/{blockHash}/transactions | List Omni Transactions By Block Hash
[**ListOmniTransactionsByBlockHeight**](OmniLayerApi.md#listomnitransactionsbyblockheight) | **GET** /blockchain-data/{blockchain}/{network}/omni/blocks/height/{blockHeight}/transactions | List Omni Transactions By Block Height
[**ListUnconfirmedOmniTransactionsByAddress**](OmniLayerApi.md#listunconfirmedomnitransactionsbyaddress) | **GET** /blockchain-data/{blockchain}/{network}/omni/address-transactions-unconfirmed/{address} | List Unconfirmed Omni Transactions By Address
[**ListUnconfirmedOmniTransactionsByPropertyID**](OmniLayerApi.md#listunconfirmedomnitransactionsbypropertyid) | **GET** /blockchain-data/{blockchain}/{network}/omni/properties/{propertyId}/transactions | List Unconfirmed Omni Transactions By Property ID


<a name="getomnitransactiondetailsbytransactionidtxid"></a>
# **GetOmniTransactionDetailsByTransactionIDTxid**
> GetOmniTransactionDetailsByTransactionIDTxidR GetOmniTransactionDetailsByTransactionIDTxid (string network, string blockchain, string transactionId, string context = null)

Get Omni Transaction Details By Transaction ID (Txid)

Through this endpoint customers can obtain details about an Omni transaction by the transaction's unique identifier. The transaction can return information such as hash, height, time of creation in Unix timestamp, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetOmniTransactionDetailsByTransactionIDTxidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OmniLayerApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var transactionId = d237ff4a681617b767bf22c4e1e8f5115b95c8c168d6cf53bbdec68529f91ecb;  // string | Represents the unique identifier of a transaction, i.e. it could be `transactionId` in UTXO-based protocols like Bitcoin, and transaction `hash` in Ethereum blockchain.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 

            try
            {
                // Get Omni Transaction Details By Transaction ID (Txid)
                GetOmniTransactionDetailsByTransactionIDTxidR result = apiInstance.GetOmniTransactionDetailsByTransactionIDTxid(network, blockchain, transactionId, context);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OmniLayerApi.GetOmniTransactionDetailsByTransactionIDTxid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
 **transactionId** | **string**| Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 

### Return type

[**GetOmniTransactionDetailsByTransactionIDTxidR**](GetOmniTransactionDetailsByTransactionIDTxidR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **404** | The specified transaction has not been found on the specific blockchain. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getunconfirmedomnitransactionbytransactionidtxid"></a>
# **GetUnconfirmedOmniTransactionByTransactionIDTxid**
> GetUnconfirmedOmniTransactionByTransactionIDTxidR GetUnconfirmedOmniTransactionByTransactionIDTxid (string network, string blockchain, string transactionId, string context = null)

Get Unconfirmed Omni Transaction By Transaction ID (Txid)

Through this endpoint customers can obtain information on unconfirmed Omni transactions by an attribute `transactionId`. The transaction can have information such as hash, height, time of creation in Unix timestamp, etc.    Unconfirmed transactions are usually put in the Mempool and await verification so that they can be added to a block.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetUnconfirmedOmniTransactionByTransactionIDTxidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OmniLayerApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var transactionId = 92f17d3d16a1baf7de570a86179cc263cb9866c66778feec2dce111430f41c08;  // string | Represents the unique identifier of a transaction, i.e. it could be `transactionId` in UTXO-based protocols like Bitcoin, and transaction `hash` in Ethereum blockchain.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 

            try
            {
                // Get Unconfirmed Omni Transaction By Transaction ID (Txid)
                GetUnconfirmedOmniTransactionByTransactionIDTxidR result = apiInstance.GetUnconfirmedOmniTransactionByTransactionIDTxid(network, blockchain, transactionId, context);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OmniLayerApi.GetUnconfirmedOmniTransactionByTransactionIDTxid: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
 **transactionId** | **string**| Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 

### Return type

[**GetUnconfirmedOmniTransactionByTransactionIDTxidR**](GetUnconfirmedOmniTransactionByTransactionIDTxidR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **404** | The specified transaction has not been found on the specific blockchain. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listomnitokensbyaddress"></a>
# **ListOmniTokensByAddress**
> ListOmniTokensByAddressR ListOmniTokensByAddress (string network, string blockchain, string address, string context = null)

List Omni Tokens By Address

Through this endpoint the customer can receive basic information about a given Omni address based on confirmed/synced blocks only. In the case where there are any incoming or outgoing **unconfirmed** transactions for the specific address, they **will not** be counted or calculated here.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListOmniTokensByAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OmniLayerApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var address = mi7iSsKcvyFYNsiYdDZqJmH75RmoHomwmo;  // string | Represents the public address, which is a compressed and shortened form of a public key.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 

            try
            {
                // List Omni Tokens By Address
                ListOmniTokensByAddressR result = apiInstance.ListOmniTokensByAddress(network, blockchain, address, context);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OmniLayerApi.ListOmniTokensByAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
 **address** | **string**| Represents the public address, which is a compressed and shortened form of a public key. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 

### Return type

[**ListOmniTokensByAddressR**](ListOmniTokensByAddressR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listomnitransactionsbyaddress"></a>
# **ListOmniTransactionsByAddress**
> ListOmniTransactionsByAddressR ListOmniTransactionsByAddress (string network, string blockchain, string address, string context = null, int? limit = null, int? offset = null)

List Omni Transactions By Address

This endpoint will list Omni transactions by an attribute `address`. The transactions listed will detail additional information such as hash, height, time of creation in Unix timestamp, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListOmniTransactionsByAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OmniLayerApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var address = mi7iSsKcvyFYNsiYdDZqJmH75RmoHomwmo;  // string | Represents the public address, which is a compressed and shortened form of a public key.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var limit = 50;  // int? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 10;  // int? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)

            try
            {
                // List Omni Transactions By Address
                ListOmniTransactionsByAddressR result = apiInstance.ListOmniTransactionsByAddress(network, blockchain, address, context, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OmniLayerApi.ListOmniTransactionsByAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
 **address** | **string**| Represents the public address, which is a compressed and shortened form of a public key. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 
 **limit** | **int?**| Defines how many items should be returned in the response per page basis. | [optional] [default to 50]
 **offset** | **int?**| The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0]

### Return type

[**ListOmniTransactionsByAddressR**](ListOmniTransactionsByAddressR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listomnitransactionsbyblockhash"></a>
# **ListOmniTransactionsByBlockHash**
> ListOmniTransactionsByBlockHashR ListOmniTransactionsByBlockHash (string network, string blockchain, string blockHash, string context = null, int? limit = null, int? offset = null)

List Omni Transactions By Block Hash

This endpoint will list Omni transactions by an attribute `transactionHash`. The transactions listed will detail additional information such as addresses, height, time of creation in Unix timestamp, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListOmniTransactionsByBlockHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OmniLayerApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var blockHash = 000000000000001f50c9d33d122562daa7fc9582df0b415e626216c37d015818;  // string | Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var limit = 50;  // int? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 10;  // int? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)

            try
            {
                // List Omni Transactions By Block Hash
                ListOmniTransactionsByBlockHashR result = apiInstance.ListOmniTransactionsByBlockHash(network, blockchain, blockHash, context, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OmniLayerApi.ListOmniTransactionsByBlockHash: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
 **blockHash** | **string**| Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 
 **limit** | **int?**| Defines how many items should be returned in the response per page basis. | [optional] [default to 50]
 **offset** | **int?**| The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0]

### Return type

[**ListOmniTransactionsByBlockHashR**](ListOmniTransactionsByBlockHashR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successfull. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listomnitransactionsbyblockheight"></a>
# **ListOmniTransactionsByBlockHeight**
> ListOmniTransactionsByBlockHeightR ListOmniTransactionsByBlockHeight (string network, string blockchain, string blockHeight, string context = null, int? limit = null, int? offset = null)

List Omni Transactions By Block Height

This endpoint will list Omni transactions by an attribute `blockHeight`. The transactions listed will detail additional information such as hash, addresses, time of creation in Unix timestamp, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListOmniTransactionsByBlockHeightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OmniLayerApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var blockHeight = 1941222;  // string | Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \"Genesis block\".
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var limit = 50;  // int? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 10;  // int? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)

            try
            {
                // List Omni Transactions By Block Height
                ListOmniTransactionsByBlockHeightR result = apiInstance.ListOmniTransactionsByBlockHeight(network, blockchain, blockHeight, context, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OmniLayerApi.ListOmniTransactionsByBlockHeight: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
 **blockHeight** | **string**| Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 
 **limit** | **int?**| Defines how many items should be returned in the response per page basis. | [optional] [default to 50]
 **offset** | **int?**| The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0]

### Return type

[**ListOmniTransactionsByBlockHeightR**](ListOmniTransactionsByBlockHeightR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listunconfirmedomnitransactionsbyaddress"></a>
# **ListUnconfirmedOmniTransactionsByAddress**
> ListUnconfirmedOmniTransactionsByAddressR ListUnconfirmedOmniTransactionsByAddress (string network, string blockchain, string address, string context = null, int? limit = null, int? offset = null)

List Unconfirmed Omni Transactions By Address

This endpoint will list unconfirmed Omni transactions by an attribute `address`. The transactions listed will detail additional information such as hash, height, time of creation in Unix timestamp, etc.    Unconfirmed transactions are usually put in the Mempool and await verification so that they can be added to a block.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListUnconfirmedOmniTransactionsByAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OmniLayerApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var address = mi7iSsKcvyFYNsiYdDZqJmH75RmoHomwmo;  // string | Represents the public address, which is a compressed and shortened form of a public key.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var limit = 50;  // int? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 10;  // int? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)

            try
            {
                // List Unconfirmed Omni Transactions By Address
                ListUnconfirmedOmniTransactionsByAddressR result = apiInstance.ListUnconfirmedOmniTransactionsByAddress(network, blockchain, address, context, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OmniLayerApi.ListUnconfirmedOmniTransactionsByAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
 **address** | **string**| Represents the public address, which is a compressed and shortened form of a public key. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 
 **limit** | **int?**| Defines how many items should be returned in the response per page basis. | [optional] [default to 50]
 **offset** | **int?**| The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0]

### Return type

[**ListUnconfirmedOmniTransactionsByAddressR**](ListUnconfirmedOmniTransactionsByAddressR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listunconfirmedomnitransactionsbypropertyid"></a>
# **ListUnconfirmedOmniTransactionsByPropertyID**
> ListUnconfirmedOmniTransactionsByPropertyIDR ListUnconfirmedOmniTransactionsByPropertyID (string network, string blockchain, string propertyId, string context = null, int? limit = null, int? offset = null)

List Unconfirmed Omni Transactions By Property ID

This endpoint will list unconfirmed Omni transactions by an attribute `propertyId`. The transactions listed will detail additional information such as hash, height, time of creation in Unix timestamp, etc.    Unconfirmed transactions are usually put in the Mempool and await verification so that they can be added to a block.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListUnconfirmedOmniTransactionsByPropertyIDExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new OmniLayerApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var propertyId = 2;  // string | Represents the identifier of the tokens to send.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var limit = 50;  // int? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 10;  // int? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)

            try
            {
                // List Unconfirmed Omni Transactions By Property ID
                ListUnconfirmedOmniTransactionsByPropertyIDR result = apiInstance.ListUnconfirmedOmniTransactionsByPropertyID(network, blockchain, propertyId, context, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OmniLayerApi.ListUnconfirmedOmniTransactionsByPropertyID: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
 **propertyId** | **string**| Represents the identifier of the tokens to send. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 
 **limit** | **int?**| Defines how many items should be returned in the response per page basis. | [optional] [default to 50]
 **offset** | **int?**| The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0]

### Return type

[**ListUnconfirmedOmniTransactionsByPropertyIDR**](ListUnconfirmedOmniTransactionsByPropertyIDR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

