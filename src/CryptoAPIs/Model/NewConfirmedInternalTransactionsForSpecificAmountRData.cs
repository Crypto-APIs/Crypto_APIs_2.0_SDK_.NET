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
    /// NewConfirmedInternalTransactionsForSpecificAmountRData
    /// </summary>
    [DataContract(Name = "NewConfirmedInternalTransactionsForSpecificAmountR_data")]
    public partial class NewConfirmedInternalTransactionsForSpecificAmountRData : IEquatable<NewConfirmedInternalTransactionsForSpecificAmountRData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedInternalTransactionsForSpecificAmountRData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewConfirmedInternalTransactionsForSpecificAmountRData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedInternalTransactionsForSpecificAmountRData" /> class.
        /// </summary>
        /// <param name="item">item (required).</param>
        public NewConfirmedInternalTransactionsForSpecificAmountRData(NewConfirmedInternalTransactionsForSpecificAmountRI item = default(NewConfirmedInternalTransactionsForSpecificAmountRI))
        {
            // to ensure "item" is required (not null)
            if (item == null)
            {
                throw new ArgumentNullException("item is a required property for NewConfirmedInternalTransactionsForSpecificAmountRData and cannot be null");
            }
            this.Item = item;
        }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", IsRequired = true, EmitDefaultValue = false)]
        public NewConfirmedInternalTransactionsForSpecificAmountRI Item { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewConfirmedInternalTransactionsForSpecificAmountRData {\n");
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
            return this.Equals(input as NewConfirmedInternalTransactionsForSpecificAmountRData);
        }

        /// <summary>
        /// Returns true if NewConfirmedInternalTransactionsForSpecificAmountRData instances are equal
        /// </summary>
        /// <param name="input">Instance of NewConfirmedInternalTransactionsForSpecificAmountRData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewConfirmedInternalTransactionsForSpecificAmountRData input)
        {
            if (input == null)
            {
                return false;
            }
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
                {
                    hashCode = (hashCode * 59) + this.Item.GetHashCode();
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
