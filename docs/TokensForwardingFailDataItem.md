# Org.OpenAPITools.Model.TokensForwardingFailDataItem
Defines an `item` as one result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
**Network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
**FromAddress** | **string** | Represents the hash of the address that provides the tokens. | 
**ToAddress** | **string** | Represents the hash of the address to forward the tokens to. | 
**TriggerTransactionId** | **string** | Defines the unique Transaction ID that triggered the token forwarding. | 
**ErrorCode** | **string** | Represents the error code received for the failed token forwarding. | 
**ErrorMessage** | **string** | Represents the error message received for the failed token forwarding. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

