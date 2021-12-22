# CryptoAPIs.Model.GetBlockDetailsByBlockHeightFromCallbackRIBS

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bits** | **string** | Represents a specific sub-unit of Zcash. Bits have two-decimal precision | 
**Chainwork** | **string** | Represents a hexadecimal number of all the hashes necessary to produce the current chain. E.g., when converting 0000000000000000000000000000000000000000000086859f7a841475b236fd to a decimal you get 635262017308958427068157 hashes, or 635262 exahashes. | 
**Difficulty** | **string** | Defines how difficult it is for a specific miner to mine the block. | 
**MerkleRoot** | **string** | Defines the single and final (root) node of a Merkle tree. It is the combined hash of all transactions&#39; hashes that are part of a blockchain block. | 
**Nonce** | **string** | Represents a random value that can be adjusted to satisfy the proof of work | 
**Size** | **int** | Represents the total size of the block in Bytes. | 
**StrippedSize** | **int** | Defines the numeric representation of the block size excluding the witness data. | 
**_Version** | **int** | Represents the transaction version number. | 
**VersionHex** | **string** | Is the hexadecimal string representation of the block&#39;s version. | 
**Weight** | **int** | Represents a measurement to compare the size of different transactions to each other in proportion to the block size limit. | 
**Strippedsize** | **int** | Defines the numeric representation of the block size excluding the witness data. | 
**ExtraData** | **string** | Represents any data that can be included by the miner in the block. | 
**GasLimit** | **int** | Represents the maximum amount of gas allowed in the block in order to determine how many transactions it can fit. | 
**GasUsed** | **int** | Defines how much of the gas for the block has been used. | 
**MinedInSeconds** | **int** | Specifies the amount of time required for the block to be mined in seconds. | 
**Sha3Uncles** | **string** | Defines the combined hash of all uncles for a given parent. | 
**TotalDifficulty** | **string** | Defines the total difficulty of the chain until this block, i.e. how difficult it is for a specific miner to mine a new block. | 
**Uncles** | **List&lt;string&gt;** |  | [optional] 
**DsBlock** | **int** | Represents the Directory Service block which contains metadata about the miners who participate in the consensus protocol. | 
**DsDifficulty** | **string** | Defines how difficult it is to mine the dsBlocks. | 
**DsLeader** | **string** | Represents a part of the DS Committee which leads the consensus protocol for the epoch. | 
**MicroBlocks** | **List&lt;string&gt;** |  | 
**TotalCoins** | [**GetLatestMinedXRPRippleBlockRITotalCoins**](GetLatestMinedXRPRippleBlockRITotalCoins.md) |  | 
**TotalFees** | [**GetLatestMinedXRPRippleBlockRITotalFees**](GetLatestMinedXRPRippleBlockRITotalFees.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

