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
    [DataContract(Name = "GetBlockDetailsByBlockHeightFromCallbackRIBSE")]
    public partial class GetBlockDetailsByBlockHeightFromCallbackRIBSE : IEquatable<GetBlockDetailsByBlockHeightFromCallbackRIBSE>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHeightFromCallbackRIBSE" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetBlockDetailsByBlockHeightFromCallbackRIBSE() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHeightFromCallbackRIBSE" /> class.
        /// </summary>
        /// <param name="difficulty">Represents a mathematical value of how hard it is to find a valid hash for this block. (required).</param>
        /// <param name="extraData">Represents any data that can be included by the miner in the block. (required).</param>
        /// <param name="gasLimit">Defines the total gas limit of all transactions in the block. (required).</param>
        /// <param name="gasUsed">Represents the total amount of gas used by all transactions in this block. (required).</param>
        /// <param name="minedInSeconds">Specifies the amount of time required for the block to be mined in seconds. (required).</param>
        /// <param name="nonce">Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address. (required).</param>
        /// <param name="sha3Uncles">Defines the combined hash of all uncles for a given parent. (required).</param>
        /// <param name="size">Represents the total size of the block in Bytes. (required).</param>
        /// <param name="totalDifficulty">Defines the total difficulty of the chain until this block, i.e. how difficult it is for a specific miner to mine a new block. (required).</param>
        /// <param name="uncles">uncles.</param>
        public GetBlockDetailsByBlockHeightFromCallbackRIBSE(string difficulty = default(string), string extraData = default(string), string gasLimit = default(string), string gasUsed = default(string), int minedInSeconds = default(int), string nonce = default(string), string sha3Uncles = default(string), int size = default(int), string totalDifficulty = default(string), List<string> uncles = default(List<string>))
        {
            // to ensure "difficulty" is required (not null)
            if (difficulty == null) {
                throw new ArgumentNullException("difficulty is a required property for GetBlockDetailsByBlockHeightFromCallbackRIBSE and cannot be null");
            }
            this.Difficulty = difficulty;
            // to ensure "extraData" is required (not null)
            if (extraData == null) {
                throw new ArgumentNullException("extraData is a required property for GetBlockDetailsByBlockHeightFromCallbackRIBSE and cannot be null");
            }
            this.ExtraData = extraData;
            // to ensure "gasLimit" is required (not null)
            if (gasLimit == null) {
                throw new ArgumentNullException("gasLimit is a required property for GetBlockDetailsByBlockHeightFromCallbackRIBSE and cannot be null");
            }
            this.GasLimit = gasLimit;
            // to ensure "gasUsed" is required (not null)
            if (gasUsed == null) {
                throw new ArgumentNullException("gasUsed is a required property for GetBlockDetailsByBlockHeightFromCallbackRIBSE and cannot be null");
            }
            this.GasUsed = gasUsed;
            this.MinedInSeconds = minedInSeconds;
            // to ensure "nonce" is required (not null)
            if (nonce == null) {
                throw new ArgumentNullException("nonce is a required property for GetBlockDetailsByBlockHeightFromCallbackRIBSE and cannot be null");
            }
            this.Nonce = nonce;
            // to ensure "sha3Uncles" is required (not null)
            if (sha3Uncles == null) {
                throw new ArgumentNullException("sha3Uncles is a required property for GetBlockDetailsByBlockHeightFromCallbackRIBSE and cannot be null");
            }
            this.Sha3Uncles = sha3Uncles;
            this.Size = size;
            // to ensure "totalDifficulty" is required (not null)
            if (totalDifficulty == null) {
                throw new ArgumentNullException("totalDifficulty is a required property for GetBlockDetailsByBlockHeightFromCallbackRIBSE and cannot be null");
            }
            this.TotalDifficulty = totalDifficulty;
            this.Uncles = uncles;
        }

        /// <summary>
        /// Represents a mathematical value of how hard it is to find a valid hash for this block.
        /// </summary>
        /// <value>Represents a mathematical value of how hard it is to find a valid hash for this block.</value>
        [DataMember(Name = "difficulty", IsRequired = true, EmitDefaultValue = false)]
        public string Difficulty { get; set; }

        /// <summary>
        /// Represents any data that can be included by the miner in the block.
        /// </summary>
        /// <value>Represents any data that can be included by the miner in the block.</value>
        [DataMember(Name = "extraData", IsRequired = true, EmitDefaultValue = false)]
        public string ExtraData { get; set; }

        /// <summary>
        /// Defines the total gas limit of all transactions in the block.
        /// </summary>
        /// <value>Defines the total gas limit of all transactions in the block.</value>
        [DataMember(Name = "gasLimit", IsRequired = true, EmitDefaultValue = false)]
        public string GasLimit { get; set; }

        /// <summary>
        /// Represents the total amount of gas used by all transactions in this block.
        /// </summary>
        /// <value>Represents the total amount of gas used by all transactions in this block.</value>
        [DataMember(Name = "gasUsed", IsRequired = true, EmitDefaultValue = false)]
        public string GasUsed { get; set; }

        /// <summary>
        /// Specifies the amount of time required for the block to be mined in seconds.
        /// </summary>
        /// <value>Specifies the amount of time required for the block to be mined in seconds.</value>
        [DataMember(Name = "minedInSeconds", IsRequired = true, EmitDefaultValue = false)]
        public int MinedInSeconds { get; set; }

        /// <summary>
        /// Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address.
        /// </summary>
        /// <value>Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address.</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = false)]
        public string Nonce { get; set; }

        /// <summary>
        /// Defines the combined hash of all uncles for a given parent.
        /// </summary>
        /// <value>Defines the combined hash of all uncles for a given parent.</value>
        [DataMember(Name = "sha3Uncles", IsRequired = true, EmitDefaultValue = false)]
        public string Sha3Uncles { get; set; }

        /// <summary>
        /// Represents the total size of the block in Bytes.
        /// </summary>
        /// <value>Represents the total size of the block in Bytes.</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Defines the total difficulty of the chain until this block, i.e. how difficult it is for a specific miner to mine a new block.
        /// </summary>
        /// <value>Defines the total difficulty of the chain until this block, i.e. how difficult it is for a specific miner to mine a new block.</value>
        [DataMember(Name = "totalDifficulty", IsRequired = true, EmitDefaultValue = false)]
        public string TotalDifficulty { get; set; }

        /// <summary>
        /// Gets or Sets Uncles
        /// </summary>
        [DataMember(Name = "uncles", EmitDefaultValue = false)]
        public List<string> Uncles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetBlockDetailsByBlockHeightFromCallbackRIBSE {\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
            sb.Append("  MinedInSeconds: ").Append(MinedInSeconds).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Sha3Uncles: ").Append(Sha3Uncles).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  TotalDifficulty: ").Append(TotalDifficulty).Append("\n");
            sb.Append("  Uncles: ").Append(Uncles).Append("\n");
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
            return this.Equals(input as GetBlockDetailsByBlockHeightFromCallbackRIBSE);
        }

        /// <summary>
        /// Returns true if GetBlockDetailsByBlockHeightFromCallbackRIBSE instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBlockDetailsByBlockHeightFromCallbackRIBSE to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBlockDetailsByBlockHeightFromCallbackRIBSE input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Difficulty == input.Difficulty ||
                    (this.Difficulty != null &&
                    this.Difficulty.Equals(input.Difficulty))
                ) && 
                (
                    this.ExtraData == input.ExtraData ||
                    (this.ExtraData != null &&
                    this.ExtraData.Equals(input.ExtraData))
                ) && 
                (
                    this.GasLimit == input.GasLimit ||
                    (this.GasLimit != null &&
                    this.GasLimit.Equals(input.GasLimit))
                ) && 
                (
                    this.GasUsed == input.GasUsed ||
                    (this.GasUsed != null &&
                    this.GasUsed.Equals(input.GasUsed))
                ) && 
                (
                    this.MinedInSeconds == input.MinedInSeconds ||
                    this.MinedInSeconds.Equals(input.MinedInSeconds)
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Sha3Uncles == input.Sha3Uncles ||
                    (this.Sha3Uncles != null &&
                    this.Sha3Uncles.Equals(input.Sha3Uncles))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.TotalDifficulty == input.TotalDifficulty ||
                    (this.TotalDifficulty != null &&
                    this.TotalDifficulty.Equals(input.TotalDifficulty))
                ) && 
                (
                    this.Uncles == input.Uncles ||
                    this.Uncles != null &&
                    input.Uncles != null &&
                    this.Uncles.SequenceEqual(input.Uncles)
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
                if (this.Difficulty != null)
                {
                    hashCode = (hashCode * 59) + this.Difficulty.GetHashCode();
                }
                if (this.ExtraData != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraData.GetHashCode();
                }
                if (this.GasLimit != null)
                {
                    hashCode = (hashCode * 59) + this.GasLimit.GetHashCode();
                }
                if (this.GasUsed != null)
                {
                    hashCode = (hashCode * 59) + this.GasUsed.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinedInSeconds.GetHashCode();
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                if (this.Sha3Uncles != null)
                {
                    hashCode = (hashCode * 59) + this.Sha3Uncles.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                if (this.TotalDifficulty != null)
                {
                    hashCode = (hashCode * 59) + this.TotalDifficulty.GetHashCode();
                }
                if (this.Uncles != null)
                {
                    hashCode = (hashCode * 59) + this.Uncles.GetHashCode();
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
