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
    /// EstimateTokenGasLimitRBDataItem
    /// </summary>
    [DataContract(Name = "EstimateTokenGasLimitRB_data_item")]
    public partial class EstimateTokenGasLimitRBDataItem : IEquatable<EstimateTokenGasLimitRBDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateTokenGasLimitRBDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EstimateTokenGasLimitRBDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateTokenGasLimitRBDataItem" /> class.
        /// </summary>
        /// <param name="amount">Represents transactions&#39; amount. (required).</param>
        /// <param name="contract">Defines the specific token identifier.  For Ethereum-based transactions it is the contract. (required).</param>
        /// <param name="contractType">Represents the ERC contract type. It can be ERC20 or ERC721 (required).</param>
        /// <param name="recipient">The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one recipient. (required).</param>
        /// <param name="sender">Represents the address which sends this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one sender. (required).</param>
        public EstimateTokenGasLimitRBDataItem(string amount = default(string), string contract = default(string), string contractType = default(string), string recipient = default(string), string sender = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for EstimateTokenGasLimitRBDataItem and cannot be null");
            }
            this.Amount = amount;
            // to ensure "contract" is required (not null)
            if (contract == null)
            {
                throw new ArgumentNullException("contract is a required property for EstimateTokenGasLimitRBDataItem and cannot be null");
            }
            this.Contract = contract;
            // to ensure "contractType" is required (not null)
            if (contractType == null)
            {
                throw new ArgumentNullException("contractType is a required property for EstimateTokenGasLimitRBDataItem and cannot be null");
            }
            this.ContractType = contractType;
            // to ensure "recipient" is required (not null)
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient is a required property for EstimateTokenGasLimitRBDataItem and cannot be null");
            }
            this.Recipient = recipient;
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for EstimateTokenGasLimitRBDataItem and cannot be null");
            }
            this.Sender = sender;
        }

        /// <summary>
        /// Represents transactions&#39; amount.
        /// </summary>
        /// <value>Represents transactions&#39; amount.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Defines the specific token identifier.  For Ethereum-based transactions it is the contract.
        /// </summary>
        /// <value>Defines the specific token identifier.  For Ethereum-based transactions it is the contract.</value>
        [DataMember(Name = "contract", IsRequired = true, EmitDefaultValue = false)]
        public string Contract { get; set; }

        /// <summary>
        /// Represents the ERC contract type. It can be ERC20 or ERC721
        /// </summary>
        /// <value>Represents the ERC contract type. It can be ERC20 or ERC721</value>
        [DataMember(Name = "contractType", IsRequired = true, EmitDefaultValue = false)]
        public string ContractType { get; set; }

        /// <summary>
        /// The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one recipient.
        /// </summary>
        /// <value>The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one recipient.</value>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Represents the address which sends this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one sender.
        /// </summary>
        /// <value>Represents the address which sends this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one sender.</value>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = false)]
        public string Sender { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateTokenGasLimitRBDataItem {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
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
            return this.Equals(input as EstimateTokenGasLimitRBDataItem);
        }

        /// <summary>
        /// Returns true if EstimateTokenGasLimitRBDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of EstimateTokenGasLimitRBDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateTokenGasLimitRBDataItem input)
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
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.ContractType == input.ContractType ||
                    (this.ContractType != null &&
                    this.ContractType.Equals(input.ContractType))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
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
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                if (this.ContractType != null)
                {
                    hashCode = (hashCode * 59) + this.ContractType.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
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
