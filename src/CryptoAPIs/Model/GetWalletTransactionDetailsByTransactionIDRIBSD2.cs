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
    [DataContract(Name = "GetWalletTransactionDetailsByTransactionIDRIBSD2")]
    public partial class GetWalletTransactionDetailsByTransactionIDRIBSD2 : IEquatable<GetWalletTransactionDetailsByTransactionIDRIBSD2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletTransactionDetailsByTransactionIDRIBSD2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWalletTransactionDetailsByTransactionIDRIBSD2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletTransactionDetailsByTransactionIDRIBSD2" /> class.
        /// </summary>
        /// <param name="locktime">Represents the time at which a particular transaction can be added to the blockchain. (required).</param>
        /// <param name="size">Represents the total size of this transaction. (required).</param>
        /// <param name="version">Represents the transaction version number. (required).</param>
        /// <param name="vin">Object Array representation of transaction inputs (required).</param>
        /// <param name="vout">Object Array representation of transaction outputs (required).</param>
        public GetWalletTransactionDetailsByTransactionIDRIBSD2(long locktime = default(long), int size = default(int), int version = default(int), List<GetWalletTransactionDetailsByTransactionIDRIBSD2VinInner> vin = default(List<GetWalletTransactionDetailsByTransactionIDRIBSD2VinInner>), List<GetTransactionDetailsByTransactionIDRIBSD2VoutInner> vout = default(List<GetTransactionDetailsByTransactionIDRIBSD2VoutInner>))
        {
            this.Locktime = locktime;
            this.Size = size;
            this._Version = version;
            // to ensure "vin" is required (not null)
            if (vin == null)
            {
                throw new ArgumentNullException("vin is a required property for GetWalletTransactionDetailsByTransactionIDRIBSD2 and cannot be null");
            }
            this.Vin = vin;
            // to ensure "vout" is required (not null)
            if (vout == null)
            {
                throw new ArgumentNullException("vout is a required property for GetWalletTransactionDetailsByTransactionIDRIBSD2 and cannot be null");
            }
            this.Vout = vout;
        }

        /// <summary>
        /// Represents the time at which a particular transaction can be added to the blockchain.
        /// </summary>
        /// <value>Represents the time at which a particular transaction can be added to the blockchain.</value>
        [DataMember(Name = "locktime", IsRequired = true, EmitDefaultValue = false)]
        public long Locktime { get; set; }

        /// <summary>
        /// Represents the total size of this transaction.
        /// </summary>
        /// <value>Represents the total size of this transaction.</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Represents the transaction version number.
        /// </summary>
        /// <value>Represents the transaction version number.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Object Array representation of transaction inputs
        /// </summary>
        /// <value>Object Array representation of transaction inputs</value>
        [DataMember(Name = "vin", IsRequired = true, EmitDefaultValue = false)]
        public List<GetWalletTransactionDetailsByTransactionIDRIBSD2VinInner> Vin { get; set; }

        /// <summary>
        /// Object Array representation of transaction outputs
        /// </summary>
        /// <value>Object Array representation of transaction outputs</value>
        [DataMember(Name = "vout", IsRequired = true, EmitDefaultValue = false)]
        public List<GetTransactionDetailsByTransactionIDRIBSD2VoutInner> Vout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetWalletTransactionDetailsByTransactionIDRIBSD2 {\n");
            sb.Append("  Locktime: ").Append(Locktime).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as GetWalletTransactionDetailsByTransactionIDRIBSD2);
        }

        /// <summary>
        /// Returns true if GetWalletTransactionDetailsByTransactionIDRIBSD2 instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWalletTransactionDetailsByTransactionIDRIBSD2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWalletTransactionDetailsByTransactionIDRIBSD2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Locktime == input.Locktime ||
                    this.Locktime.Equals(input.Locktime)
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
                hashCode = (hashCode * 59) + this.Locktime.GetHashCode();
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
