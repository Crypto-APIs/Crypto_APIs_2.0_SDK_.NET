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
    /// GetContractDetailsByAddressRI
    /// </summary>
    [DataContract(Name = "GetContractDetailsByAddressRI")]
    public partial class GetContractDetailsByAddressRI : IEquatable<GetContractDetailsByAddressRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContractDetailsByAddressRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetContractDetailsByAddressRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContractDetailsByAddressRI" /> class.
        /// </summary>
        /// <param name="tokenDecimals">Defines the number of decimals that the token possesses. (required).</param>
        /// <param name="tokenName">Specifies the token&#39;s name..</param>
        /// <param name="tokenSymbol">Defines the unique symbol of the token..</param>
        /// <param name="tokenType">Defines the type of the token. (required).</param>
        /// <param name="totalSupply">Defines the total number of tokens created that exist on the market minus the ones that have been burned. (required).</param>
        public GetContractDetailsByAddressRI(string tokenDecimals = default(string), string tokenName = default(string), string tokenSymbol = default(string), string tokenType = default(string), string totalSupply = default(string))
        {
            // to ensure "tokenDecimals" is required (not null)
            this.TokenDecimals = tokenDecimals ?? throw new ArgumentNullException("tokenDecimals is a required property for GetContractDetailsByAddressRI and cannot be null");
            // to ensure "tokenType" is required (not null)
            this.TokenType = tokenType ?? throw new ArgumentNullException("tokenType is a required property for GetContractDetailsByAddressRI and cannot be null");
            // to ensure "totalSupply" is required (not null)
            this.TotalSupply = totalSupply ?? throw new ArgumentNullException("totalSupply is a required property for GetContractDetailsByAddressRI and cannot be null");
            this.TokenName = tokenName;
            this.TokenSymbol = tokenSymbol;
        }

        /// <summary>
        /// Defines the number of decimals that the token possesses.
        /// </summary>
        /// <value>Defines the number of decimals that the token possesses.</value>
        [DataMember(Name = "tokenDecimals", IsRequired = true, EmitDefaultValue = false)]
        public string TokenDecimals { get; set; }

        /// <summary>
        /// Specifies the token&#39;s name.
        /// </summary>
        /// <value>Specifies the token&#39;s name.</value>
        [DataMember(Name = "tokenName", EmitDefaultValue = false)]
        public string TokenName { get; set; }

        /// <summary>
        /// Defines the unique symbol of the token.
        /// </summary>
        /// <value>Defines the unique symbol of the token.</value>
        [DataMember(Name = "tokenSymbol", EmitDefaultValue = false)]
        public string TokenSymbol { get; set; }

        /// <summary>
        /// Defines the type of the token.
        /// </summary>
        /// <value>Defines the type of the token.</value>
        [DataMember(Name = "tokenType", IsRequired = true, EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Defines the total number of tokens created that exist on the market minus the ones that have been burned.
        /// </summary>
        /// <value>Defines the total number of tokens created that exist on the market minus the ones that have been burned.</value>
        [DataMember(Name = "totalSupply", IsRequired = true, EmitDefaultValue = false)]
        public string TotalSupply { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetContractDetailsByAddressRI {\n");
            sb.Append("  TokenDecimals: ").Append(TokenDecimals).Append("\n");
            sb.Append("  TokenName: ").Append(TokenName).Append("\n");
            sb.Append("  TokenSymbol: ").Append(TokenSymbol).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  TotalSupply: ").Append(TotalSupply).Append("\n");
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
            return this.Equals(input as GetContractDetailsByAddressRI);
        }

        /// <summary>
        /// Returns true if GetContractDetailsByAddressRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetContractDetailsByAddressRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetContractDetailsByAddressRI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenDecimals == input.TokenDecimals ||
                    (this.TokenDecimals != null &&
                    this.TokenDecimals.Equals(input.TokenDecimals))
                ) && 
                (
                    this.TokenName == input.TokenName ||
                    (this.TokenName != null &&
                    this.TokenName.Equals(input.TokenName))
                ) && 
                (
                    this.TokenSymbol == input.TokenSymbol ||
                    (this.TokenSymbol != null &&
                    this.TokenSymbol.Equals(input.TokenSymbol))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.TotalSupply == input.TotalSupply ||
                    (this.TotalSupply != null &&
                    this.TotalSupply.Equals(input.TotalSupply))
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
                if (this.TokenDecimals != null)
                    hashCode = hashCode * 59 + this.TokenDecimals.GetHashCode();
                if (this.TokenName != null)
                    hashCode = hashCode * 59 + this.TokenName.GetHashCode();
                if (this.TokenSymbol != null)
                    hashCode = hashCode * 59 + this.TokenSymbol.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.TotalSupply != null)
                    hashCode = hashCode * 59 + this.TotalSupply.GetHashCode();
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