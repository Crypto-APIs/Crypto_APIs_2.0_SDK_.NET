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
    /// Litecoin
    /// </summary>
    [DataContract(Name = "ListConfirmedTransactionsByAddressRIBSL")]
    public partial class ListConfirmedTransactionsByAddressRIBSL : IEquatable<ListConfirmedTransactionsByAddressRIBSL>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressRIBSL" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListConfirmedTransactionsByAddressRIBSL() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListConfirmedTransactionsByAddressRIBSL" /> class.
        /// </summary>
        /// <param name="locktime">Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid. (required).</param>
        /// <param name="size">Represents the total size of this transaction. (required).</param>
        /// <param name="vSize">Represents the virtual size of this transaction. (required).</param>
        /// <param name="version">Represents the transaction&#39;s version number. (required).</param>
        /// <param name="vin">Represents the transaction inputs. (required).</param>
        /// <param name="vout">Represents the transaction outputs. (required).</param>
        public ListConfirmedTransactionsByAddressRIBSL(int locktime = default(int), int size = default(int), int vSize = default(int), int version = default(int), List<ListConfirmedTransactionsByAddressRIBSLVin> vin = default(List<ListConfirmedTransactionsByAddressRIBSLVin>), List<GetTransactionDetailsByTransactionIDRIBSLVout> vout = default(List<GetTransactionDetailsByTransactionIDRIBSLVout>))
        {
            this.Locktime = locktime;
            this.Size = size;
            this.VSize = vSize;
            this._Version = version;
            // to ensure "vin" is required (not null)
            if (vin == null) {
                throw new ArgumentNullException("vin is a required property for ListConfirmedTransactionsByAddressRIBSL and cannot be null");
            }
            this.Vin = vin;
            // to ensure "vout" is required (not null)
            if (vout == null) {
                throw new ArgumentNullException("vout is a required property for ListConfirmedTransactionsByAddressRIBSL and cannot be null");
            }
            this.Vout = vout;
        }

        /// <summary>
        /// Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid.
        /// </summary>
        /// <value>Represents the locktime on the transaction on the specific blockchain, i.e. the blockheight at which the transaction is valid.</value>
        [DataMember(Name = "locktime", IsRequired = true, EmitDefaultValue = false)]
        public int Locktime { get; set; }

        /// <summary>
        /// Represents the total size of this transaction.
        /// </summary>
        /// <value>Represents the total size of this transaction.</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Represents the virtual size of this transaction.
        /// </summary>
        /// <value>Represents the virtual size of this transaction.</value>
        [DataMember(Name = "vSize", IsRequired = true, EmitDefaultValue = false)]
        public int VSize { get; set; }

        /// <summary>
        /// Represents the transaction&#39;s version number.
        /// </summary>
        /// <value>Represents the transaction&#39;s version number.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Represents the transaction inputs.
        /// </summary>
        /// <value>Represents the transaction inputs.</value>
        [DataMember(Name = "vin", IsRequired = true, EmitDefaultValue = false)]
        public List<ListConfirmedTransactionsByAddressRIBSLVin> Vin { get; set; }

        /// <summary>
        /// Represents the transaction outputs.
        /// </summary>
        /// <value>Represents the transaction outputs.</value>
        [DataMember(Name = "vout", IsRequired = true, EmitDefaultValue = false)]
        public List<GetTransactionDetailsByTransactionIDRIBSLVout> Vout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListConfirmedTransactionsByAddressRIBSL {\n");
            sb.Append("  Locktime: ").Append(Locktime).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  VSize: ").Append(VSize).Append("\n");
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
            return this.Equals(input as ListConfirmedTransactionsByAddressRIBSL);
        }

        /// <summary>
        /// Returns true if ListConfirmedTransactionsByAddressRIBSL instances are equal
        /// </summary>
        /// <param name="input">Instance of ListConfirmedTransactionsByAddressRIBSL to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListConfirmedTransactionsByAddressRIBSL input)
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
                    this.VSize == input.VSize ||
                    this.VSize.Equals(input.VSize)
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
                hashCode = (hashCode * 59) + this.VSize.GetHashCode();
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
