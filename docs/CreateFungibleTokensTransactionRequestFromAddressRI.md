# CryptoAPIs.Model.CreateFungibleTokensTransactionRequestFromAddressRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallbackSecretKey** | **string** | Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security). | 
**CallbackUrl** | **string** | Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;. | 
**FeePriority** | **string** | Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;. | 
**Note** | **string** | Represents an optional note to add a free text in, explaining or providing additional detail on the transaction request. | [optional] 
**Recipients** | [**List&lt;CreateFungibleTokensTransactionRequestFromAddressRIRecipients&gt;**](CreateFungibleTokensTransactionRequestFromAddressRIRecipients.md) | Defines the destination for the transaction, i.e. the recipient(s). | 
**Senders** | [**CreateFungibleTokensTransactionRequestFromAddressRISenders**](CreateFungibleTokensTransactionRequestFromAddressRISenders.md) |  | 
**TokenTypeSpecificData** | [**CreateFungibleTokensTransactionRequestFromAddressRIS**](CreateFungibleTokensTransactionRequestFromAddressRIS.md) |  | 
**TransactionRequestId** | **string** | Represents a unique identifier of the transaction request (the request sent to make a transaction), which helps in identifying which callback and which &#x60;referenceId&#x60; concern that specific transaction request. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

