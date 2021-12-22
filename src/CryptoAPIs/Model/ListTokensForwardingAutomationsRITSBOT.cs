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
    /// Bitcoin Omni Token
    /// </summary>
    [DataContract(Name = "ListTokensForwardingAutomationsRITSBOT")]
    public partial class ListTokensForwardingAutomationsRITSBOT : IEquatable<ListTokensForwardingAutomationsRITSBOT>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTokensForwardingAutomationsRITSBOT" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListTokensForwardingAutomationsRITSBOT() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTokensForwardingAutomationsRITSBOT" /> class.
        /// </summary>
        /// <param name="propertyId">Defines the Property ID of the Omni Layer token. (required).</param>
        public ListTokensForwardingAutomationsRITSBOT(int propertyId = default(int))
        {
            this.PropertyId = propertyId;
        }

        /// <summary>
        /// Defines the Property ID of the Omni Layer token.
        /// </summary>
        /// <value>Defines the Property ID of the Omni Layer token.</value>
        [DataMember(Name = "propertyId", IsRequired = true, EmitDefaultValue = false)]
        public int PropertyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListTokensForwardingAutomationsRITSBOT {\n");
            sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
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
            return this.Equals(input as ListTokensForwardingAutomationsRITSBOT);
        }

        /// <summary>
        /// Returns true if ListTokensForwardingAutomationsRITSBOT instances are equal
        /// </summary>
        /// <param name="input">Instance of ListTokensForwardingAutomationsRITSBOT to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListTokensForwardingAutomationsRITSBOT input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PropertyId == input.PropertyId ||
                    this.PropertyId.Equals(input.PropertyId)
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
                hashCode = (hashCode * 59) + this.PropertyId.GetHashCode();
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
