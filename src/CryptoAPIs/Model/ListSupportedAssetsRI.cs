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
    /// ListSupportedAssetsRI
    /// </summary>
    [DataContract(Name = "ListSupportedAssetsRI")]
    public partial class ListSupportedAssetsRI : IEquatable<ListSupportedAssetsRI>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;.
        /// </summary>
        /// <value>Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AssetTypeEnum
        {
            /// <summary>
            /// Enum Fiat for value: fiat
            /// </summary>
            [EnumMember(Value = "fiat")]
            Fiat = 1,

            /// <summary>
            /// Enum Crypto for value: crypto
            /// </summary>
            [EnumMember(Value = "crypto")]
            Crypto = 2

        }


        /// <summary>
        /// Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;.
        /// </summary>
        /// <value>Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;.</value>
        [DataMember(Name = "assetType", IsRequired = true, EmitDefaultValue = false)]
        public AssetTypeEnum AssetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSupportedAssetsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListSupportedAssetsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSupportedAssetsRI" /> class.
        /// </summary>
        /// <param name="assetId">Defines the unique ID of the specific asset. (required).</param>
        /// <param name="assetName">Specifies the name of the asset in question. (required).</param>
        /// <param name="assetSymbol">Specifies the asset&#39;s unique symbol in the Crypto APIs listings. (required).</param>
        /// <param name="assetType">Defines the type of the supported asset. This could be either \&quot;crypto\&quot; or \&quot;fiat\&quot;. (required).</param>
        /// <param name="originalSymbol">Specifies the asset&#39;s original symbol as introduced by its founders. (required).</param>
        public ListSupportedAssetsRI(string assetId = default(string), string assetName = default(string), string assetSymbol = default(string), AssetTypeEnum assetType = default(AssetTypeEnum), string originalSymbol = default(string))
        {
            // to ensure "assetId" is required (not null)
            if (assetId == null) {
                throw new ArgumentNullException("assetId is a required property for ListSupportedAssetsRI and cannot be null");
            }
            this.AssetId = assetId;
            // to ensure "assetName" is required (not null)
            if (assetName == null) {
                throw new ArgumentNullException("assetName is a required property for ListSupportedAssetsRI and cannot be null");
            }
            this.AssetName = assetName;
            // to ensure "assetSymbol" is required (not null)
            if (assetSymbol == null) {
                throw new ArgumentNullException("assetSymbol is a required property for ListSupportedAssetsRI and cannot be null");
            }
            this.AssetSymbol = assetSymbol;
            this.AssetType = assetType;
            // to ensure "originalSymbol" is required (not null)
            if (originalSymbol == null) {
                throw new ArgumentNullException("originalSymbol is a required property for ListSupportedAssetsRI and cannot be null");
            }
            this.OriginalSymbol = originalSymbol;
        }

        /// <summary>
        /// Defines the unique ID of the specific asset.
        /// </summary>
        /// <value>Defines the unique ID of the specific asset.</value>
        [DataMember(Name = "assetId", IsRequired = true, EmitDefaultValue = false)]
        public string AssetId { get; set; }

        /// <summary>
        /// Specifies the name of the asset in question.
        /// </summary>
        /// <value>Specifies the name of the asset in question.</value>
        [DataMember(Name = "assetName", IsRequired = true, EmitDefaultValue = false)]
        public string AssetName { get; set; }

        /// <summary>
        /// Specifies the asset&#39;s unique symbol in the Crypto APIs listings.
        /// </summary>
        /// <value>Specifies the asset&#39;s unique symbol in the Crypto APIs listings.</value>
        [DataMember(Name = "assetSymbol", IsRequired = true, EmitDefaultValue = false)]
        public string AssetSymbol { get; set; }

        /// <summary>
        /// Specifies the asset&#39;s original symbol as introduced by its founders.
        /// </summary>
        /// <value>Specifies the asset&#39;s original symbol as introduced by its founders.</value>
        [DataMember(Name = "originalSymbol", IsRequired = true, EmitDefaultValue = false)]
        public string OriginalSymbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListSupportedAssetsRI {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  AssetSymbol: ").Append(AssetSymbol).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  OriginalSymbol: ").Append(OriginalSymbol).Append("\n");
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
            return this.Equals(input as ListSupportedAssetsRI);
        }

        /// <summary>
        /// Returns true if ListSupportedAssetsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListSupportedAssetsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListSupportedAssetsRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.AssetName == input.AssetName ||
                    (this.AssetName != null &&
                    this.AssetName.Equals(input.AssetName))
                ) && 
                (
                    this.AssetSymbol == input.AssetSymbol ||
                    (this.AssetSymbol != null &&
                    this.AssetSymbol.Equals(input.AssetSymbol))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    this.AssetType.Equals(input.AssetType)
                ) && 
                (
                    this.OriginalSymbol == input.OriginalSymbol ||
                    (this.OriginalSymbol != null &&
                    this.OriginalSymbol.Equals(input.OriginalSymbol))
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
                if (this.AssetId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                }
                if (this.AssetName != null)
                {
                    hashCode = (hashCode * 59) + this.AssetName.GetHashCode();
                }
                if (this.AssetSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.AssetSymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AssetType.GetHashCode();
                if (this.OriginalSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalSymbol.GetHashCode();
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
