# CryptoAPIs.Model.TransactionRequestRejectionDataItem
Defines an `item` as one result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
**Network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. | 
**RequiredApprovals** | **int** | The required number of approvals needed to approve the transaction. | 
**RequiredRejections** | **int** | The required number of rejections needed to reject the transaction. | 
**CurrentApprovals** | **int** | The current number of approvals given for the transaction. | 
**CurrentRejections** | **int** | The current number of rejections given for the transaction. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

