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
    /// ListDepositAddressesRI
    /// </summary>
    [DataContract(Name = "ListDepositAddressesRI")]
    public partial class ListDepositAddressesRI : IEquatable<ListDepositAddressesRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDepositAddressesRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListDepositAddressesRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDepositAddressesRI" /> class.
        /// </summary>
        /// <param name="address">Specifies the specific address&#39;s unique string value. (required).</param>
        /// <param name="confirmedBalance">confirmedBalance (required).</param>
        /// <param name="createdTimestamp">Defines the specific UNIX time when the deposit address was created. (required).</param>
        /// <param name="fungibleTokens">Represents fungible tokens&#39;es detailed information (required).</param>
        /// <param name="index">Represents the index of the address in the wallet. (required).</param>
        /// <param name="label">Represents a custom tag that customers can set up for their Wallets and addresses. E.g. custom label named \&quot;Special addresses\&quot;. (required).</param>
        /// <param name="nonFungibleTokens">Represents non-fungible tokens&#39;es detailed information. (required).</param>
        public ListDepositAddressesRI(string address = default(string), ListDepositAddressesRIConfirmedBalance confirmedBalance = default(ListDepositAddressesRIConfirmedBalance), int createdTimestamp = default(int), List<ListDepositAddressesRIFungibleTokensInner> fungibleTokens = default(List<ListDepositAddressesRIFungibleTokensInner>), string index = default(string), string label = default(string), List<ListDepositAddressesRINonFungibleTokensInner> nonFungibleTokens = default(List<ListDepositAddressesRINonFungibleTokensInner>))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for ListDepositAddressesRI and cannot be null");
            }
            this.Address = address;
            // to ensure "confirmedBalance" is required (not null)
            if (confirmedBalance == null)
            {
                throw new ArgumentNullException("confirmedBalance is a required property for ListDepositAddressesRI and cannot be null");
            }
            this.ConfirmedBalance = confirmedBalance;
            this.CreatedTimestamp = createdTimestamp;
            // to ensure "fungibleTokens" is required (not null)
            if (fungibleTokens == null)
            {
                throw new ArgumentNullException("fungibleTokens is a required property for ListDepositAddressesRI and cannot be null");
            }
            this.FungibleTokens = fungibleTokens;
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new ArgumentNullException("index is a required property for ListDepositAddressesRI and cannot be null");
            }
            this.Index = index;
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for ListDepositAddressesRI and cannot be null");
            }
            this.Label = label;
            // to ensure "nonFungibleTokens" is required (not null)
            if (nonFungibleTokens == null)
            {
                throw new ArgumentNullException("nonFungibleTokens is a required property for ListDepositAddressesRI and cannot be null");
            }
            this.NonFungibleTokens = nonFungibleTokens;
        }

        /// <summary>
        /// Specifies the specific address&#39;s unique string value.
        /// </summary>
        /// <value>Specifies the specific address&#39;s unique string value.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedBalance
        /// </summary>
        [DataMember(Name = "confirmedBalance", IsRequired = true, EmitDefaultValue = false)]
        public ListDepositAddressesRIConfirmedBalance ConfirmedBalance { get; set; }

        /// <summary>
        /// Defines the specific UNIX time when the deposit address was created.
        /// </summary>
        /// <value>Defines the specific UNIX time when the deposit address was created.</value>
        [DataMember(Name = "createdTimestamp", IsRequired = true, EmitDefaultValue = false)]
        public int CreatedTimestamp { get; set; }

        /// <summary>
        /// Represents fungible tokens&#39;es detailed information
        /// </summary>
        /// <value>Represents fungible tokens&#39;es detailed information</value>
        [DataMember(Name = "fungibleTokens", IsRequired = true, EmitDefaultValue = false)]
        public List<ListDepositAddressesRIFungibleTokensInner> FungibleTokens { get; set; }

        /// <summary>
        /// Represents the index of the address in the wallet.
        /// </summary>
        /// <value>Represents the index of the address in the wallet.</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = false)]
        public string Index { get; set; }

        /// <summary>
        /// Represents a custom tag that customers can set up for their Wallets and addresses. E.g. custom label named \&quot;Special addresses\&quot;.
        /// </summary>
        /// <value>Represents a custom tag that customers can set up for their Wallets and addresses. E.g. custom label named \&quot;Special addresses\&quot;.</value>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Represents non-fungible tokens&#39;es detailed information.
        /// </summary>
        /// <value>Represents non-fungible tokens&#39;es detailed information.</value>
        [DataMember(Name = "nonFungibleTokens", IsRequired = true, EmitDefaultValue = false)]
        public List<ListDepositAddressesRINonFungibleTokensInner> NonFungibleTokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListDepositAddressesRI {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ConfirmedBalance: ").Append(ConfirmedBalance).Append("\n");
            sb.Append("  CreatedTimestamp: ").Append(CreatedTimestamp).Append("\n");
            sb.Append("  FungibleTokens: ").Append(FungibleTokens).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  NonFungibleTokens: ").Append(NonFungibleTokens).Append("\n");
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
            return this.Equals(input as ListDepositAddressesRI);
        }

        /// <summary>
        /// Returns true if ListDepositAddressesRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListDepositAddressesRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListDepositAddressesRI input)
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
                    this.ConfirmedBalance == input.ConfirmedBalance ||
                    (this.ConfirmedBalance != null &&
                    this.ConfirmedBalance.Equals(input.ConfirmedBalance))
                ) && 
                (
                    this.CreatedTimestamp == input.CreatedTimestamp ||
                    this.CreatedTimestamp.Equals(input.CreatedTimestamp)
                ) && 
                (
                    this.FungibleTokens == input.FungibleTokens ||
                    this.FungibleTokens != null &&
                    input.FungibleTokens != null &&
                    this.FungibleTokens.SequenceEqual(input.FungibleTokens)
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.NonFungibleTokens == input.NonFungibleTokens ||
                    this.NonFungibleTokens != null &&
                    input.NonFungibleTokens != null &&
                    this.NonFungibleTokens.SequenceEqual(input.NonFungibleTokens)
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
                if (this.ConfirmedBalance != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmedBalance.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedTimestamp.GetHashCode();
                if (this.FungibleTokens != null)
                {
                    hashCode = (hashCode * 59) + this.FungibleTokens.GetHashCode();
                }
                if (this.Index != null)
                {
                    hashCode = (hashCode * 59) + this.Index.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.NonFungibleTokens != null)
                {
                    hashCode = (hashCode * 59) + this.NonFungibleTokens.GetHashCode();
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
