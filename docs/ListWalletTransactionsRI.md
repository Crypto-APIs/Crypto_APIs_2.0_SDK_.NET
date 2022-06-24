# CryptoAPIs.Model.ListWalletTransactionsRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Direction** | **string** | Defines the direction of the transaction, e.g. incoming. | 
**Fee** | [**ListWalletTransactionsRIFee**](ListWalletTransactionsRIFee.md) |  | 
**FungibleTokens** | [**List&lt;ListWalletTransactionsRIFungibleTokensInner&gt;**](ListWalletTransactionsRIFungibleTokensInner.md) | Represents fungible tokens&#39;es detailed information | [optional] 
**InternalTransactions** | [**List&lt;ListWalletTransactionsRIInternalTransactionsInner&gt;**](ListWalletTransactionsRIInternalTransactionsInner.md) |  | [optional] 
**NonFungibleTokens** | [**List&lt;ListWalletTransactionsRINonFungibleTokensInner&gt;**](ListWalletTransactionsRINonFungibleTokensInner.md) | Represents non-fungible tokens&#39;es detailed information. | [optional] 
**Recipients** | [**List&lt;ListWalletTransactionsRIRecipientsInner&gt;**](ListWalletTransactionsRIRecipientsInner.md) | Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. | 
**Senders** | [**List&lt;ListWalletTransactionsRISendersInner&gt;**](ListWalletTransactionsRISendersInner.md) | Represents a list of sender addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. | 
**Status** | **string** | Defines the status of the transaction, if it is confirmed or unconfirmed. | 
**Timestamp** | **int** | Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. | 
**TransactionId** | **string** | Represents the unique TD of the transaction. | 
**Value** | [**ListWalletTransactionsRIValue**](ListWalletTransactionsRIValue.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

