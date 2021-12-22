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
    /// NewConfirmedTokensTransactionsAndEachConfirmationRI
    /// </summary>
    [DataContract(Name = "NewConfirmedTokensTransactionsAndEachConfirmationRI")]
    public partial class NewConfirmedTokensTransactionsAndEachConfirmationRI : IEquatable<NewConfirmedTokensTransactionsAndEachConfirmationRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedTokensTransactionsAndEachConfirmationRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewConfirmedTokensTransactionsAndEachConfirmationRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedTokensTransactionsAndEachConfirmationRI" /> class.
        /// </summary>
        /// <param name="address">Represents the address of the transaction, per which the result is returned. (required).</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. (required).</param>
        /// <param name="confirmationsCount">Represents the number of confirmations, i.e. the amount of blocks that have been built on top of this block..</param>
        /// <param name="createdTimestamp">Defines the specific time/date when the subscription was created in Unix Timestamp. (required).</param>
        /// <param name="eventType">Defines the type of the specific event available for the customer to subscribe to for callback notification. (required).</param>
        /// <param name="referenceId">Represents a unique ID used to reference the specific callback subscription. (required).</param>
        public NewConfirmedTokensTransactionsAndEachConfirmationRI(string address = default(string), string callbackUrl = default(string), int confirmationsCount = default(int), int createdTimestamp = default(int), string eventType = default(string), string referenceId = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null) {
                throw new ArgumentNullException("address is a required property for NewConfirmedTokensTransactionsAndEachConfirmationRI and cannot be null");
            }
            this.Address = address;
            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null) {
                throw new ArgumentNullException("callbackUrl is a required property for NewConfirmedTokensTransactionsAndEachConfirmationRI and cannot be null");
            }
            this.CallbackUrl = callbackUrl;
            this.CreatedTimestamp = createdTimestamp;
            // to ensure "eventType" is required (not null)
            if (eventType == null) {
                throw new ArgumentNullException("eventType is a required property for NewConfirmedTokensTransactionsAndEachConfirmationRI and cannot be null");
            }
            this.EventType = eventType;
            // to ensure "referenceId" is required (not null)
            if (referenceId == null) {
                throw new ArgumentNullException("referenceId is a required property for NewConfirmedTokensTransactionsAndEachConfirmationRI and cannot be null");
            }
            this.ReferenceId = referenceId;
            this.ConfirmationsCount = confirmationsCount;
        }

        /// <summary>
        /// Represents the address of the transaction, per which the result is returned.
        /// </summary>
        /// <value>Represents the address of the transaction, per which the result is returned.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs.
        /// </summary>
        /// <value>Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs.</value>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Represents the number of confirmations, i.e. the amount of blocks that have been built on top of this block.
        /// </summary>
        /// <value>Represents the number of confirmations, i.e. the amount of blocks that have been built on top of this block.</value>
        [DataMember(Name = "confirmationsCount", EmitDefaultValue = false)]
        public int ConfirmationsCount { get; set; }

        /// <summary>
        /// Defines the specific time/date when the subscription was created in Unix Timestamp.
        /// </summary>
        /// <value>Defines the specific time/date when the subscription was created in Unix Timestamp.</value>
        [DataMember(Name = "createdTimestamp", IsRequired = true, EmitDefaultValue = false)]
        public int CreatedTimestamp { get; set; }

        /// <summary>
        /// Defines the type of the specific event available for the customer to subscribe to for callback notification.
        /// </summary>
        /// <value>Defines the type of the specific event available for the customer to subscribe to for callback notification.</value>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = false)]
        public string EventType { get; set; }

        /// <summary>
        /// Represents a unique ID used to reference the specific callback subscription.
        /// </summary>
        /// <value>Represents a unique ID used to reference the specific callback subscription.</value>
        [DataMember(Name = "referenceId", IsRequired = true, EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewConfirmedTokensTransactionsAndEachConfirmationRI {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  ConfirmationsCount: ").Append(ConfirmationsCount).Append("\n");
            sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
            return this.Equals(input as NewConfirmedTokensTransactionsAndEachConfirmationRI);
        }

        /// <summary>
        /// Returns true if NewConfirmedTokensTransactionsAndEachConfirmationRI instances are equal
        /// </summary>
        /// <param name="input">Instance of NewConfirmedTokensTransactionsAndEachConfirmationRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewConfirmedTokensTransactionsAndEachConfirmationRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.ConfirmationsCount == input.ConfirmationsCount ||
                    this.ConfirmationsCount.Equals(input.ConfirmationsCount)
                ) && 
                (
                    this.CreatedTimestamp == input.CreatedTimestamp ||
                    this.CreatedTimestamp.Equals(input.CreatedTimestamp)
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConfirmationsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedTimestamp.GetHashCode();
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.ReferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceId.GetHashCode();
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
