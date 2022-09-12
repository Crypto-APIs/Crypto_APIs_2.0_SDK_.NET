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
    /// Crypto Type Data
    /// </summary>
    [DataContract(Name = "GetAssetDetailsByAssetIDRISC")]
    public partial class GetAssetDetailsByAssetIDRISC : IEquatable<GetAssetDetailsByAssetIDRISC>, IValidatableObject
    {
        /// <summary>
        /// Represent a subtype of the crypto assets. Could be COIN or TOKEN.
        /// </summary>
        /// <value>Represent a subtype of the crypto assets. Could be COIN or TOKEN.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AssetTypeEnum
        {
            /// <summary>
            /// Enum Coin for value: coin
            /// </summary>
            [EnumMember(Value = "coin")]
            Coin = 1,

            /// <summary>
            /// Enum Token for value: token
            /// </summary>
            [EnumMember(Value = "token")]
            Token = 2

        }


        /// <summary>
        /// Represent a subtype of the crypto assets. Could be COIN or TOKEN.
        /// </summary>
        /// <value>Represent a subtype of the crypto assets. Could be COIN or TOKEN.</value>
        [DataMember(Name = "assetType", IsRequired = true, EmitDefaultValue = false)]
        public AssetTypeEnum AssetType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetDetailsByAssetIDRISC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssetDetailsByAssetIDRISC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetDetailsByAssetIDRISC" /> class.
        /// </summary>
        /// <param name="_1hourPriceChangeInPercentage">Represents the percentage of the asset&#39;s current price against the its price from 1 hour ago. (required).</param>
        /// <param name="_1weekPriceChangeInPercentage">Represents the percentage of the asset&#39;s current price against the its price from 1 week ago. (required).</param>
        /// <param name="_24hoursPriceChangeInPercentage">Represents the percentage of the asset&#39;s current price against the its price from 24 hours ago. (required).</param>
        /// <param name="_24hoursTradingVolume">Represents the trading volume of the asset for the time frame of 24 hours. (required).</param>
        /// <param name="assetType">Represent a subtype of the crypto assets. Could be COIN or TOKEN. (required).</param>
        /// <param name="circulatingSupply">Represents the amount of the asset that is circulating on the market and in public hands. (required).</param>
        /// <param name="marketCapInUSD">Defines the total market value of the asset&#39;s circulating supply in USD. (required).</param>
        /// <param name="maxSupply">Represents the maximum amount of all coins of a specific asset that will ever exist in its lifetime. (required).</param>
        public GetAssetDetailsByAssetIDRISC(string _1hourPriceChangeInPercentage = default(string), string _1weekPriceChangeInPercentage = default(string), string _24hoursPriceChangeInPercentage = default(string), string _24hoursTradingVolume = default(string), AssetTypeEnum assetType = default(AssetTypeEnum), string circulatingSupply = default(string), string marketCapInUSD = default(string), string maxSupply = default(string))
        {
            // to ensure "_1hourPriceChangeInPercentage" is required (not null)
            if (_1hourPriceChangeInPercentage == null)
            {
                throw new ArgumentNullException("_1hourPriceChangeInPercentage is a required property for GetAssetDetailsByAssetIDRISC and cannot be null");
            }
            this._1HourPriceChangeInPercentage = _1hourPriceChangeInPercentage;
            // to ensure "_1weekPriceChangeInPercentage" is required (not null)
            if (_1weekPriceChangeInPercentage == null)
            {
                throw new ArgumentNullException("_1weekPriceChangeInPercentage is a required property for GetAssetDetailsByAssetIDRISC and cannot be null");
            }
            this._1WeekPriceChangeInPercentage = _1weekPriceChangeInPercentage;
            // to ensure "_24hoursPriceChangeInPercentage" is required (not null)
            if (_24hoursPriceChangeInPercentage == null)
            {
                throw new ArgumentNullException("_24hoursPriceChangeInPercentage is a required property for GetAssetDetailsByAssetIDRISC and cannot be null");
            }
            this._24HoursPriceChangeInPercentage = _24hoursPriceChangeInPercentage;
            // to ensure "_24hoursTradingVolume" is required (not null)
            if (_24hoursTradingVolume == null)
            {
                throw new ArgumentNullException("_24hoursTradingVolume is a required property for GetAssetDetailsByAssetIDRISC and cannot be null");
            }
            this._24HoursTradingVolume = _24hoursTradingVolume;
            this.AssetType = assetType;
            // to ensure "circulatingSupply" is required (not null)
            if (circulatingSupply == null)
            {
                throw new ArgumentNullException("circulatingSupply is a required property for GetAssetDetailsByAssetIDRISC and cannot be null");
            }
            this.CirculatingSupply = circulatingSupply;
            // to ensure "marketCapInUSD" is required (not null)
            if (marketCapInUSD == null)
            {
                throw new ArgumentNullException("marketCapInUSD is a required property for GetAssetDetailsByAssetIDRISC and cannot be null");
            }
            this.MarketCapInUSD = marketCapInUSD;
            // to ensure "maxSupply" is required (not null)
            if (maxSupply == null)
            {
                throw new ArgumentNullException("maxSupply is a required property for GetAssetDetailsByAssetIDRISC and cannot be null");
            }
            this.MaxSupply = maxSupply;
        }

        /// <summary>
        /// Represents the percentage of the asset&#39;s current price against the its price from 1 hour ago.
        /// </summary>
        /// <value>Represents the percentage of the asset&#39;s current price against the its price from 1 hour ago.</value>
        [DataMember(Name = "1HourPriceChangeInPercentage", IsRequired = true, EmitDefaultValue = false)]
        public string _1HourPriceChangeInPercentage { get; set; }

        /// <summary>
        /// Represents the percentage of the asset&#39;s current price against the its price from 1 week ago.
        /// </summary>
        /// <value>Represents the percentage of the asset&#39;s current price against the its price from 1 week ago.</value>
        [DataMember(Name = "1WeekPriceChangeInPercentage", IsRequired = true, EmitDefaultValue = false)]
        public string _1WeekPriceChangeInPercentage { get; set; }

        /// <summary>
        /// Represents the percentage of the asset&#39;s current price against the its price from 24 hours ago.
        /// </summary>
        /// <value>Represents the percentage of the asset&#39;s current price against the its price from 24 hours ago.</value>
        [DataMember(Name = "24HoursPriceChangeInPercentage", IsRequired = true, EmitDefaultValue = false)]
        public string _24HoursPriceChangeInPercentage { get; set; }

        /// <summary>
        /// Represents the trading volume of the asset for the time frame of 24 hours.
        /// </summary>
        /// <value>Represents the trading volume of the asset for the time frame of 24 hours.</value>
        [DataMember(Name = "24HoursTradingVolume", IsRequired = true, EmitDefaultValue = false)]
        public string _24HoursTradingVolume { get; set; }

        /// <summary>
        /// Represents the amount of the asset that is circulating on the market and in public hands.
        /// </summary>
        /// <value>Represents the amount of the asset that is circulating on the market and in public hands.</value>
        [DataMember(Name = "circulatingSupply", IsRequired = true, EmitDefaultValue = false)]
        public string CirculatingSupply { get; set; }

        /// <summary>
        /// Defines the total market value of the asset&#39;s circulating supply in USD.
        /// </summary>
        /// <value>Defines the total market value of the asset&#39;s circulating supply in USD.</value>
        [DataMember(Name = "marketCapInUSD", IsRequired = true, EmitDefaultValue = false)]
        public string MarketCapInUSD { get; set; }

        /// <summary>
        /// Represents the maximum amount of all coins of a specific asset that will ever exist in its lifetime.
        /// </summary>
        /// <value>Represents the maximum amount of all coins of a specific asset that will ever exist in its lifetime.</value>
        [DataMember(Name = "maxSupply", IsRequired = true, EmitDefaultValue = false)]
        public string MaxSupply { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetDetailsByAssetIDRISC {\n");
            sb.Append("  _1HourPriceChangeInPercentage: ").Append(_1HourPriceChangeInPercentage).Append("\n");
            sb.Append("  _1WeekPriceChangeInPercentage: ").Append(_1WeekPriceChangeInPercentage).Append("\n");
            sb.Append("  _24HoursPriceChangeInPercentage: ").Append(_24HoursPriceChangeInPercentage).Append("\n");
            sb.Append("  _24HoursTradingVolume: ").Append(_24HoursTradingVolume).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  CirculatingSupply: ").Append(CirculatingSupply).Append("\n");
            sb.Append("  MarketCapInUSD: ").Append(MarketCapInUSD).Append("\n");
            sb.Append("  MaxSupply: ").Append(MaxSupply).Append("\n");
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
            return this.Equals(input as GetAssetDetailsByAssetIDRISC);
        }

        /// <summary>
        /// Returns true if GetAssetDetailsByAssetIDRISC instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAssetDetailsByAssetIDRISC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAssetDetailsByAssetIDRISC input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._1HourPriceChangeInPercentage == input._1HourPriceChangeInPercentage ||
                    (this._1HourPriceChangeInPercentage != null &&
                    this._1HourPriceChangeInPercentage.Equals(input._1HourPriceChangeInPercentage))
                ) && 
                (
                    this._1WeekPriceChangeInPercentage == input._1WeekPriceChangeInPercentage ||
                    (this._1WeekPriceChangeInPercentage != null &&
                    this._1WeekPriceChangeInPercentage.Equals(input._1WeekPriceChangeInPercentage))
                ) && 
                (
                    this._24HoursPriceChangeInPercentage == input._24HoursPriceChangeInPercentage ||
                    (this._24HoursPriceChangeInPercentage != null &&
                    this._24HoursPriceChangeInPercentage.Equals(input._24HoursPriceChangeInPercentage))
                ) && 
                (
                    this._24HoursTradingVolume == input._24HoursTradingVolume ||
                    (this._24HoursTradingVolume != null &&
                    this._24HoursTradingVolume.Equals(input._24HoursTradingVolume))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    this.AssetType.Equals(input.AssetType)
                ) && 
                (
                    this.CirculatingSupply == input.CirculatingSupply ||
                    (this.CirculatingSupply != null &&
                    this.CirculatingSupply.Equals(input.CirculatingSupply))
                ) && 
                (
                    this.MarketCapInUSD == input.MarketCapInUSD ||
                    (this.MarketCapInUSD != null &&
                    this.MarketCapInUSD.Equals(input.MarketCapInUSD))
                ) && 
                (
                    this.MaxSupply == input.MaxSupply ||
                    (this.MaxSupply != null &&
                    this.MaxSupply.Equals(input.MaxSupply))
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
                if (this._1HourPriceChangeInPercentage != null)
                {
                    hashCode = (hashCode * 59) + this._1HourPriceChangeInPercentage.GetHashCode();
                }
                if (this._1WeekPriceChangeInPercentage != null)
                {
                    hashCode = (hashCode * 59) + this._1WeekPriceChangeInPercentage.GetHashCode();
                }
                if (this._24HoursPriceChangeInPercentage != null)
                {
                    hashCode = (hashCode * 59) + this._24HoursPriceChangeInPercentage.GetHashCode();
                }
                if (this._24HoursTradingVolume != null)
                {
                    hashCode = (hashCode * 59) + this._24HoursTradingVolume.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AssetType.GetHashCode();
                if (this.CirculatingSupply != null)
                {
                    hashCode = (hashCode * 59) + this.CirculatingSupply.GetHashCode();
                }
                if (this.MarketCapInUSD != null)
                {
                    hashCode = (hashCode * 59) + this.MarketCapInUSD.GetHashCode();
                }
                if (this.MaxSupply != null)
                {
                    hashCode = (hashCode * 59) + this.MaxSupply.GetHashCode();
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
