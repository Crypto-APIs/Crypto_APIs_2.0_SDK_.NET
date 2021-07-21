# CryptoAPIs.Model.GetZilliqaBlockDetailsByBlockHashRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockHeight** | **int** | Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;. | 
**Difficulty** | **string** | Defines how difficult it is for a specific miner to mine the block. | 
**DsBlock** | **int** | Represents the Directory Service block which contains metadata about the miners who participate in the consensus protocol. | 
**DsDifficulty** | **string** | Defines how difficult it is to mine the dsBlocks. | 
**DsLeader** | **string** | Represents a part of the DS Committee which leads the consensus protocol for the epoch. | 
**GasLimit** | **int** | Represents the maximum amount of gas allowed in the block in order to determine how many transactions it can fit. | 
**GasUsed** | **int** | Defines how much of the gas for the block has been used. | 
**MicroBlocks** | **List&lt;string&gt;** |  | 
**NextBlockHash** | **string** | Defines the hash of the next block from the specific blockchain. | 
**PreviousBlockHash** | **string** | Represents the hash of the previous block, also known as the parent block. | 
**Timestamp** | **int** | Defines the exact date/time when this block was mined in Unix Timestamp. | 
**TransactionsCount** | **int** | Represents the total number of all transactions as part of this block. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

