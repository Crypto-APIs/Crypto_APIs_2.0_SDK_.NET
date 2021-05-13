# CryptoAPIs.Model.BlockMinedDataItem
Defines an `item` as one result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
**Network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
**Height** | **int** | Defines the number of blocks in the blockchain preceding this specific block. | 
**Hash** | **string** | Represents the hash of the block&#39;s header, i.e. an output that has a fixed length. | 
**Timestamp** | **int** | Defines the exact date/time when this block was mined in seconds since Unix Epoch time. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

