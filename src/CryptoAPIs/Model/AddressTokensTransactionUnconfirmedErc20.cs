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
    /// ERC-20
    /// </summary>
    [DataContract(Name = "AddressTokensTransactionUnconfirmedErc-20")]
    public partial class AddressTokensTransactionUnconfirmedErc20 : IEquatable<AddressTokensTransactionUnconfirmedErc20>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionUnconfirmedErc20" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressTokensTransactionUnconfirmedErc20() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionUnconfirmedErc20" /> class.
        /// </summary>
        /// <param name="name">Specifies the name of the token. (required).</param>
        /// <param name="symbol">Specifies an identifier of the token, where up to five alphanumeric characters can be used for it. (required).</param>
        /// <param name="decimals">Defines how many decimals can be used to break the token..</param>
        /// <param name="amount">Defines the amount of tokens sent with the transaction that is pending confirmation. (required).</param>
        /// <param name="contractAddress">Defines the address of the contract. (required).</param>
        public AddressTokensTransactionUnconfirmedErc20(string name = default(string), string symbol = default(string), string decimals = default(string), string amount = default(string), string contractAddress = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for AddressTokensTransactionUnconfirmedErc20 and cannot be null");
            }
            this.Name = name;
            // to ensure "symbol" is required (not null)
            if (symbol == null) {
                throw new ArgumentNullException("symbol is a required property for AddressTokensTransactionUnconfirmedErc20 and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "amount" is required (not null)
            if (amount == null) {
                throw new ArgumentNullException("amount is a required property for AddressTokensTransactionUnconfirmedErc20 and cannot be null");
            }
            this.Amount = amount;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null) {
                throw new ArgumentNullException("contractAddress is a required property for AddressTokensTransactionUnconfirmedErc20 and cannot be null");
            }
            this.ContractAddress = contractAddress;
            this.Decimals = decimals;
        }

        /// <summary>
        /// Specifies the name of the token.
        /// </summary>
        /// <value>Specifies the name of the token.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies an identifier of the token, where up to five alphanumeric characters can be used for it.
        /// </summary>
        /// <value>Specifies an identifier of the token, where up to five alphanumeric characters can be used for it.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Defines how many decimals can be used to break the token.
        /// </summary>
        /// <value>Defines how many decimals can be used to break the token.</value>
        [DataMember(Name = "decimals", EmitDefaultValue = false)]
        public string Decimals { get; set; }

        /// <summary>
        /// Defines the amount of tokens sent with the transaction that is pending confirmation.
        /// </summary>
        /// <value>Defines the amount of tokens sent with the transaction that is pending confirmation.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Defines the address of the contract.
        /// </summary>
        /// <value>Defines the address of the contract.</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = false)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressTokensTransactionUnconfirmedErc20 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
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
            return this.Equals(input as AddressTokensTransactionUnconfirmedErc20);
        }

        /// <summary>
        /// Returns true if AddressTokensTransactionUnconfirmedErc20 instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressTokensTransactionUnconfirmedErc20 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressTokensTransactionUnconfirmedErc20 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Decimals == input.Decimals ||
                    (this.Decimals != null &&
                    this.Decimals.Equals(input.Decimals))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.Decimals != null)
                {
                    hashCode = (hashCode * 59) + this.Decimals.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
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
