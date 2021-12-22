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
    /// GetLatestMinedXRPRippleBlockRI
    /// </summary>
    [DataContract(Name = "GetLatestMinedXRPRippleBlockRI")]
    public partial class GetLatestMinedXRPRippleBlockRI : IEquatable<GetLatestMinedXRPRippleBlockRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLatestMinedXRPRippleBlockRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetLatestMinedXRPRippleBlockRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLatestMinedXRPRippleBlockRI" /> class.
        /// </summary>
        /// <param name="blockHash">Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. (required).</param>
        /// <param name="blockHeight">Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;. (required).</param>
        /// <param name="previousBlockHash">Represents the hash of the previous block, also known as the parent block. (required).</param>
        /// <param name="timestamp">Defines the exact date/time when this block was mined in Unix Timestamp. (required).</param>
        /// <param name="transactionsCount">Represents the total number of all transactions as part of this block. (required).</param>
        /// <param name="totalCoins">totalCoins (required).</param>
        /// <param name="totalFees">totalFees (required).</param>
        public GetLatestMinedXRPRippleBlockRI(string blockHash = default(string), int blockHeight = default(int), string previousBlockHash = default(string), int timestamp = default(int), int transactionsCount = default(int), GetLatestMinedXRPRippleBlockRITotalCoins totalCoins = default(GetLatestMinedXRPRippleBlockRITotalCoins), GetLatestMinedXRPRippleBlockRITotalFees totalFees = default(GetLatestMinedXRPRippleBlockRITotalFees))
        {
            // to ensure "blockHash" is required (not null)
            if (blockHash == null) {
                throw new ArgumentNullException("blockHash is a required property for GetLatestMinedXRPRippleBlockRI and cannot be null");
            }
            this.BlockHash = blockHash;
            this.BlockHeight = blockHeight;
            // to ensure "previousBlockHash" is required (not null)
            if (previousBlockHash == null) {
                throw new ArgumentNullException("previousBlockHash is a required property for GetLatestMinedXRPRippleBlockRI and cannot be null");
            }
            this.PreviousBlockHash = previousBlockHash;
            this.Timestamp = timestamp;
            this.TransactionsCount = transactionsCount;
            // to ensure "totalCoins" is required (not null)
            if (totalCoins == null) {
                throw new ArgumentNullException("totalCoins is a required property for GetLatestMinedXRPRippleBlockRI and cannot be null");
            }
            this.TotalCoins = totalCoins;
            // to ensure "totalFees" is required (not null)
            if (totalFees == null) {
                throw new ArgumentNullException("totalFees is a required property for GetLatestMinedXRPRippleBlockRI and cannot be null");
            }
            this.TotalFees = totalFees;
        }

        /// <summary>
        /// Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.
        /// </summary>
        /// <value>Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm.</value>
        [DataMember(Name = "blockHash", IsRequired = true, EmitDefaultValue = false)]
        public string BlockHash { get; set; }

        /// <summary>
        /// Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;.
        /// </summary>
        /// <value>Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;.</value>
        [DataMember(Name = "blockHeight", IsRequired = true, EmitDefaultValue = false)]
        public int BlockHeight { get; set; }

        /// <summary>
        /// Represents the hash of the previous block, also known as the parent block.
        /// </summary>
        /// <value>Represents the hash of the previous block, also known as the parent block.</value>
        [DataMember(Name = "previousBlockHash", IsRequired = true, EmitDefaultValue = false)]
        public string PreviousBlockHash { get; set; }

        /// <summary>
        /// Defines the exact date/time when this block was mined in Unix Timestamp.
        /// </summary>
        /// <value>Defines the exact date/time when this block was mined in Unix Timestamp.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Represents the total number of all transactions as part of this block.
        /// </summary>
        /// <value>Represents the total number of all transactions as part of this block.</value>
        [DataMember(Name = "transactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int TransactionsCount { get; set; }

        /// <summary>
        /// Gets or Sets TotalCoins
        /// </summary>
        [DataMember(Name = "totalCoins", IsRequired = true, EmitDefaultValue = false)]
        public GetLatestMinedXRPRippleBlockRITotalCoins TotalCoins { get; set; }

        /// <summary>
        /// Gets or Sets TotalFees
        /// </summary>
        [DataMember(Name = "totalFees", IsRequired = true, EmitDefaultValue = false)]
        public GetLatestMinedXRPRippleBlockRITotalFees TotalFees { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetLatestMinedXRPRippleBlockRI {\n");
            sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
            sb.Append("  BlockHeight: ").Append(BlockHeight).Append("\n");
            sb.Append("  PreviousBlockHash: ").Append(PreviousBlockHash).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransactionsCount: ").Append(TransactionsCount).Append("\n");
            sb.Append("  TotalCoins: ").Append(TotalCoins).Append("\n");
            sb.Append("  TotalFees: ").Append(TotalFees).Append("\n");
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
            return this.Equals(input as GetLatestMinedXRPRippleBlockRI);
        }

        /// <summary>
        /// Returns true if GetLatestMinedXRPRippleBlockRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetLatestMinedXRPRippleBlockRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetLatestMinedXRPRippleBlockRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BlockHash == input.BlockHash ||
                    (this.BlockHash != null &&
                    this.BlockHash.Equals(input.BlockHash))
                ) && 
                (
                    this.BlockHeight == input.BlockHeight ||
                    this.BlockHeight.Equals(input.BlockHeight)
                ) && 
                (
                    this.PreviousBlockHash == input.PreviousBlockHash ||
                    (this.PreviousBlockHash != null &&
                    this.PreviousBlockHash.Equals(input.PreviousBlockHash))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
                ) && 
                (
                    this.TransactionsCount == input.TransactionsCount ||
                    this.TransactionsCount.Equals(input.TransactionsCount)
                ) && 
                (
                    this.TotalCoins == input.TotalCoins ||
                    (this.TotalCoins != null &&
                    this.TotalCoins.Equals(input.TotalCoins))
                ) && 
                (
                    this.TotalFees == input.TotalFees ||
                    (this.TotalFees != null &&
                    this.TotalFees.Equals(input.TotalFees))
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
                if (this.BlockHash != null)
                {
                    hashCode = (hashCode * 59) + this.BlockHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BlockHeight.GetHashCode();
                if (this.PreviousBlockHash != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousBlockHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                hashCode = (hashCode * 59) + this.TransactionsCount.GetHashCode();
                if (this.TotalCoins != null)
                {
                    hashCode = (hashCode * 59) + this.TotalCoins.GetHashCode();
                }
                if (this.TotalFees != null)
                {
                    hashCode = (hashCode * 59) + this.TotalFees.GetHashCode();
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
