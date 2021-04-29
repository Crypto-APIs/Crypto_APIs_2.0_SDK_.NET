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
    /// ListTransactionsByBlockHashResponseData
    /// </summary>
    [DataContract(Name = "ListTransactionsByBlockHashResponse_data")]
    public partial class ListTransactionsByBlockHashResponseData : IEquatable<ListTransactionsByBlockHashResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHashResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListTransactionsByBlockHashResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListTransactionsByBlockHashResponseData" /> class.
        /// </summary>
        /// <param name="offset">The starting index of the response items, i.e. where the response should start listing the returned items. (required).</param>
        /// <param name="limit">Defines how many items should be returned in the response per page basis. (required).</param>
        /// <param name="total">Defines the total number of items returned in the response. (required).</param>
        /// <param name="items">items (required).</param>
        public ListTransactionsByBlockHashResponseData(int offset = default(int), int limit = default(int), int total = default(int), List<ListTransactionsByBlockHashResponseItem> items = default(List<ListTransactionsByBlockHashResponseItem>))
        {
            this.Offset = offset;
            this.Limit = limit;
            this.Total = total;
            // to ensure "items" is required (not null)
            this.Items = items ?? throw new ArgumentNullException("items is a required property for ListTransactionsByBlockHashResponseData and cannot be null");
        }

        /// <summary>
        /// The starting index of the response items, i.e. where the response should start listing the returned items.
        /// </summary>
        /// <value>The starting index of the response items, i.e. where the response should start listing the returned items.</value>
        [DataMember(Name = "offset", IsRequired = true, EmitDefaultValue = false)]
        public int Offset { get; set; }

        /// <summary>
        /// Defines how many items should be returned in the response per page basis.
        /// </summary>
        /// <value>Defines how many items should be returned in the response per page basis.</value>
        [DataMember(Name = "limit", IsRequired = true, EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Defines the total number of items returned in the response.
        /// </summary>
        /// <value>Defines the total number of items returned in the response.</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = false)]
        public List<ListTransactionsByBlockHashResponseItem> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTransactionsByBlockHashResponseData {\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as ListTransactionsByBlockHashResponseData);
        }

        /// <summary>
        /// Returns true if ListTransactionsByBlockHashResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of ListTransactionsByBlockHashResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListTransactionsByBlockHashResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Offset == input.Offset ||
                    this.Offset.Equals(input.Offset)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                hashCode = hashCode * 59 + this.Offset.GetHashCode();
                hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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