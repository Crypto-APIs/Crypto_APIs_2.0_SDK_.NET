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
    /// ListWalletTransactionsRIValue
    /// </summary>
    [DataContract(Name = "ListWalletTransactionsRI_value")]
    public partial class ListWalletTransactionsRIValue : IEquatable<ListWalletTransactionsRIValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWalletTransactionsRIValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListWalletTransactionsRIValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWalletTransactionsRIValue" /> class.
        /// </summary>
        /// <param name="amount">Defines the transaction amount. (required).</param>
        /// <param name="convertedAmount">Defines the converted amount of the transaction as a string. (required).</param>
        /// <param name="exchangeRateUnit">Defines the exchange rate&#39;s unit. (required).</param>
        /// <param name="symbol">Defines the unit of the transaction&#39;s amount. (required).</param>
        public ListWalletTransactionsRIValue(string amount = default(string), string convertedAmount = default(string), string exchangeRateUnit = default(string), string symbol = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ListWalletTransactionsRIValue and cannot be null");
            }
            this.Amount = amount;
            // to ensure "convertedAmount" is required (not null)
            if (convertedAmount == null)
            {
                throw new ArgumentNullException("convertedAmount is a required property for ListWalletTransactionsRIValue and cannot be null");
            }
            this.ConvertedAmount = convertedAmount;
            // to ensure "exchangeRateUnit" is required (not null)
            if (exchangeRateUnit == null)
            {
                throw new ArgumentNullException("exchangeRateUnit is a required property for ListWalletTransactionsRIValue and cannot be null");
            }
            this.ExchangeRateUnit = exchangeRateUnit;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for ListWalletTransactionsRIValue and cannot be null");
            }
            this.Symbol = symbol;
        }

        /// <summary>
        /// Defines the transaction amount.
        /// </summary>
        /// <value>Defines the transaction amount.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Defines the converted amount of the transaction as a string.
        /// </summary>
        /// <value>Defines the converted amount of the transaction as a string.</value>
        [DataMember(Name = "convertedAmount", IsRequired = true, EmitDefaultValue = false)]
        public string ConvertedAmount { get; set; }

        /// <summary>
        /// Defines the exchange rate&#39;s unit.
        /// </summary>
        /// <value>Defines the exchange rate&#39;s unit.</value>
        [DataMember(Name = "exchangeRateUnit", IsRequired = true, EmitDefaultValue = false)]
        public string ExchangeRateUnit { get; set; }

        /// <summary>
        /// Defines the unit of the transaction&#39;s amount.
        /// </summary>
        /// <value>Defines the unit of the transaction&#39;s amount.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListWalletTransactionsRIValue {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ConvertedAmount: ").Append(ConvertedAmount).Append("\n");
            sb.Append("  ExchangeRateUnit: ").Append(ExchangeRateUnit).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
            return this.Equals(input as ListWalletTransactionsRIValue);
        }

        /// <summary>
        /// Returns true if ListWalletTransactionsRIValue instances are equal
        /// </summary>
        /// <param name="input">Instance of ListWalletTransactionsRIValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListWalletTransactionsRIValue input)
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
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
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
                if (this.ConvertedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ConvertedAmount.GetHashCode();
                }
                if (this.ExchangeRateUnit != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeRateUnit.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
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
