# CryptoAPIs.Api.CreateSubscriptionsForApi

All URIs are relative to *https://rest.cryptoapis.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BlockHeightReached**](CreateSubscriptionsForApi.md#blockheightreached) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/block-height-reached | Block Height Reached |
| [**MinedTransaction**](CreateSubscriptionsForApi.md#minedtransaction) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/transaction-mined | Mined transaction |
| [**NewBlock**](CreateSubscriptionsForApi.md#newblock) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/block-mined | New Block |
| [**NewConfirmedCoinsTransactions**](CreateSubscriptionsForApi.md#newconfirmedcoinstransactions) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-coins-transactions-confirmed | New confirmed coins transactions |
| [**NewConfirmedCoinsTransactionsAndEachConfirmation**](CreateSubscriptionsForApi.md#newconfirmedcoinstransactionsandeachconfirmation) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-coins-transactions-confirmed-each-confirmation | New confirmed coins transactions and each confirmation |
| [**NewConfirmedCoinsTransactionsForSpecificAmount**](CreateSubscriptionsForApi.md#newconfirmedcoinstransactionsforspecificamount) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/coins-transactions-for-specific-amount | New Confirmed Coins Transactions For Specific Amount |
| [**NewConfirmedInternalTransactions**](CreateSubscriptionsForApi.md#newconfirmedinternaltransactions) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-internal-transactions-confirmed | New confirmed internal transactions |
| [**NewConfirmedInternalTransactionsAndEachConfirmation**](CreateSubscriptionsForApi.md#newconfirmedinternaltransactionsandeachconfirmation) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-internal-transactions-confirmed-each-confirmation | New confirmed internal transactions and each confirmation |
| [**NewConfirmedInternalTransactionsForSpecificAmount**](CreateSubscriptionsForApi.md#newconfirmedinternaltransactionsforspecificamount) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/internal-transactions-for-specific-amount | New Confirmed Internal Transactions For Specific Amount |
| [**NewConfirmedTokenTransactionsForSpecificAmount**](CreateSubscriptionsForApi.md#newconfirmedtokentransactionsforspecificamount) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/tokens-transfers-for-specific-amount | New Confirmed Token Transactions For Specific Amount |
| [**NewConfirmedTokensTransactions**](CreateSubscriptionsForApi.md#newconfirmedtokenstransactions) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-tokens-transactions-confirmed | New confirmed tokens transactions |
| [**NewConfirmedTokensTransactionsAndEachConfirmation**](CreateSubscriptionsForApi.md#newconfirmedtokenstransactionsandeachconfirmation) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-tokens-transactions-confirmed-each-confirmation | New confirmed tokens transactions and each confirmation |
| [**NewUnconfirmedCoinsTransactions**](CreateSubscriptionsForApi.md#newunconfirmedcoinstransactions) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-coins-transactions-unconfirmed | New unconfirmed coins transactions |
| [**NewUnconfirmedTokensTransactions**](CreateSubscriptionsForApi.md#newunconfirmedtokenstransactions) | **POST** /blockchain-events/{blockchain}/{network}/subscriptions/address-tokens-transactions-unconfirmed | New unconfirmed tokens transactions |

<a name="blockheightreached"></a>
# **BlockHeightReached**
> BlockHeightReachedR BlockHeightReached (string blockchain, string network, string context = null, BlockHeightReachedRB blockHeightReachedRB = null)

Block Height Reached

Through this endpoint customers can create callback subscriptions for a specific block height that hasn't been reached yet. In this case the event is when the specified block height in the request body is reached in a said blockchain. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class BlockHeightReachedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var blockHeightReachedRB = new BlockHeightReachedRB(); // BlockHeightReachedRB |  (optional) 

            try
            {
                // Block Height Reached
                BlockHeightReachedR result = apiInstance.BlockHeightReached(blockchain, network, context, blockHeightReachedRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.BlockHeightReached: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BlockHeightReachedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Block Height Reached
    ApiResponse<BlockHeightReachedR> response = apiInstance.BlockHeightReachedWithHttpInfo(blockchain, network, context, blockHeightReachedRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.BlockHeightReachedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **blockHeightReachedRB** | [**BlockHeightReachedRB**](BlockHeightReachedRB.md) |  | [optional]  |

### Return type

[**BlockHeightReachedR**](BlockHeightReachedR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="minedtransaction"></a>
# **MinedTransaction**
> MinedTransactionR MinedTransaction (string blockchain, string network, string context = null, MinedTransactionRB minedTransactionRB = null)

Mined transaction

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when a specific transaction is mined. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified `transactionId`.    A transaction is mined when it is included in a new block in the blockchain.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class MinedTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var minedTransactionRB = new MinedTransactionRB(); // MinedTransactionRB |  (optional) 

            try
            {
                // Mined transaction
                MinedTransactionR result = apiInstance.MinedTransaction(blockchain, network, context, minedTransactionRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.MinedTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MinedTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mined transaction
    ApiResponse<MinedTransactionR> response = apiInstance.MinedTransactionWithHttpInfo(blockchain, network, context, minedTransactionRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.MinedTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **minedTransactionRB** | [**MinedTransactionRB**](MinedTransactionRB.md) |  | [optional]  |

### Return type

[**MinedTransactionR**](MinedTransactionR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newblock"></a>
# **NewBlock**
> NewBlockR NewBlock (string blockchain, string network, string context = null, NewBlockRB newBlockRB = null)

New Block

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when a new block is mined in the specific blockchain. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.    A new block is mined when it is added to the chain once a consensus is reached by the majority of the miners, which is when the block gets validated and added to the blockchain.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewBlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newBlockRB = new NewBlockRB(); // NewBlockRB |  (optional) 

            try
            {
                // New Block
                NewBlockR result = apiInstance.NewBlock(blockchain, network, context, newBlockRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewBlock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewBlockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New Block
    ApiResponse<NewBlockR> response = apiInstance.NewBlockWithHttpInfo(blockchain, network, context, newBlockRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewBlockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newBlockRB** | [**NewBlockRB**](NewBlockRB.md) |  | [optional]  |

### Return type

[**NewBlockR**](NewBlockR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedcoinstransactions"></a>
# **NewConfirmedCoinsTransactions**
> NewConfirmedCoinsTransactionsR NewConfirmedCoinsTransactions (string blockchain, string network, string context = null, NewConfirmedCoinsTransactionsRB newConfirmedCoinsTransactionsRB = null)

New confirmed coins transactions

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new incoming or outgoing confirmed transactions for coins from/to the customer's address. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.     Being confirmed means that the transactions are verified by miners and added to the next block.    {note}For UTXO-based protocols like Bitcoin a transaction could have multiple inputs and outputs which means the address could in as both sender and recipient. [Here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-data-returned-for-utxo-based-transactions) is how we inform you on that.{/note}    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewConfirmedCoinsTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedCoinsTransactionsRB = new NewConfirmedCoinsTransactionsRB(); // NewConfirmedCoinsTransactionsRB |  (optional) 

            try
            {
                // New confirmed coins transactions
                NewConfirmedCoinsTransactionsR result = apiInstance.NewConfirmedCoinsTransactions(blockchain, network, context, newConfirmedCoinsTransactionsRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedCoinsTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewConfirmedCoinsTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New confirmed coins transactions
    ApiResponse<NewConfirmedCoinsTransactionsR> response = apiInstance.NewConfirmedCoinsTransactionsWithHttpInfo(blockchain, network, context, newConfirmedCoinsTransactionsRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedCoinsTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newConfirmedCoinsTransactionsRB** | [**NewConfirmedCoinsTransactionsRB**](NewConfirmedCoinsTransactionsRB.md) |  | [optional]  |

### Return type

[**NewConfirmedCoinsTransactionsR**](NewConfirmedCoinsTransactionsR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedcoinstransactionsandeachconfirmation"></a>
# **NewConfirmedCoinsTransactionsAndEachConfirmation**
> NewConfirmedCoinsTransactionsAndEachConfirmationR NewConfirmedCoinsTransactionsAndEachConfirmation (string blockchain, string network, string context = null, NewConfirmedCoinsTransactionsAndEachConfirmationRB newConfirmedCoinsTransactionsAndEachConfirmationRB = null)

New confirmed coins transactions and each confirmation

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new incoming or outgoing confirmed transactions for coins from/to the customer's address with also a response at each confirmation the transaction has received until the specified confirmations limit is reached. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.     Being confirmed means that the transactions are verified by miners and added to the next block. This endpoint refers to **coins transactions only, not tokens**.    {note}For UTXO-based protocols like Bitcoin a transaction could have multiple inputs and outputs which means the address could in as both sender and recipient. [Here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-data-returned-for-utxo-based-transactions) is how we inform you on that.{/note}    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewConfirmedCoinsTransactionsAndEachConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedCoinsTransactionsAndEachConfirmationRB = new NewConfirmedCoinsTransactionsAndEachConfirmationRB(); // NewConfirmedCoinsTransactionsAndEachConfirmationRB |  (optional) 

            try
            {
                // New confirmed coins transactions and each confirmation
                NewConfirmedCoinsTransactionsAndEachConfirmationR result = apiInstance.NewConfirmedCoinsTransactionsAndEachConfirmation(blockchain, network, context, newConfirmedCoinsTransactionsAndEachConfirmationRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedCoinsTransactionsAndEachConfirmation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewConfirmedCoinsTransactionsAndEachConfirmationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New confirmed coins transactions and each confirmation
    ApiResponse<NewConfirmedCoinsTransactionsAndEachConfirmationR> response = apiInstance.NewConfirmedCoinsTransactionsAndEachConfirmationWithHttpInfo(blockchain, network, context, newConfirmedCoinsTransactionsAndEachConfirmationRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedCoinsTransactionsAndEachConfirmationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newConfirmedCoinsTransactionsAndEachConfirmationRB** | [**NewConfirmedCoinsTransactionsAndEachConfirmationRB**](NewConfirmedCoinsTransactionsAndEachConfirmationRB.md) |  | [optional]  |

### Return type

[**NewConfirmedCoinsTransactionsAndEachConfirmationR**](NewConfirmedCoinsTransactionsAndEachConfirmationR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedcoinstransactionsforspecificamount"></a>
# **NewConfirmedCoinsTransactionsForSpecificAmount**
> NewConfirmedCoinsTransactionsForSpecificAmountR NewConfirmedCoinsTransactionsForSpecificAmount (string blockchain, string network, string context = null, NewConfirmedCoinsTransactionsForSpecificAmountRB newConfirmedCoinsTransactionsForSpecificAmountRB = null)

New Confirmed Coins Transactions For Specific Amount

Through this endpoint customers can create callback subscriptions for a specific event and \"amountHigherThan\" value. In this case the event is when there are new incoming or outgoing confirmed coins transactions for the specified blockchain and the amount is equal or higher than the value specified.  By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs  filtered for the specified amount. The information is returned per specified address.    Being confirmed means that the transactions are verified by miners and added to the next block.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewConfirmedCoinsTransactionsForSpecificAmountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedCoinsTransactionsForSpecificAmountRB = new NewConfirmedCoinsTransactionsForSpecificAmountRB(); // NewConfirmedCoinsTransactionsForSpecificAmountRB |  (optional) 

            try
            {
                // New Confirmed Coins Transactions For Specific Amount
                NewConfirmedCoinsTransactionsForSpecificAmountR result = apiInstance.NewConfirmedCoinsTransactionsForSpecificAmount(blockchain, network, context, newConfirmedCoinsTransactionsForSpecificAmountRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedCoinsTransactionsForSpecificAmount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewConfirmedCoinsTransactionsForSpecificAmountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New Confirmed Coins Transactions For Specific Amount
    ApiResponse<NewConfirmedCoinsTransactionsForSpecificAmountR> response = apiInstance.NewConfirmedCoinsTransactionsForSpecificAmountWithHttpInfo(blockchain, network, context, newConfirmedCoinsTransactionsForSpecificAmountRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedCoinsTransactionsForSpecificAmountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newConfirmedCoinsTransactionsForSpecificAmountRB** | [**NewConfirmedCoinsTransactionsForSpecificAmountRB**](NewConfirmedCoinsTransactionsForSpecificAmountRB.md) |  | [optional]  |

### Return type

[**NewConfirmedCoinsTransactionsForSpecificAmountR**](NewConfirmedCoinsTransactionsForSpecificAmountR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedinternaltransactions"></a>
# **NewConfirmedInternalTransactions**
> NewConfirmedInternalTransactionsR NewConfirmedInternalTransactions (string blockchain, string network, string context = null, NewConfirmedInternalTransactionsRB newConfirmedInternalTransactionsRB = null)

New confirmed internal transactions

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new confirmed internal transactions. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs.    Being confirmed means that the transactions are verified by miners and added to the next block.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewConfirmedInternalTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = ethereum-classic;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = mordor;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedInternalTransactionsRB = new NewConfirmedInternalTransactionsRB(); // NewConfirmedInternalTransactionsRB |  (optional) 

            try
            {
                // New confirmed internal transactions
                NewConfirmedInternalTransactionsR result = apiInstance.NewConfirmedInternalTransactions(blockchain, network, context, newConfirmedInternalTransactionsRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedInternalTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewConfirmedInternalTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New confirmed internal transactions
    ApiResponse<NewConfirmedInternalTransactionsR> response = apiInstance.NewConfirmedInternalTransactionsWithHttpInfo(blockchain, network, context, newConfirmedInternalTransactionsRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedInternalTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newConfirmedInternalTransactionsRB** | [**NewConfirmedInternalTransactionsRB**](NewConfirmedInternalTransactionsRB.md) |  | [optional]  |

### Return type

[**NewConfirmedInternalTransactionsR**](NewConfirmedInternalTransactionsR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedinternaltransactionsandeachconfirmation"></a>
# **NewConfirmedInternalTransactionsAndEachConfirmation**
> NewConfirmedInternalTransactionsAndEachConfirmationR NewConfirmedInternalTransactionsAndEachConfirmation (string blockchain, string network, string context = null, NewConfirmedInternalTransactionsAndEachConfirmationRB newConfirmedInternalTransactionsAndEachConfirmationRB = null)

New confirmed internal transactions and each confirmation

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new confirmed internal transactions. Includes also a response at each confirmation the transaction receives until the specified confirmations limit is reached. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs.     Being confirmed means that the transactions are verified by miners and added to the next block.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewConfirmedInternalTransactionsAndEachConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = ethereum-classic;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = mordor;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedInternalTransactionsAndEachConfirmationRB = new NewConfirmedInternalTransactionsAndEachConfirmationRB(); // NewConfirmedInternalTransactionsAndEachConfirmationRB |  (optional) 

            try
            {
                // New confirmed internal transactions and each confirmation
                NewConfirmedInternalTransactionsAndEachConfirmationR result = apiInstance.NewConfirmedInternalTransactionsAndEachConfirmation(blockchain, network, context, newConfirmedInternalTransactionsAndEachConfirmationRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedInternalTransactionsAndEachConfirmation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewConfirmedInternalTransactionsAndEachConfirmationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New confirmed internal transactions and each confirmation
    ApiResponse<NewConfirmedInternalTransactionsAndEachConfirmationR> response = apiInstance.NewConfirmedInternalTransactionsAndEachConfirmationWithHttpInfo(blockchain, network, context, newConfirmedInternalTransactionsAndEachConfirmationRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedInternalTransactionsAndEachConfirmationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newConfirmedInternalTransactionsAndEachConfirmationRB** | [**NewConfirmedInternalTransactionsAndEachConfirmationRB**](NewConfirmedInternalTransactionsAndEachConfirmationRB.md) |  | [optional]  |

### Return type

[**NewConfirmedInternalTransactionsAndEachConfirmationR**](NewConfirmedInternalTransactionsAndEachConfirmationR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedinternaltransactionsforspecificamount"></a>
# **NewConfirmedInternalTransactionsForSpecificAmount**
> NewConfirmedInternalTransactionsForSpecificAmountR NewConfirmedInternalTransactionsForSpecificAmount (string blockchain, string network, string context = null, NewConfirmedInternalTransactionsForSpecificAmountRB newConfirmedInternalTransactionsForSpecificAmountRB = null)

New Confirmed Internal Transactions For Specific Amount

Through this endpoint customers can create callback subscriptions for a specific event and \"amountHigherThan\" value. In this case the event is when there are new confirmed internal transactions and the amount is equal or higher than a value, specified by the customer. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs, filtered for the specified amount.  Being confirmed means that the transactions are verified by miners and added to the next block

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewConfirmedInternalTransactionsForSpecificAmountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = ethereum;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = ropsten;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedInternalTransactionsForSpecificAmountRB = new NewConfirmedInternalTransactionsForSpecificAmountRB(); // NewConfirmedInternalTransactionsForSpecificAmountRB |  (optional) 

            try
            {
                // New Confirmed Internal Transactions For Specific Amount
                NewConfirmedInternalTransactionsForSpecificAmountR result = apiInstance.NewConfirmedInternalTransactionsForSpecificAmount(blockchain, network, context, newConfirmedInternalTransactionsForSpecificAmountRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedInternalTransactionsForSpecificAmount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewConfirmedInternalTransactionsForSpecificAmountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New Confirmed Internal Transactions For Specific Amount
    ApiResponse<NewConfirmedInternalTransactionsForSpecificAmountR> response = apiInstance.NewConfirmedInternalTransactionsForSpecificAmountWithHttpInfo(blockchain, network, context, newConfirmedInternalTransactionsForSpecificAmountRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedInternalTransactionsForSpecificAmountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newConfirmedInternalTransactionsForSpecificAmountRB** | [**NewConfirmedInternalTransactionsForSpecificAmountRB**](NewConfirmedInternalTransactionsForSpecificAmountRB.md) |  | [optional]  |

### Return type

[**NewConfirmedInternalTransactionsForSpecificAmountR**](NewConfirmedInternalTransactionsForSpecificAmountR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedtokentransactionsforspecificamount"></a>
# **NewConfirmedTokenTransactionsForSpecificAmount**
> NewConfirmedTokenTransactionsForSpecificAmountR NewConfirmedTokenTransactionsForSpecificAmount (string blockchain, string network, string context = null, NewConfirmedTokenTransactionsForSpecificAmountRB newConfirmedTokenTransactionsForSpecificAmountRB = null)

New Confirmed Token Transactions For Specific Amount

Through this endpoint customers can create callback subscriptions for a specific event and \"amountHigherThan\" value. In this case the event is when there are new incoming or outgoing confirmed token transactions for the specified blockchain and the amount is equal or higher than the value specified. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs, filtered for the specified amount.  Being confirmed means that the transactions are verified by miners and added to the next block. This endpoint refers to tokens transactions only, not coins.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewConfirmedTokenTransactionsForSpecificAmountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = ethereum;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = ropsten;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedTokenTransactionsForSpecificAmountRB = new NewConfirmedTokenTransactionsForSpecificAmountRB(); // NewConfirmedTokenTransactionsForSpecificAmountRB |  (optional) 

            try
            {
                // New Confirmed Token Transactions For Specific Amount
                NewConfirmedTokenTransactionsForSpecificAmountR result = apiInstance.NewConfirmedTokenTransactionsForSpecificAmount(blockchain, network, context, newConfirmedTokenTransactionsForSpecificAmountRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedTokenTransactionsForSpecificAmount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewConfirmedTokenTransactionsForSpecificAmountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New Confirmed Token Transactions For Specific Amount
    ApiResponse<NewConfirmedTokenTransactionsForSpecificAmountR> response = apiInstance.NewConfirmedTokenTransactionsForSpecificAmountWithHttpInfo(blockchain, network, context, newConfirmedTokenTransactionsForSpecificAmountRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedTokenTransactionsForSpecificAmountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newConfirmedTokenTransactionsForSpecificAmountRB** | [**NewConfirmedTokenTransactionsForSpecificAmountRB**](NewConfirmedTokenTransactionsForSpecificAmountRB.md) |  | [optional]  |

### Return type

[**NewConfirmedTokenTransactionsForSpecificAmountR**](NewConfirmedTokenTransactionsForSpecificAmountR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **404** | The specified resource has not been found. |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedtokenstransactions"></a>
# **NewConfirmedTokensTransactions**
> NewConfirmedTokensTransactionsR NewConfirmedTokensTransactions (string blockchain, string network, string context = null, NewConfirmedTokensTransactionsRB newConfirmedTokensTransactionsRB = null)

New confirmed tokens transactions

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new incoming or outgoing confirmed transactions for tokens from/to the customer's address. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.     Being confirmed means that the transactions are verified by miners and added to the next block. This endpoint refers to **tokens transactions only, not coins**.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewConfirmedTokensTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = ethereum;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = ropsten;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedTokensTransactionsRB = new NewConfirmedTokensTransactionsRB(); // NewConfirmedTokensTransactionsRB |  (optional) 

            try
            {
                // New confirmed tokens transactions
                NewConfirmedTokensTransactionsR result = apiInstance.NewConfirmedTokensTransactions(blockchain, network, context, newConfirmedTokensTransactionsRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedTokensTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewConfirmedTokensTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New confirmed tokens transactions
    ApiResponse<NewConfirmedTokensTransactionsR> response = apiInstance.NewConfirmedTokensTransactionsWithHttpInfo(blockchain, network, context, newConfirmedTokensTransactionsRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedTokensTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newConfirmedTokensTransactionsRB** | [**NewConfirmedTokensTransactionsRB**](NewConfirmedTokensTransactionsRB.md) |  | [optional]  |

### Return type

[**NewConfirmedTokensTransactionsR**](NewConfirmedTokensTransactionsR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newconfirmedtokenstransactionsandeachconfirmation"></a>
# **NewConfirmedTokensTransactionsAndEachConfirmation**
> NewConfirmedTokensTransactionsAndEachConfirmationR NewConfirmedTokensTransactionsAndEachConfirmation (string blockchain, string network, string context = null, NewConfirmedTokensTransactionsAndEachConfirmationRB newConfirmedTokensTransactionsAndEachConfirmationRB = null)

New confirmed tokens transactions and each confirmation

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new incoming or outgoing confirmed transactions for tokens from/to the customer's address with also a response at each confirmation the transaction has received until the specified confirmations limit is reached. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.     Being confirmed means that the transactions are verified by miners and added to the next block. This endpoint refers to **tokens transactions only, not coins**.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewConfirmedTokensTransactionsAndEachConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = ethereum;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = ropsten;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newConfirmedTokensTransactionsAndEachConfirmationRB = new NewConfirmedTokensTransactionsAndEachConfirmationRB(); // NewConfirmedTokensTransactionsAndEachConfirmationRB |  (optional) 

            try
            {
                // New confirmed tokens transactions and each confirmation
                NewConfirmedTokensTransactionsAndEachConfirmationR result = apiInstance.NewConfirmedTokensTransactionsAndEachConfirmation(blockchain, network, context, newConfirmedTokensTransactionsAndEachConfirmationRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedTokensTransactionsAndEachConfirmation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewConfirmedTokensTransactionsAndEachConfirmationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New confirmed tokens transactions and each confirmation
    ApiResponse<NewConfirmedTokensTransactionsAndEachConfirmationR> response = apiInstance.NewConfirmedTokensTransactionsAndEachConfirmationWithHttpInfo(blockchain, network, context, newConfirmedTokensTransactionsAndEachConfirmationRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewConfirmedTokensTransactionsAndEachConfirmationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newConfirmedTokensTransactionsAndEachConfirmationRB** | [**NewConfirmedTokensTransactionsAndEachConfirmationRB**](NewConfirmedTokensTransactionsAndEachConfirmationRB.md) |  | [optional]  |

### Return type

[**NewConfirmedTokensTransactionsAndEachConfirmationR**](NewConfirmedTokensTransactionsAndEachConfirmationR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successful. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newunconfirmedcoinstransactions"></a>
# **NewUnconfirmedCoinsTransactions**
> NewUnconfirmedCoinsTransactionsR NewUnconfirmedCoinsTransactions (string blockchain, string network, string context = null, NewUnconfirmedCoinsTransactionsRB newUnconfirmedCoinsTransactionsRB = null)

New unconfirmed coins transactions

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new unconfirmed coins transactions for the user. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.    Unconfirmed coins transactions remain in the mempool (memory pool) until they are confirmed by miners and added to the next block. Sometimes spikes in transaction activity can cause delays in confirmations.    {note}For UTXO-based protocols like Bitcoin a transaction could have multiple inputs and outputs which means the address could in as both sender and recipient. [Here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-data-returned-for-utxo-based-transactions) is how we inform you on that.{/note}    {warning}We cannot guarantee at 100% that webhooks for unconfirmed transactions will always be received. Some may **not get received** due to the possibility of some nodes not being updated with that information. This can occur in networks with low activity and/or not many nodes, e.g. Testnet networks and rarely Mainnets.{/warning}    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {note}It is also **important to note** that just because pending unconfirmed transactions are in the mempool, **doesn't necessarily** mean they will get confirmed.{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewUnconfirmedCoinsTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newUnconfirmedCoinsTransactionsRB = new NewUnconfirmedCoinsTransactionsRB(); // NewUnconfirmedCoinsTransactionsRB |  (optional) 

            try
            {
                // New unconfirmed coins transactions
                NewUnconfirmedCoinsTransactionsR result = apiInstance.NewUnconfirmedCoinsTransactions(blockchain, network, context, newUnconfirmedCoinsTransactionsRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewUnconfirmedCoinsTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewUnconfirmedCoinsTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New unconfirmed coins transactions
    ApiResponse<NewUnconfirmedCoinsTransactionsR> response = apiInstance.NewUnconfirmedCoinsTransactionsWithHttpInfo(blockchain, network, context, newUnconfirmedCoinsTransactionsRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewUnconfirmedCoinsTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newUnconfirmedCoinsTransactionsRB** | [**NewUnconfirmedCoinsTransactionsRB**](NewUnconfirmedCoinsTransactionsRB.md) |  | [optional]  |

### Return type

[**NewUnconfirmedCoinsTransactionsR**](NewUnconfirmedCoinsTransactionsR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newunconfirmedtokenstransactions"></a>
# **NewUnconfirmedTokensTransactions**
> NewUnconfirmedTokensTransactionsR NewUnconfirmedTokensTransactions (string blockchain, string network, string context = null, NewUnconfirmedTokensTransactionsRB newUnconfirmedTokensTransactionsRB = null)

New unconfirmed tokens transactions

Through this endpoint customers can create callback subscriptions for a specific event. In this case the event is when there are new unconfirmed tokens transactions for the user. By creating this subscription the user will be notified by Crypto APIs 2.0 when that event occurs. The information is returned per specified address.    Unconfirmed tokens transactions remain in the mempool (memory pool) until they are confirmed by miners and added to the next block. Sometimes spikes in transaction activity can cause delays in confirmations.    {warning}We cannot guarantee at 100% that webhooks for unconfirmed transactions will always be received. Some may **not get received** due to the possibility of some nodes not being updated with that information. This can occur in networks with low activity and/or not many nodes, e.g. Testnet networks and rarely Mainnets.{/warning}    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {note}It is also **important to note** that just because pending unconfirmed transactions are in the mempool, **doesn't necessarily** mean they will get confirmed.{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class NewUnconfirmedTokensTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CreateSubscriptionsForApi(config);
            var blockchain = ethereum;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = ropsten;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var newUnconfirmedTokensTransactionsRB = new NewUnconfirmedTokensTransactionsRB(); // NewUnconfirmedTokensTransactionsRB |  (optional) 

            try
            {
                // New unconfirmed tokens transactions
                NewUnconfirmedTokensTransactionsR result = apiInstance.NewUnconfirmedTokensTransactions(blockchain, network, context, newUnconfirmedTokensTransactionsRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateSubscriptionsForApi.NewUnconfirmedTokensTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewUnconfirmedTokensTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // New unconfirmed tokens transactions
    ApiResponse<NewUnconfirmedTokensTransactionsR> response = apiInstance.NewUnconfirmedTokensTransactionsWithHttpInfo(blockchain, network, context, newUnconfirmedTokensTransactionsRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateSubscriptionsForApi.NewUnconfirmedTokensTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **newUnconfirmedTokensTransactionsRB** | [**NewUnconfirmedTokensTransactionsRB**](NewUnconfirmedTokensTransactionsRB.md) |  | [optional]  |

### Return type

[**NewUnconfirmedTokensTransactionsR**](NewUnconfirmedTokensTransactionsR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The resource has been successfully created. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | 409 |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | Your request body for POST requests must have a structure of { data: { item: [...properties] } } |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

