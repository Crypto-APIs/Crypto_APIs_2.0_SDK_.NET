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
    /// ListInternalTransactionsByAddressAndTimeRangeRI
    /// </summary>
    [DataContract(Name = "ListInternalTransactionsByAddressAndTimeRangeRI")]
    public partial class ListInternalTransactionsByAddressAndTimeRangeRI : IEquatable<ListInternalTransactionsByAddressAndTimeRangeRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInternalTransactionsByAddressAndTimeRangeRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListInternalTransactionsByAddressAndTimeRangeRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInternalTransactionsByAddressAndTimeRangeRI" /> class.
        /// </summary>
        /// <param name="amount">Defines the specific amount of the transaction. (required).</param>
        /// <param name="minedInBlockHash">Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. (required).</param>
        /// <param name="minedInBlockHeight">Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block. (required).</param>
        /// <param name="operationID">Represents the unique internal transaction ID in regards to the parent transaction (type trace address). (required).</param>
        /// <param name="operationType">Defines the call type of the internal transaction. (required).</param>
        /// <param name="parentHash">Defines the specific hash of the parent transaction. (required).</param>
        /// <param name="recipient">Represents the recipient address with the respective amount. (required).</param>
        /// <param name="sender">Represents the sender address with the respective amount. (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        public ListInternalTransactionsByAddressAndTimeRangeRI(string amount = default(string), string minedInBlockHash = default(string), int minedInBlockHeight = default(int), string operationID = default(string), string operationType = default(string), string parentHash = default(string), string recipient = default(string), string sender = default(string), int timestamp = default(int))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ListInternalTransactionsByAddressAndTimeRangeRI and cannot be null");
            }
            this.Amount = amount;
            // to ensure "minedInBlockHash" is required (not null)
            if (minedInBlockHash == null)
            {
                throw new ArgumentNullException("minedInBlockHash is a required property for ListInternalTransactionsByAddressAndTimeRangeRI and cannot be null");
            }
            this.MinedInBlockHash = minedInBlockHash;
            this.MinedInBlockHeight = minedInBlockHeight;
            // to ensure "operationID" is required (not null)
            if (operationID == null)
            {
                throw new ArgumentNullException("operationID is a required property for ListInternalTransactionsByAddressAndTimeRangeRI and cannot be null");
            }
            this.OperationID = operationID;
            // to ensure "operationType" is required (not null)
            if (operationType == null)
            {
                throw new ArgumentNullException("operationType is a required property for ListInternalTransactionsByAddressAndTimeRangeRI and cannot be null");
            }
            this.OperationType = operationType;
            // to ensure "parentHash" is required (not null)
            if (parentHash == null)
            {
                throw new ArgumentNullException("parentHash is a required property for ListInternalTransactionsByAddressAndTimeRangeRI and cannot be null");
            }
            this.ParentHash = parentHash;
            // to ensure "recipient" is required (not null)
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient is a required property for ListInternalTransactionsByAddressAndTimeRangeRI and cannot be null");
            }
            this.Recipient = recipient;
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for ListInternalTransactionsByAddressAndTimeRangeRI and cannot be null");
            }
            this.Sender = sender;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Defines the specific amount of the transaction.
        /// </summary>
        /// <value>Defines the specific amount of the transaction.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.
        /// </summary>
        /// <value>Represents the hash of the block where this transaction was mined/confirmed for first time. The hash is defined as a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.</value>
        [DataMember(Name = "minedInBlockHash", IsRequired = true, EmitDefaultValue = false)]
        public string MinedInBlockHash { get; set; }

        /// <summary>
        /// Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block.
        /// </summary>
        /// <value>Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block.</value>
        [DataMember(Name = "minedInBlockHeight", IsRequired = true, EmitDefaultValue = false)]
        public int MinedInBlockHeight { get; set; }

        /// <summary>
        /// Represents the unique internal transaction ID in regards to the parent transaction (type trace address).
        /// </summary>
        /// <value>Represents the unique internal transaction ID in regards to the parent transaction (type trace address).</value>
        [DataMember(Name = "operationID", IsRequired = true, EmitDefaultValue = false)]
        public string OperationID { get; set; }

        /// <summary>
        /// Defines the call type of the internal transaction.
        /// </summary>
        /// <value>Defines the call type of the internal transaction.</value>
        [DataMember(Name = "operationType", IsRequired = true, EmitDefaultValue = false)]
        public string OperationType { get; set; }

        /// <summary>
        /// Defines the specific hash of the parent transaction.
        /// </summary>
        /// <value>Defines the specific hash of the parent transaction.</value>
        [DataMember(Name = "parentHash", IsRequired = true, EmitDefaultValue = false)]
        public string ParentHash { get; set; }

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
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListInternalTransactionsByAddressAndTimeRangeRI {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  MinedInBlockHash: ").Append(MinedInBlockHash).Append("\n");
            sb.Append("  MinedInBlockHeight: ").Append(MinedInBlockHeight).Append("\n");
            sb.Append("  OperationID: ").Append(OperationID).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  ParentHash: ").Append(ParentHash).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as ListInternalTransactionsByAddressAndTimeRangeRI);
        }

        /// <summary>
        /// Returns true if ListInternalTransactionsByAddressAndTimeRangeRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListInternalTransactionsByAddressAndTimeRangeRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListInternalTransactionsByAddressAndTimeRangeRI input)
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
                    this.MinedInBlockHash == input.MinedInBlockHash ||
                    (this.MinedInBlockHash != null &&
                    this.MinedInBlockHash.Equals(input.MinedInBlockHash))
                ) && 
                (
                    this.MinedInBlockHeight == input.MinedInBlockHeight ||
                    this.MinedInBlockHeight.Equals(input.MinedInBlockHeight)
                ) && 
                (
                    this.OperationID == input.OperationID ||
                    (this.OperationID != null &&
                    this.OperationID.Equals(input.OperationID))
                ) && 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.ParentHash == input.ParentHash ||
                    (this.ParentHash != null &&
                    this.ParentHash.Equals(input.ParentHash))
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
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
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
                if (this.MinedInBlockHash != null)
                {
                    hashCode = (hashCode * 59) + this.MinedInBlockHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinedInBlockHeight.GetHashCode();
                if (this.OperationID != null)
                {
                    hashCode = (hashCode * 59) + this.OperationID.GetHashCode();
                }
                if (this.OperationType != null)
                {
                    hashCode = (hashCode * 59) + this.OperationType.GetHashCode();
                }
                if (this.ParentHash != null)
                {
                    hashCode = (hashCode * 59) + this.ParentHash.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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
