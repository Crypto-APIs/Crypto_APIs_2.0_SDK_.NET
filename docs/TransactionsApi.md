# CryptoAPIs.Api.TransactionsApi

All URIs are relative to *https://rest.cryptoapis.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCoinsTransactionFromAddressForWholeAmount**](TransactionsApi.md#createcoinstransactionfromaddressforwholeamount) | **POST** /wallet-as-a-service/wallets/{walletId}/{blockchain}/{network}/addresses/{address}/all-transaction-requests | Create Coins Transaction From Address For Whole Amount |
| [**CreateCoinsTransactionRequestFromAddress**](TransactionsApi.md#createcoinstransactionrequestfromaddress) | **POST** /wallet-as-a-service/wallets/{walletId}/{blockchain}/{network}/addresses/{address}/transaction-requests | Create Coins Transaction Request from Address |
| [**CreateCoinsTransactionRequestFromWallet**](TransactionsApi.md#createcoinstransactionrequestfromwallet) | **POST** /wallet-as-a-service/wallets/{walletId}/{blockchain}/{network}/transaction-requests | Create Coins Transaction Request from Wallet |
| [**CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriority**](TransactionsApi.md#createfungibletokentransactionrequestfromaddresswithoutfeepriority) | **POST** /wallet-as-a-service/wallets/{walletId}/{blockchain}/{network}/addresses/{senderAddress}/feeless-token-transaction-requests | Create Fungible Token Transaction Request From Address Without Fee Priority |
| [**CreateFungibleTokensTransactionRequestFromAddress**](TransactionsApi.md#createfungibletokenstransactionrequestfromaddress) | **POST** /wallet-as-a-service/wallets/{walletId}/{blockchain}/{network}/addresses/{senderAddress}/token-transaction-requests | Create Fungible Tokens Transaction Request from Address |
| [**CreateSingleTransactionRequestFromAddressWithoutFeePriority**](TransactionsApi.md#createsingletransactionrequestfromaddresswithoutfeepriority) | **POST** /wallet-as-a-service/wallets/{walletId}/{blockchain}/{network}/addresses/{address}/feeless-transaction-requests | Create Single Transaction Request From Address Without Fee Priority |

<a name="createcoinstransactionfromaddressforwholeamount"></a>
# **CreateCoinsTransactionFromAddressForWholeAmount**
> CreateCoinsTransactionFromAddressForWholeAmountR CreateCoinsTransactionFromAddressForWholeAmount (string address, string blockchain, string network, string walletId, string context = null, CreateCoinsTransactionFromAddressForWholeAmountRB createCoinsTransactionFromAddressForWholeAmountRB = null)

Create Coins Transaction From Address For Whole Amount

Through this endpoint customers can create a new transaction from address for **coins** specifically, which will transfer over the entire available amount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class CreateCoinsTransactionFromAddressForWholeAmountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TransactionsApi(config);
            var address = 0x6f61e3c2fbb8c8be698bd0907ba6c04b62800fe5;  // string | Defines the source address.
            var blockchain = ethereum;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = ropsten;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var walletId = 609e221675d04500068718dc;  // string | Represents the sender's specific and unique Wallet ID of the sender.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var createCoinsTransactionFromAddressForWholeAmountRB = new CreateCoinsTransactionFromAddressForWholeAmountRB(); // CreateCoinsTransactionFromAddressForWholeAmountRB |  (optional) 

            try
            {
                // Create Coins Transaction From Address For Whole Amount
                CreateCoinsTransactionFromAddressForWholeAmountR result = apiInstance.CreateCoinsTransactionFromAddressForWholeAmount(address, blockchain, network, walletId, context, createCoinsTransactionFromAddressForWholeAmountRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateCoinsTransactionFromAddressForWholeAmount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCoinsTransactionFromAddressForWholeAmountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Coins Transaction From Address For Whole Amount
    ApiResponse<CreateCoinsTransactionFromAddressForWholeAmountR> response = apiInstance.CreateCoinsTransactionFromAddressForWholeAmountWithHttpInfo(address, blockchain, network, walletId, context, createCoinsTransactionFromAddressForWholeAmountRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateCoinsTransactionFromAddressForWholeAmountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | Defines the source address. |  |
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **walletId** | **string** | Represents the sender&#39;s specific and unique Wallet ID of the sender. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **createCoinsTransactionFromAddressForWholeAmountRB** | [**CreateCoinsTransactionFromAddressForWholeAmountRB**](CreateCoinsTransactionFromAddressForWholeAmountRB.md) |  | [optional]  |

### Return type

[**CreateCoinsTransactionFromAddressForWholeAmountR**](CreateCoinsTransactionFromAddressForWholeAmountR.md)

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

<a name="createcoinstransactionrequestfromaddress"></a>
# **CreateCoinsTransactionRequestFromAddress**
> CreateCoinsTransactionRequestFromAddressR CreateCoinsTransactionRequestFromAddress (string address, string blockchain, string network, string walletId, string context = null, CreateCoinsTransactionRequestFromAddressRB createCoinsTransactionRequestFromAddressRB = null)

Create Coins Transaction Request from Address

Through this endpoint users can create a new single transaction request from one address to another.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class CreateCoinsTransactionRequestFromAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TransactionsApi(config);
            var address = 0x6f61e3c2fbb8c8be698bd0907ba6c04b62800fe5;  // string | Defines the specific source address for the transaction. For XRP we also support the X-address format.
            var blockchain = ethereum;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = ropsten;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var walletId = 609e221675d04500068718dc;  // string | Represents the sender's specific and unique Wallet ID of the sender.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var createCoinsTransactionRequestFromAddressRB = new CreateCoinsTransactionRequestFromAddressRB(); // CreateCoinsTransactionRequestFromAddressRB |  (optional) 

            try
            {
                // Create Coins Transaction Request from Address
                CreateCoinsTransactionRequestFromAddressR result = apiInstance.CreateCoinsTransactionRequestFromAddress(address, blockchain, network, walletId, context, createCoinsTransactionRequestFromAddressRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateCoinsTransactionRequestFromAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCoinsTransactionRequestFromAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Coins Transaction Request from Address
    ApiResponse<CreateCoinsTransactionRequestFromAddressR> response = apiInstance.CreateCoinsTransactionRequestFromAddressWithHttpInfo(address, blockchain, network, walletId, context, createCoinsTransactionRequestFromAddressRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateCoinsTransactionRequestFromAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | Defines the specific source address for the transaction. For XRP we also support the X-address format. |  |
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **walletId** | **string** | Represents the sender&#39;s specific and unique Wallet ID of the sender. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **createCoinsTransactionRequestFromAddressRB** | [**CreateCoinsTransactionRequestFromAddressRB**](CreateCoinsTransactionRequestFromAddressRB.md) |  | [optional]  |

### Return type

[**CreateCoinsTransactionRequestFromAddressR**](CreateCoinsTransactionRequestFromAddressR.md)

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

<a name="createcoinstransactionrequestfromwallet"></a>
# **CreateCoinsTransactionRequestFromWallet**
> CreateCoinsTransactionRequestFromWalletR CreateCoinsTransactionRequestFromWallet (string blockchain, string network, string walletId, string context = null, CreateCoinsTransactionRequestFromWalletRB createCoinsTransactionRequestFromWalletRB = null)

Create Coins Transaction Request from Wallet

Through this endpoint users can create a new transaction request from the entire Wallet instead from just a specific address. This endpoint can generate transactions from multiple to multiple addresses.    {warning}This is available **only** for UTXO-based protocols such as Bitcoin, Bitcoin Cash, Litecoin, etc. It **is not** available for Account-based protocols like Ethereum.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class CreateCoinsTransactionRequestFromWalletExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TransactionsApi(config);
            var blockchain = bitcoin;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = testnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks. (default to testnet)
            var walletId = 609e221675d04500068718dc;  // string | Represents the sender's specific and unique Wallet ID of the sender.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var createCoinsTransactionRequestFromWalletRB = new CreateCoinsTransactionRequestFromWalletRB(); // CreateCoinsTransactionRequestFromWalletRB |  (optional) 

            try
            {
                // Create Coins Transaction Request from Wallet
                CreateCoinsTransactionRequestFromWalletR result = apiInstance.CreateCoinsTransactionRequestFromWallet(blockchain, network, walletId, context, createCoinsTransactionRequestFromWalletRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateCoinsTransactionRequestFromWallet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCoinsTransactionRequestFromWalletWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Coins Transaction Request from Wallet
    ApiResponse<CreateCoinsTransactionRequestFromWalletR> response = apiInstance.CreateCoinsTransactionRequestFromWalletWithHttpInfo(blockchain, network, walletId, context, createCoinsTransactionRequestFromWalletRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateCoinsTransactionRequestFromWalletWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. | [default to testnet] |
| **walletId** | **string** | Represents the sender&#39;s specific and unique Wallet ID of the sender. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **createCoinsTransactionRequestFromWalletRB** | [**CreateCoinsTransactionRequestFromWalletRB**](CreateCoinsTransactionRequestFromWalletRB.md) |  | [optional]  |

### Return type

[**CreateCoinsTransactionRequestFromWalletR**](CreateCoinsTransactionRequestFromWalletR.md)

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

<a name="createfungibletokentransactionrequestfromaddresswithoutfeepriority"></a>
# **CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriority**
> CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityR CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriority (string blockchain, string network, string senderAddress, string walletId, string context = null, CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB createFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB = null)

Create Fungible Token Transaction Request From Address Without Fee Priority

Through this endpoint customers can make a single feeless token transaction on the Tron blockchain protocol. TRX transactions burn certain resources called Bandwidth and Energy. Each account has 1500 bandwidth free for use every 24 hours and more can be obtained by staking TRX. The unit price of Energy is 280 SUN and of bandwidth - 1000 SUN. If the resources are insufficient, TRX will be burned to pay for them.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TransactionsApi(config);
            var blockchain = tron;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = nile;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var senderAddress = TX8VXpdEoNNrKeEuNTfbEXfa9eZivcyUwD;  // string | Defines the specific source address for the transaction.
            var walletId = 62b9b5c3b97f4b0008092714;  // string | Defines the unique ID of the Wallet.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var createFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB = new CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB(); // CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB |  (optional) 

            try
            {
                // Create Fungible Token Transaction Request From Address Without Fee Priority
                CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityR result = apiInstance.CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriority(blockchain, network, senderAddress, walletId, context, createFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriority: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Fungible Token Transaction Request From Address Without Fee Priority
    ApiResponse<CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityR> response = apiInstance.CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityWithHttpInfo(blockchain, network, senderAddress, walletId, context, createFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **senderAddress** | **string** | Defines the specific source address for the transaction. |  |
| **walletId** | **string** | Defines the unique ID of the Wallet. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **createFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB** | [**CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB**](CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB.md) |  | [optional]  |

### Return type

[**CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityR**](CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityR.md)

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

<a name="createfungibletokenstransactionrequestfromaddress"></a>
# **CreateFungibleTokensTransactionRequestFromAddress**
> CreateFungibleTokensTransactionRequestFromAddressR CreateFungibleTokensTransactionRequestFromAddress (string blockchain, string network, string senderAddress, string walletId, string context = null, CreateFungibleTokensTransactionRequestFromAddressRB createFungibleTokensTransactionRequestFromAddressRB = null)

Create Fungible Tokens Transaction Request from Address

Through this endpoint users can make a single token transaction.    {note}To have an operational callback subscription, you need to first verify a domain for the Callback URL. Please see more information on Callbacks [here](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-url).{/note}    {warning}Crypto APIs will notify the user **only when** the event occurs. There are cases when the specific event doesn't happen at all, or takes a long time to do so. A callback notification **will not** be sent if the event does not or cannot occur, or will take long time to occur.{/warning}

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class CreateFungibleTokensTransactionRequestFromAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TransactionsApi(config);
            var blockchain = ethereum;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (default to ethereum)
            var network = mainnet;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks. (default to mainnet)
            var senderAddress = 0x6f61e3c2fbb8c8be698bd0907ba6c04b62800fe5;  // string | Defines the specific source address for the transaction.
            var walletId = 609e221675d04500068718dc;  // string | Defines the unique ID of the Wallet.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var createFungibleTokensTransactionRequestFromAddressRB = new CreateFungibleTokensTransactionRequestFromAddressRB(); // CreateFungibleTokensTransactionRequestFromAddressRB |  (optional) 

            try
            {
                // Create Fungible Tokens Transaction Request from Address
                CreateFungibleTokensTransactionRequestFromAddressR result = apiInstance.CreateFungibleTokensTransactionRequestFromAddress(blockchain, network, senderAddress, walletId, context, createFungibleTokensTransactionRequestFromAddressRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateFungibleTokensTransactionRequestFromAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFungibleTokensTransactionRequestFromAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Fungible Tokens Transaction Request from Address
    ApiResponse<CreateFungibleTokensTransactionRequestFromAddressR> response = apiInstance.CreateFungibleTokensTransactionRequestFromAddressWithHttpInfo(blockchain, network, senderAddress, walletId, context, createFungibleTokensTransactionRequestFromAddressRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateFungibleTokensTransactionRequestFromAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | [default to ethereum] |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. | [default to mainnet] |
| **senderAddress** | **string** | Defines the specific source address for the transaction. |  |
| **walletId** | **string** | Defines the unique ID of the Wallet. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **createFungibleTokensTransactionRequestFromAddressRB** | [**CreateFungibleTokensTransactionRequestFromAddressRB**](CreateFungibleTokensTransactionRequestFromAddressRB.md) |  | [optional]  |

### Return type

[**CreateFungibleTokensTransactionRequestFromAddressR**](CreateFungibleTokensTransactionRequestFromAddressR.md)

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

<a name="createsingletransactionrequestfromaddresswithoutfeepriority"></a>
# **CreateSingleTransactionRequestFromAddressWithoutFeePriority**
> CreateSingleTransactionRequestFromAddressWithoutFeePriorityR CreateSingleTransactionRequestFromAddressWithoutFeePriority (string address, string blockchain, string network, string walletId, string context = null, CreateSingleTransactionRequestFromAddressWithoutFeePriorityRB createSingleTransactionRequestFromAddressWithoutFeePriorityRB = null)

Create Single Transaction Request From Address Without Fee Priority

Through this endpoint users can create a new single transaction request from one address to another. The difference between this endpoint and \"Create Coins Transaction Request from Address\"  is that for Tron blockchain there is no Fee Priority that defines how fast a transaction can be mined.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class CreateSingleTransactionRequestFromAddressWithoutFeePriorityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new TransactionsApi(config);
            var address = TX8VXpdEoNNrKeEuNTfbEXfa9eZivcyUwD;  // string | Defines the specific source address for the transaction.
            var blockchain = tron;  // string | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
            var network = nile;  // string | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \"mainnet\" is the live network with actual data while networks like \"testnet\", \"ropsten\" are test networks.
            var walletId = 62b9b5c3b97f4b0008092714;  // string | Represents the sender's specific and unique Wallet ID of the sender.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var createSingleTransactionRequestFromAddressWithoutFeePriorityRB = new CreateSingleTransactionRequestFromAddressWithoutFeePriorityRB(); // CreateSingleTransactionRequestFromAddressWithoutFeePriorityRB |  (optional) 

            try
            {
                // Create Single Transaction Request From Address Without Fee Priority
                CreateSingleTransactionRequestFromAddressWithoutFeePriorityR result = apiInstance.CreateSingleTransactionRequestFromAddressWithoutFeePriority(address, blockchain, network, walletId, context, createSingleTransactionRequestFromAddressWithoutFeePriorityRB);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateSingleTransactionRequestFromAddressWithoutFeePriority: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSingleTransactionRequestFromAddressWithoutFeePriorityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Single Transaction Request From Address Without Fee Priority
    ApiResponse<CreateSingleTransactionRequestFromAddressWithoutFeePriorityR> response = apiInstance.CreateSingleTransactionRequestFromAddressWithoutFeePriorityWithHttpInfo(address, blockchain, network, walletId, context, createSingleTransactionRequestFromAddressWithoutFeePriorityRB);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateSingleTransactionRequestFromAddressWithoutFeePriorityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | Defines the specific source address for the transaction. |  |
| **blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. |  |
| **network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. |  |
| **walletId** | **string** | Represents the sender&#39;s specific and unique Wallet ID of the sender. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **createSingleTransactionRequestFromAddressWithoutFeePriorityRB** | [**CreateSingleTransactionRequestFromAddressWithoutFeePriorityRB**](CreateSingleTransactionRequestFromAddressWithoutFeePriorityRB.md) |  | [optional]  |

### Return type

[**CreateSingleTransactionRequestFromAddressWithoutFeePriorityR**](CreateSingleTransactionRequestFromAddressWithoutFeePriorityR.md)

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

