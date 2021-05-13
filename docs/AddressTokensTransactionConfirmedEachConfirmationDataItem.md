# CryptoAPIs.Model.AddressTokensTransactionConfirmedEachConfirmationDataItem
Defines an `item` as one result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
**Network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
**Address** | **string** | Defines the specific address to which the transaction has been sent. | 
**MinedInBlock** | [**AddressTokensTransactionConfirmedEachConfirmationDataItemMinedInBlock**](AddressTokensTransactionConfirmedEachConfirmationDataItemMinedInBlock.md) |  | 
**TransactionId** | **string** | Defines the unique ID of the specific transaction, i.e. its identification number. | 
**CurrentConfirmations** | **int** | Defines the number of currently received confirmations for the transaction. | 
**TargetConfirmations** | **int** | Defines the number of confirmation transactions requested as callbacks, i.e. the system can notify till the n-th confirmation. | 
**TokenType** | **string** | Defines the type of token sent with the transaction, e.g. ERC 20. | 
**Token** | [**AddressTokensTransactionConfirmedEachConfirmationToken**](AddressTokensTransactionConfirmedEachConfirmationToken.md) |  | 
**Direction** | **string** | Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

