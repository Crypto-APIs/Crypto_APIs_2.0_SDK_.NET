# CryptoAPIs.Model.AddressInternalTransactionConfirmedDataItem
Defines an `item` as one result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
**Network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
**Address** | **string** | Defines the specific address of the internal transaction. | 
**MinedInBlock** | [**AddressInternalTransactionConfirmedDataItemMinedInBlock**](AddressInternalTransactionConfirmedDataItemMinedInBlock.md) |  | 
**ParentTransactionId** | **string** | Defines the Parent Transaction&#39;s unique ID. | 
**OperationId** | **string** | Defines the specific operation&#39;s unique ID. | 
**Amount** | **string** | Defines the amount of coins sent with the confirmed transaction. | 
**Unit** | **string** | Defines the unit of the transaction, e.g. Gwei. | 
**Direction** | **string** | Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

