# CryptoAPIs.Model.PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalData** | **string** | Representation of the additional data | [optional] 
**Fee** | **string** | When isConfirmed is True - Defines the amount of the transaction fee When isConfirmed is False - For ETH-based blockchains this attribute represents the max fee value. | 
**FeePerByte** | **string** | Defines the fee per byte value | [optional] 
**Locktime** | **long** | Represents the time at which a particular transaction can be added to the blockchain. | 
**Replaceable** | **bool** | Representation of whether the transaction is replaceable | 
**Size** | **int** | Represents the total size of this transaction. | 
**Vin** | [**List&lt;PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRIVinInner&gt;**](PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRIVinInner.md) | Represents the transaction inputs. | 
**Vout** | [**List&lt;PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRIVoutInner&gt;**](PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRIVoutInner.md) | Represents the transaction outputs. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

