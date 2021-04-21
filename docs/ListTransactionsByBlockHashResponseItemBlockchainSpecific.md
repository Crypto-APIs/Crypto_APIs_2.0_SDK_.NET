# Org.OpenAPITools.Model.ListTransactionsByBlockHashResponseItemBlockchainSpecific

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locktime** | **int** | Represents the time at which a particular transaction can be added to the blockchain. | 
**Size** | **int** | Represents the total size of this transaction. | 
**VSize** | **int** | Represents the virtual size of this transaction. | 
**Version** | **int** | Represents transaction version number. | 
**Vin** | [**List&lt;ListTransactionsByBlockHashResponseItemBlockchainSpecificDashVin&gt;**](ListTransactionsByBlockHashResponseItemBlockchainSpecificDashVin.md) | Represents the transaction inputs. | 
**Vout** | [**List&lt;ListTransactionsByBlockHashResponseItemBlockchainSpecificDashVout&gt;**](ListTransactionsByBlockHashResponseItemBlockchainSpecificDashVout.md) | Represents the transaction outputs. | 
**Vsize** | **int** | Represents the virtual size of this transaction. | 
**Contract** | **string** | Represents the specific transaction contract. | 
**GasLimit** | **string** | Represents the amount of gas used by this specific transaction alone. | 
**GasPrice** | [**ListTransactionsByBlockHashResponseItemBlockchainSpecificEthereumGasPrice**](ListTransactionsByBlockHashResponseItemBlockchainSpecificEthereumGasPrice.md) |  | 
**GasUsed** | **string** | Represents the exact unit of gas that was used for the transaction. | 
**InputData** | **string** | Represents additional information that is required for the transaction. | 
**Nonce** | **string** | Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address. | 
**TransactionStatus** | **string** | String representation of the transaction status | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

