# CryptoAPIs.Model.ListTransactionsByAddressRIBS

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locktime** | **int** | Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid. | 
**Size** | **int** | Represents the total size of this transaction. | 
**VSize** | **int** | Represents the virtual size of this transaction. | 
**Version** | **int** | Represents the transaction&#39;s version number. | 
**Vin** | [**List&lt;ListTransactionsByAddressRIBSD2Vin&gt;**](ListTransactionsByAddressRIBSD2Vin.md) | Represents the transaction inputs. | 
**Vout** | [**List&lt;ListTransactionsByAddressRIBSD2Vout&gt;**](ListTransactionsByAddressRIBSD2Vout.md) | Represents the transaction outputs. | 
**Contract** | **string** | Represents the specific transaction contract. | 
**GasLimit** | **string** | Represents the amount of gas used by this specific transaction alone. | 
**GasPrice** | [**ListTransactionsByAddressRIBSEGasPrice**](ListTransactionsByAddressRIBSEGasPrice.md) |  | 
**GasUsed** | **string** | Represents the exact unit of gas that was used for the transaction. | 
**InputData** | **string** | Represents additional information that is required for the transaction. | 
**Nonce** | **int** | Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address. | 
**TransactionStatus** | **string** | String representation of the transaction status | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

