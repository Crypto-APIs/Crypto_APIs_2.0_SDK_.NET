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
    /// ListHDWalletXPubYPubZPubUTXOs400Response
    /// </summary>
    [DataContract(Name = "List_HD_Wallet__xPub__yPub__zPub__UTXOs_400_response")]
    public partial class ListHDWalletXPubYPubZPubUTXOs400Response : IEquatable<ListHDWalletXPubYPubZPubUTXOs400Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListHDWalletXPubYPubZPubUTXOs400Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListHDWalletXPubYPubZPubUTXOs400Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListHDWalletXPubYPubZPubUTXOs400Response" /> class.
        /// </summary>
        /// <param name="apiVersion">Specifies the version of the API that incorporates this endpoint. (required).</param>
        /// <param name="requestId">Defines the ID of the request. The &#x60;requestId&#x60; is generated by Crypto APIs and it&#39;s unique for every request. (required).</param>
        /// <param name="context">In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user..</param>
        /// <param name="error">error (required).</param>
        public ListHDWalletXPubYPubZPubUTXOs400Response(string apiVersion = default(string), string requestId = default(string), string context = default(string), ListHDWalletXPubYPubZPubUTXOsE400 error = default(ListHDWalletXPubYPubZPubUTXOsE400))
        {
            // to ensure "apiVersion" is required (not null)
            if (apiVersion == null)
            {
                throw new ArgumentNullException("apiVersion is a required property for ListHDWalletXPubYPubZPubUTXOs400Response and cannot be null");
            }
            this.ApiVersion = apiVersion;
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new ArgumentNullException("requestId is a required property for ListHDWalletXPubYPubZPubUTXOs400Response and cannot be null");
            }
            this.RequestId = requestId;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for ListHDWalletXPubYPubZPubUTXOs400Response and cannot be null");
            }
            this.Error = error;
            this.Context = context;
        }

        /// <summary>
        /// Specifies the version of the API that incorporates this endpoint.
        /// </summary>
        /// <value>Specifies the version of the API that incorporates this endpoint.</value>
        [DataMember(Name = "apiVersion", IsRequired = true, EmitDefaultValue = false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Defines the ID of the request. The &#x60;requestId&#x60; is generated by Crypto APIs and it&#39;s unique for every request.
        /// </summary>
        /// <value>Defines the ID of the request. The &#x60;requestId&#x60; is generated by Crypto APIs and it&#39;s unique for every request.</value>
        [DataMember(Name = "requestId", IsRequired = true, EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user.
        /// </summary>
        /// <value>In batch situations the user can use the context to correlate responses with requests. This property is present regardless of whether the response was successful or returned as an error. &#x60;context&#x60; is specified by the user.</value>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public string Context { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = false)]
        public ListHDWalletXPubYPubZPubUTXOsE400 Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListHDWalletXPubYPubZPubUTXOs400Response {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as ListHDWalletXPubYPubZPubUTXOs400Response);
        }

        /// <summary>
        /// Returns true if ListHDWalletXPubYPubZPubUTXOs400Response instances are equal
        /// </summary>
        /// <param name="input">Instance of ListHDWalletXPubYPubZPubUTXOs400Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListHDWalletXPubYPubZPubUTXOs400Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.ApiVersion != null)
                {
                    hashCode = (hashCode * 59) + this.ApiVersion.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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
