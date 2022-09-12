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
    /// BannedIpAddressDetailsInner
    /// </summary>
    [DataContract(Name = "BannedIpAddress_details_inner")]
    public partial class BannedIpAddressDetailsInner : IEquatable<BannedIpAddressDetailsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BannedIpAddressDetailsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BannedIpAddressDetailsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BannedIpAddressDetailsInner" /> class.
        /// </summary>
        /// <param name="attribute">Specifies an attribute of the error by name. (required).</param>
        /// <param name="message">Specifies the details of an attribute as part from the error. (required).</param>
        public BannedIpAddressDetailsInner(string attribute = default(string), string message = default(string))
        {
            // to ensure "attribute" is required (not null)
            if (attribute == null)
            {
                throw new ArgumentNullException("attribute is a required property for BannedIpAddressDetailsInner and cannot be null");
            }
            this.Attribute = attribute;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for BannedIpAddressDetailsInner and cannot be null");
            }
            this.Message = message;
        }

        /// <summary>
        /// Specifies an attribute of the error by name.
        /// </summary>
        /// <value>Specifies an attribute of the error by name.</value>
        [DataMember(Name = "attribute", IsRequired = true, EmitDefaultValue = false)]
        public string Attribute { get; set; }

        /// <summary>
        /// Specifies the details of an attribute as part from the error.
        /// </summary>
        /// <value>Specifies the details of an attribute as part from the error.</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BannedIpAddressDetailsInner {\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as BannedIpAddressDetailsInner);
        }

        /// <summary>
        /// Returns true if BannedIpAddressDetailsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of BannedIpAddressDetailsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BannedIpAddressDetailsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attribute == input.Attribute ||
                    (this.Attribute != null &&
                    this.Attribute.Equals(input.Attribute))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Attribute != null)
                {
                    hashCode = (hashCode * 59) + this.Attribute.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
