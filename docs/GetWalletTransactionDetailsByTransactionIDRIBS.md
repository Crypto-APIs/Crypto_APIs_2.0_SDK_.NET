# CryptoAPIs.Model.GetWalletTransactionDetailsByTransactionIDRIBS

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Locktime** | **long** | Represents the time at which a particular transaction can be added to the blockchain. | 
**Size** | **int** | Represents the total size of this transaction. | 
**VSize** | **int** | Represents the virtual size of this transaction. | 
**_Version** | **int** | Represents the transaction version number. | 
**Vin** | [**List&lt;GetWalletTransactionDetailsByTransactionIDRIBSZVinInner&gt;**](GetWalletTransactionDetailsByTransactionIDRIBSZVinInner.md) | Object Array representation of transaction inputs | 
**Vout** | [**List&lt;ListTransactionsByBlockHeightRIBSZVoutInner&gt;**](ListTransactionsByBlockHeightRIBSZVoutInner.md) | Object Array representation of transaction outputs | 
**Contract** | **string** | Represents the specific transaction contract | 
**GasLimit** | **string** | Represents the amount of gas used by this specific transaction alone. | 
**GasPrice** | [**GetWalletTransactionDetailsByTransactionIDRIBSPGasPrice**](GetWalletTransactionDetailsByTransactionIDRIBSPGasPrice.md) |  | 
**GasUsed** | **string** | Defines the unit of the gas price amount, e.g. BTC, ETH, XRP. | 
**InputData** | **string** | Represents additional information that is required for the transaction. | 
**Nonce** | **int** | Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address. | 
**TransactionStatus** | **string** | String representation of the transaction status | 
**BindingSig** | **string** | It is used to enforce balance of Spend and Output transfers, in order to prevent their replay across transactions. | 
**ExpiryHeight** | **int** | Represents a block height after which the transaction will expire. | 
**JoinSplitPubKey** | **string** | Represents an encoding of a JoinSplitSig public validating key. | 
**JoinSplitSig** | **string** | Is used to sign transactions that contain at least one JoinSplit description. | 
**Overwintered** | **bool** | \&quot;Overwinter\&quot; is the network upgrade for the Zcash blockchain. | 
**VJoinSplit** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSZVJoinSplitInner&gt;**](GetTransactionDetailsByTransactionIDRIBSZVJoinSplitInner.md) | Represents a sequence of JoinSplit descriptions using BCTV14 proofs. | [optional] 
**VShieldedOutput** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSZVShieldedOutputInner&gt;**](GetTransactionDetailsByTransactionIDRIBSZVShieldedOutputInner.md) | Object Array representation of transaction output descriptions | [optional] 
**VShieldedSpend** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner&gt;**](GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner.md) | Object Array representation of transaction spend descriptions | [optional] 
**ValueBalance** | **string** | String representation of the transaction value balance | 
**VersionGroupId** | **string** | Represents the transaction version group ID. | 
**Amount** | **string** | String representation of the amount value | 
**BandwidthUsed** | **string** | Numeric representation of the transaction used bandwidth | 
**EnergyUsed** | **string** | String representation of the transaction used energy | 
**HasInternalTransactions** | **bool** |  | 
**HasTokenTransfers** | **bool** |  | 
**Input** | **string** | Numeric representation of the transaction input | 
**Status** | **string** | String representation of the transaction status | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

