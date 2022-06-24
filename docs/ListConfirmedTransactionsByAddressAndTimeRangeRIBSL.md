# CryptoAPIs.Model.ListConfirmedTransactionsByAddressAndTimeRangeRIBSL
Litecoin

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locktime** | **long** | Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid. | 
**Size** | **int** | Represents the total size of this transaction. | 
**VSize** | **int** | Represents the virtual size of this transaction. | 
**_Version** | **int** | Represents the transaction&#39;s version number. | 
**Vin** | [**List&lt;ListConfirmedTransactionsByAddressRIBSLVinInner&gt;**](ListConfirmedTransactionsByAddressRIBSLVinInner.md) | Represents the transaction inputs. | 
**Vout** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSLVoutInner&gt;**](GetTransactionDetailsByTransactionIDRIBSLVoutInner.md) | Represents the transaction outputs. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

