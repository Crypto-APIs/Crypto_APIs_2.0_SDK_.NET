# CryptoAPIs.Model.ListHDWalletXPubYPubZPubUTXOsRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | Represents the public address, which is a compressed and shortened form of a public key. | 
**AddressPath** | **string** | Defines a data which tells a Hierarchical Deterministic wallet how to derive a specific key within a tree of keys. | 
**Amount** | **string** | Represents the UTXO amount value. | 
**Derivation** | **string** | The way how the HD walled derives, for example when the type is ACCOUNT, it derives change and receive addresses while when the type is BIP32 it derives directly. | 
**Index** | **int** | Represents the output index. It refers to the UTXO sequence in the transaction outputs (vout). | 
**IsAvailable** | **bool** | Represents if the UTXO has been used from another unconfirmed transaction. If it is - the value will be \&quot;false\&quot;. | 
**IsConfirmed** | **bool** | Represents the state of the transaction whether it is confirmed or not confirmed. | 
**ReferenceId** | **string** | Represents the reference id of the record. It may be used for the startingAfter pagination attribute. | 
**TransactionId** | **string** | Represents the unique identifier of a transaction, i.e. it could be transactionId in UTXO-based protocols like Bitcoin, and transaction hash in Ethereum blockchain. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

