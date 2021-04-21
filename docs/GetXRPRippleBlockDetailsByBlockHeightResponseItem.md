# Org.OpenAPITools.Model.GetXRPRippleBlockDetailsByBlockHeightResponseItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockHash** | **string** | Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. | 
**BlockHeight** | **int** | Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;. | 
**NextBlockHash** | **string** | Represents the hash of the next block. When this is the last block of the blockchain this value will be an empty string. | 
**PreviousBlockHash** | **string** | Represents the hash of the previous block, also known as the parent block. | 
**Timestamp** | **int** | Defines the exact date/time when this block was mined in Unix Timestamp. | 
**TotalCoins** | [**GetXRPRippleBlockDetailsByBlockHeightResponseItemTotalCoins**](GetXRPRippleBlockDetailsByBlockHeightResponseItemTotalCoins.md) |  | 
**TotalFees** | [**GetXRPRippleBlockDetailsByBlockHeightResponseItemTotalFees**](GetXRPRippleBlockDetailsByBlockHeightResponseItemTotalFees.md) |  | 
**TransactionsCount** | **int** | Represents the total number of all transactions as part of this block. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

