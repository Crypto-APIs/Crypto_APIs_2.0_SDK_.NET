# Org.OpenAPITools.Model.GetBlockDetailsByBlockHashResponseItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hash** | **string** | Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. | 
**Height** | **int** | Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;. | 
**NextBlockHash** | **string** | Represents the hash of the next block. When this is the last block of the blockchain this value will be an empty string. | 
**PreviousBlockHash** | **string** | Represents the hash of the previous block, also known as the parent block. | 
**Timestamp** | **int** | Defines the exact date/time when this block was mined in Unix Timestamp. | 
**TransactionsCount** | **int** | Represents the total number of all transactions as part of this block. | 
**BlockchainSpecific** | [**GetBlockDetailsByBlockHashResponseItemBlockchainSpecific**](GetBlockDetailsByBlockHashResponseItemBlockchainSpecific.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
