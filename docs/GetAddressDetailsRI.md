# CryptoAPIs.Model.GetAddressDetailsRI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionsCount** | **int** | Represents the total number of confirmed coins transactions for this address, both incoming and outgoing. Applies for coins only **and not** tokens transfers e.g. for Ethereum. &#x60;transactionsCount&#x60; could result as less than incoming and outgoing transactions put together (e.g. in Bitcoin), due to the fact that one and the same address could be in senders and receivers addresses. | 
**ConfirmedBalance** | [**GetAddressDetailsRIConfirmedBalance**](GetAddressDetailsRIConfirmedBalance.md) |  | 
**TotalReceived** | [**GetAddressDetailsRITotalReceived**](GetAddressDetailsRITotalReceived.md) |  | 
**TotalSpent** | [**GetAddressDetailsRITotalSpent**](GetAddressDetailsRITotalSpent.md) |  | 
**IncomingTransactionsCount** | **int** | Defines the received transaction count to the address. | 
**OutgoingTransactionsCount** | **int** | Defines the sent transaction count from the address. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

