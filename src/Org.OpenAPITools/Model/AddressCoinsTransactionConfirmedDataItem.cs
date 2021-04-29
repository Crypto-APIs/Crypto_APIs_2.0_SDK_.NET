/*
 * Crypto APIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: bizdev@cryptoapis.io
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines an &#x60;item&#x60; as one result.
    /// </summary>
    [DataContract(Name = "AddressCoinsTransactionConfirmed_data_item")]
    public partial class AddressCoinsTransactionConfirmedDataItem : IEquatable<AddressCoinsTransactionConfirmedDataItem>, IValidatableObject
    {
        /// <summary>
        /// Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.
        /// </summary>
        /// <value>Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum Incoming for value: incoming
            /// </summary>
            [EnumMember(Value = "incoming")]
            Incoming = 1,

            /// <summary>
            /// Enum Outgoing for value: outgoing
            /// </summary>
            [EnumMember(Value = "outgoing")]
            Outgoing = 2

        }


        /// <summary>
        /// Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.
        /// </summary>
        /// <value>Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;.</value>
        [DataMember(Name = "direction", IsRequired = true, EmitDefaultValue = false)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressCoinsTransactionConfirmedDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressCoinsTransactionConfirmedDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressCoinsTransactionConfirmedDataItem" /> class.
        /// </summary>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (required).</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. (required).</param>
        /// <param name="address">Defines the specific address to which the coin transaction has been sent and is confirmed. (required).</param>
        /// <param name="minedInBlock">minedInBlock (required).</param>
        /// <param name="transactionId">Defines the unique ID of the specific transaction, i.e. its identification number. (required).</param>
        /// <param name="amount">Defines the amount of coins sent with the confirmed transaction. (required).</param>
        /// <param name="unit">Defines the unit of the transaction, e.g. BTC. (required).</param>
        /// <param name="direction">Defines whether the transaction is \&quot;incoming\&quot; or \&quot;outgoing\&quot;. (required).</param>
        public AddressCoinsTransactionConfirmedDataItem(string blockchain = default(string), string network = default(string), string address = default(string), AddressCoinsTransactionConfirmedDataItemMinedInBlock minedInBlock = default(AddressCoinsTransactionConfirmedDataItemMinedInBlock), string transactionId = default(string), string amount = default(string), string unit = default(string), DirectionEnum direction = default(DirectionEnum))
        {
            // to ensure "blockchain" is required (not null)
            this.Blockchain = blockchain ?? throw new ArgumentNullException("blockchain is a required property for AddressCoinsTransactionConfirmedDataItem and cannot be null");
            // to ensure "network" is required (not null)
            this.Network = network ?? throw new ArgumentNullException("network is a required property for AddressCoinsTransactionConfirmedDataItem and cannot be null");
            // to ensure "address" is required (not null)
            this.Address = address ?? throw new ArgumentNullException("address is a required property for AddressCoinsTransactionConfirmedDataItem and cannot be null");
            // to ensure "minedInBlock" is required (not null)
            this.MinedInBlock = minedInBlock ?? throw new ArgumentNullException("minedInBlock is a required property for AddressCoinsTransactionConfirmedDataItem and cannot be null");
            // to ensure "transactionId" is required (not null)
            this.TransactionId = transactionId ?? throw new ArgumentNullException("transactionId is a required property for AddressCoinsTransactionConfirmedDataItem and cannot be null");
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount is a required property for AddressCoinsTransactionConfirmedDataItem and cannot be null");
            // to ensure "unit" is required (not null)
            this.Unit = unit ?? throw new ArgumentNullException("unit is a required property for AddressCoinsTransactionConfirmedDataItem and cannot be null");
            this.Direction = direction;
        }

        /// <summary>
        /// Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.
        /// </summary>
        /// <value>Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc.</value>
        [DataMember(Name = "blockchain", IsRequired = true, EmitDefaultValue = false)]
        public string Blockchain { get; set; }

        /// <summary>
        /// Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.
        /// </summary>
        /// <value>Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks.</value>
        [DataMember(Name = "network", IsRequired = true, EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Defines the specific address to which the coin transaction has been sent and is confirmed.
        /// </summary>
        /// <value>Defines the specific address to which the coin transaction has been sent and is confirmed.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets MinedInBlock
        /// </summary>
        [DataMember(Name = "minedInBlock", IsRequired = true, EmitDefaultValue = false)]
        public AddressCoinsTransactionConfirmedDataItemMinedInBlock MinedInBlock { get; set; }

        /// <summary>
        /// Defines the unique ID of the specific transaction, i.e. its identification number.
        /// </summary>
        /// <value>Defines the unique ID of the specific transaction, i.e. its identification number.</value>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Defines the amount of coins sent with the confirmed transaction.
        /// </summary>
        /// <value>Defines the amount of coins sent with the confirmed transaction.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Defines the unit of the transaction, e.g. BTC.
        /// </summary>
        /// <value>Defines the unit of the transaction, e.g. BTC.</value>
        [DataMember(Name = "unit", IsRequired = true, EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressCoinsTransactionConfirmedDataItem {\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  MinedInBlock: ").Append(MinedInBlock).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(input as AddressCoinsTransactionConfirmedDataItem);
        }

        /// <summary>
        /// Returns true if AddressCoinsTransactionConfirmedDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressCoinsTransactionConfirmedDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressCoinsTransactionConfirmedDataItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Blockchain == input.Blockchain ||
                    (this.Blockchain != null &&
                    this.Blockchain.Equals(input.Blockchain))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.MinedInBlock == input.MinedInBlock ||
                    (this.MinedInBlock != null &&
                    this.MinedInBlock.Equals(input.MinedInBlock))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
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
                if (this.Blockchain != null)
                    hashCode = hashCode * 59 + this.Blockchain.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.MinedInBlock != null)
                    hashCode = hashCode * 59 + this.MinedInBlock.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
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