# Org.OpenAPITools.Model.GetUnconfirmedOmniTransactionByTransactionIDTxidResponseItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **string** | Defines the amount of the sent tokens. | 
**Divisible** | **bool** | Defines whether the attribute can be divisible or not, as boolean. E.g., if it is \&quot;true\&quot;, the attribute is divisible. | 
**Mined** | **bool** | Defines whether the transaction has been mined or not, as boolean. E.g. if set to \&quot;true\&quot;, it means the transaction is mined. | 
**PropertyId** | **int** | Represents the identifier of the tokens to send. | 
**Recipients** | [**List&lt;GetUnconfirmedOmniTransactionByTransactionIDTxidResponseItemRecipients&gt;**](GetUnconfirmedOmniTransactionByTransactionIDTxidResponseItemRecipients.md) | Represents an object of addresses that receive the transactions. | 
**Senders** | [**List&lt;GetUnconfirmedOmniTransactionByTransactionIDTxidResponseItemSenders&gt;**](GetUnconfirmedOmniTransactionByTransactionIDTxidResponseItemSenders.md) | Represents an object of addresses that provide the funds. | 
**Sent** | **bool** | Defines whether the transaction has been sent or not, as boolean. E.g. if set to \&quot;true\&quot;, it means the transaction is sent. | 
**Timestamp** | **int** | Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. | 
**TransactionId** | **string** | String representation of the transaction identifier (txid) | 
**Type** | **string** | Defines the type of the transaction as a string. | 
**TypeInt** | **int** | Defines the type of the transaction as a number. | 
**Version** | **int** | Defines the specific version. | 
**Fee** | [**ListUnconfirmedOmniTransactionsByAddressResponseItemFee**](ListUnconfirmedOmniTransactionsByAddressResponseItemFee.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

