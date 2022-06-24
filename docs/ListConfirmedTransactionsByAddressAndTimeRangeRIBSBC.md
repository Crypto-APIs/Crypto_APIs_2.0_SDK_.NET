# CryptoAPIs.Model.ListConfirmedTransactionsByAddressAndTimeRangeRIBSBC
Bitcoin Cash

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locktime** | **long** | Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid. | 
**Size** | **int** | Represents the total size of this transaction. | 
**_Version** | **int** | Represents the transaction&#39;s version number. | 
**Vin** | [**List&lt;ListConfirmedTransactionsByAddressRIBSBCVinInner&gt;**](ListConfirmedTransactionsByAddressRIBSBCVinInner.md) | Represents the transaction inputs. | 
**Vout** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSBCVoutInner&gt;**](GetTransactionDetailsByTransactionIDRIBSBCVoutInner.md) | Represents the transaction outputs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

