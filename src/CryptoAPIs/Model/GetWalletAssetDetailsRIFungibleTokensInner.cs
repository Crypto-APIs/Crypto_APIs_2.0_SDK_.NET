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
    /// GetWalletAssetDetailsRIFungibleTokensInner
    /// </summary>
    [DataContract(Name = "GetWalletAssetDetailsRI_fungibleTokens_inner")]
    public partial class GetWalletAssetDetailsRIFungibleTokensInner : IEquatable<GetWalletAssetDetailsRIFungibleTokensInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletAssetDetailsRIFungibleTokensInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWalletAssetDetailsRIFungibleTokensInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletAssetDetailsRIFungibleTokensInner" /> class.
        /// </summary>
        /// <param name="confirmedAmount">Defines the amount of the fungible tokens. (required).</param>
        /// <param name="identifier">Defines the specific token identifier. For Bitcoin-based transactions it should be the propertyId and for Ethereum-based transactions - the contract. (required).</param>
        /// <param name="symbol">Defines the symbol of the fungible tokens. (required).</param>
        /// <param name="type">Defines the specific token type. (required).</param>
        public GetWalletAssetDetailsRIFungibleTokensInner(string confirmedAmount = default(string), string identifier = default(string), string symbol = default(string), string type = default(string))
        {
            // to ensure "confirmedAmount" is required (not null)
            if (confirmedAmount == null)
            {
                throw new ArgumentNullException("confirmedAmount is a required property for GetWalletAssetDetailsRIFungibleTokensInner and cannot be null");
            }
            this.ConfirmedAmount = confirmedAmount;
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for GetWalletAssetDetailsRIFungibleTokensInner and cannot be null");
            }
            this.Identifier = identifier;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for GetWalletAssetDetailsRIFungibleTokensInner and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for GetWalletAssetDetailsRIFungibleTokensInner and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Defines the amount of the fungible tokens.
        /// </summary>
        /// <value>Defines the amount of the fungible tokens.</value>
        [DataMember(Name = "confirmedAmount", IsRequired = true, EmitDefaultValue = false)]
        public string ConfirmedAmount { get; set; }

        /// <summary>
        /// Defines the specific token identifier. For Bitcoin-based transactions it should be the propertyId and for Ethereum-based transactions - the contract.
        /// </summary>
        /// <value>Defines the specific token identifier. For Bitcoin-based transactions it should be the propertyId and for Ethereum-based transactions - the contract.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Defines the symbol of the fungible tokens.
        /// </summary>
        /// <value>Defines the symbol of the fungible tokens.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Defines the specific token type.
        /// </summary>
        /// <value>Defines the specific token type.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetWalletAssetDetailsRIFungibleTokensInner {\n");
            sb.Append("  ConfirmedAmount: ").Append(ConfirmedAmount).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GetWalletAssetDetailsRIFungibleTokensInner);
        }

        /// <summary>
        /// Returns true if GetWalletAssetDetailsRIFungibleTokensInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWalletAssetDetailsRIFungibleTokensInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWalletAssetDetailsRIFungibleTokensInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConfirmedAmount == input.ConfirmedAmount ||
                    (this.ConfirmedAmount != null &&
                    this.ConfirmedAmount.Equals(input.ConfirmedAmount))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ConfirmedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmedAmount.GetHashCode();
                }
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
