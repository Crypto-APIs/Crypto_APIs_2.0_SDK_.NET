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
    /// CreateCoinsTransactionRequestFromAddressRI
    /// </summary>
    [DataContract(Name = "CreateCoinsTransactionRequestFromAddressRI")]
    public partial class CreateCoinsTransactionRequestFromAddressRI : IEquatable<CreateCoinsTransactionRequestFromAddressRI>, IValidatableObject
    {
        /// <summary>
        /// Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.
        /// </summary>
        /// <value>Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.</value>
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
        /// Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.
        /// </summary>
        /// <value>Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;.</value>
        [DataMember(Name = "feePriority", IsRequired = true, EmitDefaultValue = false)]
        public FeePriorityEnum FeePriority { get; set; }
        /// <summary>
        /// Defines the status of the transaction request, e.g. \&quot;created, \&quot;await_approval\&quot;, \&quot;pending\&quot;, \&quot;prepared\&quot;, \&quot;signed\&quot;, \&quot;broadcasted\&quot;, \&quot;success\&quot;, \&quot;failed\&quot;, \&quot;rejected\&quot;, mined\&quot;.
        /// </summary>
        /// <value>Defines the status of the transaction request, e.g. \&quot;created, \&quot;await_approval\&quot;, \&quot;pending\&quot;, \&quot;prepared\&quot;, \&quot;signed\&quot;, \&quot;broadcasted\&quot;, \&quot;success\&quot;, \&quot;failed\&quot;, \&quot;rejected\&quot;, mined\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionRequestStatusEnum
        {
            /// <summary>
            /// Enum Created for value: created
            /// </summary>
            [EnumMember(Value = "created")]
            Created = 1,

            /// <summary>
            /// Enum AwaitApproval for value: await-approval
            /// </summary>
            [EnumMember(Value = "await-approval")]
            AwaitApproval = 2,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 3,

            /// <summary>
            /// Enum Prepared for value: prepared
            /// </summary>
            [EnumMember(Value = "prepared")]
            Prepared = 4,

            /// <summary>
            /// Enum Signed for value: signed
            /// </summary>
            [EnumMember(Value = "signed")]
            Signed = 5,

            /// <summary>
            /// Enum Broadcasted for value: broadcasted
            /// </summary>
            [EnumMember(Value = "broadcasted")]
            Broadcasted = 6,

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 7,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 8,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 9,

            /// <summary>
            /// Enum Mined for value: mined
            /// </summary>
            [EnumMember(Value = "mined")]
            Mined = 10

        }


        /// <summary>
        /// Defines the status of the transaction request, e.g. \&quot;created, \&quot;await_approval\&quot;, \&quot;pending\&quot;, \&quot;prepared\&quot;, \&quot;signed\&quot;, \&quot;broadcasted\&quot;, \&quot;success\&quot;, \&quot;failed\&quot;, \&quot;rejected\&quot;, mined\&quot;.
        /// </summary>
        /// <value>Defines the status of the transaction request, e.g. \&quot;created, \&quot;await_approval\&quot;, \&quot;pending\&quot;, \&quot;prepared\&quot;, \&quot;signed\&quot;, \&quot;broadcasted\&quot;, \&quot;success\&quot;, \&quot;failed\&quot;, \&quot;rejected\&quot;, mined\&quot;.</value>
        [DataMember(Name = "transactionRequestStatus", IsRequired = true, EmitDefaultValue = false)]
        public TransactionRequestStatusEnum TransactionRequestStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCoinsTransactionRequestFromAddressRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCoinsTransactionRequestFromAddressRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCoinsTransactionRequestFromAddressRI" /> class.
        /// </summary>
        /// <param name="callbackSecretKey">Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs..</param>
        /// <param name="callbackUrl">Verified URL for sending callbacks.</param>
        /// <param name="feePriority">Represents the fee priority of the automation, whether it is \&quot;slow\&quot;, \&quot;standard\&quot; or \&quot;fast\&quot;. (required).</param>
        /// <param name="recipients">Defines the destination for the transaction, i.e. the recipient(s). (required).</param>
        /// <param name="senders">senders (required).</param>
        /// <param name="transactionRequestStatus">Defines the status of the transaction request, e.g. \&quot;created, \&quot;await_approval\&quot;, \&quot;pending\&quot;, \&quot;prepared\&quot;, \&quot;signed\&quot;, \&quot;broadcasted\&quot;, \&quot;success\&quot;, \&quot;failed\&quot;, \&quot;rejected\&quot;, mined\&quot;. (required).</param>
        public CreateCoinsTransactionRequestFromAddressRI(string callbackSecretKey = default(string), string callbackUrl = default(string), FeePriorityEnum feePriority = default(FeePriorityEnum), List<CreateCoinsTransactionRequestFromAddressRIRecipients> recipients = default(List<CreateCoinsTransactionRequestFromAddressRIRecipients>), CreateCoinsTransactionRequestFromAddressRISenders senders = default(CreateCoinsTransactionRequestFromAddressRISenders), TransactionRequestStatusEnum transactionRequestStatus = default(TransactionRequestStatusEnum))
        {
            this.FeePriority = feePriority;
            // to ensure "recipients" is required (not null)
            this.Recipients = recipients ?? throw new ArgumentNullException("recipients is a required property for CreateCoinsTransactionRequestFromAddressRI and cannot be null");
            // to ensure "senders" is required (not null)
            this.Senders = senders ?? throw new ArgumentNullException("senders is a required property for CreateCoinsTransactionRequestFromAddressRI and cannot be null");
            this.TransactionRequestStatus = transactionRequestStatus;
            this.CallbackSecretKey = callbackSecretKey;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs.
        /// </summary>
        /// <value>Represents the Secret Key value provided by the customer. This field is used for security purposes during the callback notification, in order to prove the sender of the callback as Crypto APIs.</value>
        [DataMember(Name = "callbackSecretKey", EmitDefaultValue = false)]
        public string CallbackSecretKey { get; set; }

        /// <summary>
        /// Verified URL for sending callbacks
        /// </summary>
        /// <value>Verified URL for sending callbacks</value>
        [DataMember(Name = "callbackUrl", EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Defines the destination for the transaction, i.e. the recipient(s).
        /// </summary>
        /// <value>Defines the destination for the transaction, i.e. the recipient(s).</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public List<CreateCoinsTransactionRequestFromAddressRIRecipients> Recipients { get; set; }

        /// <summary>
        /// Gets or Sets Senders
        /// </summary>
        [DataMember(Name = "senders", IsRequired = true, EmitDefaultValue = false)]
        public CreateCoinsTransactionRequestFromAddressRISenders Senders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCoinsTransactionRequestFromAddressRI {\n");
            sb.Append("  CallbackSecretKey: ").Append(CallbackSecretKey).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  FeePriority: ").Append(FeePriority).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Senders: ").Append(Senders).Append("\n");
            sb.Append("  TransactionRequestStatus: ").Append(TransactionRequestStatus).Append("\n");
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
            return this.Equals(input as CreateCoinsTransactionRequestFromAddressRI);
        }

        /// <summary>
        /// Returns true if CreateCoinsTransactionRequestFromAddressRI instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCoinsTransactionRequestFromAddressRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCoinsTransactionRequestFromAddressRI input)
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
                    this.FeePriority == input.FeePriority ||
                    this.FeePriority.Equals(input.FeePriority)
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Senders == input.Senders ||
                    (this.Senders != null &&
                    this.Senders.Equals(input.Senders))
                ) && 
                (
                    this.TransactionRequestStatus == input.TransactionRequestStatus ||
                    this.TransactionRequestStatus.Equals(input.TransactionRequestStatus)
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
                hashCode = hashCode * 59 + this.FeePriority.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Senders != null)
                    hashCode = hashCode * 59 + this.Senders.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionRequestStatus.GetHashCode();
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