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
    /// GetLatestMinedZilliqaBlockRI
    /// </summary>
    [DataContract(Name = "GetLatestMinedZilliqaBlockRI")]
    public partial class GetLatestMinedZilliqaBlockRI : IEquatable<GetLatestMinedZilliqaBlockRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLatestMinedZilliqaBlockRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetLatestMinedZilliqaBlockRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLatestMinedZilliqaBlockRI" /> class.
        /// </summary>
        /// <param name="blockHash">Represents the hash of the block, which is its unique identifier. It represents a cryptographic digital fingerprint made by hashing the block header twice through the SHA256 algorithm. (required).</param>
        /// <param name="blockHeight">Represents the number of blocks in the blockchain preceding this specific block. Block numbers have no gaps. A blockchain usually starts with block 0 called the \&quot;Genesis block\&quot;. (required).</param>
        /// <param name="difficulty">Defines how difficult it is for a specific miner to mine the block. (required).</param>
        /// <param name="dsBlock">Represents the Directory Service block which contains metadata about the miners who participate in the consensus protocol. (required).</param>
        /// <param name="dsDifficulty">Defines how difficult it is to mine the dsBlocks. (required).</param>
        /// <param name="dsLeader">Represents a part of the DS Committee which leads the consensus protocol for the epoch. (required).</param>
        /// <param name="gasLimit">Represents the maximum amount of gas allowed in the block in order to determine how many transactions it can fit. (required).</param>
        /// <param name="gasUsed">Defines how much of the gas for the block has been used. (required).</param>
        /// <param name="microBlocks">microBlocks (required).</param>
        /// <param name="previousBlockHash">Represents the hash of the previous block, also known as the parent block. (required).</param>
        /// <param name="timestamp">Defines the exact date/time when this block was mined in Unix Timestamp. (required).</param>
        /// <param name="transactionsCount">Represents the total number of all transactions as part of this block. (required).</param>
        public GetLatestMinedZilliqaBlockRI(string blockHash = default(string), int blockHeight = default(int), string difficulty = default(string), int dsBlock = default(int), string dsDifficulty = default(string), string dsLeader = default(string), int gasLimit = default(int), int gasUsed = default(int), List<string> microBlocks = default(List<string>), string previousBlockHash = default(string), int timestamp = default(int), int transactionsCount = default(int))
        {
            // to ensure "blockHash" is required (not null)
            if (blockHash == null) {
                throw new ArgumentNullException("blockHash is a required property for GetLatestMinedZilliqaBlockRI and cannot be null");
            }
            this.BlockHash = blockHash;
            this.BlockHeight = blockHeight;
            // to ensure "difficulty" is required (not null)
            if (difficulty == null) {
                throw new ArgumentNullException("difficulty is a required property for GetLatestMinedZilliqaBlockRI and cannot be null");
            }
            this.Difficulty = difficulty;
            this.DsBlock = dsBlock;
            // to ensure "dsDifficulty" is required (not null)
            if (dsDifficulty == null) {
                throw new ArgumentNullException("dsDifficulty is a required property for GetLatestMinedZilliqaBlockRI and cannot be null");
            }
            this.DsDifficulty = dsDifficulty;
            // to ensure "dsLeader" is required (not null)
            if (dsLeader == null) {
                throw new ArgumentNullException("dsLeader is a required property for GetLatestMinedZilliqaBlockRI and cannot be null");
            }
            this.DsLeader = dsLeader;
            this.GasLimit = gasLimit;
            this.GasUsed = gasUsed;
            // to ensure "microBlocks" is required (not null)
            if (microBlocks == null) {
                throw new ArgumentNullException("microBlocks is a required property for GetLatestMinedZilliqaBlockRI and cannot be null");
            }
            this.MicroBlocks = microBlocks;
            // to ensure "previousBlockHash" is required (not null)
            if (previousBlockHash == null) {
                throw new ArgumentNullException("previousBlockHash is a required property for GetLatestMinedZilliqaBlockRI and cannot be null");
            }
            this.PreviousBlockHash = previousBlockHash;
            this.Timestamp = timestamp;
            this.TransactionsCount = transactionsCount;
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
        /// Defines how difficult it is for a specific miner to mine the block.
        /// </summary>
        /// <value>Defines how difficult it is for a specific miner to mine the block.</value>
        [DataMember(Name = "difficulty", IsRequired = true, EmitDefaultValue = false)]
        public string Difficulty { get; set; }

        /// <summary>
        /// Represents the Directory Service block which contains metadata about the miners who participate in the consensus protocol.
        /// </summary>
        /// <value>Represents the Directory Service block which contains metadata about the miners who participate in the consensus protocol.</value>
        [DataMember(Name = "dsBlock", IsRequired = true, EmitDefaultValue = false)]
        public int DsBlock { get; set; }

        /// <summary>
        /// Defines how difficult it is to mine the dsBlocks.
        /// </summary>
        /// <value>Defines how difficult it is to mine the dsBlocks.</value>
        [DataMember(Name = "dsDifficulty", IsRequired = true, EmitDefaultValue = false)]
        public string DsDifficulty { get; set; }

        /// <summary>
        /// Represents a part of the DS Committee which leads the consensus protocol for the epoch.
        /// </summary>
        /// <value>Represents a part of the DS Committee which leads the consensus protocol for the epoch.</value>
        [DataMember(Name = "dsLeader", IsRequired = true, EmitDefaultValue = false)]
        public string DsLeader { get; set; }

        /// <summary>
        /// Represents the maximum amount of gas allowed in the block in order to determine how many transactions it can fit.
        /// </summary>
        /// <value>Represents the maximum amount of gas allowed in the block in order to determine how many transactions it can fit.</value>
        [DataMember(Name = "gasLimit", IsRequired = true, EmitDefaultValue = false)]
        public int GasLimit { get; set; }

        /// <summary>
        /// Defines how much of the gas for the block has been used.
        /// </summary>
        /// <value>Defines how much of the gas for the block has been used.</value>
        [DataMember(Name = "gasUsed", IsRequired = true, EmitDefaultValue = false)]
        public int GasUsed { get; set; }

        /// <summary>
        /// Gets or Sets MicroBlocks
        /// </summary>
        [DataMember(Name = "microBlocks", IsRequired = true, EmitDefaultValue = false)]
        public List<string> MicroBlocks { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetLatestMinedZilliqaBlockRI {\n");
            sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
            sb.Append("  BlockHeight: ").Append(BlockHeight).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  DsBlock: ").Append(DsBlock).Append("\n");
            sb.Append("  DsDifficulty: ").Append(DsDifficulty).Append("\n");
            sb.Append("  DsLeader: ").Append(DsLeader).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
            sb.Append("  MicroBlocks: ").Append(MicroBlocks).Append("\n");
            sb.Append("  PreviousBlockHash: ").Append(PreviousBlockHash).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TransactionsCount: ").Append(TransactionsCount).Append("\n");
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
            return this.Equals(input as GetLatestMinedZilliqaBlockRI);
        }

        /// <summary>
        /// Returns true if GetLatestMinedZilliqaBlockRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetLatestMinedZilliqaBlockRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetLatestMinedZilliqaBlockRI input)
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
                    this.Difficulty == input.Difficulty ||
                    (this.Difficulty != null &&
                    this.Difficulty.Equals(input.Difficulty))
                ) && 
                (
                    this.DsBlock == input.DsBlock ||
                    this.DsBlock.Equals(input.DsBlock)
                ) && 
                (
                    this.DsDifficulty == input.DsDifficulty ||
                    (this.DsDifficulty != null &&
                    this.DsDifficulty.Equals(input.DsDifficulty))
                ) && 
                (
                    this.DsLeader == input.DsLeader ||
                    (this.DsLeader != null &&
                    this.DsLeader.Equals(input.DsLeader))
                ) && 
                (
                    this.GasLimit == input.GasLimit ||
                    this.GasLimit.Equals(input.GasLimit)
                ) && 
                (
                    this.GasUsed == input.GasUsed ||
                    this.GasUsed.Equals(input.GasUsed)
                ) && 
                (
                    this.MicroBlocks == input.MicroBlocks ||
                    this.MicroBlocks != null &&
                    input.MicroBlocks != null &&
                    this.MicroBlocks.SequenceEqual(input.MicroBlocks)
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
                if (this.Difficulty != null)
                {
                    hashCode = (hashCode * 59) + this.Difficulty.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DsBlock.GetHashCode();
                if (this.DsDifficulty != null)
                {
                    hashCode = (hashCode * 59) + this.DsDifficulty.GetHashCode();
                }
                if (this.DsLeader != null)
                {
                    hashCode = (hashCode * 59) + this.DsLeader.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GasLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.GasUsed.GetHashCode();
                if (this.MicroBlocks != null)
                {
                    hashCode = (hashCode * 59) + this.MicroBlocks.GetHashCode();
                }
                if (this.PreviousBlockHash != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousBlockHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                hashCode = (hashCode * 59) + this.TransactionsCount.GetHashCode();
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
