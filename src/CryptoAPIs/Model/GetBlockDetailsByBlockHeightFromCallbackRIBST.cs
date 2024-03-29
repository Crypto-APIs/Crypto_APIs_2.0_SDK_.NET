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
    /// Tron
    /// </summary>
    [DataContract(Name = "GetBlockDetailsByBlockHeightFromCallbackRIBST")]
    public partial class GetBlockDetailsByBlockHeightFromCallbackRIBST : IEquatable<GetBlockDetailsByBlockHeightFromCallbackRIBST>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHeightFromCallbackRIBST" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetBlockDetailsByBlockHeightFromCallbackRIBST() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHeightFromCallbackRIBST" /> class.
        /// </summary>
        /// <param name="bandwidthUsed">Represents the bandwidth used for the transaction. (required).</param>
        /// <param name="burnedTrx">Represents the block burned TRX. (required).</param>
        /// <param name="energyUsed">Representats the used energy for the transaction. (required).</param>
        /// <param name="size">Represents the total size of the block in Bytes. (required).</param>
        public GetBlockDetailsByBlockHeightFromCallbackRIBST(string bandwidthUsed = default(string), string burnedTrx = default(string), string energyUsed = default(string), int size = default(int))
        {
            // to ensure "bandwidthUsed" is required (not null)
            if (bandwidthUsed == null)
            {
                throw new ArgumentNullException("bandwidthUsed is a required property for GetBlockDetailsByBlockHeightFromCallbackRIBST and cannot be null");
            }
            this.BandwidthUsed = bandwidthUsed;
            // to ensure "burnedTrx" is required (not null)
            if (burnedTrx == null)
            {
                throw new ArgumentNullException("burnedTrx is a required property for GetBlockDetailsByBlockHeightFromCallbackRIBST and cannot be null");
            }
            this.BurnedTrx = burnedTrx;
            // to ensure "energyUsed" is required (not null)
            if (energyUsed == null)
            {
                throw new ArgumentNullException("energyUsed is a required property for GetBlockDetailsByBlockHeightFromCallbackRIBST and cannot be null");
            }
            this.EnergyUsed = energyUsed;
            this.Size = size;
        }

        /// <summary>
        /// Represents the bandwidth used for the transaction.
        /// </summary>
        /// <value>Represents the bandwidth used for the transaction.</value>
        [DataMember(Name = "bandwidthUsed", IsRequired = true, EmitDefaultValue = false)]
        public string BandwidthUsed { get; set; }

        /// <summary>
        /// Represents the block burned TRX.
        /// </summary>
        /// <value>Represents the block burned TRX.</value>
        [DataMember(Name = "burnedTrx", IsRequired = true, EmitDefaultValue = false)]
        public string BurnedTrx { get; set; }

        /// <summary>
        /// Representats the used energy for the transaction.
        /// </summary>
        /// <value>Representats the used energy for the transaction.</value>
        [DataMember(Name = "energyUsed", IsRequired = true, EmitDefaultValue = false)]
        public string EnergyUsed { get; set; }

        /// <summary>
        /// Represents the total size of the block in Bytes.
        /// </summary>
        /// <value>Represents the total size of the block in Bytes.</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetBlockDetailsByBlockHeightFromCallbackRIBST {\n");
            sb.Append("  BandwidthUsed: ").Append(BandwidthUsed).Append("\n");
            sb.Append("  BurnedTrx: ").Append(BurnedTrx).Append("\n");
            sb.Append("  EnergyUsed: ").Append(EnergyUsed).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as GetBlockDetailsByBlockHeightFromCallbackRIBST);
        }

        /// <summary>
        /// Returns true if GetBlockDetailsByBlockHeightFromCallbackRIBST instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBlockDetailsByBlockHeightFromCallbackRIBST to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBlockDetailsByBlockHeightFromCallbackRIBST input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BandwidthUsed == input.BandwidthUsed ||
                    (this.BandwidthUsed != null &&
                    this.BandwidthUsed.Equals(input.BandwidthUsed))
                ) && 
                (
                    this.BurnedTrx == input.BurnedTrx ||
                    (this.BurnedTrx != null &&
                    this.BurnedTrx.Equals(input.BurnedTrx))
                ) && 
                (
                    this.EnergyUsed == input.EnergyUsed ||
                    (this.EnergyUsed != null &&
                    this.EnergyUsed.Equals(input.EnergyUsed))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
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
                if (this.BandwidthUsed != null)
                {
                    hashCode = (hashCode * 59) + this.BandwidthUsed.GetHashCode();
                }
                if (this.BurnedTrx != null)
                {
                    hashCode = (hashCode * 59) + this.BurnedTrx.GetHashCode();
                }
                if (this.EnergyUsed != null)
                {
                    hashCode = (hashCode * 59) + this.EnergyUsed.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
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
