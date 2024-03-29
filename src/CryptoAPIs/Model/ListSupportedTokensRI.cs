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
    /// ListSupportedTokensRI
    /// </summary>
    [DataContract(Name = "ListSupportedTokensRI")]
    public partial class ListSupportedTokensRI : IEquatable<ListSupportedTokensRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSupportedTokensRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListSupportedTokensRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSupportedTokensRI" /> class.
        /// </summary>
        /// <param name="decimals">Defines the token&#39;s decimal number or all of its points after the zero. (required).</param>
        /// <param name="identifier">Represents a unique identifier for the specific blockchain and network, e.g. smart contract address, property ID, etc. (required).</param>
        /// <param name="name">Defines the token name. (required).</param>
        /// <param name="symbol">Defines the token&#39;s unique symbol in the Crypto APIs listings. (required).</param>
        /// <param name="type">Represents the token&#39;s type representation, e.g. ERC-20, Omni, etc. (required).</param>
        public ListSupportedTokensRI(int decimals = default(int), string identifier = default(string), string name = default(string), string symbol = default(string), string type = default(string))
        {
            this.Decimals = decimals;
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for ListSupportedTokensRI and cannot be null");
            }
            this.Identifier = identifier;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ListSupportedTokensRI and cannot be null");
            }
            this.Name = name;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for ListSupportedTokensRI and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ListSupportedTokensRI and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Defines the token&#39;s decimal number or all of its points after the zero.
        /// </summary>
        /// <value>Defines the token&#39;s decimal number or all of its points after the zero.</value>
        [DataMember(Name = "decimals", IsRequired = true, EmitDefaultValue = false)]
        public int Decimals { get; set; }

        /// <summary>
        /// Represents a unique identifier for the specific blockchain and network, e.g. smart contract address, property ID, etc.
        /// </summary>
        /// <value>Represents a unique identifier for the specific blockchain and network, e.g. smart contract address, property ID, etc.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Defines the token name.
        /// </summary>
        /// <value>Defines the token name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Defines the token&#39;s unique symbol in the Crypto APIs listings.
        /// </summary>
        /// <value>Defines the token&#39;s unique symbol in the Crypto APIs listings.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Represents the token&#39;s type representation, e.g. ERC-20, Omni, etc.
        /// </summary>
        /// <value>Represents the token&#39;s type representation, e.g. ERC-20, Omni, etc.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListSupportedTokensRI {\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ListSupportedTokensRI);
        }

        /// <summary>
        /// Returns true if ListSupportedTokensRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListSupportedTokensRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListSupportedTokensRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Decimals == input.Decimals ||
                    this.Decimals.Equals(input.Decimals)
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.Decimals.GetHashCode();
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
