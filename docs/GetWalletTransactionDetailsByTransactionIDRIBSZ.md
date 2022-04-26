# CryptoAPIs.Model.GetWalletTransactionDetailsByTransactionIDRIBSZ
Zcash

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BindingSig** | **string** | It is used to enforce balance of Spend and Output transfers, in order to prevent their replay across transactions. | 
**ExpiryHeight** | **int** | Represents a block height after which the transaction will expire. | 
**JoinSplitPubKey** | **string** | Represents an encoding of a JoinSplitSig public validating key. | 
**JoinSplitSig** | **string** | Is used to sign transactions that contain at least one JoinSplit description. | 
**Locktime** | **long** | Represents the time at which a particular transaction can be added to the blockchain. | 
**Overwintered** | **bool** | \&quot;Overwinter\&quot; is the network upgrade for the Zcash blockchain. | 
**Size** | **int** | Represents the total size of this transaction. | 
**VJoinSplit** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSZVJoinSplit&gt;**](GetTransactionDetailsByTransactionIDRIBSZVJoinSplit.md) | Represents a sequence of JoinSplit descriptions using BCTV14 proofs. | [optional] 
**VShieldedOutput** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSZVShieldedOutput&gt;**](GetTransactionDetailsByTransactionIDRIBSZVShieldedOutput.md) | Object Array representation of transaction output descriptions | [optional] 
**VShieldedSpend** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSZVShieldedSpend&gt;**](GetTransactionDetailsByTransactionIDRIBSZVShieldedSpend.md) | Object Array representation of transaction spend descriptions | [optional] 
**ValueBalance** | **string** | String representation of the transaction value balance | 
**_Version** | **int** | Represents the transaction version number. | 
**VersionGroupId** | **string** | Represents the transaction version group ID. | 
**Vin** | [**List&lt;GetWalletTransactionDetailsByTransactionIDRIBSZVin&gt;**](GetWalletTransactionDetailsByTransactionIDRIBSZVin.md) | Object Array representation of transaction inputs | 
**Vout** | [**List&lt;ListTransactionsByBlockHeightRIBSZVout&gt;**](ListTransactionsByBlockHeightRIBSZVout.md) | Object Array representation of transaction outputs | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

