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
    /// ListWalletTransactionsRIInternalTransactionsInner
    /// </summary>
    [DataContract(Name = "ListWalletTransactionsRI_internalTransactions_inner")]
    public partial class ListWalletTransactionsRIInternalTransactionsInner : IEquatable<ListWalletTransactionsRIInternalTransactionsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWalletTransactionsRIInternalTransactionsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListWalletTransactionsRIInternalTransactionsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWalletTransactionsRIInternalTransactionsInner" /> class.
        /// </summary>
        /// <param name="amount">Defines the specific amount of the transaction. (required).</param>
        /// <param name="convertedAmount">Represents the converted amount. (required).</param>
        /// <param name="exchangeRateUnit">Defines the base asset symbol to get a rate for. (required).</param>
        /// <param name="operationId">Represents the unique internal transaction ID in regards to the parent transaction (type trace address). (required).</param>
        /// <param name="recipient">Represents the recipient address with the respective amount. (required).</param>
        /// <param name="sender">Represents the sender address with the respective amount. (required).</param>
        /// <param name="symbol">Represents the unique unit symbol. (required).</param>
        public ListWalletTransactionsRIInternalTransactionsInner(string amount = default(string), string convertedAmount = default(string), string exchangeRateUnit = default(string), string operationId = default(string), string recipient = default(string), string sender = default(string), string symbol = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ListWalletTransactionsRIInternalTransactionsInner and cannot be null");
            }
            this.Amount = amount;
            // to ensure "convertedAmount" is required (not null)
            if (convertedAmount == null)
            {
                throw new ArgumentNullException("convertedAmount is a required property for ListWalletTransactionsRIInternalTransactionsInner and cannot be null");
            }
            this.ConvertedAmount = convertedAmount;
            // to ensure "exchangeRateUnit" is required (not null)
            if (exchangeRateUnit == null)
            {
                throw new ArgumentNullException("exchangeRateUnit is a required property for ListWalletTransactionsRIInternalTransactionsInner and cannot be null");
            }
            this.ExchangeRateUnit = exchangeRateUnit;
            // to ensure "operationId" is required (not null)
            if (operationId == null)
            {
                throw new ArgumentNullException("operationId is a required property for ListWalletTransactionsRIInternalTransactionsInner and cannot be null");
            }
            this.OperationId = operationId;
            // to ensure "recipient" is required (not null)
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient is a required property for ListWalletTransactionsRIInternalTransactionsInner and cannot be null");
            }
            this.Recipient = recipient;
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for ListWalletTransactionsRIInternalTransactionsInner and cannot be null");
            }
            this.Sender = sender;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for ListWalletTransactionsRIInternalTransactionsInner and cannot be null");
            }
            this.Symbol = symbol;
        }

        /// <summary>
        /// Defines the specific amount of the transaction.
        /// </summary>
        /// <value>Defines the specific amount of the transaction.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Represents the converted amount.
        /// </summary>
        /// <value>Represents the converted amount.</value>
        [DataMember(Name = "convertedAmount", IsRequired = true, EmitDefaultValue = false)]
        public string ConvertedAmount { get; set; }

        /// <summary>
        /// Defines the base asset symbol to get a rate for.
        /// </summary>
        /// <value>Defines the base asset symbol to get a rate for.</value>
        [DataMember(Name = "exchangeRateUnit", IsRequired = true, EmitDefaultValue = false)]
        public string ExchangeRateUnit { get; set; }

        /// <summary>
        /// Represents the unique internal transaction ID in regards to the parent transaction (type trace address).
        /// </summary>
        /// <value>Represents the unique internal transaction ID in regards to the parent transaction (type trace address).</value>
        [DataMember(Name = "operationId", IsRequired = true, EmitDefaultValue = false)]
        public string OperationId { get; set; }

        /// <summary>
        /// Represents the recipient address with the respective amount.
        /// </summary>
        /// <value>Represents the recipient address with the respective amount.</value>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Represents the sender address with the respective amount.
        /// </summary>
        /// <value>Represents the sender address with the respective amount.</value>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = false)]
        public string Sender { get; set; }

        /// <summary>
        /// Represents the unique unit symbol.
        /// </summary>
        /// <value>Represents the unique unit symbol.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListWalletTransactionsRIInternalTransactionsInner {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ConvertedAmount: ").Append(ConvertedAmount).Append("\n");
            sb.Append("  ExchangeRateUnit: ").Append(ExchangeRateUnit).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
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
            return this.Equals(input as ListWalletTransactionsRIInternalTransactionsInner);
        }

        /// <summary>
        /// Returns true if ListWalletTransactionsRIInternalTransactionsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ListWalletTransactionsRIInternalTransactionsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListWalletTransactionsRIInternalTransactionsInner input)
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
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
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
                if (this.OperationId != null)
                {
                    hashCode = (hashCode * 59) + this.OperationId.GetHashCode();
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
