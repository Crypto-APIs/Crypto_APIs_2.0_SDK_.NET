# Org.OpenAPITools.Model.ListXRPRippleTransactionsByAddressResponseItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalData** | **string** | Represents any additional data that may be needed. | 
**Index** | **int** | Represents the index position of the transaction in the block. | 
**MinedInBlockHash** | **string** | Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. | 
**MinedInBlockHeight** | **int** | Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block. | 
**Recipients** | [**List&lt;GetXRPRippleTransactionDetailsByTransactionIDResponseItemRecipients&gt;**](GetXRPRippleTransactionDetailsByTransactionIDResponseItemRecipients.md) | Represents an object of addresses that receive the transactions. | 
**Senders** | [**List&lt;GetXRPRippleTransactionDetailsByTransactionIDResponseItemSenders&gt;**](GetXRPRippleTransactionDetailsByTransactionIDResponseItemSenders.md) | Represents an object of addresses that provide the funds. | 
**Sequence** | **int** | Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime. | 
**Status** | **string** | Defines the status of the transaction. | 
**Timestamp** | **int** | Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. | 
**TransactionHash** | **string** | Represents the hash of the XRP transaction. | 
**Type** | **string** | Specifies the type of the transaction. | 
**Fee** | [**ListXRPRippleTransactionsByAddressResponseItemFee**](ListXRPRippleTransactionsByAddressResponseItemFee.md) |  | 
**Offer** | [**ListXRPRippleTransactionsByAddressResponseItemOffer**](ListXRPRippleTransactionsByAddressResponseItemOffer.md) |  | 
**Receive** | [**ListXRPRippleTransactionsByAddressResponseItemReceive**](ListXRPRippleTransactionsByAddressResponseItemReceive.md) |  | 
**Value** | [**ListXRPRippleTransactionsByAddressResponseItemValue**](ListXRPRippleTransactionsByAddressResponseItemValue.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
