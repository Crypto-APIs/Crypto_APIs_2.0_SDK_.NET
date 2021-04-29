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
    /// NewUnconfirmedCoinsTransactionsRequestBody
    /// </summary>
    [DataContract(Name = "NewUnconfirmedCoinsTransactionsRequestBody")]
    public partial class NewUnconfirmedCoinsTransactionsRequestBody : IEquatable<NewUnconfirmedCoinsTransactionsRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewUnconfirmedCoinsTransactionsRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewUnconfirmedCoinsTransactionsRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewUnconfirmedCoinsTransactionsRequestBody" /> class.
        /// </summary>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user..</param>
        /// <param name="data">data (required).</param>
        public NewUnconfirmedCoinsTransactionsRequestBody(string context = default(string), NewUnconfirmedCoinsTransactionsRequestBodyData data = default(NewUnconfirmedCoinsTransactionsRequestBodyData))
        {
            // to ensure "data" is required (not null)
            this.Data = data ?? throw new ArgumentNullException("data is a required property for NewUnconfirmedCoinsTransactionsRequestBody and cannot be null");
            this.Context = context;
        }

        /// <summary>
        /// In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user.
        /// </summary>
        /// <value>In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user.</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public string Context { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public NewUnconfirmedCoinsTransactionsRequestBodyData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewUnconfirmedCoinsTransactionsRequestBody {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as NewUnconfirmedCoinsTransactionsRequestBody);
        }

        /// <summary>
        /// Returns true if NewUnconfirmedCoinsTransactionsRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of NewUnconfirmedCoinsTransactionsRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewUnconfirmedCoinsTransactionsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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