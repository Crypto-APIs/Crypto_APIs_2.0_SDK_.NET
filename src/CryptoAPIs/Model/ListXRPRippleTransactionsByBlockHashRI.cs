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
    /// ListXRPRippleTransactionsByBlockHashRI
    /// </summary>
    [DataContract(Name = "ListXRPRippleTransactionsByBlockHashRI")]
    public partial class ListXRPRippleTransactionsByBlockHashRI : IEquatable<ListXRPRippleTransactionsByBlockHashRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListXRPRippleTransactionsByBlockHashRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListXRPRippleTransactionsByBlockHashRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListXRPRippleTransactionsByBlockHashRI" /> class.
        /// </summary>
        /// <param name="additionalData">Represents any additional data that may be needed..</param>
        /// <param name="destinationTag">destinationTag.</param>
        /// <param name="index">Represents the index position of the transaction in the specific block. (required).</param>
        /// <param name="minedInBlockHeight">Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block. (required).</param>
        /// <param name="recipients">Represents an object of addresses that receive the transactions. (required).</param>
        /// <param name="senders">Represents an object of addresses that provide the funds. (required).</param>
        /// <param name="sequence">Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime. (required).</param>
        /// <param name="status">Defines the status of the transaction. (required).</param>
        /// <param name="timestamp">Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed. (required).</param>
        /// <param name="transactionHash">Represents the same as &#x60;transactionId&#x60; for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols &#x60;hash&#x60; is different from &#x60;transactionId&#x60; for SegWit transactions. (required).</param>
        /// <param name="type">Defines the type of the transaction. (required).</param>
        /// <param name="fee">fee (required).</param>
        /// <param name="offer">offer (required).</param>
        /// <param name="receive">receive (required).</param>
        /// <param name="value">value (required).</param>
        public ListXRPRippleTransactionsByBlockHashRI(string additionalData = default(string), long destinationTag = default(long), int index = default(int), int minedInBlockHeight = default(int), List<ListXRPRippleTransactionsByBlockHashRIRecipientsInner> recipients = default(List<ListXRPRippleTransactionsByBlockHashRIRecipientsInner>), List<ListXRPRippleTransactionsByBlockHashRISendersInner> senders = default(List<ListXRPRippleTransactionsByBlockHashRISendersInner>), long sequence = default(long), string status = default(string), int timestamp = default(int), string transactionHash = default(string), string type = default(string), ListXRPRippleTransactionsByBlockHashRIFee fee = default(ListXRPRippleTransactionsByBlockHashRIFee), ListXRPRippleTransactionsByBlockHashRIOffer offer = default(ListXRPRippleTransactionsByBlockHashRIOffer), ListXRPRippleTransactionsByBlockHashRIReceive receive = default(ListXRPRippleTransactionsByBlockHashRIReceive), ListXRPRippleTransactionsByBlockHashRIValue value = default(ListXRPRippleTransactionsByBlockHashRIValue))
        {
            this.Index = index;
            this.MinedInBlockHeight = minedInBlockHeight;
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new ArgumentNullException("recipients is a required property for ListXRPRippleTransactionsByBlockHashRI and cannot be null");
            }
            this.Recipients = recipients;
            // to ensure "senders" is required (not null)
            if (senders == null)
            {
                throw new ArgumentNullException("senders is a required property for ListXRPRippleTransactionsByBlockHashRI and cannot be null");
            }
            this.Senders = senders;
            this.Sequence = sequence;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for ListXRPRippleTransactionsByBlockHashRI and cannot be null");
            }
            this.Status = status;
            this.Timestamp = timestamp;
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for ListXRPRippleTransactionsByBlockHashRI and cannot be null");
            }
            this.TransactionHash = transactionHash;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ListXRPRippleTransactionsByBlockHashRI and cannot be null");
            }
            this.Type = type;
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new ArgumentNullException("fee is a required property for ListXRPRippleTransactionsByBlockHashRI and cannot be null");
            }
            this.Fee = fee;
            // to ensure "offer" is required (not null)
            if (offer == null)
            {
                throw new ArgumentNullException("offer is a required property for ListXRPRippleTransactionsByBlockHashRI and cannot be null");
            }
            this.Offer = offer;
            // to ensure "receive" is required (not null)
            if (receive == null)
            {
                throw new ArgumentNullException("receive is a required property for ListXRPRippleTransactionsByBlockHashRI and cannot be null");
            }
            this.Receive = receive;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ListXRPRippleTransactionsByBlockHashRI and cannot be null");
            }
            this.Value = value;
            this.AdditionalData = additionalData;
            this.DestinationTag = destinationTag;
        }

        /// <summary>
        /// Represents any additional data that may be needed.
        /// </summary>
        /// <value>Represents any additional data that may be needed.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public string AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets DestinationTag
        /// </summary>
        [DataMember(Name = "destinationTag", EmitDefaultValue = false)]
        public long DestinationTag { get; set; }

        /// <summary>
        /// Represents the index position of the transaction in the specific block.
        /// </summary>
        /// <value>Represents the index position of the transaction in the specific block.</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block.
        /// </summary>
        /// <value>Represents the hight of the block where this transaction was mined/confirmed for first time. The height is defined as the number of blocks in the blockchain preceding this specific block.</value>
        [DataMember(Name = "minedInBlockHeight", IsRequired = true, EmitDefaultValue = false)]
        public int MinedInBlockHeight { get; set; }

        /// <summary>
        /// Represents an object of addresses that receive the transactions.
        /// </summary>
        /// <value>Represents an object of addresses that receive the transactions.</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public List<ListXRPRippleTransactionsByBlockHashRIRecipientsInner> Recipients { get; set; }

        /// <summary>
        /// Represents an object of addresses that provide the funds.
        /// </summary>
        /// <value>Represents an object of addresses that provide the funds.</value>
        [DataMember(Name = "senders", IsRequired = true, EmitDefaultValue = false)]
        public List<ListXRPRippleTransactionsByBlockHashRISendersInner> Senders { get; set; }

        /// <summary>
        /// Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime.
        /// </summary>
        /// <value>Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime.</value>
        [DataMember(Name = "sequence", IsRequired = true, EmitDefaultValue = false)]
        public long Sequence { get; set; }

        /// <summary>
        /// Defines the status of the transaction.
        /// </summary>
        /// <value>Defines the status of the transaction.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed.
        /// </summary>
        /// <value>Defines the exact date/time in Unix Timestamp when this transaction was mined, confirmed or first seen in Mempool, if it is unconfirmed.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Represents the same as &#x60;transactionId&#x60; for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols &#x60;hash&#x60; is different from &#x60;transactionId&#x60; for SegWit transactions.
        /// </summary>
        /// <value>Represents the same as &#x60;transactionId&#x60; for account-based protocols like Ethereum, while it could be different in UTXO-based protocols like Bitcoin. E.g., in UTXO-based protocols &#x60;hash&#x60; is different from &#x60;transactionId&#x60; for SegWit transactions.</value>
        [DataMember(Name = "transactionHash", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// Defines the type of the transaction.
        /// </summary>
        /// <value>Defines the type of the transaction.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", IsRequired = true, EmitDefaultValue = false)]
        public ListXRPRippleTransactionsByBlockHashRIFee Fee { get; set; }

        /// <summary>
        /// Gets or Sets Offer
        /// </summary>
        [DataMember(Name = "offer", IsRequired = true, EmitDefaultValue = false)]
        public ListXRPRippleTransactionsByBlockHashRIOffer Offer { get; set; }

        /// <summary>
        /// Gets or Sets Receive
        /// </summary>
        [DataMember(Name = "receive", IsRequired = true, EmitDefaultValue = false)]
        public ListXRPRippleTransactionsByBlockHashRIReceive Receive { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public ListXRPRippleTransactionsByBlockHashRIValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListXRPRippleTransactionsByBlockHashRI {\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  DestinationTag: ").Append(DestinationTag).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  MinedInBlockHeight: ").Append(MinedInBlockHeight).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Senders: ").Append(Senders).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Offer: ").Append(Offer).Append("\n");
            sb.Append("  Receive: ").Append(Receive).Append("\n");
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
            return this.Equals(input as ListXRPRippleTransactionsByBlockHashRI);
        }

        /// <summary>
        /// Returns true if ListXRPRippleTransactionsByBlockHashRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListXRPRippleTransactionsByBlockHashRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListXRPRippleTransactionsByBlockHashRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalData == input.AdditionalData ||
                    (this.AdditionalData != null &&
                    this.AdditionalData.Equals(input.AdditionalData))
                ) && 
                (
                    this.DestinationTag == input.DestinationTag ||
                    this.DestinationTag.Equals(input.DestinationTag)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.MinedInBlockHeight == input.MinedInBlockHeight ||
                    this.MinedInBlockHeight.Equals(input.MinedInBlockHeight)
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
                    this.Sequence == input.Sequence ||
                    this.Sequence.Equals(input.Sequence)
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
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.Offer == input.Offer ||
                    (this.Offer != null &&
                    this.Offer.Equals(input.Offer))
                ) && 
                (
                    this.Receive == input.Receive ||
                    (this.Receive != null &&
                    this.Receive.Equals(input.Receive))
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
                if (this.AdditionalData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DestinationTag.GetHashCode();
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.MinedInBlockHeight.GetHashCode();
                if (this.Recipients != null)
                {
                    hashCode = (hashCode * 59) + this.Recipients.GetHashCode();
                }
                if (this.Senders != null)
                {
                    hashCode = (hashCode * 59) + this.Senders.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Sequence.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.Offer != null)
                {
                    hashCode = (hashCode * 59) + this.Offer.GetHashCode();
                }
                if (this.Receive != null)
                {
                    hashCode = (hashCode * 59) + this.Receive.GetHashCode();
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
