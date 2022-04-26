# CryptoAPIs.Model.ListInternalTransactionsByAddressAndTimeRangeRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **string** | Defines the specific amount of the transaction. | 
**MinedInBlockHash** | **string** | Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. | 
**MinedInBlockHeight** | **int** | Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block. | 
**OperationID** | **string** | Represents the unique internal transaction ID in regards to the parent transaction (type trace address). | 
**OperationType** | **string** | Defines the call type of the internal transaction. | 
**ParentHash** | **string** | Defines the specific hash of the parent transaction. | 
**Recipient** | **string** | Represents the recipient address with the respective amount. | 
**Sender** | **string** | Represents the sender address with the respective amount. | 
**Timestamp** | **int** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

