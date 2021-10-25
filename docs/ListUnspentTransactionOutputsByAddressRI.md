# CryptoAPIs.Model.ListUnspentTransactionOutputsByAddressRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **int** | Represents the index position of the transaction in the block. | 
**Locktime** | **int** | Represents the time at which a particular transaction can be added to the blockchain | 
**MinedInBlockHash** | **string** | Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. | 
**MinedInBlockHeight** | **int** | Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block. | 
**Recipients** | [**List&lt;GetTransactionDetailsByTransactionIDRIRecipients&gt;**](GetTransactionDetailsByTransactionIDRIRecipients.md) | Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. | 
**Senders** | [**List&lt;ListUnspentTransactionOutputsByAddressRISenders&gt;**](ListUnspentTransactionOutputsByAddressRISenders.md) | Object Array representation of transaction senders | 
**Size** | **int** | Represents the total size of this transaction | 
**Timestamp** | **int** | Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. | 
**TransactionHash** | **string** | Represents the same as &#x60;transactionId&#x60; for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols &#x60;hash&#x60; is different from &#x60;transactionId&#x60; for SegWit transactions. | 
**TransactionId** | **string** | Represents the unique identifier of a transaction, i.e. it could be &#x60;transactionId&#x60; in UTXO-based protocols like Bitcoin, and transaction &#x60;hash&#x60; in Ethereum blockchain. | 
**_Version** | **int** | Represents the transaction version number. | 
**Vin** | [**List&lt;ListUnspentTransactionOutputsByAddressRIVin&gt;**](ListUnspentTransactionOutputsByAddressRIVin.md) | Represents the transaction inputs. | 
**Vout** | [**List&lt;ListConfirmedTransactionsByAddressRIBSBVout&gt;**](ListConfirmedTransactionsByAddressRIBSBVout.md) | Represents the transaction outputs. | 
**Fee** | [**ListUnspentTransactionOutputsByAddressRIFee**](ListUnspentTransactionOutputsByAddressRIFee.md) |  | 
**BlockchainSpecific** | [**ListUnspentTransactionOutputsByAddressRIBlockchainSpecific**](ListUnspentTransactionOutputsByAddressRIBlockchainSpecific.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

