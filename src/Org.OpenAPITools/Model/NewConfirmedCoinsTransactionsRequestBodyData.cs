/*
 * Crypto APIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: bizdev@cryptoapis.io
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// NewConfirmedCoinsTransactionsRequestBodyData
    /// </summary>
    [DataContract(Name = "NewConfirmedCoinsTransactionsRequestBody_data")]
    public partial class NewConfirmedCoinsTransactionsRequestBodyData : IEquatable<NewConfirmedCoinsTransactionsRequestBodyData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedCoinsTransactionsRequestBodyData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewConfirmedCoinsTransactionsRequestBodyData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedCoinsTransactionsRequestBodyData" /> class.
        /// </summary>
        /// <param name="item">item (required).</param>
        public NewConfirmedCoinsTransactionsRequestBodyData(NewConfirmedCoinsTransactionsRequestBodyDataItem item = default(NewConfirmedCoinsTransactionsRequestBodyDataItem))
        {
            // to ensure "item" is required (not null)
            this.Item = item ?? throw new ArgumentNullException("item is a required property for NewConfirmedCoinsTransactionsRequestBodyData and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", IsRequired = true, EmitDefaultValue = false)]
        public NewConfirmedCoinsTransactionsRequestBodyDataItem Item { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewConfirmedCoinsTransactionsRequestBodyData {\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
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
            return this.Equals(input as NewConfirmedCoinsTransactionsRequestBodyData);
        }

        /// <summary>
        /// Returns true if NewConfirmedCoinsTransactionsRequestBodyData instances are equal
        /// </summary>
        /// <param name="input">Instance of NewConfirmedCoinsTransactionsRequestBodyData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewConfirmedCoinsTransactionsRequestBodyData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
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
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}