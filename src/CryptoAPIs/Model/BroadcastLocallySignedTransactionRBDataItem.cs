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
    /// BroadcastLocallySignedTransactionRBDataItem
    /// </summary>
    [DataContract(Name = "BroadcastLocallySignedTransactionRB_data_item")]
    public partial class BroadcastLocallySignedTransactionRBDataItem : IEquatable<BroadcastLocallySignedTransactionRBDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastLocallySignedTransactionRBDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BroadcastLocallySignedTransactionRBDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastLocallySignedTransactionRBDataItem" /> class.
        /// </summary>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs..</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. (required).</param>
        /// <param name="signedTransactionHex">Represents the signed transaction&#39;s specific hex. (required).</param>
        public BroadcastLocallySignedTransactionRBDataItem(string callbackSecretKey = default(string), string callbackUrl = default(string), string signedTransactionHex = default(string))
        {
            // to ensure "callbackUrl" is required (not null)
            this.CallbackUrl = callbackUrl ?? throw new ArgumentNullException("callbackUrl is a required property for BroadcastLocallySignedTransactionRBDataItem and cannot be null");
            // to ensure "signedTransactionHex" is required (not null)
            this.SignedTransactionHex = signedTransactionHex ?? throw new ArgumentNullException("signedTransactionHex is a required property for BroadcastLocallySignedTransactionRBDataItem and cannot be null");
            this.CallbackSecretKey = callbackSecretKey;
        }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs.
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs.</value>
        [DataMember(Name = "callbackSecretKey", EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs.
        /// </summary>
        /// <value>Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs.</value>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Represents the signed transaction&#39;s specific hex.
        /// </summary>
        /// <value>Represents the signed transaction&#39;s specific hex.</value>
        [DataMember(Name = "signedTransactionHex", IsRequired = true, EmitDefaultValue = false)]
        public string SignedTransactionHex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BroadcastLocallySignedTransactionRBDataItem {\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  SignedTransactionHex: ").Append(SignedTransactionHex).Append("\n");
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
            return this.Equals(input as BroadcastLocallySignedTransactionRBDataItem);
        }

        /// <summary>
        /// Returns true if BroadcastLocallySignedTransactionRBDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of BroadcastLocallySignedTransactionRBDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BroadcastLocallySignedTransactionRBDataItem input)
        {
            if (input == null)
                return false;

            return 
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
                    this.SignedTransactionHex == input.SignedTransactionHex ||
                    (this.SignedTransactionHex != null &&
                    this.SignedTransactionHex.Equals(input.SignedTransactionHex))
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
                if (this.CallbackSecretKey != null)
                    hashCode = hashCode * 59 + this.CallbackSecretKey.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.SignedTransactionHex != null)
                    hashCode = hashCode * 59 + this.SignedTransactionHex.GetHashCode();
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