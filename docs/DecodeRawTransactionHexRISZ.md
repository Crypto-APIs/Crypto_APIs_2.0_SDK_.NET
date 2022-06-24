# CryptoAPIs.Model.DecodeRawTransactionHexRISZ
Zcash

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpiryHeight** | **int** | Represents a block height after which the transaction will expire. | 
**Locktime** | **int** | Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid. | 
**Overwintered** | **bool** | \&quot;Overwinter\&quot; is the network upgrade for the Zcash blockchain. | 
**Saplinged** | **bool** | Defines if the transaction includes sapling or not. | 
**TransactionHash** | **string** | Represents the same as transactionId for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols hash is different from transactionId for SegWit transactions. | 
**ValueBalance** | **string** | Defines the transaction value balance. | 
**_Version** | **int** | Represents the transaction version number. | 
**VersionGroupId** | **string** | Represents the transaction version group ID | 
**Vin** | [**List&lt;DecodeRawTransactionHexRISZVinInner&gt;**](DecodeRawTransactionHexRISZVinInner.md) | Represents the Inputs of the transaction | 
**Vout** | [**List&lt;DecodeRawTransactionHexRISZVoutInner&gt;**](DecodeRawTransactionHexRISZVoutInner.md) | Represents the Inputs of the transaction | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

