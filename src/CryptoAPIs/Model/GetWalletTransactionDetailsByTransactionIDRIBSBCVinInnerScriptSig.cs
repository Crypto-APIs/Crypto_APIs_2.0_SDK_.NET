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
    /// Object representation of the script
    /// </summary>
    [DataContract(Name = "GetWalletTransactionDetailsByTransactionIDRIBSBC_vin_inner_scriptSig")]
    public partial class GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig : IEquatable<GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig" /> class.
        /// </summary>
        /// <param name="asm">The asm strands for assembly, which is the symbolic representation of the Bitcoin&#39;s Script language op-codes. (required).</param>
        /// <param name="hex">Represents the hex of the public key of the address. (required).</param>
        /// <param name="type">Represents the script type of the reference transaction identifier. (required).</param>
        public GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig(string asm = default(string), string hex = default(string), string type = default(string))
        {
            // to ensure "asm" is required (not null)
            if (asm == null)
            {
                throw new ArgumentNullException("asm is a required property for GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig and cannot be null");
            }
            this.Asm = asm;
            // to ensure "hex" is required (not null)
            if (hex == null)
            {
                throw new ArgumentNullException("hex is a required property for GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig and cannot be null");
            }
            this.Hex = hex;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// The asm strands for assembly, which is the symbolic representation of the Bitcoin&#39;s Script language op-codes.
        /// </summary>
        /// <value>The asm strands for assembly, which is the symbolic representation of the Bitcoin&#39;s Script language op-codes.</value>
        [DataMember(Name = "asm", IsRequired = true, EmitDefaultValue = false)]
        public string Asm { get; set; }

        /// <summary>
        /// Represents the hex of the public key of the address.
        /// </summary>
        /// <value>Represents the hex of the public key of the address.</value>
        [DataMember(Name = "hex", IsRequired = true, EmitDefaultValue = false)]
        public string Hex { get; set; }

        /// <summary>
        /// Represents the script type of the reference transaction identifier.
        /// </summary>
        /// <value>Represents the script type of the reference transaction identifier.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig {\n");
            sb.Append("  Asm: ").Append(Asm).Append("\n");
            sb.Append("  Hex: ").Append(Hex).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig);
        }

        /// <summary>
        /// Returns true if GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWalletTransactionDetailsByTransactionIDRIBSBCVinInnerScriptSig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Asm == input.Asm ||
                    (this.Asm != null &&
                    this.Asm.Equals(input.Asm))
                ) && 
                (
                    this.Hex == input.Hex ||
                    (this.Hex != null &&
                    this.Hex.Equals(input.Hex))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Asm != null)
                {
                    hashCode = (hashCode * 59) + this.Asm.GetHashCode();
                }
                if (this.Hex != null)
                {
                    hashCode = (hashCode * 59) + this.Hex.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
