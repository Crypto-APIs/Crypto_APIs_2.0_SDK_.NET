# CryptoAPIs.Model.GetZilliqaTransactionDetailsByTransactionIDRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fee** | [**GetZilliqaTransactionDetailsByTransactionIDRIFee**](GetZilliqaTransactionDetailsByTransactionIDRIFee.md) |  | 
**GasLimit** | **int** | Represents the maximum amount of gas allowed in the block in order to determine how many transactions it can fit. | 
**GasPrice** | **int** | Defines the price of the gas. | 
**GasUsed** | **int** | Defines how much of the gas for the block has been used. | 
**MinedInBlockHash** | **string** | Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. | 
**MinedInBlockHeight** | **int** | Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;. | 
**Nonce** | **int** | Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address. | 
**Recipients** | [**List&lt;GetZilliqaTransactionDetailsByTransactionIDRIRecipientsInner&gt;**](GetZilliqaTransactionDetailsByTransactionIDRIRecipientsInner.md) | Represents an object of addresses that receive the transactions. | 
**Senders** | [**List&lt;GetZilliqaTransactionDetailsByTransactionIDRISendersInner&gt;**](GetZilliqaTransactionDetailsByTransactionIDRISendersInner.md) | Represents an object of addresses that provide the funds. | 
**Timestamp** | **int** | Defines the exact date/time when this block was mined in Unix Timestamp. | 
**TransactionIndex** | **int** | Defines the numeric representation of the transaction index. | 
**TransactionStatus** | **string** | Defines the status of the transaction, whether it is e.g. pending or complete. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

