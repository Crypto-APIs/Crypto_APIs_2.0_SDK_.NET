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
    /// Ethereum
    /// </summary>
    [DataContract(Name = "ListAllUnconfirmedTransactionsRIBSE")]
    public partial class ListAllUnconfirmedTransactionsRIBSE : IEquatable<ListAllUnconfirmedTransactionsRIBSE>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBSE" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListAllUnconfirmedTransactionsRIBSE() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBSE" /> class.
        /// </summary>
        /// <param name="fee">fee (required).</param>
        /// <param name="gasLimit">Represents the amount of gas used by this specific transaction alone. (required).</param>
        /// <param name="gasPrice">gasPrice (required).</param>
        /// <param name="inputData">Represents additional information that is required for the transaction. (required).</param>
        /// <param name="nonce">Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address. (required).</param>
        /// <param name="transactionStatus">Defines the transaction status. (required).</param>
        public ListAllUnconfirmedTransactionsRIBSE(ListAllUnconfirmedTransactionsRIBSEFee fee = default(ListAllUnconfirmedTransactionsRIBSEFee), string gasLimit = default(string), ListAllUnconfirmedTransactionsRIBSEGasPrice gasPrice = default(ListAllUnconfirmedTransactionsRIBSEGasPrice), string inputData = default(string), int nonce = default(int), string transactionStatus = default(string))
        {
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new ArgumentNullException("fee is a required property for ListAllUnconfirmedTransactionsRIBSE and cannot be null");
            }
            this.Fee = fee;
            // to ensure "gasLimit" is required (not null)
            if (gasLimit == null)
            {
                throw new ArgumentNullException("gasLimit is a required property for ListAllUnconfirmedTransactionsRIBSE and cannot be null");
            }
            this.GasLimit = gasLimit;
            // to ensure "gasPrice" is required (not null)
            if (gasPrice == null)
            {
                throw new ArgumentNullException("gasPrice is a required property for ListAllUnconfirmedTransactionsRIBSE and cannot be null");
            }
            this.GasPrice = gasPrice;
            // to ensure "inputData" is required (not null)
            if (inputData == null)
            {
                throw new ArgumentNullException("inputData is a required property for ListAllUnconfirmedTransactionsRIBSE and cannot be null");
            }
            this.InputData = inputData;
            this.Nonce = nonce;
            // to ensure "transactionStatus" is required (not null)
            if (transactionStatus == null)
            {
                throw new ArgumentNullException("transactionStatus is a required property for ListAllUnconfirmedTransactionsRIBSE and cannot be null");
            }
            this.TransactionStatus = transactionStatus;
        }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", IsRequired = true, EmitDefaultValue = false)]
        public ListAllUnconfirmedTransactionsRIBSEFee Fee { get; set; }

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
        public ListAllUnconfirmedTransactionsRIBSEGasPrice GasPrice { get; set; }

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
        /// Defines the transaction status.
        /// </summary>
        /// <value>Defines the transaction status.</value>
        [DataMember(Name = "transactionStatus", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListAllUnconfirmedTransactionsRIBSE {\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
            sb.Append("  InputData: ").Append(InputData).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
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
            return this.Equals(input as ListAllUnconfirmedTransactionsRIBSE);
        }

        /// <summary>
        /// Returns true if ListAllUnconfirmedTransactionsRIBSE instances are equal
        /// </summary>
        /// <param name="input">Instance of ListAllUnconfirmedTransactionsRIBSE to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListAllUnconfirmedTransactionsRIBSE input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
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
                    this.InputData == input.InputData ||
                    (this.InputData != null &&
                    this.InputData.Equals(input.InputData))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    (this.TransactionStatus != null &&
                    this.TransactionStatus.Equals(input.TransactionStatus))
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
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.GasLimit != null)
                {
                    hashCode = (hashCode * 59) + this.GasLimit.GetHashCode();
                }
                if (this.GasPrice != null)
                {
                    hashCode = (hashCode * 59) + this.GasPrice.GetHashCode();
                }
                if (this.InputData != null)
                {
                    hashCode = (hashCode * 59) + this.InputData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.TransactionStatus != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionStatus.GetHashCode();
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
