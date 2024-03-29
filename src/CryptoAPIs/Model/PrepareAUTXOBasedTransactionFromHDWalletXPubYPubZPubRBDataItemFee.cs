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
    /// PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee
    /// </summary>
    [DataContract(Name = "PrepareAUTXO_BasedTransactionFromHDWalletXPubYPubZPubRB_data_item_fee")]
    public partial class PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee : IEquatable<PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee>, IValidatableObject
    {
        /// <summary>
        /// Represents the fee priority
        /// </summary>
        /// <value>Represents the fee priority</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            /// <summary>
            /// Enum Slow for value: slow
            /// </summary>
            [EnumMember(Value = "slow")]
            Slow = 1,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 2,

            /// <summary>
            /// Enum Fast for value: fast
            /// </summary>
            [EnumMember(Value = "fast")]
            Fast = 3

        }


        /// <summary>
        /// Represents the fee priority
        /// </summary>
        /// <value>Represents the fee priority</value>
        [DataMember(Name = "priority", EmitDefaultValue = false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee" /> class.
        /// </summary>
        /// <param name="address">Represents the fee address.</param>
        /// <param name="exactAmount">Representation of the exact amount value.</param>
        /// <param name="priority">Represents the fee priority.</param>
        public PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee(string address = default(string), string exactAmount = default(string), PriorityEnum? priority = default(PriorityEnum?))
        {
            this.Address = address;
            this.ExactAmount = exactAmount;
            this.Priority = priority;
        }

        /// <summary>
        /// Represents the fee address
        /// </summary>
        /// <value>Represents the fee address</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Representation of the exact amount value
        /// </summary>
        /// <value>Representation of the exact amount value</value>
        [DataMember(Name = "exactAmount", EmitDefaultValue = false)]
        public string ExactAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ExactAmount: ").Append(ExactAmount).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee);
        }

        /// <summary>
        /// Returns true if PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee instances are equal
        /// </summary>
        /// <param name="input">Instance of PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRBDataItemFee input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.ExactAmount == input.ExactAmount ||
                    (this.ExactAmount != null &&
                    this.ExactAmount.Equals(input.ExactAmount))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.ExactAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ExactAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Priority.GetHashCode();
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
