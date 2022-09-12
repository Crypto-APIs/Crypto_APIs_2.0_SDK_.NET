# CryptoAPIs.Model.PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalData** | **string** | Representation of the additional data. | [optional] 
**Fee** | [**PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee**](PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee.md) |  | 
**Locktime** | **int** | Represents the time at which a particular transaction can be added to the blockchain. | [optional] 
**PrepareStrategy** | **string** | Representation of the transaction&#39;s strategy type | [optional] 
**Recipients** | [**List&lt;PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemRecipientsInner&gt;**](PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemRecipientsInner.md) | Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. | 
**Replaceable** | **bool** | Representation of whether the transaction is replaceable | [optional] 
**Xpub** | **string** | Defines the account extended publicly known key which is used to derive all child public keys. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

