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
    /// ListXRPRippleTransactionsByAddressRIReceive
    /// </summary>
    [DataContract(Name = "ListXRPRippleTransactionsByAddressRI_receive")]
    public partial class ListXRPRippleTransactionsByAddressRIReceive : IEquatable<ListXRPRippleTransactionsByAddressRIReceive>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListXRPRippleTransactionsByAddressRIReceive" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListXRPRippleTransactionsByAddressRIReceive() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListXRPRippleTransactionsByAddressRIReceive" /> class.
        /// </summary>
        /// <param name="amount">Defines the amount received. (required).</param>
        /// <param name="unit">Defines the unit of the amount received. (required).</param>
        public ListXRPRippleTransactionsByAddressRIReceive(string amount = default(string), string unit = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ListXRPRippleTransactionsByAddressRIReceive and cannot be null");
            }
            this.Amount = amount;
            // to ensure "unit" is required (not null)
            if (unit == null)
            {
                throw new ArgumentNullException("unit is a required property for ListXRPRippleTransactionsByAddressRIReceive and cannot be null");
            }
            this.Unit = unit;
        }

        /// <summary>
        /// Defines the amount received.
        /// </summary>
        /// <value>Defines the amount received.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Defines the unit of the amount received.
        /// </summary>
        /// <value>Defines the unit of the amount received.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListXRPRippleTransactionsByAddressRIReceive {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as ListXRPRippleTransactionsByAddressRIReceive);
        }

        /// <summary>
        /// Returns true if ListXRPRippleTransactionsByAddressRIReceive instances are equal
        /// </summary>
        /// <param name="input">Instance of ListXRPRippleTransactionsByAddressRIReceive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListXRPRippleTransactionsByAddressRIReceive input)
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
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
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
