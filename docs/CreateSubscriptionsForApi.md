# Org.OpenAPITools.Api.CreateSubscriptionsForApi

All URIs are relative to *https://rest.cryptoapis.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MinedTransaction**](CreateSubscriptionsForApi.md#minedtransaction) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/transaction-mined | Mined transaction
[**NewBlock**](CreateSubscriptionsForApi.md#newblock) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/block-mined | New Block
[**NewConfirmedCoinsTransactions**](CreateSubscriptionsForApi.md#newconfirmedcoinstransactions) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-coins-transactions-confirmed | New confirmed coins transactions
[**NewConfirmedCoinsTransactionsAndEachConfirmation**](CreateSubscriptionsForApi.md#newconfirmedcoinstransactionsandeachconfirmation) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-coins-transactions-confirmed-each-confirmation | New confirmed coins transactions and each confirmation
[**NewConfirmedTokensTransactions**](CreateSubscriptionsForApi.md#newconfirmedtokenstransactions) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-tokens-transactions-confirmed | New confirmed tokens transactions
[**NewConfirmedTokensTransactionsAndEachConfirmation**](CreateSubscriptionsForApi.md#newconfirmedtokenstransactionsandeachconfirmation) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-tokens-transactions-confirmed-each-confirmation | New confirmed tokens transactions and each confirmation
[**NewUnconfirmedCoinsTransactions**](CreateSubscriptionsForApi.md#newunconfirmedcoinstransactions) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-coins-transactions-unconfirmed | New unconfirmed coins transactions
[**NewUnconfirmedTokensTransactions**](CreateSubscriptionsForApi.md#newunconfirmedtokenstransactions) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-tokens-transactions-unconfirmed | New unconfirmed tokens transactions


<a name="minedtransaction"></a>
# **MinedTransaction**
> MinedTransactionResponse MinedTransaction (string blockchain, string network, string context = null, MinedTransactionRequestBody minedTransactionRequestBody = null)

Mined transaction

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when a specific transaction is mined. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified `transactionId`.    A transaction is mined when it is included in a new block in the blockchain.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MinedTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var minedTransactionRequestBody = new MinedTransactionRequestBody(); // MinedTransactionRequestBody |  (optional) 

            try
            {
                // Mined transaction
                MinedTransactionResponse result = apiInstance.MinedTransaction(blockchain, network, context, minedTransactionRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.MinedTransaction: " + e.Message );
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
 **minedTransactionRequestBody** | [**MinedTransactionRequestBody**](MinedTransactionRequestBody.md)|  | [optional] 

### Return type

[**MinedTransactionResponse**](MinedTransactionResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | You have reached the maximum number of active Blockchain Events subscriptions which is {callbacks_limit} now. Please upgrade your plan to be get higher number of active subscriptions. |  -  |
| **409** | The specified resource already exists. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newblock"></a>
# **NewBlock**
> NewBlockResponse NewBlock (string blockchain, string network, string context = null, NewBlockRequestBody newBlockRequestBody = null)

New Block

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when a new block is mined in the specific blockchain. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.    A new block is mined when it is added to the chain once a consensus is reached by the majority of the miners, which is when the block gets validated and added to the blockchain.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NewBlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newBlockRequestBody = new NewBlockRequestBody(); // NewBlockRequestBody |  (optional) 

            try
            {
                // New Block
                NewBlockResponse result = apiInstance.NewBlock(blockchain, network, context, newBlockRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewBlock: " + e.Message );
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
 **newBlockRequestBody** | [**NewBlockRequestBody**](NewBlockRequestBody.md)|  | [optional] 

### Return type

[**NewBlockResponse**](NewBlockResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | You have reached the maximum number of active Blockchain Events subscriptions which is {callbacks_limit} now. Please upgrade your plan to be get higher number of active subscriptions. |  -  |
| **409** | The specified resource already exists. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedcoinstransactions"></a>
# **NewConfirmedCoinsTransactions**
> NewConfirmedCoinsTransactionsResponse NewConfirmedCoinsTransactions (string blockchain, string network, string context = null, NewConfirmedCoinsTransactionsRequestBody newConfirmedCoinsTransactionsRequestBody = null)

New confirmed coins transactions

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new incoming or outgoing confirmed transactions for coins from/to the customer's address. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.     Being confirmed means that the transactions are verified by miners and added to the next block.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NewConfirmedCoinsTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedCoinsTransactionsRequestBody = new NewConfirmedCoinsTransactionsRequestBody(); // NewConfirmedCoinsTransactionsRequestBody |  (optional) 

            try
            {
                // New confirmed coins transactions
                NewConfirmedCoinsTransactionsResponse result = apiInstance.NewConfirmedCoinsTransactions(blockchain, network, context, newConfirmedCoinsTransactionsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedCoinsTransactions: " + e.Message );
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
 **newConfirmedCoinsTransactionsRequestBody** | [**NewConfirmedCoinsTransactionsRequestBody**](NewConfirmedCoinsTransactionsRequestBody.md)|  | [optional] 

### Return type

[**NewConfirmedCoinsTransactionsResponse**](NewConfirmedCoinsTransactionsResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | You have reached the maximum number of active Blockchain Events subscriptions which is {callbacks_limit} now. Please upgrade your plan to be get higher number of active subscriptions. |  -  |
| **409** | The specified resource already exists. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedcoinstransactionsandeachconfirmation"></a>
# **NewConfirmedCoinsTransactionsAndEachConfirmation**
> NewConfirmedCoinsTransactionsAndEachConfirmationResponse NewConfirmedCoinsTransactionsAndEachConfirmation (string blockchain, string network, string context = null, NewConfirmedCoinsTransactionsAndEachConfirmationRequestBody newConfirmedCoinsTransactionsAndEachConfirmationRequestBody = null)

New confirmed coins transactions and each confirmation

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new incoming or outgoing confirmed transactions for coins from/to the customer's address with also a response at each confirmation the transaction has received until the specified confirmations limit is reached. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.     Being confirmed means that the transactions are verified by miners and added to the next block. This endpoint refers to **coins transactions only, not tokens**.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NewConfirmedCoinsTransactionsAndEachConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedCoinsTransactionsAndEachConfirmationRequestBody = new NewConfirmedCoinsTransactionsAndEachConfirmationRequestBody(); // NewConfirmedCoinsTransactionsAndEachConfirmationRequestBody |  (optional) 

            try
            {
                // New confirmed coins transactions and each confirmation
                NewConfirmedCoinsTransactionsAndEachConfirmationResponse result = apiInstance.NewConfirmedCoinsTransactionsAndEachConfirmation(blockchain, network, context, newConfirmedCoinsTransactionsAndEachConfirmationRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedCoinsTransactionsAndEachConfirmation: " + e.Message );
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
 **newConfirmedCoinsTransactionsAndEachConfirmationRequestBody** | [**NewConfirmedCoinsTransactionsAndEachConfirmationRequestBody**](NewConfirmedCoinsTransactionsAndEachConfirmationRequestBody.md)|  | [optional] 

### Return type

[**NewConfirmedCoinsTransactionsAndEachConfirmationResponse**](NewConfirmedCoinsTransactionsAndEachConfirmationResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | You have reached the maximum number of active Blockchain Events subscriptions which is {callbacks_limit} now. Please upgrade your plan to be get higher number of active subscriptions. |  -  |
| **409** | The specified resource already exists. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedtokenstransactions"></a>
# **NewConfirmedTokensTransactions**
> NewConfirmedTokensTransactionsResponse NewConfirmedTokensTransactions (string blockchain, string network, string context = null, NewConfirmedTokensTransactionsRequestBody newConfirmedTokensTransactionsRequestBody = null)

New confirmed tokens transactions

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new incoming or outgoing confirmed transactions for tokens from/to the customer's address. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.     Being confirmed means that the transactions are verified by miners and added to the next block. This endpoint refers to **tokens transactions only, not coins**.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NewConfirmedTokensTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedTokensTransactionsRequestBody = new NewConfirmedTokensTransactionsRequestBody(); // NewConfirmedTokensTransactionsRequestBody |  (optional) 

            try
            {
                // New confirmed tokens transactions
                NewConfirmedTokensTransactionsResponse result = apiInstance.NewConfirmedTokensTransactions(blockchain, network, context, newConfirmedTokensTransactionsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedTokensTransactions: " + e.Message );
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
 **newConfirmedTokensTransactionsRequestBody** | [**NewConfirmedTokensTransactionsRequestBody**](NewConfirmedTokensTransactionsRequestBody.md)|  | [optional] 

### Return type

[**NewConfirmedTokensTransactionsResponse**](NewConfirmedTokensTransactionsResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | You have reached the maximum number of active Blockchain Events subscriptions which is {callbacks_limit} now. Please upgrade your plan to be get higher number of active subscriptions. |  -  |
| **409** | The specified resource already exists. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedtokenstransactionsandeachconfirmation"></a>
# **NewConfirmedTokensTransactionsAndEachConfirmation**
> NewConfirmedTokensTransactionsAndEachConfirmationResponse NewConfirmedTokensTransactionsAndEachConfirmation (string blockchain, string network, string context = null, NewConfirmedTokensTransactionsAndEachConfirmationRequestBody newConfirmedTokensTransactionsAndEachConfirmationRequestBody = null)

New confirmed tokens transactions and each confirmation

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new incoming or outgoing confirmed transactions for tokens from/to the customer's address with also a response at each confirmation the transaction has received until the specified confirmations limit is reached. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.     Being confirmed means that the transactions are verified by miners and added to the next block. This endpoint refers to **tokens transactions only, not coins**.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NewConfirmedTokensTransactionsAndEachConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedTokensTransactionsAndEachConfirmationRequestBody = new NewConfirmedTokensTransactionsAndEachConfirmationRequestBody(); // NewConfirmedTokensTransactionsAndEachConfirmationRequestBody |  (optional) 

            try
            {
                // New confirmed tokens transactions and each confirmation
                NewConfirmedTokensTransactionsAndEachConfirmationResponse result = apiInstance.NewConfirmedTokensTransactionsAndEachConfirmation(blockchain, network, context, newConfirmedTokensTransactionsAndEachConfirmationRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedTokensTransactionsAndEachConfirmation: " + e.Message );
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
 **newConfirmedTokensTransactionsAndEachConfirmationRequestBody** | [**NewConfirmedTokensTransactionsAndEachConfirmationRequestBody**](NewConfirmedTokensTransactionsAndEachConfirmationRequestBody.md)|  | [optional] 

### Return type

[**NewConfirmedTokensTransactionsAndEachConfirmationResponse**](NewConfirmedTokensTransactionsAndEachConfirmationResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | You have reached the maximum number of active Blockchain Events subscriptions which is {callbacks_limit} now. Please upgrade your plan to be get higher number of active subscriptions. |  -  |
| **409** | The specified resource already exists. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newunconfirmedcoinstransactions"></a>
# **NewUnconfirmedCoinsTransactions**
> NewUnconfirmedCoinsTransactionsResponse NewUnconfirmedCoinsTransactions (string blockchain, string network, string context = null, NewUnconfirmedCoinsTransactionsRequestBody newUnconfirmedCoinsTransactionsRequestBody = null)

New unconfirmed coins transactions

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new unconfirmed coins transactions for the user. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.    Unconfirmed coins transactions remain in the mempool (memory pool) until they are confirmed by miners and added to the next block. Sometimes spikes in transaction activity can cause delays in confirmations.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {note}It is also **important to note** that just because pending unconfirmed transactions are in the mempool, **doesn't necessarily** mean they will get confirmed.{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NewUnconfirmedCoinsTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newUnconfirmedCoinsTransactionsRequestBody = new NewUnconfirmedCoinsTransactionsRequestBody(); // NewUnconfirmedCoinsTransactionsRequestBody |  (optional) 

            try
            {
                // New unconfirmed coins transactions
                NewUnconfirmedCoinsTransactionsResponse result = apiInstance.NewUnconfirmedCoinsTransactions(blockchain, network, context, newUnconfirmedCoinsTransactionsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewUnconfirmedCoinsTransactions: " + e.Message );
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
 **newUnconfirmedCoinsTransactionsRequestBody** | [**NewUnconfirmedCoinsTransactionsRequestBody**](NewUnconfirmedCoinsTransactionsRequestBody.md)|  | [optional] 

### Return type

[**NewUnconfirmedCoinsTransactionsResponse**](NewUnconfirmedCoinsTransactionsResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | You have reached the maximum number of active Blockchain Events subscriptions which is {callbacks_limit} now. Please upgrade your plan to be get higher number of active subscriptions. |  -  |
| **409** | The specified resource already exists. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newunconfirmedtokenstransactions"></a>
# **NewUnconfirmedTokensTransactions**
> NewUnconfirmedTokensTransactionsResponse NewUnconfirmedTokensTransactions (string blockchain, string network, string context = null, NewUnconfirmedTokensTransactionsRequestBody newUnconfirmedTokensTransactionsRequestBody = null)

New unconfirmed tokens transactions

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new unconfirmed tokens transactions for the user. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.    Unconfirmed tokens transactions remain in the mempool (memory pool) until they are confirmed by miners and added to the next block. Sometimes spikes in transaction activity can cause delays in confirmations.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {note}It is also **important to note** that just because pending unconfirmed transactions are in the mempool, **doesn't necessarily** mean they will get confirmed.{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NewUnconfirmedTokensTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\", \"rinkeby\" are test networks.
            var context = context_example;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newUnconfirmedTokensTransactionsRequestBody = new NewUnconfirmedTokensTransactionsRequestBody(); // NewUnconfirmedTokensTransactionsRequestBody |  (optional) 

            try
            {
                // New unconfirmed tokens transactions
                NewUnconfirmedTokensTransactionsResponse result = apiInstance.NewUnconfirmedTokensTransactions(blockchain, network, context, newUnconfirmedTokensTransactionsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewUnconfirmedTokensTransactions: " + e.Message );
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
 **newUnconfirmedTokensTransactionsRequestBody** | [**NewUnconfirmedTokensTransactionsRequestBody**](NewUnconfirmedTokensTransactionsRequestBody.md)|  | [optional] 

### Return type

[**NewUnconfirmedTokensTransactionsResponse**](NewUnconfirmedTokensTransactionsResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | The pagination attributes that have been used are invalid. Please check the Documentation to see details on pagination. |  -  |
| **401** | The provided API key is invalid. Please, generate a new one from your Dashboard. |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | You have reached the maximum number of active Blockchain Events subscriptions which is {callbacks_limit} now. Please upgrade your plan to be get higher number of active subscriptions. |  -  |
| **409** | The specified resource already exists. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
