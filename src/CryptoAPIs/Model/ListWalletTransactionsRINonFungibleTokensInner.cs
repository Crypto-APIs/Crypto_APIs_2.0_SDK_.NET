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
    /// ListWalletTransactionsRINonFungibleTokensInner
    /// </summary>
    [DataContract(Name = "ListWalletTransactionsRI_nonFungibleTokens_inner")]
    public partial class ListWalletTransactionsRINonFungibleTokensInner : IEquatable<ListWalletTransactionsRINonFungibleTokensInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWalletTransactionsRINonFungibleTokensInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListWalletTransactionsRINonFungibleTokensInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWalletTransactionsRINonFungibleTokensInner" /> class.
        /// </summary>
        /// <param name="convertedAmount">Defines the tokens&#39; converted amount value. (required).</param>
        /// <param name="exchangeRateUnit">Represents token&#39;s exchange rate unit. (required).</param>
        /// <param name="name">Defines the token&#39;s name as a string. (required).</param>
        /// <param name="recipient">Defines the address to which the recipient receives the transferred tokens. (required).</param>
        /// <param name="sender">Defines the address from which the sender transfers tokens. (required).</param>
        /// <param name="symbol">Defines the symbol of the non-fungible tokens. (required).</param>
        /// <param name="tokenId">Represents tokens&#39; unique identifier. (required).</param>
        /// <param name="type">Defines the specific token type. (required).</param>
        public ListWalletTransactionsRINonFungibleTokensInner(string convertedAmount = default(string), string exchangeRateUnit = default(string), string name = default(string), string recipient = default(string), string sender = default(string), string symbol = default(string), string tokenId = default(string), string type = default(string))
        {
            // to ensure "convertedAmount" is required (not null)
            if (convertedAmount == null)
            {
                throw new ArgumentNullException("convertedAmount is a required property for ListWalletTransactionsRINonFungibleTokensInner and cannot be null");
            }
            this.ConvertedAmount = convertedAmount;
            // to ensure "exchangeRateUnit" is required (not null)
            if (exchangeRateUnit == null)
            {
                throw new ArgumentNullException("exchangeRateUnit is a required property for ListWalletTransactionsRINonFungibleTokensInner and cannot be null");
            }
            this.ExchangeRateUnit = exchangeRateUnit;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ListWalletTransactionsRINonFungibleTokensInner and cannot be null");
            }
            this.Name = name;
            // to ensure "recipient" is required (not null)
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient is a required property for ListWalletTransactionsRINonFungibleTokensInner and cannot be null");
            }
            this.Recipient = recipient;
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for ListWalletTransactionsRINonFungibleTokensInner and cannot be null");
            }
            this.Sender = sender;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for ListWalletTransactionsRINonFungibleTokensInner and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new ArgumentNullException("tokenId is a required property for ListWalletTransactionsRINonFungibleTokensInner and cannot be null");
            }
            this.TokenId = tokenId;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ListWalletTransactionsRINonFungibleTokensInner and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Defines the tokens&#39; converted amount value.
        /// </summary>
        /// <value>Defines the tokens&#39; converted amount value.</value>
        [DataMember(Name = "convertedAmount", IsRequired = true, EmitDefaultValue = false)]
        public string ConvertedAmount { get; set; }

        /// <summary>
        /// Represents token&#39;s exchange rate unit.
        /// </summary>
        /// <value>Represents token&#39;s exchange rate unit.</value>
        [DataMember(Name = "exchangeRateUnit", IsRequired = true, EmitDefaultValue = false)]
        public string ExchangeRateUnit { get; set; }

        /// <summary>
        /// Defines the token&#39;s name as a string.
        /// </summary>
        /// <value>Defines the token&#39;s name as a string.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Defines the address to which the recipient receives the transferred tokens.
        /// </summary>
        /// <value>Defines the address to which the recipient receives the transferred tokens.</value>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Defines the address from which the sender transfers tokens.
        /// </summary>
        /// <value>Defines the address from which the sender transfers tokens.</value>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = false)]
        public string Sender { get; set; }

        /// <summary>
        /// Defines the symbol of the non-fungible tokens.
        /// </summary>
        /// <value>Defines the symbol of the non-fungible tokens.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Represents tokens&#39; unique identifier.
        /// </summary>
        /// <value>Represents tokens&#39; unique identifier.</value>
        [DataMember(Name = "tokenId", IsRequired = true, EmitDefaultValue = false)]
        public string TokenId { get; set; }

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
            sb.Append("class ListWalletTransactionsRINonFungibleTokensInner {\n");
            sb.Append("  ConvertedAmount: ").Append(ConvertedAmount).Append("\n");
            sb.Append("  ExchangeRateUnit: ").Append(ExchangeRateUnit).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
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
            return this.Equals(input as ListWalletTransactionsRINonFungibleTokensInner);
        }

        /// <summary>
        /// Returns true if ListWalletTransactionsRINonFungibleTokensInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ListWalletTransactionsRINonFungibleTokensInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListWalletTransactionsRINonFungibleTokensInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConvertedAmount == input.ConvertedAmount ||
                    (this.ConvertedAmount != null &&
                    this.ConvertedAmount.Equals(input.ConvertedAmount))
                ) && 
                (
                    this.ExchangeRateUnit == input.ExchangeRateUnit ||
                    (this.ExchangeRateUnit != null &&
                    this.ExchangeRateUnit.Equals(input.ExchangeRateUnit))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
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
                if (this.ConvertedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ConvertedAmount.GetHashCode();
                }
                if (this.ExchangeRateUnit != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeRateUnit.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
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
