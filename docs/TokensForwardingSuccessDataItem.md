# CryptoAPIs.Model.TokensForwardingSuccessDataItem
Defines an `item` as one result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
**Network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
**FromAddress** | **string** | Represents the hash of the address that provides the tokens. | 
**ToAddress** | **string** | Represents the hash of the address to forward the tokens to. | 
**SpentFeesAmount** | **string** | Represents the amount of the fee spent for the tokens to be forwarded. | 
**SpentFeesUnit** | **string** | Represents the unit of the fee spent for the tokens to be forwarded, e.g. BTC. | 
**TriggerTransactionId** | **string** | Defines the unique Transaction ID that triggered the token forwarding. | 
**ForwardingTransactionId** | **string** | Defines the unique Transaction ID that forwarded the tokens. | 
**TokenType** | **string** | Defines the type of token sent with the transaction, e.g. ERC 20. | 
**Token** | [**TokensForwardingSuccessToken**](TokensForwardingSuccessToken.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

