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
    /// ValidateAddressRI
    /// </summary>
    [DataContract(Name = "ValidateAddressRI")]
    public partial class ValidateAddressRI : IEquatable<ValidateAddressRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateAddressRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidateAddressRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateAddressRI" /> class.
        /// </summary>
        /// <param name="address">Represents the specific address that will be checked if it&#39;s valid or not. (required).</param>
        /// <param name="isValid">Defines whether the address is valid or not. Set as boolean. (required).</param>
        public ValidateAddressRI(string address = default(string), bool isValid = default(bool))
        {
            // to ensure "address" is required (not null)
            this.Address = address ?? throw new ArgumentNullException("address is a required property for ValidateAddressRI and cannot be null");
            this.IsValid = isValid;
        }

        /// <summary>
        /// Represents the specific address that will be checked if it&#39;s valid or not.
        /// </summary>
        /// <value>Represents the specific address that will be checked if it&#39;s valid or not.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Defines whether the address is valid or not. Set as boolean.
        /// </summary>
        /// <value>Defines whether the address is valid or not. Set as boolean.</value>
        [DataMember(Name = "isValid", IsRequired = true, EmitDefaultValue = true)]
        public bool IsValid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateAddressRI {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
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
            return this.Equals(input as ValidateAddressRI);
        }

        /// <summary>
        /// Returns true if ValidateAddressRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateAddressRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateAddressRI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
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
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}