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
    /// OMNI
    /// </summary>
    [DataContract(Name = "AddressTokensTransactionConfirmedEachConfirmationOmni")]
    public partial class AddressTokensTransactionConfirmedEachConfirmationOmni : IEquatable<AddressTokensTransactionConfirmedEachConfirmationOmni>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedEachConfirmationOmni" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressTokensTransactionConfirmedEachConfirmationOmni() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedEachConfirmationOmni" /> class.
        /// </summary>
        /// <param name="name">Specifies the name of the token. (required).</param>
        /// <param name="propertyId">Defines the ID of the property for Omni Layer. (required).</param>
        /// <param name="transactionType">Defines the type of the transaction. (required).</param>
        /// <param name="createdByTransactionId">The transaction ID used to create the token. (required).</param>
        /// <param name="amount">Defines the amount of tokens sent with the confirmed transaction. (required).</param>
        public AddressTokensTransactionConfirmedEachConfirmationOmni(string name = default(string), string propertyId = default(string), string transactionType = default(string), string createdByTransactionId = default(string), string amount = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AddressTokensTransactionConfirmedEachConfirmationOmni and cannot be null");
            }
            this.Name = name;
            // to ensure "propertyId" is required (not null)
            if (propertyId == null)
            {
                throw new ArgumentNullException("propertyId is a required property for AddressTokensTransactionConfirmedEachConfirmationOmni and cannot be null");
            }
            this.PropertyId = propertyId;
            // to ensure "transactionType" is required (not null)
            if (transactionType == null)
            {
                throw new ArgumentNullException("transactionType is a required property for AddressTokensTransactionConfirmedEachConfirmationOmni and cannot be null");
            }
            this.TransactionType = transactionType;
            // to ensure "createdByTransactionId" is required (not null)
            if (createdByTransactionId == null)
            {
                throw new ArgumentNullException("createdByTransactionId is a required property for AddressTokensTransactionConfirmedEachConfirmationOmni and cannot be null");
            }
            this.CreatedByTransactionId = createdByTransactionId;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for AddressTokensTransactionConfirmedEachConfirmationOmni and cannot be null");
            }
            this.Amount = amount;
        }

        /// <summary>
        /// Specifies the name of the token.
        /// </summary>
        /// <value>Specifies the name of the token.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Defines the ID of the property for Omni Layer.
        /// </summary>
        /// <value>Defines the ID of the property for Omni Layer.</value>
        [DataMember(Name = "propertyId", IsRequired = true, EmitDefaultValue = false)]
        public string PropertyId { get; set; }

        /// <summary>
        /// Defines the type of the transaction.
        /// </summary>
        /// <value>Defines the type of the transaction.</value>
        [DataMember(Name = "transactionType", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// The transaction ID used to create the token.
        /// </summary>
        /// <value>The transaction ID used to create the token.</value>
        [DataMember(Name = "createdByTransactionId", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedByTransactionId { get; set; }

        /// <summary>
        /// Defines the amount of tokens sent with the confirmed transaction.
        /// </summary>
        /// <value>Defines the amount of tokens sent with the confirmed transaction.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressTokensTransactionConfirmedEachConfirmationOmni {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  CreatedByTransactionId: ").Append(CreatedByTransactionId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as AddressTokensTransactionConfirmedEachConfirmationOmni);
        }

        /// <summary>
        /// Returns true if AddressTokensTransactionConfirmedEachConfirmationOmni instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressTokensTransactionConfirmedEachConfirmationOmni to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressTokensTransactionConfirmedEachConfirmationOmni input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PropertyId == input.PropertyId ||
                    (this.PropertyId != null &&
                    this.PropertyId.Equals(input.PropertyId))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.CreatedByTransactionId == input.CreatedByTransactionId ||
                    (this.CreatedByTransactionId != null &&
                    this.CreatedByTransactionId.Equals(input.CreatedByTransactionId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PropertyId != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyId.GetHashCode();
                }
                if (this.TransactionType != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionType.GetHashCode();
                }
                if (this.CreatedByTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedByTransactionId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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
