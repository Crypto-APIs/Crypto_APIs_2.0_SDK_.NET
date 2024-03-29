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
    /// GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner
    /// </summary>
    [DataContract(Name = "GetTransactionDetailsByTransactionIDRIBSZ_vShieldedSpend_inner")]
    public partial class GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner : IEquatable<GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner" /> class.
        /// </summary>
        /// <param name="anchor">Defines a Merkle tree root of a note commitment tree which uniquely identifies a note commitment tree state given the assumed security properties of the Merkle tree’s  hash function. (required).</param>
        /// <param name="cv">Defines a value commitment to the value of the input note. (required).</param>
        /// <param name="nullifier">Represents a sequence of nullifiers of the input notes. (required).</param>
        /// <param name="proof">Represents the proof. (required).</param>
        /// <param name="rk">Represents the randomized validating key for spendAuthSig. (required).</param>
        /// <param name="spendAuthSig">Used to prove knowledge of the spending key authorizing spending of an input note. (required).</param>
        public GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner(string anchor = default(string), string cv = default(string), string nullifier = default(string), string proof = default(string), string rk = default(string), string spendAuthSig = default(string))
        {
            // to ensure "anchor" is required (not null)
            if (anchor == null)
            {
                throw new ArgumentNullException("anchor is a required property for GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner and cannot be null");
            }
            this.Anchor = anchor;
            // to ensure "cv" is required (not null)
            if (cv == null)
            {
                throw new ArgumentNullException("cv is a required property for GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner and cannot be null");
            }
            this.Cv = cv;
            // to ensure "nullifier" is required (not null)
            if (nullifier == null)
            {
                throw new ArgumentNullException("nullifier is a required property for GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner and cannot be null");
            }
            this.Nullifier = nullifier;
            // to ensure "proof" is required (not null)
            if (proof == null)
            {
                throw new ArgumentNullException("proof is a required property for GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner and cannot be null");
            }
            this.Proof = proof;
            // to ensure "rk" is required (not null)
            if (rk == null)
            {
                throw new ArgumentNullException("rk is a required property for GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner and cannot be null");
            }
            this.Rk = rk;
            // to ensure "spendAuthSig" is required (not null)
            if (spendAuthSig == null)
            {
                throw new ArgumentNullException("spendAuthSig is a required property for GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner and cannot be null");
            }
            this.SpendAuthSig = spendAuthSig;
        }

        /// <summary>
        /// Defines a Merkle tree root of a note commitment tree which uniquely identifies a note commitment tree state given the assumed security properties of the Merkle tree’s  hash function.
        /// </summary>
        /// <value>Defines a Merkle tree root of a note commitment tree which uniquely identifies a note commitment tree state given the assumed security properties of the Merkle tree’s  hash function.</value>
        [DataMember(Name = "anchor", IsRequired = true, EmitDefaultValue = false)]
        public string Anchor { get; set; }

        /// <summary>
        /// Defines a value commitment to the value of the input note.
        /// </summary>
        /// <value>Defines a value commitment to the value of the input note.</value>
        [DataMember(Name = "cv", IsRequired = true, EmitDefaultValue = false)]
        public string Cv { get; set; }

        /// <summary>
        /// Represents a sequence of nullifiers of the input notes.
        /// </summary>
        /// <value>Represents a sequence of nullifiers of the input notes.</value>
        [DataMember(Name = "nullifier", IsRequired = true, EmitDefaultValue = false)]
        public string Nullifier { get; set; }

        /// <summary>
        /// Represents the proof.
        /// </summary>
        /// <value>Represents the proof.</value>
        [DataMember(Name = "proof", IsRequired = true, EmitDefaultValue = false)]
        public string Proof { get; set; }

        /// <summary>
        /// Represents the randomized validating key for spendAuthSig.
        /// </summary>
        /// <value>Represents the randomized validating key for spendAuthSig.</value>
        [DataMember(Name = "rk", IsRequired = true, EmitDefaultValue = false)]
        public string Rk { get; set; }

        /// <summary>
        /// Used to prove knowledge of the spending key authorizing spending of an input note.
        /// </summary>
        /// <value>Used to prove knowledge of the spending key authorizing spending of an input note.</value>
        [DataMember(Name = "spendAuthSig", IsRequired = true, EmitDefaultValue = false)]
        public string SpendAuthSig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner {\n");
            sb.Append("  Anchor: ").Append(Anchor).Append("\n");
            sb.Append("  Cv: ").Append(Cv).Append("\n");
            sb.Append("  Nullifier: ").Append(Nullifier).Append("\n");
            sb.Append("  Proof: ").Append(Proof).Append("\n");
            sb.Append("  Rk: ").Append(Rk).Append("\n");
            sb.Append("  SpendAuthSig: ").Append(SpendAuthSig).Append("\n");
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
            return this.Equals(input as GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner);
        }

        /// <summary>
        /// Returns true if GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionDetailsByTransactionIDRIBSZVShieldedSpendInner input)
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
                    this.Cv == input.Cv ||
                    (this.Cv != null &&
                    this.Cv.Equals(input.Cv))
                ) && 
                (
                    this.Nullifier == input.Nullifier ||
                    (this.Nullifier != null &&
                    this.Nullifier.Equals(input.Nullifier))
                ) && 
                (
                    this.Proof == input.Proof ||
                    (this.Proof != null &&
                    this.Proof.Equals(input.Proof))
                ) && 
                (
                    this.Rk == input.Rk ||
                    (this.Rk != null &&
                    this.Rk.Equals(input.Rk))
                ) && 
                (
                    this.SpendAuthSig == input.SpendAuthSig ||
                    (this.SpendAuthSig != null &&
                    this.SpendAuthSig.Equals(input.SpendAuthSig))
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
                if (this.Cv != null)
                {
                    hashCode = (hashCode * 59) + this.Cv.GetHashCode();
                }
                if (this.Nullifier != null)
                {
                    hashCode = (hashCode * 59) + this.Nullifier.GetHashCode();
                }
                if (this.Proof != null)
                {
                    hashCode = (hashCode * 59) + this.Proof.GetHashCode();
                }
                if (this.Rk != null)
                {
                    hashCode = (hashCode * 59) + this.Rk.GetHashCode();
                }
                if (this.SpendAuthSig != null)
                {
                    hashCode = (hashCode * 59) + this.SpendAuthSig.GetHashCode();
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
