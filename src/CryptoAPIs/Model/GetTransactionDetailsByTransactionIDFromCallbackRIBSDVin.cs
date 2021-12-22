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
    /// GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin
    /// </summary>
    [DataContract(Name = "GetTransactionDetailsByTransactionIDFromCallbackRIBSD_vin")]
    public partial class GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin : IEquatable<GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin" /> class.
        /// </summary>
        /// <param name="addresses">addresses (required).</param>
        /// <param name="coinbase">Represents the coinbase hex..</param>
        /// <param name="scriptSig">scriptSig (required).</param>
        /// <param name="sequence">Represents the script sequence number. (required).</param>
        /// <param name="txid">String representation of the txid.</param>
        /// <param name="txinwitness">txinwitness (required).</param>
        /// <param name="value">Represents the sent/received amount..</param>
        /// <param name="vout">It refers to the index of the output address of this transaction. The index starts from 0..</param>
        public GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin(List<string> addresses = default(List<string>), string coinbase = default(string), GetTransactionDetailsByTransactionIDRIBSD2ScriptSig scriptSig = default(GetTransactionDetailsByTransactionIDRIBSD2ScriptSig), int sequence = default(int), string txid = default(string), List<string> txinwitness = default(List<string>), string value = default(string), int vout = default(int))
        {
            // to ensure "addresses" is required (not null)
            if (addresses == null) {
                throw new ArgumentNullException("addresses is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin and cannot be null");
            }
            this.Addresses = addresses;
            // to ensure "scriptSig" is required (not null)
            if (scriptSig == null) {
                throw new ArgumentNullException("scriptSig is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin and cannot be null");
            }
            this.ScriptSig = scriptSig;
            this.Sequence = sequence;
            // to ensure "txinwitness" is required (not null)
            if (txinwitness == null) {
                throw new ArgumentNullException("txinwitness is a required property for GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin and cannot be null");
            }
            this.Txinwitness = txinwitness;
            this.Coinbase = coinbase;
            this.Txid = txid;
            this.Value = value;
            this.Vout = vout;
        }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// Represents the coinbase hex.
        /// </summary>
        /// <value>Represents the coinbase hex.</value>
        [DataMember(Name = "coinbase", EmitDefaultValue = false)]
        public string Coinbase { get; set; }

        /// <summary>
        /// Gets or Sets ScriptSig
        /// </summary>
        [DataMember(Name = "scriptSig", IsRequired = true, EmitDefaultValue = false)]
        public GetTransactionDetailsByTransactionIDRIBSD2ScriptSig ScriptSig { get; set; }

        /// <summary>
        /// Represents the script sequence number.
        /// </summary>
        /// <value>Represents the script sequence number.</value>
        [DataMember(Name = "sequence", IsRequired = true, EmitDefaultValue = false)]
        public int Sequence { get; set; }

        /// <summary>
        /// String representation of the txid
        /// </summary>
        /// <value>String representation of the txid</value>
        [DataMember(Name = "txid", EmitDefaultValue = false)]
        public string Txid { get; set; }

        /// <summary>
        /// Gets or Sets Txinwitness
        /// </summary>
        [DataMember(Name = "txinwitness", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Txinwitness { get; set; }

        /// <summary>
        /// Represents the sent/received amount.
        /// </summary>
        /// <value>Represents the sent/received amount.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// It refers to the index of the output address of this transaction. The index starts from 0.
        /// </summary>
        /// <value>It refers to the index of the output address of this transaction. The index starts from 0.</value>
        [DataMember(Name = "vout", EmitDefaultValue = false)]
        public int Vout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Coinbase: ").Append(Coinbase).Append("\n");
            sb.Append("  ScriptSig: ").Append(ScriptSig).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Txid: ").Append(Txid).Append("\n");
            sb.Append("  Txinwitness: ").Append(Txinwitness).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin);
        }

        /// <summary>
        /// Returns true if GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionDetailsByTransactionIDFromCallbackRIBSDVin input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Coinbase == input.Coinbase ||
                    (this.Coinbase != null &&
                    this.Coinbase.Equals(input.Coinbase))
                ) && 
                (
                    this.ScriptSig == input.ScriptSig ||
                    (this.ScriptSig != null &&
                    this.ScriptSig.Equals(input.ScriptSig))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    this.Sequence.Equals(input.Sequence)
                ) && 
                (
                    this.Txid == input.Txid ||
                    (this.Txid != null &&
                    this.Txid.Equals(input.Txid))
                ) && 
                (
                    this.Txinwitness == input.Txinwitness ||
                    this.Txinwitness != null &&
                    input.Txinwitness != null &&
                    this.Txinwitness.SequenceEqual(input.Txinwitness)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Vout == input.Vout ||
                    this.Vout.Equals(input.Vout)
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
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                if (this.Coinbase != null)
                {
                    hashCode = (hashCode * 59) + this.Coinbase.GetHashCode();
                }
                if (this.ScriptSig != null)
                {
                    hashCode = (hashCode * 59) + this.ScriptSig.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Sequence.GetHashCode();
                if (this.Txid != null)
                {
                    hashCode = (hashCode * 59) + this.Txid.GetHashCode();
                }
                if (this.Txinwitness != null)
                {
                    hashCode = (hashCode * 59) + this.Txinwitness.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Vout.GetHashCode();
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
