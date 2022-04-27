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
    /// ListAllAssetsFromAllWalletsRI
    /// </summary>
    [DataContract(Name = "ListAllAssetsFromAllWalletsRI")]
    public partial class ListAllAssetsFromAllWalletsRI : IEquatable<ListAllAssetsFromAllWalletsRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllAssetsFromAllWalletsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListAllAssetsFromAllWalletsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllAssetsFromAllWalletsRI" /> class.
        /// </summary>
        /// <param name="coins">coins (required).</param>
        /// <param name="fungibleTokens">Represents fungible tokens&#39;es detailed information (required).</param>
        /// <param name="nonFungibleTokens">Represents non-fungible tokens&#39;es detailed information. (required).</param>
        /// <param name="walletId">Defines the unique ID of the Wallet. (required).</param>
        /// <param name="walletName">Represents the name of the wallet. (required).</param>
        public ListAllAssetsFromAllWalletsRI(List<ListAllAssetsFromAllWalletsRICoins> coins = default(List<ListAllAssetsFromAllWalletsRICoins>), List<ListAllAssetsFromAllWalletsRIFungibleTokens> fungibleTokens = default(List<ListAllAssetsFromAllWalletsRIFungibleTokens>), List<ListAllAssetsFromAllWalletsRINonFungibleTokens> nonFungibleTokens = default(List<ListAllAssetsFromAllWalletsRINonFungibleTokens>), string walletId = default(string), string walletName = default(string))
        {
            // to ensure "coins" is required (not null)
            if (coins == null)
            {
                throw new ArgumentNullException("coins is a required property for ListAllAssetsFromAllWalletsRI and cannot be null");
            }
            this.Coins = coins;
            // to ensure "fungibleTokens" is required (not null)
            if (fungibleTokens == null)
            {
                throw new ArgumentNullException("fungibleTokens is a required property for ListAllAssetsFromAllWalletsRI and cannot be null");
            }
            this.FungibleTokens = fungibleTokens;
            // to ensure "nonFungibleTokens" is required (not null)
            if (nonFungibleTokens == null)
            {
                throw new ArgumentNullException("nonFungibleTokens is a required property for ListAllAssetsFromAllWalletsRI and cannot be null");
            }
            this.NonFungibleTokens = nonFungibleTokens;
            // to ensure "walletId" is required (not null)
            if (walletId == null)
            {
                throw new ArgumentNullException("walletId is a required property for ListAllAssetsFromAllWalletsRI and cannot be null");
            }
            this.WalletId = walletId;
            // to ensure "walletName" is required (not null)
            if (walletName == null)
            {
                throw new ArgumentNullException("walletName is a required property for ListAllAssetsFromAllWalletsRI and cannot be null");
            }
            this.WalletName = walletName;
        }

        /// <summary>
        /// Gets or Sets Coins
        /// </summary>
        [DataMember(Name = "coins", IsRequired = true, EmitDefaultValue = false)]
        public List<ListAllAssetsFromAllWalletsRICoins> Coins { get; set; }

        /// <summary>
        /// Represents fungible tokens&#39;es detailed information
        /// </summary>
        /// <value>Represents fungible tokens&#39;es detailed information</value>
        [DataMember(Name = "fungibleTokens", IsRequired = true, EmitDefaultValue = false)]
        public List<ListAllAssetsFromAllWalletsRIFungibleTokens> FungibleTokens { get; set; }

        /// <summary>
        /// Represents non-fungible tokens&#39;es detailed information.
        /// </summary>
        /// <value>Represents non-fungible tokens&#39;es detailed information.</value>
        [DataMember(Name = "nonFungibleTokens", IsRequired = true, EmitDefaultValue = false)]
        public List<ListAllAssetsFromAllWalletsRINonFungibleTokens> NonFungibleTokens { get; set; }

        /// <summary>
        /// Defines the unique ID of the Wallet.
        /// </summary>
        /// <value>Defines the unique ID of the Wallet.</value>
        [DataMember(Name = "walletId", IsRequired = true, EmitDefaultValue = false)]
        public string WalletId { get; set; }

        /// <summary>
        /// Represents the name of the wallet.
        /// </summary>
        /// <value>Represents the name of the wallet.</value>
        [DataMember(Name = "walletName", IsRequired = true, EmitDefaultValue = false)]
        public string WalletName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListAllAssetsFromAllWalletsRI {\n");
            sb.Append("  Coins: ").Append(Coins).Append("\n");
            sb.Append("  FungibleTokens: ").Append(FungibleTokens).Append("\n");
            sb.Append("  NonFungibleTokens: ").Append(NonFungibleTokens).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  WalletName: ").Append(WalletName).Append("\n");
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
            return this.Equals(input as ListAllAssetsFromAllWalletsRI);
        }

        /// <summary>
        /// Returns true if ListAllAssetsFromAllWalletsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListAllAssetsFromAllWalletsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListAllAssetsFromAllWalletsRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Coins == input.Coins ||
                    this.Coins != null &&
                    input.Coins != null &&
                    this.Coins.SequenceEqual(input.Coins)
                ) && 
                (
                    this.FungibleTokens == input.FungibleTokens ||
                    this.FungibleTokens != null &&
                    input.FungibleTokens != null &&
                    this.FungibleTokens.SequenceEqual(input.FungibleTokens)
                ) && 
                (
                    this.NonFungibleTokens == input.NonFungibleTokens ||
                    this.NonFungibleTokens != null &&
                    input.NonFungibleTokens != null &&
                    this.NonFungibleTokens.SequenceEqual(input.NonFungibleTokens)
                ) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && 
                (
                    this.WalletName == input.WalletName ||
                    (this.WalletName != null &&
                    this.WalletName.Equals(input.WalletName))
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
                if (this.Coins != null)
                {
                    hashCode = (hashCode * 59) + this.Coins.GetHashCode();
                }
                if (this.FungibleTokens != null)
                {
                    hashCode = (hashCode * 59) + this.FungibleTokens.GetHashCode();
                }
                if (this.NonFungibleTokens != null)
                {
                    hashCode = (hashCode * 59) + this.NonFungibleTokens.GetHashCode();
                }
                if (this.WalletId != null)
                {
                    hashCode = (hashCode * 59) + this.WalletId.GetHashCode();
                }
                if (this.WalletName != null)
                {
                    hashCode = (hashCode * 59) + this.WalletName.GetHashCode();
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