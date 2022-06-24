# CryptoAPIs.Api.ExchangeRatesApi

All URIs are relative to *https://rest.cryptoapis.io/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetExchangeRateByAssetSymbols**](ExchangeRatesApi.md#getexchangeratebyassetsymbols) | **GET** /market-data/exchange-rates/by-symbols/{fromAssetSymbol}/{toAssetSymbol} | Get Exchange Rate By Asset Symbols |
| [**GetExchangeRateByAssetsIDs**](ExchangeRatesApi.md#getexchangeratebyassetsids) | **GET** /market-data/exchange-rates/by-asset-ids/{fromAssetId}/{toAssetId} | Get Exchange Rate By Assets IDs |

<a name="getexchangeratebyassetsymbols"></a>
# **GetExchangeRateByAssetSymbols**
> GetExchangeRateByAssetSymbolsR GetExchangeRateByAssetSymbols (string fromAssetSymbol, string toAssetSymbol, string context = null, int? calculationTimestamp = null)

Get Exchange Rate By Asset Symbols

Through this endpoint customers can obtain exchange rates by asset symbols. The process represents the exchange rate value of a single unit of one asset versus another one. Data is provided per unique asset symbol.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetExchangeRateByAssetSymbolsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExchangeRatesApi(config);
            var fromAssetSymbol = btc;  // string | Defines the base asset symbol to get a rate for.
            var toAssetSymbol = usd;  // string | Defines the relation asset symbol in which the base asset rate will be displayed.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var calculationTimestamp = 1635514425;  // int? | Defines the time of the market data used to calculate the exchange rate in UNIX Timestamp. (optional) 

            try
            {
                // Get Exchange Rate By Asset Symbols
                GetExchangeRateByAssetSymbolsR result = apiInstance.GetExchangeRateByAssetSymbols(fromAssetSymbol, toAssetSymbol, context, calculationTimestamp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExchangeRatesApi.GetExchangeRateByAssetSymbols: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExchangeRateByAssetSymbolsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Exchange Rate By Asset Symbols
    ApiResponse<GetExchangeRateByAssetSymbolsR> response = apiInstance.GetExchangeRateByAssetSymbolsWithHttpInfo(fromAssetSymbol, toAssetSymbol, context, calculationTimestamp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExchangeRatesApi.GetExchangeRateByAssetSymbolsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromAssetSymbol** | **string** | Defines the base asset symbol to get a rate for. |  |
| **toAssetSymbol** | **string** | Defines the relation asset symbol in which the base asset rate will be displayed. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **calculationTimestamp** | **int?** | Defines the time of the market data used to calculate the exchange rate in UNIX Timestamp. | [optional]  |

### Return type

[**GetExchangeRateByAssetSymbolsR**](GetExchangeRateByAssetSymbolsR.md)

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
| **422** | 422 |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexchangeratebyassetsids"></a>
# **GetExchangeRateByAssetsIDs**
> GetExchangeRateByAssetsIDsR GetExchangeRateByAssetsIDs (string fromAssetId, string toAssetId, string context = null, int? calculationTimestamp = null)

Get Exchange Rate By Assets IDs

Through this endpoint customers can obtain exchange rates by asset IDs. The process represents the exchange rate value of a single unit of one asset versus another one. Data is provided per unique asset Reference ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CryptoAPIs.Api;
using CryptoAPIs.Client;
using CryptoAPIs.Model;

namespace Example
{
    public class GetExchangeRateByAssetsIDsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.cryptoapis.io/v2";
            // Configure API key authorization: ApiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExchangeRatesApi(config);
            var fromAssetId = 5b1ea92e584bf50020130612;  // string | Defines the base asset Reference ID to get a rate for.
            var toAssetId = 5b1ea92e584bf50020130615;  // string | Defines the relation asset Reference ID in which the base asset rate will be displayed.
            var context = yourExampleString;  // string | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. `context` is specified by the user. (optional) 
            var calculationTimestamp = 1618577849;  // int? | Defines the time of the market data used to calculate the exchange rate in UNIX Timestamp. (optional) 

            try
            {
                // Get Exchange Rate By Assets IDs
                GetExchangeRateByAssetsIDsR result = apiInstance.GetExchangeRateByAssetsIDs(fromAssetId, toAssetId, context, calculationTimestamp);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExchangeRatesApi.GetExchangeRateByAssetsIDs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExchangeRateByAssetsIDsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Exchange Rate By Assets IDs
    ApiResponse<GetExchangeRateByAssetsIDsR> response = apiInstance.GetExchangeRateByAssetsIDsWithHttpInfo(fromAssetId, toAssetId, context, calculationTimestamp);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExchangeRatesApi.GetExchangeRateByAssetsIDsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromAssetId** | **string** | Defines the base asset Reference ID to get a rate for. |  |
| **toAssetId** | **string** | Defines the relation asset Reference ID in which the base asset rate will be displayed. |  |
| **context** | **string** | In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user. | [optional]  |
| **calculationTimestamp** | **int?** | Defines the time of the market data used to calculate the exchange rate in UNIX Timestamp. | [optional]  |

### Return type

[**GetExchangeRateByAssetsIDsR**](GetExchangeRateByAssetsIDsR.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The request has been successfull. |  -  |
| **400** | 400 |  -  |
| **401** | 401 |  -  |
| **402** | You have insufficient credits. Please upgrade your plan from your Dashboard or contact our team via email. |  -  |
| **403** | 403 |  -  |
| **409** | The data provided seems to be invalid. |  -  |
| **415** | The selected Media Type is unavailable. The Content-Type header should be &#39;application/json&#39;. |  -  |
| **422** | 422 |  -  |
| **429** | The request limit has been reached. There can be maximum {requests} requests per {seconds} second(s) made. Please contact our team via email if you need more or upgrade your plan. |  -  |
| **500** | An unexpected server error has occurred, we are working to fix this. Please try again later and in case it occurs again please report it to our team via email. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

