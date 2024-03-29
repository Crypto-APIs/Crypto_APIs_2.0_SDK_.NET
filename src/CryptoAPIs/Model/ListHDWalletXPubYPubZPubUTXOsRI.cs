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
    /// ListHDWalletXPubYPubZPubUTXOsRI
    /// </summary>
    [DataContract(Name = "ListHDWalletXPubYPubZPubUTXOsRI")]
    public partial class ListHDWalletXPubYPubZPubUTXOsRI : IEquatable<ListHDWalletXPubYPubZPubUTXOsRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListHDWalletXPubYPubZPubUTXOsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListHDWalletXPubYPubZPubUTXOsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListHDWalletXPubYPubZPubUTXOsRI" /> class.
        /// </summary>
        /// <param name="address">Represents the public address, which is a compressed and shortened form of a public key. (required).</param>
        /// <param name="addressPath">Defines a data which tells a Hierarchical Deterministic wallet how to derive a specific key within a tree of keys. (required).</param>
        /// <param name="amount">Represents the UTXO amount value. (required).</param>
        /// <param name="derivation">The way how the HD walled derives, for example when the type is ACCOUNT, it derives change and receive addresses while when the type is BIP32 it derives directly. (required).</param>
        /// <param name="index">Represents the output index. It refers to the UTXO sequence in the transaction outputs (vout). (required).</param>
        /// <param name="isAvailable">Represents if the UTXO has been used from another unconfirmed transaction. If it is - the value will be \&quot;false\&quot;. (required).</param>
        /// <param name="isConfirmed">Represents the state of the transaction whether it is confirmed or not confirmed. (required).</param>
        /// <param name="referenceId">Represents the reference id of the record. It may be used for the startingAfter pagination attribute. (required).</param>
        /// <param name="transactionId">Represents the unique identifier of a transaction, i.e. it could be transactionId in UTXO-based protocols like Bitcoin, and transaction hash in Ethereum blockchain. (required).</param>
        public ListHDWalletXPubYPubZPubUTXOsRI(string address = default(string), string addressPath = default(string), string amount = default(string), string derivation = default(string), int index = default(int), bool isAvailable = default(bool), bool isConfirmed = default(bool), string referenceId = default(string), string transactionId = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for ListHDWalletXPubYPubZPubUTXOsRI and cannot be null");
            }
            this.Address = address;
            // to ensure "addressPath" is required (not null)
            if (addressPath == null)
            {
                throw new ArgumentNullException("addressPath is a required property for ListHDWalletXPubYPubZPubUTXOsRI and cannot be null");
            }
            this.AddressPath = addressPath;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ListHDWalletXPubYPubZPubUTXOsRI and cannot be null");
            }
            this.Amount = amount;
            // to ensure "derivation" is required (not null)
            if (derivation == null)
            {
                throw new ArgumentNullException("derivation is a required property for ListHDWalletXPubYPubZPubUTXOsRI and cannot be null");
            }
            this.Derivation = derivation;
            this.Index = index;
            this.IsAvailable = isAvailable;
            this.IsConfirmed = isConfirmed;
            // to ensure "referenceId" is required (not null)
            if (referenceId == null)
            {
                throw new ArgumentNullException("referenceId is a required property for ListHDWalletXPubYPubZPubUTXOsRI and cannot be null");
            }
            this.ReferenceId = referenceId;
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new ArgumentNullException("transactionId is a required property for ListHDWalletXPubYPubZPubUTXOsRI and cannot be null");
            }
            this.TransactionId = transactionId;
        }

        /// <summary>
        /// Represents the public address, which is a compressed and shortened form of a public key.
        /// </summary>
        /// <value>Represents the public address, which is a compressed and shortened form of a public key.</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Defines a data which tells a Hierarchical Deterministic wallet how to derive a specific key within a tree of keys.
        /// </summary>
        /// <value>Defines a data which tells a Hierarchical Deterministic wallet how to derive a specific key within a tree of keys.</value>
        [DataMember(Name = "addressPath", IsRequired = true, EmitDefaultValue = false)]
        public string AddressPath { get; set; }

        /// <summary>
        /// Represents the UTXO amount value.
        /// </summary>
        /// <value>Represents the UTXO amount value.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// The way how the HD walled derives, for example when the type is ACCOUNT, it derives change and receive addresses while when the type is BIP32 it derives directly.
        /// </summary>
        /// <value>The way how the HD walled derives, for example when the type is ACCOUNT, it derives change and receive addresses while when the type is BIP32 it derives directly.</value>
        [DataMember(Name = "derivation", IsRequired = true, EmitDefaultValue = false)]
        public string Derivation { get; set; }

        /// <summary>
        /// Represents the output index. It refers to the UTXO sequence in the transaction outputs (vout).
        /// </summary>
        /// <value>Represents the output index. It refers to the UTXO sequence in the transaction outputs (vout).</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = false)]
        public int Index { get; set; }

        /// <summary>
        /// Represents if the UTXO has been used from another unconfirmed transaction. If it is - the value will be \&quot;false\&quot;.
        /// </summary>
        /// <value>Represents if the UTXO has been used from another unconfirmed transaction. If it is - the value will be \&quot;false\&quot;.</value>
        [DataMember(Name = "isAvailable", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Represents the state of the transaction whether it is confirmed or not confirmed.
        /// </summary>
        /// <value>Represents the state of the transaction whether it is confirmed or not confirmed.</value>
        [DataMember(Name = "isConfirmed", IsRequired = true, EmitDefaultValue = true)]
        public bool IsConfirmed { get; set; }

        /// <summary>
        /// Represents the reference id of the record. It may be used for the startingAfter pagination attribute.
        /// </summary>
        /// <value>Represents the reference id of the record. It may be used for the startingAfter pagination attribute.</value>
        [DataMember(Name = "referenceId", IsRequired = true, EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Represents the unique identifier of a transaction, i.e. it could be transactionId in UTXO-based protocols like Bitcoin, and transaction hash in Ethereum blockchain.
        /// </summary>
        /// <value>Represents the unique identifier of a transaction, i.e. it could be transactionId in UTXO-based protocols like Bitcoin, and transaction hash in Ethereum blockchain.</value>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListHDWalletXPubYPubZPubUTXOsRI {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressPath: ").Append(AddressPath).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Derivation: ").Append(Derivation).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  IsConfirmed: ").Append(IsConfirmed).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(input as ListHDWalletXPubYPubZPubUTXOsRI);
        }

        /// <summary>
        /// Returns true if ListHDWalletXPubYPubZPubUTXOsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListHDWalletXPubYPubZPubUTXOsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListHDWalletXPubYPubZPubUTXOsRI input)
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
                    this.AddressPath == input.AddressPath ||
                    (this.AddressPath != null &&
                    this.AddressPath.Equals(input.AddressPath))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Derivation == input.Derivation ||
                    (this.Derivation != null &&
                    this.Derivation.Equals(input.Derivation))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.IsAvailable == input.IsAvailable ||
                    this.IsAvailable.Equals(input.IsAvailable)
                ) && 
                (
                    this.IsConfirmed == input.IsConfirmed ||
                    this.IsConfirmed.Equals(input.IsConfirmed)
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
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
                if (this.AddressPath != null)
                {
                    hashCode = (hashCode * 59) + this.AddressPath.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Derivation != null)
                {
                    hashCode = (hashCode * 59) + this.Derivation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.IsAvailable.GetHashCode();
                hashCode = (hashCode * 59) + this.IsConfirmed.GetHashCode();
                if (this.ReferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceId.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
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
