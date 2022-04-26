# CryptoAPIs.Model.DecodeRawTransactionHexRISB2
Bitcoin Cash

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locktime** | **int** | Represents the time at which a particular transaction can be added to the blockchain. | 
**TransactionHash** | **string** | Represents the same as transactionId for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols hash is different from transactionId for SegWit transactions. | 
**VSize** | **int** | Represents the virtual size of this transaction. | 
**_Version** | **int** | Represents transaction version number. | 
**Vin** | [**List&lt;DecodeRawTransactionHexRISB2Vin&gt;**](DecodeRawTransactionHexRISB2Vin.md) | Represents the transaction inputs. | 
**Vout** | [**List&lt;DecodeRawTransactionHexRISB2Vout&gt;**](DecodeRawTransactionHexRISB2Vout.md) | Represents the transaction outputs. | 
**Weight** | **int** | Represents the size of a block, measured in weight units and including the segwit discount. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

