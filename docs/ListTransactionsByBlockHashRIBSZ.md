# CryptoAPIs.Model.ListTransactionsByBlockHashRIBSZ
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
**VJoinSplit** | [**List&lt;ListTransactionsByBlockHashRIBSZVJoinSplitInner&gt;**](ListTransactionsByBlockHashRIBSZVJoinSplitInner.md) | Represents a sequence of JoinSplit descriptions using BCTV14 proofs. | 
**VShieldedOutput** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSZVShieldedOutputInner&gt;**](GetTransactionDetailsByTransactionIDRIBSZVShieldedOutputInner.md) | Object Array representation of transaction output descriptions | 
**VShieldedSpend** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner&gt;**](GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner.md) | Object Array representation of transaction spend descriptions | 
**ValueBalance** | **string** | Defines the transaction value balance. | 
**_Version** | **int** | Numeric representation of the transaction Represents the transaction version number. | 
**VersionGroupId** | **string** | Represents the transaction version group ID. | 
**Vin** | [**List&lt;ListTransactionsByBlockHashRIBSZVinInner&gt;**](ListTransactionsByBlockHashRIBSZVinInner.md) | Object Array representation of transaction inputs | 
**Vout** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSZVoutInner&gt;**](GetTransactionDetailsByTransactionIDRIBSZVoutInner.md) | Object Array representation of transaction outputs | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

