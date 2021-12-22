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
    /// Zcash
    /// </summary>
    [DataContract(Name = "GetTransactionDetailsByTransactionIDFromCallbackRIBSZ")]
    public partial class GetTransactionDetailsByTransactionIDFromCallbackRIBSZ : IEquatable<GetTransactionDetailsByTransactionIDFromCallbackRIBSZ>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDFromCallbackRIBSZ" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransactionDetailsByTransactionIDFromCallbackRIBSZ() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDFromCallbackRIBSZ" /> class.
        /// </summary>
        /// <param name="bindingSig">It is used to enforce balance of Spend and Output transfers, in order to prevent their replay across transactions. (required).</param>
        /// <param name="expiryHeight">Represents a block height after which the transaction will expire. (required).</param>
        /// <param name="joinSplitPubKey">Represents an encoding of a JoinSplitSig public validating key. (required).</param>
        /// <param name="joinSplitSig">Is used to sign transactions that contain at least one JoinSplit description. (required).</param>
        /// <param name="locktime">Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid. (required).</param>
        /// <param name="overwintered">\&quot;Overwinter\&quot; is the network upgrade for the Zcash blockchain. (required).</param>
        /// <param name="size">Represents the total size of this transaction. (required).</param>
        /// <param name="vJoinSplit">Represents a sequence of JoinSplit descriptions using BCTV14 proofs. (required).</param>
        /// <param name="vShieldedOutput">Object Array representation of transaction output descriptions (required).</param>
        /// <param name="vShieldedSpend">Object Array representation of transaction spend descriptions (required).</param>
        /// <param name="valueBalance">String representation of the transaction value balance (required).</param>
        /// <param name="version">Defines the version of the transaction. (required).</param>
        /// <param name="versionGroupId">Represents the transaction version group ID (required).</param>
        /// <param name="vin">Object Array representation of transaction inputs (required).</param>
        /// <param name="vout">Object Array representation of transaction outputs (required).</param>
        public GetTransactionDetailsByTransactionIDFromCallbackRIBSZ(string bindingSig = default(string), int expiryHeight = default(int), string joinSplitPubKey = default(string), string joinSplitSig = default(string), int locktime = default(int), bool overwintered = default(bool), int size = default(int), List<GetTransactionDetailsByTransactionIDRIBSZVJoinSplit> vJoinSplit = default(List<GetTransactionDetailsByTransactionIDRIBSZVJoinSplit>), List<GetTransactionDetailsByTransactionIDRIBSZVShieldedOutput> vShieldedOutput = default(List<GetTransactionDetailsByTransactionIDRIBSZVShieldedOutput>), List<GetTransactionDetailsByTransactionIDRIBSZVShieldedSpend> vShieldedSpend = default(List<GetTransactionDetailsByTransactionIDRIBSZVShieldedSpend>), string valueBalance = default(string), int version = default(int), string versionGroupId = default(string), List<GetTransactionDetailsByTransactionIDRIBSZVin> vin = default(List<GetTransactionDetailsByTransactionIDRIBSZVin>), List<GetTransactionDetailsByTransactionIDRIBSZVout> vout = default(List<GetTransactionDetailsByTransactionIDRIBSZVout>))
        {
            // to ensure "bindingSig" is required (not null)
            if (bindingSig == null) {
                throw new ArgumentNullException("bindingSig is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSZ and cannot be null");
            }
            this.BindingSig = bindingSig;
            this.ExpiryHeight = expiryHeight;
            // to ensure "joinSplitPubKey" is required (not null)
            if (joinSplitPubKey == null) {
                throw new ArgumentNullException("joinSplitPubKey is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSZ and cannot be null");
            }
            this.JoinSplitPubKey = joinSplitPubKey;
            // to ensure "joinSplitSig" is required (not null)
            if (joinSplitSig == null) {
                throw new ArgumentNullException("joinSplitSig is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSZ and cannot be null");
            }
            this.JoinSplitSig = joinSplitSig;
            this.Locktime = locktime;
            this.Overwintered = overwintered;
            this.Size = size;
            // to ensure "vJoinSplit" is required (not null)
            if (vJoinSplit == null) {
                throw new ArgumentNullException("vJoinSplit is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSZ and cannot be null");
            }
            this.VJoinSplit = vJoinSplit;
            // to ensure "vShieldedOutput" is required (not null)
            if (vShieldedOutput == null) {
                throw new ArgumentNullException("vShieldedOutput is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSZ and cannot be null");
            }
            this.VShieldedOutput = vShieldedOutput;
            // to ensure "vShieldedSpend" is required (not null)
            if (vShieldedSpend == null) {
                throw new ArgumentNullException("vShieldedSpend is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSZ and cannot be null");
            }
            this.VShieldedSpend = vShieldedSpend;
            // to ensure "valueBalance" is required (not null)
            if (valueBalance == null) {
                throw new ArgumentNullException("valueBalance is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSZ and cannot be null");
            }
            this.ValueBalance = valueBalance;
            this._Version = version;
            // to ensure "versionGroupId" is required (not null)
            if (versionGroupId == null) {
                throw new ArgumentNullException("versionGroupId is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSZ and cannot be null");
            }
            this.VersionGroupId = versionGroupId;
            // to ensure "vin" is required (not null)
            if (vin == null) {
                throw new ArgumentNullException("vin is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSZ and cannot be null");
            }
            this.Vin = vin;
            // to ensure "vout" is required (not null)
            if (vout == null) {
                throw new ArgumentNullException("vout is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSZ and cannot be null");
            }
            this.Vout = vout;
        }

        /// <summary>
        /// It is used to enforce balance of Spend and Output transfers, in order to prevent their replay across transactions.
        /// </summary>
        /// <value>It is used to enforce balance of Spend and Output transfers, in order to prevent their replay across transactions.</value>
        [DataMember(Name = "bindingSig", IsRequired = true, EmitDefaultValue = false)]
        public string BindingSig { get; set; }

        /// <summary>
        /// Represents a block height after which the transaction will expire.
        /// </summary>
        /// <value>Represents a block height after which the transaction will expire.</value>
        [DataMember(Name = "expiryHeight", IsRequired = true, EmitDefaultValue = false)]
        public int ExpiryHeight { get; set; }

        /// <summary>
        /// Represents an encoding of a JoinSplitSig public validating key.
        /// </summary>
        /// <value>Represents an encoding of a JoinSplitSig public validating key.</value>
        [DataMember(Name = "joinSplitPubKey", IsRequired = true, EmitDefaultValue = false)]
        public string JoinSplitPubKey { get; set; }

        /// <summary>
        /// Is used to sign transactions that contain at least one JoinSplit description.
        /// </summary>
        /// <value>Is used to sign transactions that contain at least one JoinSplit description.</value>
        [DataMember(Name = "joinSplitSig", IsRequired = true, EmitDefaultValue = false)]
        public string JoinSplitSig { get; set; }

        /// <summary>
        /// Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid.
        /// </summary>
        /// <value>Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid.</value>
        [DataMember(Name = "locktime", IsRequired = true, EmitDefaultValue = false)]
        public int Locktime { get; set; }

        /// <summary>
        /// \&quot;Overwinter\&quot; is the network upgrade for the Zcash blockchain.
        /// </summary>
        /// <value>\&quot;Overwinter\&quot; is the network upgrade for the Zcash blockchain.</value>
        [DataMember(Name = "overwintered", IsRequired = true, EmitDefaultValue = true)]
        public bool Overwintered { get; set; }

        /// <summary>
        /// Represents the total size of this transaction.
        /// </summary>
        /// <value>Represents the total size of this transaction.</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Represents a sequence of JoinSplit descriptions using BCTV14 proofs.
        /// </summary>
        /// <value>Represents a sequence of JoinSplit descriptions using BCTV14 proofs.</value>
        [DataMember(Name = "vJoinSplit", IsRequired = true, EmitDefaultValue = false)]
        public List<GetTransactionDetailsByTransactionIDRIBSZVJoinSplit> VJoinSplit { get; set; }

        /// <summary>
        /// Object Array representation of transaction output descriptions
        /// </summary>
        /// <value>Object Array representation of transaction output descriptions</value>
        [DataMember(Name = "vShieldedOutput", IsRequired = true, EmitDefaultValue = false)]
        public List<GetTransactionDetailsByTransactionIDRIBSZVShieldedOutput> VShieldedOutput { get; set; }

        /// <summary>
        /// Object Array representation of transaction spend descriptions
        /// </summary>
        /// <value>Object Array representation of transaction spend descriptions</value>
        [DataMember(Name = "vShieldedSpend", IsRequired = true, EmitDefaultValue = false)]
        public List<GetTransactionDetailsByTransactionIDRIBSZVShieldedSpend> VShieldedSpend { get; set; }

        /// <summary>
        /// String representation of the transaction value balance
        /// </summary>
        /// <value>String representation of the transaction value balance</value>
        [DataMember(Name = "valueBalance", IsRequired = true, EmitDefaultValue = false)]
        public string ValueBalance { get; set; }

        /// <summary>
        /// Defines the version of the transaction.
        /// </summary>
        /// <value>Defines the version of the transaction.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Represents the transaction version group ID
        /// </summary>
        /// <value>Represents the transaction version group ID</value>
        [DataMember(Name = "versionGroupId", IsRequired = true, EmitDefaultValue = false)]
        public string VersionGroupId { get; set; }

        /// <summary>
        /// Object Array representation of transaction inputs
        /// </summary>
        /// <value>Object Array representation of transaction inputs</value>
        [DataMember(Name = "vin", IsRequired = true, EmitDefaultValue = false)]
        public List<GetTransactionDetailsByTransactionIDRIBSZVin> Vin { get; set; }

        /// <summary>
        /// Object Array representation of transaction outputs
        /// </summary>
        /// <value>Object Array representation of transaction outputs</value>
        [DataMember(Name = "vout", IsRequired = true, EmitDefaultValue = false)]
        public List<GetTransactionDetailsByTransactionIDRIBSZVout> Vout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionDetailsByTransactionIDFromCallbackRIBSZ {\n");
            sb.Append("  BindingSig: ").Append(BindingSig).Append("\n");
            sb.Append("  ExpiryHeight: ").Append(ExpiryHeight).Append("\n");
            sb.Append("  JoinSplitPubKey: ").Append(JoinSplitPubKey).Append("\n");
            sb.Append("  JoinSplitSig: ").Append(JoinSplitSig).Append("\n");
            sb.Append("  Locktime: ").Append(Locktime).Append("\n");
            sb.Append("  Overwintered: ").Append(Overwintered).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  VJoinSplit: ").Append(VJoinSplit).Append("\n");
            sb.Append("  VShieldedOutput: ").Append(VShieldedOutput).Append("\n");
            sb.Append("  VShieldedSpend: ").Append(VShieldedSpend).Append("\n");
            sb.Append("  ValueBalance: ").Append(ValueBalance).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  VersionGroupId: ").Append(VersionGroupId).Append("\n");
            sb.Append("  Vin: ").Append(Vin).Append("\n");
            sb.Append("  Vout: ").Append(Vout).Append("\n");
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
            return this.Equals(input as GetTransactionDetailsByTransactionIDFromCallbackRIBSZ);
        }

        /// <summary>
        /// Returns true if GetTransactionDetailsByTransactionIDFromCallbackRIBSZ instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionDetailsByTransactionIDFromCallbackRIBSZ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionDetailsByTransactionIDFromCallbackRIBSZ input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BindingSig == input.BindingSig ||
                    (this.BindingSig != null &&
                    this.BindingSig.Equals(input.BindingSig))
                ) && 
                (
                    this.ExpiryHeight == input.ExpiryHeight ||
                    this.ExpiryHeight.Equals(input.ExpiryHeight)
                ) && 
                (
                    this.JoinSplitPubKey == input.JoinSplitPubKey ||
                    (this.JoinSplitPubKey != null &&
                    this.JoinSplitPubKey.Equals(input.JoinSplitPubKey))
                ) && 
                (
                    this.JoinSplitSig == input.JoinSplitSig ||
                    (this.JoinSplitSig != null &&
                    this.JoinSplitSig.Equals(input.JoinSplitSig))
                ) && 
                (
                    this.Locktime == input.Locktime ||
                    this.Locktime.Equals(input.Locktime)
                ) && 
                (
                    this.Overwintered == input.Overwintered ||
                    this.Overwintered.Equals(input.Overwintered)
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.VJoinSplit == input.VJoinSplit ||
                    this.VJoinSplit != null &&
                    input.VJoinSplit != null &&
                    this.VJoinSplit.SequenceEqual(input.VJoinSplit)
                ) && 
                (
                    this.VShieldedOutput == input.VShieldedOutput ||
                    this.VShieldedOutput != null &&
                    input.VShieldedOutput != null &&
                    this.VShieldedOutput.SequenceEqual(input.VShieldedOutput)
                ) && 
                (
                    this.VShieldedSpend == input.VShieldedSpend ||
                    this.VShieldedSpend != null &&
                    input.VShieldedSpend != null &&
                    this.VShieldedSpend.SequenceEqual(input.VShieldedSpend)
                ) && 
                (
                    this.ValueBalance == input.ValueBalance ||
                    (this.ValueBalance != null &&
                    this.ValueBalance.Equals(input.ValueBalance))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.VersionGroupId == input.VersionGroupId ||
                    (this.VersionGroupId != null &&
                    this.VersionGroupId.Equals(input.VersionGroupId))
                ) && 
                (
                    this.Vin == input.Vin ||
                    this.Vin != null &&
                    input.Vin != null &&
                    this.Vin.SequenceEqual(input.Vin)
                ) && 
                (
                    this.Vout == input.Vout ||
                    this.Vout != null &&
                    input.Vout != null &&
                    this.Vout.SequenceEqual(input.Vout)
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
                if (this.BindingSig != null)
                {
                    hashCode = (hashCode * 59) + this.BindingSig.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiryHeight.GetHashCode();
                if (this.JoinSplitPubKey != null)
                {
                    hashCode = (hashCode * 59) + this.JoinSplitPubKey.GetHashCode();
                }
                if (this.JoinSplitSig != null)
                {
                    hashCode = (hashCode * 59) + this.JoinSplitSig.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Locktime.GetHashCode();
                hashCode = (hashCode * 59) + this.Overwintered.GetHashCode();
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                if (this.VJoinSplit != null)
                {
                    hashCode = (hashCode * 59) + this.VJoinSplit.GetHashCode();
                }
                if (this.VShieldedOutput != null)
                {
                    hashCode = (hashCode * 59) + this.VShieldedOutput.GetHashCode();
                }
                if (this.VShieldedSpend != null)
                {
                    hashCode = (hashCode * 59) + this.VShieldedSpend.GetHashCode();
                }
                if (this.ValueBalance != null)
                {
                    hashCode = (hashCode * 59) + this.ValueBalance.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                if (this.VersionGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.VersionGroupId.GetHashCode();
                }
                if (this.Vin != null)
                {
                    hashCode = (hashCode * 59) + this.Vin.GetHashCode();
                }
                if (this.Vout != null)
                {
                    hashCode = (hashCode * 59) + this.Vout.GetHashCode();
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