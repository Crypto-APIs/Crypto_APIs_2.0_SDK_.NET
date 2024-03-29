/*
 * CryptoAPIs
 *
 * Crypto APIs is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2021-03-20
 * Contact: developers@cryptoapis.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CryptoAPIs.Client.OpenAPIDateConverter;

namespace CryptoAPIs.Model
{
    /// <summary>
    /// CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem
    /// </summary>
    [DataContract(Name = "CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRB_data_item")]
    public partial class CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem : IEquatable<CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem" /> class.
        /// </summary>
        /// <param name="amount">Represents the specific amount of the transaction. (required).</param>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security)..</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;..</param>
        /// <param name="feeLimit">Fee limit of the smart contract (required).</param>
        /// <param name="note">Represents an optional note to add a free text in, explaining or providing additional detail on the transaction request..</param>
        /// <param name="recipientAddress">Defines the specific recipient address for the transaction. (required).</param>
        /// <param name="tokenIdentifier">Token identifier - for BITCOIN BASED should be property id e.g 31 for ETHEREUM BASED shoud be contract e.g 0xdac17f958d2ee523a2206206994597c13d831ec7 (required).</param>
        public CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem(string amount = default(string), string callbackSecretKey = default(string), string callbackUrl = default(string), string feeLimit = default(string), string note = default(string), string recipientAddress = default(string), string tokenIdentifier = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem and cannot be null");
            }
            this.Amount = amount;
            // to ensure "feeLimit" is required (not null)
            if (feeLimit == null)
            {
                throw new ArgumentNullException("feeLimit is a required property for CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem and cannot be null");
            }
            this.FeeLimit = feeLimit;
            // to ensure "recipientAddress" is required (not null)
            if (recipientAddress == null)
            {
                throw new ArgumentNullException("recipientAddress is a required property for CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem and cannot be null");
            }
            this.RecipientAddress = recipientAddress;
            // to ensure "tokenIdentifier" is required (not null)
            if (tokenIdentifier == null)
            {
                throw new ArgumentNullException("tokenIdentifier is a required property for CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem and cannot be null");
            }
            this.TokenIdentifier = tokenIdentifier;
            this.CallbackSecretKey = callbackSecretKey;
            this.CallbackUrl = callbackUrl;
            this.Note = note;
        }

        /// <summary>
        /// Represents the specific amount of the transaction.
        /// </summary>
        /// <value>Represents the specific amount of the transaction.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).</value>
        [DataMember(Name = "callbackSecretKey", EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.
        /// </summary>
        /// <value>Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.</value>
        [DataMember(Name = "callbackUrl", EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Fee limit of the smart contract
        /// </summary>
        /// <value>Fee limit of the smart contract</value>
        [DataMember(Name = "feeLimit", IsRequired = true, EmitDefaultValue = false)]
        public string FeeLimit { get; set; }

        /// <summary>
        /// Represents an optional note to add a free text in, explaining or providing additional detail on the transaction request.
        /// </summary>
        /// <value>Represents an optional note to add a free text in, explaining or providing additional detail on the transaction request.</value>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// Defines the specific recipient address for the transaction.
        /// </summary>
        /// <value>Defines the specific recipient address for the transaction.</value>
        [DataMember(Name = "recipientAddress", IsRequired = true, EmitDefaultValue = false)]
        public string RecipientAddress { get; set; }

        /// <summary>
        /// Token identifier - for BITCOIN BASED should be property id e.g 31 for ETHEREUM BASED shoud be contract e.g 0xdac17f958d2ee523a2206206994597c13d831ec7
        /// </summary>
        /// <value>Token identifier - for BITCOIN BASED should be property id e.g 31 for ETHEREUM BASED shoud be contract e.g 0xdac17f958d2ee523a2206206994597c13d831ec7</value>
        [DataMember(Name = "tokenIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public string TokenIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  FeeLimit: ").Append(FeeLimit).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  RecipientAddress: ").Append(RecipientAddress).Append("\n");
            sb.Append("  TokenIdentifier: ").Append(TokenIdentifier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem);
        }

        /// <summary>
        /// Returns true if CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFungibleTokenTransactionRequestFromAddressWithoutFeePriorityRBDataItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.CallbackSecretKey == input.CallbackSecretKey ||
                    (this.CallbackSecretKey != null &&
                    this.CallbackSecretKey.Equals(input.CallbackSecretKey))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.FeeLimit == input.FeeLimit ||
                    (this.FeeLimit != null &&
                    this.FeeLimit.Equals(input.FeeLimit))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.RecipientAddress == input.RecipientAddress ||
                    (this.RecipientAddress != null &&
                    this.RecipientAddress.Equals(input.RecipientAddress))
                ) && 
                (
                    this.TokenIdentifier == input.TokenIdentifier ||
                    (this.TokenIdentifier != null &&
                    this.TokenIdentifier.Equals(input.TokenIdentifier))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.CallbackSecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackSecretKey.GetHashCode();
                }
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                if (this.FeeLimit != null)
                {
                    hashCode = (hashCode * 59) + this.FeeLimit.GetHashCode();
                }
                if (this.Note != null)
                {
                    hashCode = (hashCode * 59) + this.Note.GetHashCode();
                }
                if (this.RecipientAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientAddress.GetHashCode();
                }
                if (this.TokenIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.TokenIdentifier.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
