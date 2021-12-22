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
    /// Defines the block height in which this transaction was mined and confirmed in.
    /// </summary>
    [DataContract(Name = "AddressCoinsTransactionConfirmed_data_item_minedInBlock")]
    public partial class AddressCoinsTransactionConfirmedDataItemMinedInBlock : IEquatable<AddressCoinsTransactionConfirmedDataItemMinedInBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressCoinsTransactionConfirmedDataItemMinedInBlock" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressCoinsTransactionConfirmedDataItemMinedInBlock() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressCoinsTransactionConfirmedDataItemMinedInBlock" /> class.
        /// </summary>
        /// <param name="height">Defines the number of blocks in the blockchain preceding this specific block. (required).</param>
        /// <param name="hash">Represents the hash of the block&#39;s header, i.e. an output that has a fixed length. (required).</param>
        /// <param name="timestamp">Defines the exact date/time when this transaction was mined in seconds since Unix Epoch time. (required).</param>
        public AddressCoinsTransactionConfirmedDataItemMinedInBlock(int height = default(int), string hash = default(string), int timestamp = default(int))
        {
            this.Height = height;
            // to ensure "hash" is required (not null)
            if (hash == null) {
                throw new ArgumentNullException("hash is a required property for AddressCoinsTransactionConfirmedDataItemMinedInBlock and cannot be null");
            }
            this.Hash = hash;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Defines the number of blocks in the blockchain preceding this specific block.
        /// </summary>
        /// <value>Defines the number of blocks in the blockchain preceding this specific block.</value>
        [DataMember(Name = "height", IsRequired = true, EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Represents the hash of the block&#39;s header, i.e. an output that has a fixed length.
        /// </summary>
        /// <value>Represents the hash of the block&#39;s header, i.e. an output that has a fixed length.</value>
        [DataMember(Name = "hash", IsRequired = true, EmitDefaultValue = false)]
        public string Hash { get; set; }

        /// <summary>
        /// Defines the exact date/time when this transaction was mined in seconds since Unix Epoch time.
        /// </summary>
        /// <value>Defines the exact date/time when this transaction was mined in seconds since Unix Epoch time.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressCoinsTransactionConfirmedDataItemMinedInBlock {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as AddressCoinsTransactionConfirmedDataItemMinedInBlock);
        }

        /// <summary>
        /// Returns true if AddressCoinsTransactionConfirmedDataItemMinedInBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressCoinsTransactionConfirmedDataItemMinedInBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressCoinsTransactionConfirmedDataItemMinedInBlock input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
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
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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
