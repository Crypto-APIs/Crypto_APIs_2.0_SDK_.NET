# CryptoAPIs.Model.ListZilliqaTransactionsByBlockHeightRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fee** | [**GetZilliqaTransactionDetailsByTransactionIDRIFee**](GetZilliqaTransactionDetailsByTransactionIDRIFee.md) |  | 
**GasLimit** | **int** | Represents the maximum amount of gas allowed in the block in order to determine how many transactions it can fit. | 
**GasPrice** | **int** | Defines the price of the gas. | 
**GasUsed** | **int** | Defines how much of the gas for the block has been used. | 
**MinedInBlockHash** | **string** | Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. | 
**Nonce** | **int** | Represents a random value that can be adjusted to satisfy the Proof of Work. | 
**Recipients** | [**List&lt;ListZilliqaTransactionsByAddressRIRecipientsInner&gt;**](ListZilliqaTransactionsByAddressRIRecipientsInner.md) | Defines an object array of the transaction recipients. | 
**Senders** | [**List&lt;ListZilliqaTransactionsByAddressRISendersInner&gt;**](ListZilliqaTransactionsByAddressRISendersInner.md) | Represents an object of addresses that provide the funds. | 
**Timestamp** | **int** | Defines the exact date/time when this block was mined in Unix Timestamp. | 
**TransactionHash** | **string** | Represents the hash of the transaction, which is its unique identifier. | 
**TransactionIndex** | **int** | Defines the numeric representation of the transaction index. | 
**TransactionStatus** | **string** | Defines the status of the transaction, whether it is e.g. pending or complete. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

