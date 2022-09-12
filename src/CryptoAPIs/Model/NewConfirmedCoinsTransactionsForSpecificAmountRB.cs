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
    /// NewConfirmedCoinsTransactionsForSpecificAmountRB
    /// </summary>
    [DataContract(Name = "NewConfirmedCoinsTransactionsForSpecificAmountRB")]
    public partial class NewConfirmedCoinsTransactionsForSpecificAmountRB : IEquatable<NewConfirmedCoinsTransactionsForSpecificAmountRB>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedCoinsTransactionsForSpecificAmountRB" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewConfirmedCoinsTransactionsForSpecificAmountRB() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedCoinsTransactionsForSpecificAmountRB" /> class.
        /// </summary>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user..</param>
        /// <param name="data">data (required).</param>
        public NewConfirmedCoinsTransactionsForSpecificAmountRB(string context = default(string), NewConfirmedCoinsTransactionsForSpecificAmountRBData data = default(NewConfirmedCoinsTransactionsForSpecificAmountRBData))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for NewConfirmedCoinsTransactionsForSpecificAmountRB and cannot be null");
            }
            this.Data = data;
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
        public NewConfirmedCoinsTransactionsForSpecificAmountRBData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewConfirmedCoinsTransactionsForSpecificAmountRB {\n");
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
            return this.Equals(input as NewConfirmedCoinsTransactionsForSpecificAmountRB);
        }

        /// <summary>
        /// Returns true if NewConfirmedCoinsTransactionsForSpecificAmountRB instances are equal
        /// </summary>
        /// <param name="input">Instance of NewConfirmedCoinsTransactionsForSpecificAmountRB to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewConfirmedCoinsTransactionsForSpecificAmountRB input)
        {
            if (input == null)
            {
                return false;
            }
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
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
