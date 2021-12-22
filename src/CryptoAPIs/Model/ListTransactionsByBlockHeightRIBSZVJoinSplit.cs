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
    /// ListTransactionsByBlockHeightRIBSZVJoinSplit
    /// </summary>
    [DataContract(Name = "ListTransactionsByBlockHeightRIBSZ_vJoinSplit")]
    public partial class ListTransactionsByBlockHeightRIBSZVJoinSplit : IEquatable<ListTransactionsByBlockHeightRIBSZVJoinSplit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBSZVJoinSplit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListTransactionsByBlockHeightRIBSZVJoinSplit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHeightRIBSZVJoinSplit" /> class.
        /// </summary>
        /// <param name="anchor">Defines a Merkle tree root of a note commitment tree which uniquely identifies a note commitment tree state given the assumed security properties of the Merkle tree’s  hash function. (required).</param>
        /// <param name="cipherTexts">cipherTexts (required).</param>
        /// <param name="commitments">commitments (required).</param>
        /// <param name="macs">macs (required).</param>
        /// <param name="nullifiers">nullifiers (required).</param>
        /// <param name="oneTimePubKey">Defines the one time public key. (required).</param>
        /// <param name="proof">Defines the proof. (required).</param>
        /// <param name="randomSeed">Represents a 256-bit seed that must be chosen independently at random for each JoinSplit description. (required).</param>
        /// <param name="vPubNew">Defines the value that the joinSplit transfer will insert into the transparent transaction value pool. (required).</param>
        /// <param name="vPubOld">Defines the value that the joinSplit transfer will remove from the transparent transaction value pool. (required).</param>
        public ListTransactionsByBlockHeightRIBSZVJoinSplit(string anchor = default(string), List<string> cipherTexts = default(List<string>), List<string> commitments = default(List<string>), List<string> macs = default(List<string>), List<string> nullifiers = default(List<string>), string oneTimePubKey = default(string), string proof = default(string), string randomSeed = default(string), string vPubNew = default(string), string vPubOld = default(string))
        {
            // to ensure "anchor" is required (not null)
            if (anchor == null) {
                throw new ArgumentNullException("anchor is a required property for ListTransactionsByBlockHeightRIBSZVJoinSplit and cannot be null");
            }
            this.Anchor = anchor;
            // to ensure "cipherTexts" is required (not null)
            if (cipherTexts == null) {
                throw new ArgumentNullException("cipherTexts is a required property for ListTransactionsByBlockHeightRIBSZVJoinSplit and cannot be null");
            }
            this.CipherTexts = cipherTexts;
            // to ensure "commitments" is required (not null)
            if (commitments == null) {
                throw new ArgumentNullException("commitments is a required property for ListTransactionsByBlockHeightRIBSZVJoinSplit and cannot be null");
            }
            this.Commitments = commitments;
            // to ensure "macs" is required (not null)
            if (macs == null) {
                throw new ArgumentNullException("macs is a required property for ListTransactionsByBlockHeightRIBSZVJoinSplit and cannot be null");
            }
            this.Macs = macs;
            // to ensure "nullifiers" is required (not null)
            if (nullifiers == null) {
                throw new ArgumentNullException("nullifiers is a required property for ListTransactionsByBlockHeightRIBSZVJoinSplit and cannot be null");
            }
            this.Nullifiers = nullifiers;
            // to ensure "oneTimePubKey" is required (not null)
            if (oneTimePubKey == null) {
                throw new ArgumentNullException("oneTimePubKey is a required property for ListTransactionsByBlockHeightRIBSZVJoinSplit and cannot be null");
            }
            this.OneTimePubKey = oneTimePubKey;
            // to ensure "proof" is required (not null)
            if (proof == null) {
                throw new ArgumentNullException("proof is a required property for ListTransactionsByBlockHeightRIBSZVJoinSplit and cannot be null");
            }
            this.Proof = proof;
            // to ensure "randomSeed" is required (not null)
            if (randomSeed == null) {
                throw new ArgumentNullException("randomSeed is a required property for ListTransactionsByBlockHeightRIBSZVJoinSplit and cannot be null");
            }
            this.RandomSeed = randomSeed;
            // to ensure "vPubNew" is required (not null)
            if (vPubNew == null) {
                throw new ArgumentNullException("vPubNew is a required property for ListTransactionsByBlockHeightRIBSZVJoinSplit and cannot be null");
            }
            this.VPubNew = vPubNew;
            // to ensure "vPubOld" is required (not null)
            if (vPubOld == null) {
                throw new ArgumentNullException("vPubOld is a required property for ListTransactionsByBlockHeightRIBSZVJoinSplit and cannot be null");
            }
            this.VPubOld = vPubOld;
        }

        /// <summary>
        /// Defines a Merkle tree root of a note commitment tree which uniquely identifies a note commitment tree state given the assumed security properties of the Merkle tree’s  hash function.
        /// </summary>
        /// <value>Defines a Merkle tree root of a note commitment tree which uniquely identifies a note commitment tree state given the assumed security properties of the Merkle tree’s  hash function.</value>
        [DataMember(Name = "anchor", IsRequired = true, EmitDefaultValue = false)]
        public string Anchor { get; set; }

        /// <summary>
        /// Gets or Sets CipherTexts
        /// </summary>
        [DataMember(Name = "cipherTexts", IsRequired = true, EmitDefaultValue = false)]
        public List<string> CipherTexts { get; set; }

        /// <summary>
        /// Gets or Sets Commitments
        /// </summary>
        [DataMember(Name = "commitments", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Commitments { get; set; }

        /// <summary>
        /// Gets or Sets Macs
        /// </summary>
        [DataMember(Name = "macs", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Macs { get; set; }

        /// <summary>
        /// Gets or Sets Nullifiers
        /// </summary>
        [DataMember(Name = "nullifiers", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Nullifiers { get; set; }

        /// <summary>
        /// Defines the one time public key.
        /// </summary>
        /// <value>Defines the one time public key.</value>
        [DataMember(Name = "oneTimePubKey", IsRequired = true, EmitDefaultValue = false)]
        public string OneTimePubKey { get; set; }

        /// <summary>
        /// Defines the proof.
        /// </summary>
        /// <value>Defines the proof.</value>
        [DataMember(Name = "proof", IsRequired = true, EmitDefaultValue = false)]
        public string Proof { get; set; }

        /// <summary>
        /// Represents a 256-bit seed that must be chosen independently at random for each JoinSplit description.
        /// </summary>
        /// <value>Represents a 256-bit seed that must be chosen independently at random for each JoinSplit description.</value>
        [DataMember(Name = "randomSeed", IsRequired = true, EmitDefaultValue = false)]
        public string RandomSeed { get; set; }

        /// <summary>
        /// Defines the value that the joinSplit transfer will insert into the transparent transaction value pool.
        /// </summary>
        /// <value>Defines the value that the joinSplit transfer will insert into the transparent transaction value pool.</value>
        [DataMember(Name = "vPubNew", IsRequired = true, EmitDefaultValue = false)]
        public string VPubNew { get; set; }

        /// <summary>
        /// Defines the value that the joinSplit transfer will remove from the transparent transaction value pool.
        /// </summary>
        /// <value>Defines the value that the joinSplit transfer will remove from the transparent transaction value pool.</value>
        [DataMember(Name = "vPubOld", IsRequired = true, EmitDefaultValue = false)]
        public string VPubOld { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListTransactionsByBlockHeightRIBSZVJoinSplit {\n");
            sb.Append("  Anchor: ").Append(Anchor).Append("\n");
            sb.Append("  CipherTexts: ").Append(CipherTexts).Append("\n");
            sb.Append("  Commitments: ").Append(Commitments).Append("\n");
            sb.Append("  Macs: ").Append(Macs).Append("\n");
            sb.Append("  Nullifiers: ").Append(Nullifiers).Append("\n");
            sb.Append("  OneTimePubKey: ").Append(OneTimePubKey).Append("\n");
            sb.Append("  Proof: ").Append(Proof).Append("\n");
            sb.Append("  RandomSeed: ").Append(RandomSeed).Append("\n");
            sb.Append("  VPubNew: ").Append(VPubNew).Append("\n");
            sb.Append("  VPubOld: ").Append(VPubOld).Append("\n");
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
            return this.Equals(input as ListTransactionsByBlockHeightRIBSZVJoinSplit);
        }

        /// <summary>
        /// Returns true if ListTransactionsByBlockHeightRIBSZVJoinSplit instances are equal
        /// </summary>
        /// <param name="input">Instance of ListTransactionsByBlockHeightRIBSZVJoinSplit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListTransactionsByBlockHeightRIBSZVJoinSplit input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Anchor == input.Anchor ||
                    (this.Anchor != null &&
                    this.Anchor.Equals(input.Anchor))
                ) && 
                (
                    this.CipherTexts == input.CipherTexts ||
                    this.CipherTexts != null &&
                    input.CipherTexts != null &&
                    this.CipherTexts.SequenceEqual(input.CipherTexts)
                ) && 
                (
                    this.Commitments == input.Commitments ||
                    this.Commitments != null &&
                    input.Commitments != null &&
                    this.Commitments.SequenceEqual(input.Commitments)
                ) && 
                (
                    this.Macs == input.Macs ||
                    this.Macs != null &&
                    input.Macs != null &&
                    this.Macs.SequenceEqual(input.Macs)
                ) && 
                (
                    this.Nullifiers == input.Nullifiers ||
                    this.Nullifiers != null &&
                    input.Nullifiers != null &&
                    this.Nullifiers.SequenceEqual(input.Nullifiers)
                ) && 
                (
                    this.OneTimePubKey == input.OneTimePubKey ||
                    (this.OneTimePubKey != null &&
                    this.OneTimePubKey.Equals(input.OneTimePubKey))
                ) && 
                (
                    this.Proof == input.Proof ||
                    (this.Proof != null &&
                    this.Proof.Equals(input.Proof))
                ) && 
                (
                    this.RandomSeed == input.RandomSeed ||
                    (this.RandomSeed != null &&
                    this.RandomSeed.Equals(input.RandomSeed))
                ) && 
                (
                    this.VPubNew == input.VPubNew ||
                    (this.VPubNew != null &&
                    this.VPubNew.Equals(input.VPubNew))
                ) && 
                (
                    this.VPubOld == input.VPubOld ||
                    (this.VPubOld != null &&
                    this.VPubOld.Equals(input.VPubOld))
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
                if (this.Anchor != null)
                {
                    hashCode = (hashCode * 59) + this.Anchor.GetHashCode();
                }
                if (this.CipherTexts != null)
                {
                    hashCode = (hashCode * 59) + this.CipherTexts.GetHashCode();
                }
                if (this.Commitments != null)
                {
                    hashCode = (hashCode * 59) + this.Commitments.GetHashCode();
                }
                if (this.Macs != null)
                {
                    hashCode = (hashCode * 59) + this.Macs.GetHashCode();
                }
                if (this.Nullifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Nullifiers.GetHashCode();
                }
                if (this.OneTimePubKey != null)
                {
                    hashCode = (hashCode * 59) + this.OneTimePubKey.GetHashCode();
                }
                if (this.Proof != null)
                {
                    hashCode = (hashCode * 59) + this.Proof.GetHashCode();
                }
                if (this.RandomSeed != null)
                {
                    hashCode = (hashCode * 59) + this.RandomSeed.GetHashCode();
                }
                if (this.VPubNew != null)
                {
                    hashCode = (hashCode * 59) + this.VPubNew.GetHashCode();
                }
                if (this.VPubOld != null)
                {
                    hashCode = (hashCode * 59) + this.VPubOld.GetHashCode();
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
