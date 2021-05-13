# CryptoAPIs.Model.GetExchangeRateByAssetsIDsRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalculationTimestamp** | **int** | Defines the time of the market data used to calculate the exchange rate in UNIX Timestamp. | 
**FromAssetId** | **string** | Defines the base asset Reference ID to get a rate for. | 
**FromAssetSymbol** | **string** | Defines the base asset symbol to get a rate for. | 
**Rate** | **string** | Defines the exchange rate between assets calculated by weighted average of the last trades in every exchange for the last 24 hours by giving more weight to exchanges with higher volume. | 
**ToAssetId** | **string** | Defines the relation asset Reference ID in which the base asset rate will be displayed. | 
**ToAssetSymbol** | **string** | Defines the relation asset symbol in which the base asset rate will be displayed. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

