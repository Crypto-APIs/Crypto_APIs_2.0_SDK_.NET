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
    /// NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem
    /// </summary>
    [DataContract(Name = "NewConfirmedInternalTransactionsAndEachConfirmationRB_data_item")]
    public partial class NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem : IEquatable<NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem" /> class.
        /// </summary>
        /// <param name="address">Defines the specific address of the internal transaction. (required).</param>
        /// <param name="allowDuplicates">Specifies a flag that permits or denies the creation of duplicate addresses. (required) (default to false).</param>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. (required).</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. (required).</param>
        /// <param name="confirmationsCount">Represents the number of confirmations, i.e. the amount of blocks that have been built on top of this block. (required).</param>
        public NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem(string address = default(string), bool allowDuplicates = false, string callbackSecretKey = default(string), string callbackUrl = default(string), int confirmationsCount = default(int))
        {
            // to ensure "address" is required (not null)
            this.Address = address ?? throw new ArgumentNullException("address is a required property for NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem and cannot be null");
            this.AllowDuplicates = allowDuplicates;
            // to ensure "callbackSecretKey" is required (not null)
            this.CallbackSecretKey = callbackSecretKey ?? throw new ArgumentNullException("callbackSecretKey is a required property for NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem and cannot be null");
            // to ensure "callbackUrl" is required (not null)
            this.CallbackUrl = callbackUrl ?? throw new ArgumentNullException("callbackUrl is a required property for NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem and cannot be null");
            this.ConfirmationsCount = confirmationsCount;
        }

        /// <summary>
        /// Defines the specific address of the internal transaction.
        /// </summary>
        /// <value>Defines the specific address of the internal transaction.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Specifies a flag that permits or denies the creation of duplicate addresses.
        /// </summary>
        /// <value>Specifies a flag that permits or denies the creation of duplicate addresses.</value>
        [DataMember(Name = "allowDuplicates", IsRequired = true, EmitDefaultValue = true)]
        public bool AllowDuplicates { get; set; }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs.
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs.</value>
        [DataMember(Name = "callbackSecretKey", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

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
        [DataMember(Name = "confirmationsCount", IsRequired = true, EmitDefaultValue = false)]
        public int ConfirmationsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AllowDuplicates: ").Append(AllowDuplicates).Append("\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  ConfirmationsCount: ").Append(ConfirmationsCount).Append("\n");
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
            return this.Equals(input as NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem);
        }

        /// <summary>
        /// Returns true if NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewConfirmedInternalTransactionsAndEachConfirmationRBDataItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AllowDuplicates == input.AllowDuplicates ||
                    this.AllowDuplicates.Equals(input.AllowDuplicates)
                ) && 
                (
                    this.CallbackSecretKey == input.CallbackSecretKey ||
                    (this.CallbackSecretKey != null &&
                    this.CallbackSecretKey.Equals(input.CallbackSecretKey))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.ConfirmationsCount == input.ConfirmationsCount ||
                    this.ConfirmationsCount.Equals(input.ConfirmationsCount)
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
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                hashCode = hashCode * 59 + this.AllowDuplicates.GetHashCode();
                if (this.CallbackSecretKey != null)
                    hashCode = hashCode * 59 + this.CallbackSecretKey.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                hashCode = hashCode * 59 + this.ConfirmationsCount.GetHashCode();
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
