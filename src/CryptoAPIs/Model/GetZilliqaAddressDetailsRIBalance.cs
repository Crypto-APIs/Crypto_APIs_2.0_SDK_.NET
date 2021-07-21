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
    /// Represents the total balance of the address as an object.
    /// </summary>
    [DataContract(Name = "GetZilliqaAddressDetailsRI_balance")]
    public partial class GetZilliqaAddressDetailsRIBalance : IEquatable<GetZilliqaAddressDetailsRIBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetZilliqaAddressDetailsRIBalance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetZilliqaAddressDetailsRIBalance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetZilliqaAddressDetailsRIBalance" /> class.
        /// </summary>
        /// <param name="amount">Represents the amount of the address&#39;s balance. (required).</param>
        /// <param name="unit">Represents the unit of the address&#39;s balance. (required).</param>
        public GetZilliqaAddressDetailsRIBalance(string amount = default(string), string unit = default(string))
        {
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount is a required property for GetZilliqaAddressDetailsRIBalance and cannot be null");
            // to ensure "unit" is required (not null)
            this.Unit = unit ?? throw new ArgumentNullException("unit is a required property for GetZilliqaAddressDetailsRIBalance and cannot be null");
        }

        /// <summary>
        /// Represents the amount of the address&#39;s balance.
        /// </summary>
        /// <value>Represents the amount of the address&#39;s balance.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Represents the unit of the address&#39;s balance.
        /// </summary>
        /// <value>Represents the unit of the address&#39;s balance.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetZilliqaAddressDetailsRIBalance {\n");
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
            return this.Equals(input as GetZilliqaAddressDetailsRIBalance);
        }

        /// <summary>
        /// Returns true if GetZilliqaAddressDetailsRIBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of GetZilliqaAddressDetailsRIBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetZilliqaAddressDetailsRIBalance input)
        {
            if (input == null)
                return false;

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
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
