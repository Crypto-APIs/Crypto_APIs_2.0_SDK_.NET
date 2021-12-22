/*
 * CryptoAPIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
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
    /// ListOmniTransactionsByBlockHeightRIRecipients
    /// </summary>
    [DataContract(Name = "ListOmniTransactionsByBlockHeightRI_recipients")]
    public partial class ListOmniTransactionsByBlockHeightRIRecipients : IEquatable<ListOmniTransactionsByBlockHeightRIRecipients>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOmniTransactionsByBlockHeightRIRecipients" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListOmniTransactionsByBlockHeightRIRecipients() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOmniTransactionsByBlockHeightRIRecipients" /> class.
        /// </summary>
        /// <param name="address">Represents the hash of the address that receives the funds. (required).</param>
        /// <param name="amount">Defines the amount of the received funds as a string. (required).</param>
        public ListOmniTransactionsByBlockHeightRIRecipients(string address = default(string), string amount = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null) {
                throw new ArgumentNullException("address is a required property for ListOmniTransactionsByBlockHeightRIRecipients and cannot be null");
            }
            this.Address = address;
            // to ensure "amount" is required (not null)
            if (amount == null) {
                throw new ArgumentNullException("amount is a required property for ListOmniTransactionsByBlockHeightRIRecipients and cannot be null");
            }
            this.Amount = amount;
        }

        /// <summary>
        /// Represents the hash of the address that receives the funds.
        /// </summary>
        /// <value>Represents the hash of the address that receives the funds.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Defines the amount of the received funds as a string.
        /// </summary>
        /// <value>Defines the amount of the received funds as a string.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListOmniTransactionsByBlockHeightRIRecipients {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as ListOmniTransactionsByBlockHeightRIRecipients);
        }

        /// <summary>
        /// Returns true if ListOmniTransactionsByBlockHeightRIRecipients instances are equal
        /// </summary>
        /// <param name="input">Instance of ListOmniTransactionsByBlockHeightRIRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListOmniTransactionsByBlockHeightRIRecipients input)
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
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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
