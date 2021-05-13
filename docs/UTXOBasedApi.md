# CryptoAPIs.Api.UTXOBasedApi

All URIs are relative to *https://rest.cryptoapis.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetHDWalletXPubYPubZPubDetails**](UTXOBasedApi.md#gethdwalletxpubypubzpubdetails) | **GET** /blockchain-data/{blockchain}/{network}/hd/{extendedPublicKey}/details | Get HD Wallet (xPub, yPub, zPub) Details
[**ListHDWalletXPubYPubZPubTransactions**](UTXOBasedApi.md#listhdwalletxpubypubzpubtransactions) | **GET** /blockchain-data/{blockchain}/{network}/hd/{extendedPublicKey}/transactions | List HD Wallet (xPub, yPub, zPub) Transactions
[**SyncHDWalletXPubYPubZPub**](UTXOBasedApi.md#synchdwalletxpubypubzpub) | **POST** /blockchain-data/{blockchain}/{network}/hd/sync | Sync HD Wallet (xPub, yPub, zPub)


<a name="gethdwalletxpubypubzpubdetails"></a>
# **GetHDWalletXPubYPubZPubDetails**
> GetHDWalletXPubYPubZPubDetailsR GetHDWalletXPubYPubZPubDetails (string blockchain, string extendedPublicKey, string network, string context = null, string derivation = null)

Get HD Wallet (xPub, yPub, zPub) Details

HD wallet details is useful endpoint to get the most important data about HD wallet without the need to do a lot of calculations, once the HD Wallet is synced using Sync endpoint we keep it up to date and we calculate these details in advance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetHDWalletXPubYPubZPubDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new UTXOBasedApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var extendedPublicKey = upub5Ei6bRNneqozk6smK7dvtXHC5PjUyEL4ynCfMKvjznLcXi9DQaikETzQjHvJC43XexMvQs64jxB1njMjCHpRZ4xQWAmv3ge9cVtjfsHmbvQ;  // string | Defines the account extended publicly known key which is used to derive all child public keys.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var derivation = derivation_example;  // string | The way how the HD walled derives, for example when the type is ACCOUNT, it derives change and receive addresses while when the type is BIP32 it derives directly. (optional) 

            try
            {
                // Get HD Wallet (xPub, yPub, zPub) Details
                GetHDWalletXPubYPubZPubDetailsR result = apiInstance.GetHDWalletXPubYPubZPubDetails(blockchain, extendedPublicKey, network, context, derivation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UTXOBasedApi.GetHDWalletXPubYPubZPubDetails: " + e.Message );
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
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
 **extendedPublicKey** | **string**| Defines the account extended publicly known key which is used to derive all child public keys. | 
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 
 **derivation** | **string**| The way how the HD walled derives, for example when the type is ACCOUNT, it derives change and receive addresses while when the type is BIP32 it derives directly. | [optional] 

### Return type

[**GetHDWalletXPubYPubZPubDetailsR**](GetHDWalletXPubYPubZPubDetailsR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | This xPub is not yet synced, please first use endpoint “Sync HD (xPub, yPub, zPub) wallet” to synchronize it. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your wallet (xPub, yPub, zPub) is still syncing, it should take few seconds depending on how many transactions it has. |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listhdwalletxpubypubzpubtransactions"></a>
# **ListHDWalletXPubYPubZPubTransactions**
> ListHDWalletXPubYPubZPubTransactionsR ListHDWalletXPubYPubZPubTransactions (string blockchain, string extendedPublicKey, string network, string context = null, string derivation = null, int? limit = null, int? offset = null)

List HD Wallet (xPub, yPub, zPub) Transactions

This endpoint will list HD Wallet transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class ListHDWalletXPubYPubZPubTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new UTXOBasedApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain.
            var extendedPublicKey = tpubD9GMECjiZHCaF9NHSMAeMbQMXnM7CviEJZsYBuztVwsUjPHWjxewWAUXWV2UExaAtoEvQGXDBmVWo6ZHGtj6TsH6Pop7D9DskQwGHA1gu1w;  // string | Defines the master public key (xPub) of the account.
            var network = testnet;  // string | Represents the specific network.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var derivation = derivation_example;  // string | The way how the HD walled derives, for example when the type is ACCOUNT, it derives change and receive addresses while when the type is BIP32 it derives directly. (optional) 
            var limit = 50;  // int? | Defines how many items should be returned in the response per page basis. (optional)  (default to 50)
            var offset = 10;  // int? | The starting index of the response items, i.e. where the response should start listing the returned items. (optional)  (default to 0)

            try
            {
                // List HD Wallet (xPub, yPub, zPub) Transactions
                ListHDWalletXPubYPubZPubTransactionsR result = apiInstance.ListHDWalletXPubYPubZPubTransactions(blockchain, extendedPublicKey, network, context, derivation, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UTXOBasedApi.ListHDWalletXPubYPubZPubTransactions: " + e.Message );
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
 **blockchain** | **string**| Represents the specific blockchain. | 
 **extendedPublicKey** | **string**| Defines the master public key (xPub) of the account. | 
 **network** | **string**| Represents the specific network. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 
 **derivation** | **string**| The way how the HD walled derives, for example when the type is ACCOUNT, it derives change and receive addresses while when the type is BIP32 it derives directly. | [optional] 
 **limit** | **int?**| Defines how many items should be returned in the response per page basis. | [optional] [default to 50]
 **offset** | **int?**| The starting index of the response items, i.e. where the response should start listing the returned items. | [optional] [default to 0]

### Return type

[**ListHDWalletXPubYPubZPubTransactionsR**](ListHDWalletXPubYPubZPubTransactionsR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | This xPub is not yet synced, please first use endpoint “Sync HD (xPub, yPub, zPub) wallet” to synchronize it. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your wallet (xPub, yPub, zPub) is still syncing, it should take few seconds depending on how many transactions it has. |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="synchdwalletxpubypubzpub"></a>
# **SyncHDWalletXPubYPubZPub**
> SyncHDWalletXPubYPubZPubR SyncHDWalletXPubYPubZPub (string blockchain, string network, string context = null, SyncHDWalletXPubYPubZPubRB syncHDWalletXPubYPubZPubRB = null)

Sync HD Wallet (xPub, yPub, zPub)

HD wallets usually have a lot of addresses and transactions, getting the data on demand is a heavy operation. That's why we have created this feature, to be able to get HD wallet details or transactions this HD wallet must be synced first. In addition to the initial sync we keep updating the synced HD wallets all the time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class SyncHDWalletXPubYPubZPubExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new UTXOBasedApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var syncHDWalletXPubYPubZPubRB = new SyncHDWalletXPubYPubZPubRB(); // SyncHDWalletXPubYPubZPubRB |  (optional) 

            try
            {
                // Sync HD Wallet (xPub, yPub, zPub)
                SyncHDWalletXPubYPubZPubR result = apiInstance.SyncHDWalletXPubYPubZPub(blockchain, network, context, syncHDWalletXPubYPubZPubRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UTXOBasedApi.SyncHDWalletXPubYPubZPub: " + e.Message );
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
 **blockchain** | **string**| Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
 **network** | **string**| Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
 **context** | **string**| In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional] 
 **syncHDWalletXPubYPubZPubRB** | [**SyncHDWalletXPubYPubZPubRB**](SyncHDWalletXPubYPubZPubRB.md)|  | [optional] 

### Return type

[**SyncHDWalletXPubYPubZPubR**](SyncHDWalletXPubYPubZPubR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | The provided Xpub is invalid. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | Mainnets access is not available for your current subscription plan, please upgrade your plan to be able to use it. |  -  |
| **409** | The specified resource already exists. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your wallet (xPub, yPub, zPub) is still syncing, it should take few seconds depending on how many transactions it has. |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

