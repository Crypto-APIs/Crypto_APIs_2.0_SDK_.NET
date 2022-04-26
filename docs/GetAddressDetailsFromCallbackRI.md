# CryptoAPIs.Model.GetAddressDetailsFromCallbackRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncomingTransactionsCount** | **int** | Defines the count of the incoming transactions. | 
**OutgoingTransactionsCount** | **int** | Defines the count of the outgoing transactions. | 
**TransactionsCount** | **int** | Represents the total number of confirmed coins transactions for this address, both incoming and outgoing. Applies for coins only **and not** tokens transfers e.g. for Ethereum. &#x60;transactionsCount&#x60; could result as less than incoming and outgoing transactions put together (e.g. in Bitcoin), due to the fact that one and the same address could be in senders and receivers addresses. | 
**ConfirmedBalance** | [**GetAddressDetailsRIConfirmedBalance**](GetAddressDetailsRIConfirmedBalance.md) |  | 
**TotalReceived** | [**GetAddressDetailsFromCallbackRITotalReceived**](GetAddressDetailsFromCallbackRITotalReceived.md) |  | [optional] 
**TotalSpent** | [**GetAddressDetailsFromCallbackRITotalSpent**](GetAddressDetailsFromCallbackRITotalSpent.md) |  | [optional] 
**Sequence** | **long** | Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

