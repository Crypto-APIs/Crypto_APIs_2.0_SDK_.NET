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
    /// AddTokensToExistingFromAddressRBDataItem
    /// </summary>
    [DataContract(Name = "AddTokensToExistingFromAddressRB_data_item")]
    public partial class AddTokensToExistingFromAddressRBDataItem : IEquatable<AddTokensToExistingFromAddressRBDataItem>, IValidatableObject
    {
        /// <summary>
        /// Represents the fee priority of the automation, whether it is \&quot;SLOW\&quot;, \&quot;STANDARD\&quot; or \&quot;FAST\&quot;.
        /// </summary>
        /// <value>Represents the fee priority of the automation, whether it is \&quot;SLOW\&quot;, \&quot;STANDARD\&quot; or \&quot;FAST\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeePriorityEnum
        {
            /// <summary>
            /// Enum Slow for value: slow
            /// </summary>
            [EnumMember(Value = "slow")]
            Slow = 1,

            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 2,

            /// <summary>
            /// Enum Fast for value: fast
            /// </summary>
            [EnumMember(Value = "fast")]
            Fast = 3

        }


        /// <summary>
        /// Represents the fee priority of the automation, whether it is \&quot;SLOW\&quot;, \&quot;STANDARD\&quot; or \&quot;FAST\&quot;.
        /// </summary>
        /// <value>Represents the fee priority of the automation, whether it is \&quot;SLOW\&quot;, \&quot;STANDARD\&quot; or \&quot;FAST\&quot;.</value>
        [DataMember(Name = "feePriority", IsRequired = true, EmitDefaultValue = false)]
        public FeePriorityEnum FeePriority { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTokensToExistingFromAddressRBDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddTokensToExistingFromAddressRBDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTokensToExistingFromAddressRBDataItem" /> class.
        /// </summary>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security)..</param>
        /// <param name="callbackUrl">Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;. (required).</param>
        /// <param name="confirmationsCount">Represents the number of confirmations, i.e. the amount of blocks that have been built on top of this block. (required).</param>
        /// <param name="feePriority">Represents the fee priority of the automation, whether it is \&quot;SLOW\&quot;, \&quot;STANDARD\&quot; or \&quot;FAST\&quot;. (required).</param>
        /// <param name="fromAddress">Represents the hash of the address that forwards the tokens. (required).</param>
        /// <param name="minimumTransferAmount">Represents the minimum transfer amount of the currency in the &#x60;fromAddress&#x60; that can be allowed for an automatic forwarding. (required).</param>
        /// <param name="toAddress">Represents the hash of the address the currency is forwarded to. (required).</param>
        /// <param name="tokenData">tokenData (required).</param>
        public AddTokensToExistingFromAddressRBDataItem(string callbackSecretKey = default(string), string callbackUrl = default(string), int confirmationsCount = default(int), FeePriorityEnum feePriority = default(FeePriorityEnum), string fromAddress = default(string), string minimumTransferAmount = default(string), string toAddress = default(string), AddTokensToExistingFromAddressRBTokenData tokenData = default(AddTokensToExistingFromAddressRBTokenData))
        {
            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null)
            {
                throw new ArgumentNullException("callbackUrl is a required property for AddTokensToExistingFromAddressRBDataItem and cannot be null");
            }
            this.CallbackUrl = callbackUrl;
            this.ConfirmationsCount = confirmationsCount;
            this.FeePriority = feePriority;
            // to ensure "fromAddress" is required (not null)
            if (fromAddress == null)
            {
                throw new ArgumentNullException("fromAddress is a required property for AddTokensToExistingFromAddressRBDataItem and cannot be null");
            }
            this.FromAddress = fromAddress;
            // to ensure "minimumTransferAmount" is required (not null)
            if (minimumTransferAmount == null)
            {
                throw new ArgumentNullException("minimumTransferAmount is a required property for AddTokensToExistingFromAddressRBDataItem and cannot be null");
            }
            this.MinimumTransferAmount = minimumTransferAmount;
            // to ensure "toAddress" is required (not null)
            if (toAddress == null)
            {
                throw new ArgumentNullException("toAddress is a required property for AddTokensToExistingFromAddressRBDataItem and cannot be null");
            }
            this.ToAddress = toAddress;
            // to ensure "tokenData" is required (not null)
            if (tokenData == null)
            {
                throw new ArgumentNullException("tokenData is a required property for AddTokensToExistingFromAddressRBDataItem and cannot be null");
            }
            this.TokenData = tokenData;
            this.CallbackSecretKey = callbackSecretKey;
        }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs. For more information please see our [Documentation](https://developers.cryptoapis.io/technical-documentation/general-information/callbacks#callback-security).</value>
        [DataMember(Name = "callbackSecretKey", EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.
        /// </summary>
        /// <value>Represents the URL that is set by the customer where the callback will be received at. The callback notification will be received only if and when the event occurs. &#x60;We support ONLY httpS type of protocol&#x60;.</value>
        [DataMember(Name = "callbackUrl", IsRequired = true, EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Represents the number of confirmations, i.e. the amount of blocks that have been built on top of this block.
        /// </summary>
        /// <value>Represents the number of confirmations, i.e. the amount of blocks that have been built on top of this block.</value>
        [DataMember(Name = "confirmationsCount", IsRequired = true, EmitDefaultValue = false)]
        public int ConfirmationsCount { get; set; }

        /// <summary>
        /// Represents the hash of the address that forwards the tokens.
        /// </summary>
        /// <value>Represents the hash of the address that forwards the tokens.</value>
        [DataMember(Name = "fromAddress", IsRequired = true, EmitDefaultValue = false)]
        public string FromAddress { get; set; }

        /// <summary>
        /// Represents the minimum transfer amount of the currency in the &#x60;fromAddress&#x60; that can be allowed for an automatic forwarding.
        /// </summary>
        /// <value>Represents the minimum transfer amount of the currency in the &#x60;fromAddress&#x60; that can be allowed for an automatic forwarding.</value>
        [DataMember(Name = "minimumTransferAmount", IsRequired = true, EmitDefaultValue = false)]
        public string MinimumTransferAmount { get; set; }

        /// <summary>
        /// Represents the hash of the address the currency is forwarded to.
        /// </summary>
        /// <value>Represents the hash of the address the currency is forwarded to.</value>
        [DataMember(Name = "toAddress", IsRequired = true, EmitDefaultValue = false)]
        public string ToAddress { get; set; }

        /// <summary>
        /// Gets or Sets TokenData
        /// </summary>
        [DataMember(Name = "tokenData", IsRequired = true, EmitDefaultValue = false)]
        public AddTokensToExistingFromAddressRBTokenData TokenData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddTokensToExistingFromAddressRBDataItem {\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  ConfirmationsCount: ").Append(ConfirmationsCount).Append("\n");
            sb.Append("  FeePriority: ").Append(FeePriority).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  MinimumTransferAmount: ").Append(MinimumTransferAmount).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  TokenData: ").Append(TokenData).Append("\n");
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
            return this.Equals(input as AddTokensToExistingFromAddressRBDataItem);
        }

        /// <summary>
        /// Returns true if AddTokensToExistingFromAddressRBDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AddTokensToExistingFromAddressRBDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddTokensToExistingFromAddressRBDataItem input)
        {
            if (input == null)
            {
                return false;
            }
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
                    this.ConfirmationsCount == input.ConfirmationsCount ||
                    this.ConfirmationsCount.Equals(input.ConfirmationsCount)
                ) && 
                (
                    this.FeePriority == input.FeePriority ||
                    this.FeePriority.Equals(input.FeePriority)
                ) && 
                (
                    this.FromAddress == input.FromAddress ||
                    (this.FromAddress != null &&
                    this.FromAddress.Equals(input.FromAddress))
                ) && 
                (
                    this.MinimumTransferAmount == input.MinimumTransferAmount ||
                    (this.MinimumTransferAmount != null &&
                    this.MinimumTransferAmount.Equals(input.MinimumTransferAmount))
                ) && 
                (
                    this.ToAddress == input.ToAddress ||
                    (this.ToAddress != null &&
                    this.ToAddress.Equals(input.ToAddress))
                ) && 
                (
                    this.TokenData == input.TokenData ||
                    (this.TokenData != null &&
                    this.TokenData.Equals(input.TokenData))
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
                {
                    hashCode = (hashCode * 59) + this.CallbackSecretKey.GetHashCode();
                }
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConfirmationsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.FeePriority.GetHashCode();
                if (this.FromAddress != null)
                {
                    hashCode = (hashCode * 59) + this.FromAddress.GetHashCode();
                }
                if (this.MinimumTransferAmount != null)
                {
                    hashCode = (hashCode * 59) + this.MinimumTransferAmount.GetHashCode();
                }
                if (this.ToAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ToAddress.GetHashCode();
                }
                if (this.TokenData != null)
                {
                    hashCode = (hashCode * 59) + this.TokenData.GetHashCode();
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
