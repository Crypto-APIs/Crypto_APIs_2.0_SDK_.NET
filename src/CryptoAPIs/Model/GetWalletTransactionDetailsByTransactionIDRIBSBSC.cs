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
    /// Binance Smart Chain
    /// </summary>
    [DataContract(Name = "GetWalletTransactionDetailsByTransactionIDRIBSBSC")]
    public partial class GetWalletTransactionDetailsByTransactionIDRIBSBSC : IEquatable<GetWalletTransactionDetailsByTransactionIDRIBSBSC>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletTransactionDetailsByTransactionIDRIBSBSC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWalletTransactionDetailsByTransactionIDRIBSBSC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletTransactionDetailsByTransactionIDRIBSBSC" /> class.
        /// </summary>
        /// <param name="contract">Represents the specific transaction contract (required).</param>
        /// <param name="gasLimit">Represents the amount of gas used by this specific transaction alone. (required).</param>
        /// <param name="gasPrice">gasPrice (required).</param>
        /// <param name="gasUsed">Defines the unit of the gas price amount, e.g. BTC, ETH, XRP. (required).</param>
        /// <param name="inputData">Represents additional information that is required for the transaction. (required).</param>
        /// <param name="nonce">Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address. (required).</param>
        public GetWalletTransactionDetailsByTransactionIDRIBSBSC(string contract = default(string), string gasLimit = default(string), GetTransactionDetailsByTransactionIDRIBSBSCGasPrice gasPrice = default(GetTransactionDetailsByTransactionIDRIBSBSCGasPrice), string gasUsed = default(string), string inputData = default(string), int nonce = default(int))
        {
            // to ensure "contract" is required (not null)
            if (contract == null)
            {
                throw new ArgumentNullException("contract is a required property for GetWalletTransactionDetailsByTransactionIDRIBSBSC and cannot be null");
            }
            this.Contract = contract;
            // to ensure "gasLimit" is required (not null)
            if (gasLimit == null)
            {
                throw new ArgumentNullException("gasLimit is a required property for GetWalletTransactionDetailsByTransactionIDRIBSBSC and cannot be null");
            }
            this.GasLimit = gasLimit;
            // to ensure "gasPrice" is required (not null)
            if (gasPrice == null)
            {
                throw new ArgumentNullException("gasPrice is a required property for GetWalletTransactionDetailsByTransactionIDRIBSBSC and cannot be null");
            }
            this.GasPrice = gasPrice;
            // to ensure "gasUsed" is required (not null)
            if (gasUsed == null)
            {
                throw new ArgumentNullException("gasUsed is a required property for GetWalletTransactionDetailsByTransactionIDRIBSBSC and cannot be null");
            }
            this.GasUsed = gasUsed;
            // to ensure "inputData" is required (not null)
            if (inputData == null)
            {
                throw new ArgumentNullException("inputData is a required property for GetWalletTransactionDetailsByTransactionIDRIBSBSC and cannot be null");
            }
            this.InputData = inputData;
            this.Nonce = nonce;
        }

        /// <summary>
        /// Represents the specific transaction contract
        /// </summary>
        /// <value>Represents the specific transaction contract</value>
        [DataMember(Name = "contract", IsRequired = true, EmitDefaultValue = false)]
        public string Contract { get; set; }

        /// <summary>
        /// Represents the amount of gas used by this specific transaction alone.
        /// </summary>
        /// <value>Represents the amount of gas used by this specific transaction alone.</value>
        [DataMember(Name = "gasLimit", IsRequired = true, EmitDefaultValue = false)]
        public string GasLimit { get; set; }

        /// <summary>
        /// Gets or Sets GasPrice
        /// </summary>
        [DataMember(Name = "gasPrice", IsRequired = true, EmitDefaultValue = false)]
        public GetTransactionDetailsByTransactionIDRIBSBSCGasPrice GasPrice { get; set; }

        /// <summary>
        /// Defines the unit of the gas price amount, e.g. BTC, ETH, XRP.
        /// </summary>
        /// <value>Defines the unit of the gas price amount, e.g. BTC, ETH, XRP.</value>
        [DataMember(Name = "gasUsed", IsRequired = true, EmitDefaultValue = false)]
        public string GasUsed { get; set; }

        /// <summary>
        /// Represents additional information that is required for the transaction.
        /// </summary>
        /// <value>Represents additional information that is required for the transaction.</value>
        [DataMember(Name = "inputData", IsRequired = true, EmitDefaultValue = false)]
        public string InputData { get; set; }

        /// <summary>
        /// Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address.
        /// </summary>
        /// <value>Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address.</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = false)]
        public int Nonce { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetWalletTransactionDetailsByTransactionIDRIBSBSC {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
            sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
            sb.Append("  InputData: ").Append(InputData).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
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
            return this.Equals(input as GetWalletTransactionDetailsByTransactionIDRIBSBSC);
        }

        /// <summary>
        /// Returns true if GetWalletTransactionDetailsByTransactionIDRIBSBSC instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWalletTransactionDetailsByTransactionIDRIBSBSC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWalletTransactionDetailsByTransactionIDRIBSBSC input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Contract == input.Contract ||
                    (this.Contract != null &&
                    this.Contract.Equals(input.Contract))
                ) && 
                (
                    this.GasLimit == input.GasLimit ||
                    (this.GasLimit != null &&
                    this.GasLimit.Equals(input.GasLimit))
                ) && 
                (
                    this.GasPrice == input.GasPrice ||
                    (this.GasPrice != null &&
                    this.GasPrice.Equals(input.GasPrice))
                ) && 
                (
                    this.GasUsed == input.GasUsed ||
                    (this.GasUsed != null &&
                    this.GasUsed.Equals(input.GasUsed))
                ) && 
                (
                    this.InputData == input.InputData ||
                    (this.InputData != null &&
                    this.InputData.Equals(input.InputData))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
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
                if (this.Contract != null)
                {
                    hashCode = (hashCode * 59) + this.Contract.GetHashCode();
                }
                if (this.GasLimit != null)
                {
                    hashCode = (hashCode * 59) + this.GasLimit.GetHashCode();
                }
                if (this.GasPrice != null)
                {
                    hashCode = (hashCode * 59) + this.GasPrice.GetHashCode();
                }
                if (this.GasUsed != null)
                {
                    hashCode = (hashCode * 59) + this.GasUsed.GetHashCode();
                }
                if (this.InputData != null)
                {
                    hashCode = (hashCode * 59) + this.InputData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
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
