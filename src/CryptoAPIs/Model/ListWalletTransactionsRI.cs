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
    /// ListWalletTransactionsRI
    /// </summary>
    [DataContract(Name = "ListWalletTransactionsRI")]
    public partial class ListWalletTransactionsRI : IEquatable<ListWalletTransactionsRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWalletTransactionsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListWalletTransactionsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListWalletTransactionsRI" /> class.
        /// </summary>
        /// <param name="direction">Defines the direction of the transaction, e.g. incoming. (required).</param>
        /// <param name="fee">fee (required).</param>
        /// <param name="fungibleTokens">Represents fungible tokens&#39;es detailed information.</param>
        /// <param name="internalTransactions">internalTransactions.</param>
        /// <param name="nonFungibleTokens">Represents non-fungible tokens&#39;es detailed information..</param>
        /// <param name="recipients">Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. (required).</param>
        /// <param name="senders">Represents a list of sender addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list. (required).</param>
        /// <param name="status">Defines the status of the transaction, if it is confirmed or unconfirmed. (required).</param>
        /// <param name="timestamp">Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. (required).</param>
        /// <param name="transactionId">Represents the unique TD of the transaction. (required).</param>
        /// <param name="value">value (required).</param>
        public ListWalletTransactionsRI(string direction = default(string), ListWalletTransactionsRIFee fee = default(ListWalletTransactionsRIFee), List<ListWalletTransactionsRIFungibleTokens> fungibleTokens = default(List<ListWalletTransactionsRIFungibleTokens>), List<ListWalletTransactionsRIInternalTransactions> internalTransactions = default(List<ListWalletTransactionsRIInternalTransactions>), List<ListWalletTransactionsRINonFungibleTokens> nonFungibleTokens = default(List<ListWalletTransactionsRINonFungibleTokens>), List<ListWalletTransactionsRIRecipients> recipients = default(List<ListWalletTransactionsRIRecipients>), List<ListWalletTransactionsRISenders> senders = default(List<ListWalletTransactionsRISenders>), string status = default(string), int timestamp = default(int), string transactionId = default(string), ListWalletTransactionsRIValue value = default(ListWalletTransactionsRIValue))
        {
            // to ensure "direction" is required (not null)
            if (direction == null) {
                throw new ArgumentNullException("direction is a required property for ListWalletTransactionsRI and cannot be null");
            }
            this.Direction = direction;
            // to ensure "fee" is required (not null)
            if (fee == null) {
                throw new ArgumentNullException("fee is a required property for ListWalletTransactionsRI and cannot be null");
            }
            this.Fee = fee;
            // to ensure "recipients" is required (not null)
            if (recipients == null) {
                throw new ArgumentNullException("recipients is a required property for ListWalletTransactionsRI and cannot be null");
            }
            this.Recipients = recipients;
            // to ensure "senders" is required (not null)
            if (senders == null) {
                throw new ArgumentNullException("senders is a required property for ListWalletTransactionsRI and cannot be null");
            }
            this.Senders = senders;
            // to ensure "status" is required (not null)
            if (status == null) {
                throw new ArgumentNullException("status is a required property for ListWalletTransactionsRI and cannot be null");
            }
            this.Status = status;
            this.Timestamp = timestamp;
            // to ensure "transactionId" is required (not null)
            if (transactionId == null) {
                throw new ArgumentNullException("transactionId is a required property for ListWalletTransactionsRI and cannot be null");
            }
            this.TransactionId = transactionId;
            // to ensure "value" is required (not null)
            if (value == null) {
                throw new ArgumentNullException("value is a required property for ListWalletTransactionsRI and cannot be null");
            }
            this.Value = value;
            this.FungibleTokens = fungibleTokens;
            this.InternalTransactions = internalTransactions;
            this.NonFungibleTokens = nonFungibleTokens;
        }

        /// <summary>
        /// Defines the direction of the transaction, e.g. incoming.
        /// </summary>
        /// <value>Defines the direction of the transaction, e.g. incoming.</value>
        [DataMember(Name = "direction", IsRequired = true, EmitDefaultValue = false)]
        public string Direction { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", IsRequired = true, EmitDefaultValue = false)]
        public ListWalletTransactionsRIFee Fee { get; set; }

        /// <summary>
        /// Represents fungible tokens&#39;es detailed information
        /// </summary>
        /// <value>Represents fungible tokens&#39;es detailed information</value>
        [DataMember(Name = "fungibleTokens", EmitDefaultValue = false)]
        public List<ListWalletTransactionsRIFungibleTokens> FungibleTokens { get; set; }

        /// <summary>
        /// Gets or Sets InternalTransactions
        /// </summary>
        [DataMember(Name = "internalTransactions", EmitDefaultValue = false)]
        public List<ListWalletTransactionsRIInternalTransactions> InternalTransactions { get; set; }

        /// <summary>
        /// Represents non-fungible tokens&#39;es detailed information.
        /// </summary>
        /// <value>Represents non-fungible tokens&#39;es detailed information.</value>
        [DataMember(Name = "nonFungibleTokens", EmitDefaultValue = false)]
        public List<ListWalletTransactionsRINonFungibleTokens> NonFungibleTokens { get; set; }

        /// <summary>
        /// Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.
        /// </summary>
        /// <value>Represents a list of recipient addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public List<ListWalletTransactionsRIRecipients> Recipients { get; set; }

        /// <summary>
        /// Represents a list of sender addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.
        /// </summary>
        /// <value>Represents a list of sender addresses with the respective amounts. In account-based protocols like Ethereum there is only one address in this list.</value>
        [DataMember(Name = "senders", IsRequired = true, EmitDefaultValue = false)]
        public List<ListWalletTransactionsRISenders> Senders { get; set; }

        /// <summary>
        /// Defines the status of the transaction, if it is confirmed or unconfirmed.
        /// </summary>
        /// <value>Defines the status of the transaction, if it is confirmed or unconfirmed.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed.
        /// </summary>
        /// <value>Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Represents the unique TD of the transaction.
        /// </summary>
        /// <value>Represents the unique TD of the transaction.</value>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public ListWalletTransactionsRIValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListWalletTransactionsRI {\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  FungibleTokens: ").Append(FungibleTokens).Append("\n");
            sb.Append("  InternalTransactions: ").Append(InternalTransactions).Append("\n");
            sb.Append("  NonFungibleTokens: ").Append(NonFungibleTokens).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Senders: ").Append(Senders).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ListWalletTransactionsRI);
        }

        /// <summary>
        /// Returns true if ListWalletTransactionsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListWalletTransactionsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListWalletTransactionsRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.FungibleTokens == input.FungibleTokens ||
                    this.FungibleTokens != null &&
                    input.FungibleTokens != null &&
                    this.FungibleTokens.SequenceEqual(input.FungibleTokens)
                ) && 
                (
                    this.InternalTransactions == input.InternalTransactions ||
                    this.InternalTransactions != null &&
                    input.InternalTransactions != null &&
                    this.InternalTransactions.SequenceEqual(input.InternalTransactions)
                ) && 
                (
                    this.NonFungibleTokens == input.NonFungibleTokens ||
                    this.NonFungibleTokens != null &&
                    input.NonFungibleTokens != null &&
                    this.NonFungibleTokens.SequenceEqual(input.NonFungibleTokens)
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Senders == input.Senders ||
                    this.Senders != null &&
                    input.Senders != null &&
                    this.Senders.SequenceEqual(input.Senders)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Direction != null)
                {
                    hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                }
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.FungibleTokens != null)
                {
                    hashCode = (hashCode * 59) + this.FungibleTokens.GetHashCode();
                }
                if (this.InternalTransactions != null)
                {
                    hashCode = (hashCode * 59) + this.InternalTransactions.GetHashCode();
                }
                if (this.NonFungibleTokens != null)
                {
                    hashCode = (hashCode * 59) + this.NonFungibleTokens.GetHashCode();
                }
                if (this.Recipients != null)
                {
                    hashCode = (hashCode * 59) + this.Recipients.GetHashCode();
                }
                if (this.Senders != null)
                {
                    hashCode = (hashCode * 59) + this.Senders.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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