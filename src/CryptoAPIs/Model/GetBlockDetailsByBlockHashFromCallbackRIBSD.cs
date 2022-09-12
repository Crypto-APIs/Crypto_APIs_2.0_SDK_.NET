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
    /// Dash
    /// </summary>
    [DataContract(Name = "GetBlockDetailsByBlockHashFromCallbackRIBSD")]
    public partial class GetBlockDetailsByBlockHashFromCallbackRIBSD : IEquatable<GetBlockDetailsByBlockHashFromCallbackRIBSD>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSD" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetBlockDetailsByBlockHashFromCallbackRIBSD() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashFromCallbackRIBSD" /> class.
        /// </summary>
        /// <param name="bits">Represents a specific sub-unit of Dash. Bits have two-decimal precision. (required).</param>
        /// <param name="chainwork">Represents a hexadecimal number of all the hashes necessary to produce the current chain. E.g., when converting 0000000000000000000000000000000000000000000086859f7a841475b236fd to a decimal you get 635262017308958427068157 hashes, or 635262 exahashes. (required).</param>
        /// <param name="difficulty">Represents a mathematical value of how hard it is to find a valid hash for this block. (required).</param>
        /// <param name="merkleRoot">Defines the single and final (root) node of a Merkle tree. It is the combined hash of all transactions&#39; hashes that are part of a blockchain block. (required).</param>
        /// <param name="nonce">Represents a random value that can be adjusted to satisfy the proof of work (required).</param>
        /// <param name="size">Represents the total size of the block in Bytes. (required).</param>
        /// <param name="version">Represents the version of the specific block on the blockchain. (required).</param>
        /// <param name="versionHex">Is the hexadecimal string representation of the block&#39;s version. (required).</param>
        public GetBlockDetailsByBlockHashFromCallbackRIBSD(string bits = default(string), string chainwork = default(string), string difficulty = default(string), string merkleRoot = default(string), long nonce = default(long), int size = default(int), int version = default(int), string versionHex = default(string))
        {
            // to ensure "bits" is required (not null)
            if (bits == null)
            {
                throw new ArgumentNullException("bits is a required property for GetBlockDetailsByBlockHashFromCallbackRIBSD and cannot be null");
            }
            this.Bits = bits;
            // to ensure "chainwork" is required (not null)
            if (chainwork == null)
            {
                throw new ArgumentNullException("chainwork is a required property for GetBlockDetailsByBlockHashFromCallbackRIBSD and cannot be null");
            }
            this.Chainwork = chainwork;
            // to ensure "difficulty" is required (not null)
            if (difficulty == null)
            {
                throw new ArgumentNullException("difficulty is a required property for GetBlockDetailsByBlockHashFromCallbackRIBSD and cannot be null");
            }
            this.Difficulty = difficulty;
            // to ensure "merkleRoot" is required (not null)
            if (merkleRoot == null)
            {
                throw new ArgumentNullException("merkleRoot is a required property for GetBlockDetailsByBlockHashFromCallbackRIBSD and cannot be null");
            }
            this.MerkleRoot = merkleRoot;
            this.Nonce = nonce;
            this.Size = size;
            this._Version = version;
            // to ensure "versionHex" is required (not null)
            if (versionHex == null)
            {
                throw new ArgumentNullException("versionHex is a required property for GetBlockDetailsByBlockHashFromCallbackRIBSD and cannot be null");
            }
            this.VersionHex = versionHex;
        }

        /// <summary>
        /// Represents a specific sub-unit of Dash. Bits have two-decimal precision.
        /// </summary>
        /// <value>Represents a specific sub-unit of Dash. Bits have two-decimal precision.</value>
        [DataMember(Name = "bits", IsRequired = true, EmitDefaultValue = false)]
        public string Bits { get; set; }

        /// <summary>
        /// Represents a hexadecimal number of all the hashes necessary to produce the current chain. E.g., when converting 0000000000000000000000000000000000000000000086859f7a841475b236fd to a decimal you get 635262017308958427068157 hashes, or 635262 exahashes.
        /// </summary>
        /// <value>Represents a hexadecimal number of all the hashes necessary to produce the current chain. E.g., when converting 0000000000000000000000000000000000000000000086859f7a841475b236fd to a decimal you get 635262017308958427068157 hashes, or 635262 exahashes.</value>
        [DataMember(Name = "chainwork", IsRequired = true, EmitDefaultValue = false)]
        public string Chainwork { get; set; }

        /// <summary>
        /// Represents a mathematical value of how hard it is to find a valid hash for this block.
        /// </summary>
        /// <value>Represents a mathematical value of how hard it is to find a valid hash for this block.</value>
        [DataMember(Name = "difficulty", IsRequired = true, EmitDefaultValue = false)]
        public string Difficulty { get; set; }

        /// <summary>
        /// Defines the single and final (root) node of a Merkle tree. It is the combined hash of all transactions&#39; hashes that are part of a blockchain block.
        /// </summary>
        /// <value>Defines the single and final (root) node of a Merkle tree. It is the combined hash of all transactions&#39; hashes that are part of a blockchain block.</value>
        [DataMember(Name = "merkleRoot", IsRequired = true, EmitDefaultValue = false)]
        public string MerkleRoot { get; set; }

        /// <summary>
        /// Represents a random value that can be adjusted to satisfy the proof of work
        /// </summary>
        /// <value>Represents a random value that can be adjusted to satisfy the proof of work</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = false)]
        public long Nonce { get; set; }

        /// <summary>
        /// Represents the total size of the block in Bytes.
        /// </summary>
        /// <value>Represents the total size of the block in Bytes.</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Represents the version of the specific block on the blockchain.
        /// </summary>
        /// <value>Represents the version of the specific block on the blockchain.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Is the hexadecimal string representation of the block&#39;s version.
        /// </summary>
        /// <value>Is the hexadecimal string representation of the block&#39;s version.</value>
        [DataMember(Name = "versionHex", IsRequired = true, EmitDefaultValue = false)]
        public string VersionHex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetBlockDetailsByBlockHashFromCallbackRIBSD {\n");
            sb.Append("  Bits: ").Append(Bits).Append("\n");
            sb.Append("  Chainwork: ").Append(Chainwork).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  MerkleRoot: ").Append(MerkleRoot).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  VersionHex: ").Append(VersionHex).Append("\n");
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
            return this.Equals(input as GetBlockDetailsByBlockHashFromCallbackRIBSD);
        }

        /// <summary>
        /// Returns true if GetBlockDetailsByBlockHashFromCallbackRIBSD instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBlockDetailsByBlockHashFromCallbackRIBSD to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBlockDetailsByBlockHashFromCallbackRIBSD input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bits == input.Bits ||
                    (this.Bits != null &&
                    this.Bits.Equals(input.Bits))
                ) && 
                (
                    this.Chainwork == input.Chainwork ||
                    (this.Chainwork != null &&
                    this.Chainwork.Equals(input.Chainwork))
                ) && 
                (
                    this.Difficulty == input.Difficulty ||
                    (this.Difficulty != null &&
                    this.Difficulty.Equals(input.Difficulty))
                ) && 
                (
                    this.MerkleRoot == input.MerkleRoot ||
                    (this.MerkleRoot != null &&
                    this.MerkleRoot.Equals(input.MerkleRoot))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.VersionHex == input.VersionHex ||
                    (this.VersionHex != null &&
                    this.VersionHex.Equals(input.VersionHex))
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
                if (this.Bits != null)
                {
                    hashCode = (hashCode * 59) + this.Bits.GetHashCode();
                }
                if (this.Chainwork != null)
                {
                    hashCode = (hashCode * 59) + this.Chainwork.GetHashCode();
                }
                if (this.Difficulty != null)
                {
                    hashCode = (hashCode * 59) + this.Difficulty.GetHashCode();
                }
                if (this.MerkleRoot != null)
                {
                    hashCode = (hashCode * 59) + this.MerkleRoot.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                if (this.VersionHex != null)
                {
                    hashCode = (hashCode * 59) + this.VersionHex.GetHashCode();
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
