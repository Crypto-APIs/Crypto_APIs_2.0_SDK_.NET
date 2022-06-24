# CryptoAPIs.Api.XRPRippleApi

All URIs are relative to *https://rest.cryptoapis.io/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLatestMinedXRPRippleBlock**](XRPRippleApi.md#getlatestminedxrprippleblock) | **GET** /blockchain-data/xrp-specific/{network}/blocks/last | Get Latest Mined XRP (Ripple) Block |
| [**GetXRPRippleAddressDetails**](XRPRippleApi.md#getxrprippleaddressdetails) | **GET** /blockchain-data/xrp-specific/{network}/addresses/{address} | Get XRP (Ripple) Address Details |
| [**GetXRPRippleBlockDetailsByBlockHash**](XRPRippleApi.md#getxrprippleblockdetailsbyblockhash) | **GET** /blockchain-data/xrp-specific/{network}/blocks/hash/{blockHash} | Get XRP (Ripple) Block Details By Block Hash |
| [**GetXRPRippleBlockDetailsByBlockHeight**](XRPRippleApi.md#getxrprippleblockdetailsbyblockheight) | **GET** /blockchain-data/xrp-specific/{network}/blocks/height/{blockHeight} | Get XRP (Ripple) Block Details By Block Height |
| [**GetXRPRippleTransactionDetailsByTransactionID**](XRPRippleApi.md#getxrprippletransactiondetailsbytransactionid) | **GET** /blockchain-data/xrp-specific/{network}/transactions/{transactionHash} | Get XRP (Ripple) Transaction Details By Transaction ID |
| [**ListXRPRippleTransactionsByAddress**](XRPRippleApi.md#listxrprippletransactionsbyaddress) | **GET** /blockchain-data/xrp-specific/{network}/addresses/{address}/transactions | List XRP (Ripple) Transactions by Address |
| [**ListXRPRippleTransactionsByAddressAndTimeRange**](XRPRippleApi.md#listxrprippletransactionsbyaddressandtimerange) | **GET** /blockchain-data/xrp-specific/{network}/addresses/{address}/transactions-by-time-range | List XRP (Ripple) Transactions By Address And Time Range |
| [**ListXRPRippleTransactionsByBlockHash**](XRPRippleApi.md#listxrprippletransactionsbyblockhash) | **GET** /blockchain-data/xrp-specific/{network}/blocks/hash/{blockHash}/transactions | List XRP (Ripple) Transactions By Block Hash |
| [**ListXRPRippleTransactionsByBlockHeight**](XRPRippleApi.md#listxrprippletransactionsbyblockheight) | **GET** /blockchain-data/xrp-specific/{network}/blocks/height/{blockHeight}/transactions | List XRP (Ripple) Transactions By Block Height |

<a name="getlatestminedxrprippleblock"></a>
# **GetLatestMinedXRPRippleBlock**
> GetLatestMinedXRPRippleBlockR GetLatestMinedXRPRippleBlock (string network, string context = null)

Get Latest Mined XRP (Ripple) Block

Through this endpoint customers can fetch the last mined XRP block in the blockchain, along with its details. These could include the hash of the specific, the previous and the next block, its transactions count, its height, etc.     Since XRP is a different blockchain than Bitcoin and Ethereum, it isn't unified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetLatestMinedXRPRippleBlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new XRPRippleApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 

            try
            {
                // Get Latest Mined XRP (Ripple) Block
                GetLatestMinedXRPRippleBlockR result = apiInstance.GetLatestMinedXRPRippleBlock(network, context);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XRPRippleApi.GetLatestMinedXRPRippleBlock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLatestMinedXRPRippleBlockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Latest Mined XRP (Ripple) Block
    ApiResponse<GetLatestMinedXRPRippleBlockR> response = apiInstance.GetLatestMinedXRPRippleBlockWithHttpInfo(network, context);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XRPRippleApi.GetLatestMinedXRPRippleBlockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |

### Return type

[**GetLatestMinedXRPRippleBlockR**](GetLatestMinedXRPRippleBlockR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **404** | Resource not found |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxrprippleaddressdetails"></a>
# **GetXRPRippleAddressDetails**
> GetXRPRippleAddressDetailsR GetXRPRippleAddressDetails (string network, string address, string context = null)

Get XRP (Ripple) Address Details

Through this endpoint the customer can receive basic information about a given XRP address based on confirmed/synced blocks only. In the case where there are any incoming or outgoing **unconfirmed** transactions for the specific address, they **will not** be counted or calculated here.    Since XRP is a different blockchain than Bitcoin and Ethereum, it isn't unified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetXRPRippleAddressDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new XRPRippleApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\",  are test networks.
            var address = rA9bXGJcXvZKaWofrRphdJsBWzhyCfH3z;  // string | Represents the public address, which is a compressed and shortened form of a public key.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 

            try
            {
                // Get XRP (Ripple) Address Details
                GetXRPRippleAddressDetailsR result = apiInstance.GetXRPRippleAddressDetails(network, address, context);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XRPRippleApi.GetXRPRippleAddressDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetXRPRippleAddressDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get XRP (Ripple) Address Details
    ApiResponse<GetXRPRippleAddressDetailsR> response = apiInstance.GetXRPRippleAddressDetailsWithHttpInfo(network, address, context);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XRPRippleApi.GetXRPRippleAddressDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;,  are test networks. |  |
| **address** | **string** | Represents the public address, which is a compressed and shortened form of a public key. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |

### Return type

[**GetXRPRippleAddressDetailsR**](GetXRPRippleAddressDetailsR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxrprippleblockdetailsbyblockhash"></a>
# **GetXRPRippleBlockDetailsByBlockHash**
> GetXRPRippleBlockDetailsByBlockHashR GetXRPRippleBlockDetailsByBlockHash (string network, string blockHash, string context = null)

Get XRP (Ripple) Block Details By Block Hash

Through this endpoint customers can obtain basic information about a given XRP block (a block on the XRP blockchain), specifically by using the `hash` parameter. These block details could include the hash of the specific, the previous and the next block, the number of included transactions, etc.     Since XRP is a different blockchain than Bitcoin and Ethereum, it isn't unified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetXRPRippleBlockDetailsByBlockHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new XRPRippleApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var blockHash = 1ab0614d2a438da8b23086cbceef7d443edbd295d9c7619fc8a19c7618bc22c9;  // string | Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 

            try
            {
                // Get XRP (Ripple) Block Details By Block Hash
                GetXRPRippleBlockDetailsByBlockHashR result = apiInstance.GetXRPRippleBlockDetailsByBlockHash(network, blockHash, context);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XRPRippleApi.GetXRPRippleBlockDetailsByBlockHash: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetXRPRippleBlockDetailsByBlockHashWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get XRP (Ripple) Block Details By Block Hash
    ApiResponse<GetXRPRippleBlockDetailsByBlockHashR> response = apiInstance.GetXRPRippleBlockDetailsByBlockHashWithHttpInfo(network, blockHash, context);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XRPRippleApi.GetXRPRippleBlockDetailsByBlockHashWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **blockHash** | **string** | Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |

### Return type

[**GetXRPRippleBlockDetailsByBlockHashR**](GetXRPRippleBlockDetailsByBlockHashR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **404** | Resource not found |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxrprippleblockdetailsbyblockheight"></a>
# **GetXRPRippleBlockDetailsByBlockHeight**
> GetXRPRippleBlockDetailsByBlockHeightR GetXRPRippleBlockDetailsByBlockHeight (string network, string blockHeight, string context = null)

Get XRP (Ripple) Block Details By Block Height

Through this endpoint customers can obtain basic information about a given XRP block (a block on the XRP blockchain), specifically by using the `height` parameter. These block details could include the hash of the specific, the previous and the next block, its transactions count, etc.    Since XRP is a different blockchain than Bitcoin and Ethereum, it isn't unified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetXRPRippleBlockDetailsByBlockHeightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new XRPRippleApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\",  are test networks.
            var blockHeight = 15886156;  // string | Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \"Genesis block\".
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 

            try
            {
                // Get XRP (Ripple) Block Details By Block Height
                GetXRPRippleBlockDetailsByBlockHeightR result = apiInstance.GetXRPRippleBlockDetailsByBlockHeight(network, blockHeight, context);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XRPRippleApi.GetXRPRippleBlockDetailsByBlockHeight: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetXRPRippleBlockDetailsByBlockHeightWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get XRP (Ripple) Block Details By Block Height
    ApiResponse<GetXRPRippleBlockDetailsByBlockHeightR> response = apiInstance.GetXRPRippleBlockDetailsByBlockHeightWithHttpInfo(network, blockHeight, context);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XRPRippleApi.GetXRPRippleBlockDetailsByBlockHeightWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;,  are test networks. |  |
| **blockHeight** | **string** | Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |

### Return type

[**GetXRPRippleBlockDetailsByBlockHeightR**](GetXRPRippleBlockDetailsByBlockHeightR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **404** | Resource not found |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getxrprippletransactiondetailsbytransactionid"></a>
# **GetXRPRippleTransactionDetailsByTransactionID**
> GetXRPRippleTransactionDetailsByTransactionIDR GetXRPRippleTransactionDetailsByTransactionID (string network, string transactionHash, string context = null)

Get XRP (Ripple) Transaction Details By Transaction ID

Through this endpoint customers can obtain details about a XRP transaction by the transaction's unique identifier.     Since XRP is a different blockchain than Bitcoin and Ethereum, it isn't unified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetXRPRippleTransactionDetailsByTransactionIDExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new XRPRippleApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var transactionHash = 36a1737481edec87bacc3101dfb752ae2c76f9171e7edebe587e330c1ea77c8d;  // string | Represents the same as `transactionId` for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols `hash` is different from `transactionId` for SegWit transactions.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 

            try
            {
                // Get XRP (Ripple) Transaction Details By Transaction ID
                GetXRPRippleTransactionDetailsByTransactionIDR result = apiInstance.GetXRPRippleTransactionDetailsByTransactionID(network, transactionHash, context);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XRPRippleApi.GetXRPRippleTransactionDetailsByTransactionID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetXRPRippleTransactionDetailsByTransactionIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get XRP (Ripple) Transaction Details By Transaction ID
    ApiResponse<GetXRPRippleTransactionDetailsByTransactionIDR> response = apiInstance.GetXRPRippleTransactionDetailsByTransactionIDWithHttpInfo(network, transactionHash, context);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XRPRippleApi.GetXRPRippleTransactionDetailsByTransactionIDWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **transactionHash** | **string** | Represents the same as &#x60;transactionId&#x60; for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols &#x60;hash&#x60; is different from &#x60;transactionId&#x60; for SegWit transactions. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |

### Return type

[**GetXRPRippleTransactionDetailsByTransactionIDR**](GetXRPRippleTransactionDetailsByTransactionIDR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **404** | Resource not found |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listxrprippletransactionsbyaddress"></a>
# **ListXRPRippleTransactionsByAddress**
> ListXRPRippleTransactionsByAddressR ListXRPRippleTransactionsByAddress (string network, string address, string context = null, long? limit = null, long? offset = null, string transactionType = null)

List XRP (Ripple) Transactions by Address

This endpoint will list XRP transactions by a attribute `address`. The transactions listed will detail additional information such as hash, height, time of creation in Unix timestamp, etc.    Since XRP is a different blockchain than Bitcoin and Ethereum, it isn't unified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListXRPRippleTransactionsByAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new XRPRippleApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var address = rA9bXGJcXvZKaWofrRphdJsBWzhyCfH3z;  // string | Represents the public address, which is a compressed and shortened form of a public key.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var limit = 50;  // long? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 0;  // long? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)
            var transactionType = payment;  // string |  (optional) 

            try
            {
                // List XRP (Ripple) Transactions by Address
                ListXRPRippleTransactionsByAddressR result = apiInstance.ListXRPRippleTransactionsByAddress(network, address, context, limit, offset, transactionType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XRPRippleApi.ListXRPRippleTransactionsByAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListXRPRippleTransactionsByAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List XRP (Ripple) Transactions by Address
    ApiResponse<ListXRPRippleTransactionsByAddressR> response = apiInstance.ListXRPRippleTransactionsByAddressWithHttpInfo(network, address, context, limit, offset, transactionType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XRPRippleApi.ListXRPRippleTransactionsByAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **address** | **string** | Represents the public address, which is a compressed and shortened form of a public key. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **limit** | **long?** | Defines how many items should be returned in the response per page basis. | [optional] [default to 50] |
| **offset** | **long?** | The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0] |
| **transactionType** | **string** |  | [optional]  |

### Return type

[**ListXRPRippleTransactionsByAddressR**](ListXRPRippleTransactionsByAddressR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listxrprippletransactionsbyaddressandtimerange"></a>
# **ListXRPRippleTransactionsByAddressAndTimeRange**
> ListXRPRippleTransactionsByAddressAndTimeRangeR ListXRPRippleTransactionsByAddressAndTimeRange (string network, string address, int fromTimestamp, int toTimestamp, string context = null, long? limit = null, long? offset = null, string transactionType = null)

List XRP (Ripple) Transactions By Address And Time Range

Тhis endpoint lists XRP transactions by the attribute `address` and the query parameters `fromTimestamp` and `toTimestamp`  which gives customers the opportunity to filter the results by a specified time period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListXRPRippleTransactionsByAddressAndTimeRangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new XRPRippleApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var address = rA9bXGJcXvZKaWofrRphdJsBWzhyCfH3z;  // string | Represents the public address, which is a compressed and shortened form of a public key.
            var fromTimestamp = 1616347862;  // int | Defines the specific time/date from which the results will start being listed.
            var toTimestamp = 1616347870;  // int | Defines the specific time/date to which the results will be listed.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var limit = 50;  // long? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 0;  // long? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)
            var transactionType = payment;  // string | Defines the transaction type. (optional) 

            try
            {
                // List XRP (Ripple) Transactions By Address And Time Range
                ListXRPRippleTransactionsByAddressAndTimeRangeR result = apiInstance.ListXRPRippleTransactionsByAddressAndTimeRange(network, address, fromTimestamp, toTimestamp, context, limit, offset, transactionType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XRPRippleApi.ListXRPRippleTransactionsByAddressAndTimeRange: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListXRPRippleTransactionsByAddressAndTimeRangeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List XRP (Ripple) Transactions By Address And Time Range
    ApiResponse<ListXRPRippleTransactionsByAddressAndTimeRangeR> response = apiInstance.ListXRPRippleTransactionsByAddressAndTimeRangeWithHttpInfo(network, address, fromTimestamp, toTimestamp, context, limit, offset, transactionType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XRPRippleApi.ListXRPRippleTransactionsByAddressAndTimeRangeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **address** | **string** | Represents the public address, which is a compressed and shortened form of a public key. |  |
| **fromTimestamp** | **int** | Defines the specific time/date from which the results will start being listed. |  |
| **toTimestamp** | **int** | Defines the specific time/date to which the results will be listed. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **limit** | **long?** | Defines how many items should be returned in the response per page basis. | [optional] [default to 50] |
| **offset** | **long?** | The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0] |
| **transactionType** | **string** | Defines the transaction type. | [optional]  |

### Return type

[**ListXRPRippleTransactionsByAddressAndTimeRangeR**](ListXRPRippleTransactionsByAddressAndTimeRangeR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listxrprippletransactionsbyblockhash"></a>
# **ListXRPRippleTransactionsByBlockHash**
> ListXRPRippleTransactionsByBlockHashR ListXRPRippleTransactionsByBlockHash (string network, string blockHash, string context = null, long? limit = null, long? offset = null)

List XRP (Ripple) Transactions By Block Hash

This endpoint will list transactions by an attribute `blockHash`. The transactions listed will detail additional information such as hash, addresses, time of creation in Unix timestamp, etc.    Since XRP is a different blockchain than Bitcoin and Ethereum, it isn't unified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListXRPRippleTransactionsByBlockHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new XRPRippleApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var blockHash = 14754656235f865a74eba27791fd41a47bdfe07fe811ff6d78f53db32e129e39;  // string | Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var limit = 50;  // long? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 0;  // long? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)

            try
            {
                // List XRP (Ripple) Transactions By Block Hash
                ListXRPRippleTransactionsByBlockHashR result = apiInstance.ListXRPRippleTransactionsByBlockHash(network, blockHash, context, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XRPRippleApi.ListXRPRippleTransactionsByBlockHash: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListXRPRippleTransactionsByBlockHashWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List XRP (Ripple) Transactions By Block Hash
    ApiResponse<ListXRPRippleTransactionsByBlockHashR> response = apiInstance.ListXRPRippleTransactionsByBlockHashWithHttpInfo(network, blockHash, context, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XRPRippleApi.ListXRPRippleTransactionsByBlockHashWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **blockHash** | **string** | Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **limit** | **long?** | Defines how many items should be returned in the response per page basis. | [optional] [default to 50] |
| **offset** | **long?** | The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0] |

### Return type

[**ListXRPRippleTransactionsByBlockHashR**](ListXRPRippleTransactionsByBlockHashR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listxrprippletransactionsbyblockheight"></a>
# **ListXRPRippleTransactionsByBlockHeight**
> ListXRPRippleTransactionsByBlockHeightR ListXRPRippleTransactionsByBlockHeight (string network, long blockHeight, string context = null, long? limit = null, long? offset = null)

List XRP (Ripple) Transactions By Block Height

This endpoint will list transactions by an attribute `blockHeight`. The transactions listed will detail additional information such as hash, addresses, time of creation in Unix timestamp, etc.    Since XRP is a different blockchain than Bitcoin and Ethereum, it isn't unified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListXRPRippleTransactionsByBlockHeightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new XRPRippleApi(config);
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var blockHeight = 15971358;  // long | 
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var limit = 50;  // long? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 0;  // long? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)

            try
            {
                // List XRP (Ripple) Transactions By Block Height
                ListXRPRippleTransactionsByBlockHeightR result = apiInstance.ListXRPRippleTransactionsByBlockHeight(network, blockHeight, context, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling XRPRippleApi.ListXRPRippleTransactionsByBlockHeight: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListXRPRippleTransactionsByBlockHeightWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List XRP (Ripple) Transactions By Block Height
    ApiResponse<ListXRPRippleTransactionsByBlockHeightR> response = apiInstance.ListXRPRippleTransactionsByBlockHeightWithHttpInfo(network, blockHeight, context, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling XRPRippleApi.ListXRPRippleTransactionsByBlockHeightWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **blockHeight** | **long** |  |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **limit** | **long?** | Defines how many items should be returned in the response per page basis. | [optional] [default to 50] |
| **offset** | **long?** | The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0] |

### Return type

[**ListXRPRippleTransactionsByBlockHeightR**](ListXRPRippleTransactionsByBlockHeightR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

