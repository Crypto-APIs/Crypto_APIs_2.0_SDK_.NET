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
    /// DecodeRawTransactionHexRISLVinInner
    /// </summary>
    [DataContract(Name = "DecodeRawTransactionHexRISL_vin_inner")]
    public partial class DecodeRawTransactionHexRISLVinInner : IEquatable<DecodeRawTransactionHexRISLVinInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRawTransactionHexRISLVinInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecodeRawTransactionHexRISLVinInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRawTransactionHexRISLVinInner" /> class.
        /// </summary>
        /// <param name="address">Represents the addresses which send/receive the amount..</param>
        /// <param name="inputHash">Represents the transaction inputs&#39; indentifier..</param>
        /// <param name="outputIndex">Defines the output index of a transaction..</param>
        /// <param name="scriptSig">scriptSig (required).</param>
        /// <param name="sequence">Represents the script sequence number..</param>
        /// <param name="txinwitness">txinwitness.</param>
        public DecodeRawTransactionHexRISLVinInner(string address = default(string), string inputHash = default(string), string outputIndex = default(string), DecodeRawTransactionHexRISLVinInnerScriptSig scriptSig = default(DecodeRawTransactionHexRISLVinInnerScriptSig), string sequence = default(string), List<string> txinwitness = default(List<string>))
        {
            // to ensure "scriptSig" is required (not null)
            if (scriptSig == null)
            {
                throw new ArgumentNullException("scriptSig is a required property for DecodeRawTransactionHexRISLVinInner and cannot be null");
            }
            this.ScriptSig = scriptSig;
            this.Address = address;
            this.InputHash = inputHash;
            this.OutputIndex = outputIndex;
            this.Sequence = sequence;
            this.Txinwitness = txinwitness;
        }

        /// <summary>
        /// Represents the addresses which send/receive the amount.
        /// </summary>
        /// <value>Represents the addresses which send/receive the amount.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Represents the transaction inputs&#39; indentifier.
        /// </summary>
        /// <value>Represents the transaction inputs&#39; indentifier.</value>
        [DataMember(Name = "inputHash", EmitDefaultValue = false)]
        public string InputHash { get; set; }

        /// <summary>
        /// Defines the output index of a transaction.
        /// </summary>
        /// <value>Defines the output index of a transaction.</value>
        [DataMember(Name = "outputIndex", EmitDefaultValue = false)]
        public string OutputIndex { get; set; }

        /// <summary>
        /// Gets or Sets ScriptSig
        /// </summary>
        [DataMember(Name = "scriptSig", IsRequired = true, EmitDefaultValue = false)]
        public DecodeRawTransactionHexRISLVinInnerScriptSig ScriptSig { get; set; }

        /// <summary>
        /// Represents the script sequence number.
        /// </summary>
        /// <value>Represents the script sequence number.</value>
        [DataMember(Name = "sequence", EmitDefaultValue = false)]
        public string Sequence { get; set; }

        /// <summary>
        /// Gets or Sets Txinwitness
        /// </summary>
        [DataMember(Name = "txinwitness", EmitDefaultValue = false)]
        public List<string> Txinwitness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DecodeRawTransactionHexRISLVinInner {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  InputHash: ").Append(InputHash).Append("\n");
            sb.Append("  OutputIndex: ").Append(OutputIndex).Append("\n");
            sb.Append("  ScriptSig: ").Append(ScriptSig).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Txinwitness: ").Append(Txinwitness).Append("\n");
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
            return this.Equals(input as DecodeRawTransactionHexRISLVinInner);
        }

        /// <summary>
        /// Returns true if DecodeRawTransactionHexRISLVinInner instances are equal
        /// </summary>
        /// <param name="input">Instance of DecodeRawTransactionHexRISLVinInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecodeRawTransactionHexRISLVinInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.InputHash == input.InputHash ||
                    (this.InputHash != null &&
                    this.InputHash.Equals(input.InputHash))
                ) && 
                (
                    this.OutputIndex == input.OutputIndex ||
                    (this.OutputIndex != null &&
                    this.OutputIndex.Equals(input.OutputIndex))
                ) && 
                (
                    this.ScriptSig == input.ScriptSig ||
                    (this.ScriptSig != null &&
                    this.ScriptSig.Equals(input.ScriptSig))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.Txinwitness == input.Txinwitness ||
                    this.Txinwitness != null &&
                    input.Txinwitness != null &&
                    this.Txinwitness.SequenceEqual(input.Txinwitness)
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.InputHash != null)
                {
                    hashCode = (hashCode * 59) + this.InputHash.GetHashCode();
                }
                if (this.OutputIndex != null)
                {
                    hashCode = (hashCode * 59) + this.OutputIndex.GetHashCode();
                }
                if (this.ScriptSig != null)
                {
                    hashCode = (hashCode * 59) + this.ScriptSig.GetHashCode();
                }
                if (this.Sequence != null)
                {
                    hashCode = (hashCode * 59) + this.Sequence.GetHashCode();
                }
                if (this.Txinwitness != null)
                {
                    hashCode = (hashCode * 59) + this.Txinwitness.GetHashCode();
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
