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
    /// GetHDWalletXPubYPubZPubDetailsRI
    /// </summary>
    [DataContract(Name = "GetHDWalletXPubYPubZPubDetailsRI")]
    public partial class GetHDWalletXPubYPubZPubDetailsRI : IEquatable<GetHDWalletXPubYPubZPubDetailsRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHDWalletXPubYPubZPubDetailsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetHDWalletXPubYPubZPubDetailsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHDWalletXPubYPubZPubDetailsRI" /> class.
        /// </summary>
        /// <param name="confirmedBalance">Specifies the confirmed coins balance of the Wallet. (required).</param>
        /// <param name="totalReceived">Defines the total currency received to the Wallet. (required).</param>
        /// <param name="totalSpent">Defines the total currency spent from the Wallet. (required).</param>
        public GetHDWalletXPubYPubZPubDetailsRI(string confirmedBalance = default(string), string totalReceived = default(string), string totalSpent = default(string))
        {
            // to ensure "confirmedBalance" is required (not null)
            if (confirmedBalance == null) {
                throw new ArgumentNullException("confirmedBalance is a required property for GetHDWalletXPubYPubZPubDetailsRI and cannot be null");
            }
            this.ConfirmedBalance = confirmedBalance;
            // to ensure "totalReceived" is required (not null)
            if (totalReceived == null) {
                throw new ArgumentNullException("totalReceived is a required property for GetHDWalletXPubYPubZPubDetailsRI and cannot be null");
            }
            this.TotalReceived = totalReceived;
            // to ensure "totalSpent" is required (not null)
            if (totalSpent == null) {
                throw new ArgumentNullException("totalSpent is a required property for GetHDWalletXPubYPubZPubDetailsRI and cannot be null");
            }
            this.TotalSpent = totalSpent;
        }

        /// <summary>
        /// Specifies the confirmed coins balance of the Wallet.
        /// </summary>
        /// <value>Specifies the confirmed coins balance of the Wallet.</value>
        [DataMember(Name = "confirmedBalance", IsRequired = true, EmitDefaultValue = false)]
        public string ConfirmedBalance { get; set; }

        /// <summary>
        /// Defines the total currency received to the Wallet.
        /// </summary>
        /// <value>Defines the total currency received to the Wallet.</value>
        [DataMember(Name = "totalReceived", IsRequired = true, EmitDefaultValue = false)]
        public string TotalReceived { get; set; }

        /// <summary>
        /// Defines the total currency spent from the Wallet.
        /// </summary>
        /// <value>Defines the total currency spent from the Wallet.</value>
        [DataMember(Name = "totalSpent", IsRequired = true, EmitDefaultValue = false)]
        public string TotalSpent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetHDWalletXPubYPubZPubDetailsRI {\n");
            sb.Append("  ConfirmedBalance: ").Append(ConfirmedBalance).Append("\n");
            sb.Append("  TotalReceived: ").Append(TotalReceived).Append("\n");
            sb.Append("  TotalSpent: ").Append(TotalSpent).Append("\n");
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
            return this.Equals(input as GetHDWalletXPubYPubZPubDetailsRI);
        }

        /// <summary>
        /// Returns true if GetHDWalletXPubYPubZPubDetailsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetHDWalletXPubYPubZPubDetailsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetHDWalletXPubYPubZPubDetailsRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConfirmedBalance == input.ConfirmedBalance ||
                    (this.ConfirmedBalance != null &&
                    this.ConfirmedBalance.Equals(input.ConfirmedBalance))
                ) && 
                (
                    this.TotalReceived == input.TotalReceived ||
                    (this.TotalReceived != null &&
                    this.TotalReceived.Equals(input.TotalReceived))
                ) && 
                (
                    this.TotalSpent == input.TotalSpent ||
                    (this.TotalSpent != null &&
                    this.TotalSpent.Equals(input.TotalSpent))
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
                if (this.ConfirmedBalance != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmedBalance.GetHashCode();
                }
                if (this.TotalReceived != null)
                {
                    hashCode = (hashCode * 59) + this.TotalReceived.GetHashCode();
                }
                if (this.TotalSpent != null)
                {
                    hashCode = (hashCode * 59) + this.TotalSpent.GetHashCode();
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
