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
    /// GenerateDepositAddressRI
    /// </summary>
    [DataContract(Name = "GenerateDepositAddressRI")]
    public partial class GenerateDepositAddressRI : IEquatable<GenerateDepositAddressRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDepositAddressRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateDepositAddressRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDepositAddressRI" /> class.
        /// </summary>
        /// <param name="address">Specifies the specific address&#39;s unique string value. (required).</param>
        /// <param name="createdTimestamp">Defines the specific UNIX time when the deposit address was created. (required).</param>
        /// <param name="label">Represents a custom tag that customers can set up for their Wallets and addresses. E.g. custom label named \&quot;Special addresses\&quot;. (required).</param>
        public GenerateDepositAddressRI(string address = default(string), int createdTimestamp = default(int), string label = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for GenerateDepositAddressRI and cannot be null");
            }
            this.Address = address;
            this.CreatedTimestamp = createdTimestamp;
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for GenerateDepositAddressRI and cannot be null");
            }
            this.Label = label;
        }

        /// <summary>
        /// Specifies the specific address&#39;s unique string value.
        /// </summary>
        /// <value>Specifies the specific address&#39;s unique string value.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Defines the specific UNIX time when the deposit address was created.
        /// </summary>
        /// <value>Defines the specific UNIX time when the deposit address was created.</value>
        [DataMember(Name = "createdTimestamp", IsRequired = true, EmitDefaultValue = false)]
        public int CreatedTimestamp { get; set; }

        /// <summary>
        /// Represents a custom tag that customers can set up for their Wallets and addresses. E.g. custom label named \&quot;Special addresses\&quot;.
        /// </summary>
        /// <value>Represents a custom tag that customers can set up for their Wallets and addresses. E.g. custom label named \&quot;Special addresses\&quot;.</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateDepositAddressRI {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as GenerateDepositAddressRI);
        }

        /// <summary>
        /// Returns true if GenerateDepositAddressRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateDepositAddressRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateDepositAddressRI input)
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
                    this.CreatedTimestamp == input.CreatedTimestamp ||
                    this.CreatedTimestamp.Equals(input.CreatedTimestamp)
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                hashCode = (hashCode * 59) + this.CreatedTimestamp.GetHashCode();
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
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
