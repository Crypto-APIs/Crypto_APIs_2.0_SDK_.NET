# CryptoAPIs.Model.ListUnconfirmedOmniTransactionsByAddressRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **string** | Defines the amount of the sent tokens. | 
**Divisible** | **bool** | Defines whether the attribute can be divisible or not, as boolean. E.g., if it is \&quot;true\&quot;, the attribute is divisible. | 
**Mined** | **bool** | Defines whether the transaction has been mined or not, as boolean. E.g. if set to \&quot;true\&quot;, it means the transaction is mined. | 
**PropertyId** | **int** | Represents the identifier of the tokens to send. | 
**Recipients** | [**List&lt;ListOmniTransactionsByAddressRIRecipientsInner&gt;**](ListOmniTransactionsByAddressRIRecipientsInner.md) | Represents an object of addresses that receive the transactions. | 
**Senders** | [**List&lt;ListUnconfirmedOmniTransactionsByAddressRISendersInner&gt;**](ListUnconfirmedOmniTransactionsByAddressRISendersInner.md) | Represents an object of addresses that provide the funds. | 
**Sent** | **bool** | Defines whether the transaction has been sent or not, as boolean. E.g. if set to \&quot;true\&quot;, it means the transaction is sent. | 
**Timestamp** | **int** | Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. | 
**TransactionId** | **string** | Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain. | 
**Type** | **string** | Defines the type of the transaction as a string. | 
**TypeInt** | **int** | Defines the type of the transaction as a number. | 
**_Version** | **int** | Defines the specific version. | 
**Fee** | [**ListUnconfirmedOmniTransactionsByAddressRIFee**](ListUnconfirmedOmniTransactionsByAddressRIFee.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

