# CryptoAPIs.Model.ListUnspentTransactionOutputsByAddressRIBlockchainSpecific

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VSize** | **int** | Represents the virtual size of this transaction | 
**BindingSig** | **string** | It is used to enforce balance of Spend and Output transfers, in order to prevent their replay across transactions. | 
**ExpiryHeight** | **int** | Represents a block height after which the transaction will expire. | 
**JoinSplitPubKey** | **string** | Represents an encoding of a JoinSplitSig public validating key. | 
**JoinSplitSig** | **string** | Is used to sign transactions that contain at least one JoinSplit description. | 
**Overwintered** | **bool** | \&quot;Overwinter\&quot; is the network upgrade for the Zcash blockchain. | 
**VJoinSplit** | [**List&lt;ListUnspentTransactionOutputsByAddressRIBlockchainSpecificVJoinSplit&gt;**](ListUnspentTransactionOutputsByAddressRIBlockchainSpecificVJoinSplit.md) | Represents a sequence of JoinSplit descriptions using BCTV14 proofs. | [optional] 
**VShieldedOutput** | [**List&lt;GetTransactionDetailsByTransactionIDRIBSZVShieldedOutput&gt;**](GetTransactionDetailsByTransactionIDRIBSZVShieldedOutput.md) | Object Array representation of transaction output descriptions | [optional] 
**VShieldedSpend** | [**List&lt;ListUnspentTransactionOutputsByAddressRIBlockchainSpecificVShieldedSpend&gt;**](ListUnspentTransactionOutputsByAddressRIBlockchainSpecificVShieldedSpend.md) | Object Array representation of transaction spend descriptions | 
**ValueBalance** | **string** | Defines the transaction value balance. | 
**VersionGroupId** | **string** | Represents the transaction version group ID. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

