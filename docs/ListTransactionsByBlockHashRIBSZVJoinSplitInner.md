# CryptoAPIs.Model.ListTransactionsByBlockHashRIBSZVJoinSplitInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Anchor** | **string** | Defines a Merkle tree root of a note commitment tree which uniquely identifies a note commitment tree state given the assumed security properties of the Merkle tree’s  hash function. | 
**CipherTexts** | **List&lt;string&gt;** |  | 
**Commitments** | **List&lt;string&gt;** |  | 
**Macs** | **List&lt;string&gt;** |  | 
**Nullifiers** | **List&lt;string&gt;** |  | 
**OneTimePubKey** | **string** | Defines the one time public key. | 
**Proof** | **string** | Defines the proof. | 
**RandomSeed** | **string** | Represents a 256-bit seed that must be chosen independently at random for each JoinSplit description. | 
**VPubNew** | **string** | Defines the value that the joinSplit transfer will insert into the transparent transaction value pool. | 
**VPubOld** | **string** | Defines the value that the joinSplit transfer will remove from the transparent transaction value pool. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

