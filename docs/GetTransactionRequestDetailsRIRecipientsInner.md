# CryptoAPIs.Model.GetTransactionRequestDetailsRIRecipientsInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one recipient. | 
**AddressTag** | **int** | Defines a specific Tag that is an additional XRP address feature. It helps identify a transaction recipient beyond a wallet address. The tag that was encoded into the x-Address along with the Classic Address. | [optional] 
**Amount** | **string** | Represents the amount received to this address. | 
**ClassicAddress** | **string** | Represents the public address, which is a compressed and shortened form of a public key. A classic address is shown when the destination address is an x-Address. | [optional] 
**Unit** | **string** | Defines the unit of the amount. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

