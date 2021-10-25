# CryptoAPIs.Model.GetTransactionRequestDetailsRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalDetails** | **string** | Defines an optional note for additional details. | 
**Blockchain** | **string** | Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. | 
**FeePriority** | **string** | Defines the priority for the fee, if it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;. | 
**Network** | **string** | Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot; are test networks. | 
**Recipients** | [**List&lt;GetTransactionRequestDetailsRIRecipients&gt;**](GetTransactionRequestDetailsRIRecipients.md) | Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. | 
**TotalTransactionAmount** | **string** | Defines the total transaction amount. | 
**TransactionRequestStatus** | **string** | Defines the status of the transaction request, e.g. pending. | 
**TransactionType** | **string** | Defines the transaction type, if it is for coins or tokens. | 
**Unit** | **string** | Defines the unit of the amount. | 
**WalletId** | **string** | Defines the unique ID of the Wallet. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

