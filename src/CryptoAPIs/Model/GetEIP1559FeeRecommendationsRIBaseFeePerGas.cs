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
    /// GetEIP1559FeeRecommendationsRIBaseFeePerGas
    /// </summary>
    [DataContract(Name = "GetEIP1559FeeRecommendationsRI_baseFeePerGas")]
    public partial class GetEIP1559FeeRecommendationsRIBaseFeePerGas : IEquatable<GetEIP1559FeeRecommendationsRIBaseFeePerGas>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEIP1559FeeRecommendationsRIBaseFeePerGas" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEIP1559FeeRecommendationsRIBaseFeePerGas() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEIP1559FeeRecommendationsRIBaseFeePerGas" /> class.
        /// </summary>
        /// <param name="unit">Represents the unit of the base fee per gas. (required).</param>
        /// <param name="value">Represents the expected base fee per gas of the upcoming block, calculated from the previous block data. (required).</param>
        public GetEIP1559FeeRecommendationsRIBaseFeePerGas(string unit = default(string), string value = default(string))
        {
            // to ensure "unit" is required (not null)
            if (unit == null)
            {
                throw new ArgumentNullException("unit is a required property for GetEIP1559FeeRecommendationsRIBaseFeePerGas and cannot be null");
            }
            this.Unit = unit;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for GetEIP1559FeeRecommendationsRIBaseFeePerGas and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// Represents the unit of the base fee per gas.
        /// </summary>
        /// <value>Represents the unit of the base fee per gas.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Represents the expected base fee per gas of the upcoming block, calculated from the previous block data.
        /// </summary>
        /// <value>Represents the expected base fee per gas of the upcoming block, calculated from the previous block data.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetEIP1559FeeRecommendationsRIBaseFeePerGas {\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as GetEIP1559FeeRecommendationsRIBaseFeePerGas);
        }

        /// <summary>
        /// Returns true if GetEIP1559FeeRecommendationsRIBaseFeePerGas instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEIP1559FeeRecommendationsRIBaseFeePerGas to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEIP1559FeeRecommendationsRIBaseFeePerGas input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
