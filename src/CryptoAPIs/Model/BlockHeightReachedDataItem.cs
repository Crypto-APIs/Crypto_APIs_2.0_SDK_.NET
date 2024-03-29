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
    /// Defines an &#x60;item&#x60; as one result.
    /// </summary>
    [DataContract(Name = "BlockHeightReached_data_item")]
    public partial class BlockHeightReachedDataItem : IEquatable<BlockHeightReachedDataItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockHeightReachedDataItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BlockHeightReachedDataItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockHeightReachedDataItem" /> class.
        /// </summary>
        /// <param name="blockchain">Represents the specific blockchain protocol name, e.g. Ethereum, Bitcoin, etc. (required).</param>
        /// <param name="network">Represents the name of the blockchain network used; blockchain networks are usually identical as technology and software, but they differ in data, e.g. - \&quot;mainnet\&quot; is the live network with actual data while networks like \&quot;testnet\&quot;, \&quot;ropsten\&quot;, \&quot;rinkeby\&quot; are test networks. (required).</param>
        /// <param name="height">Defines the number of blocks in the blockchain preceding this specific block. (required).</param>
        /// <param name="hash">Represents the hash of the block&#39;s header, i.e. an output that has a fixed length. (required).</param>
        /// <param name="timestamp">Defines the exact date/time when this block was mined in seconds since Unix Epoch time. (required).</param>
        public BlockHeightReachedDataItem(string blockchain = default(string), string network = default(string), int height = default(int), string hash = default(string), int timestamp = default(int))
        {
            // to ensure "blockchain" is required (not null)
            if (blockchain == null)
            {
                throw new ArgumentNullException("blockchain is a required property for BlockHeightReachedDataItem and cannot be null");
            }
            this.Blockchain = blockchain;
            // to ensure "network" is required (not null)
            if (network == null)
            {
                throw new ArgumentNullException("network is a required property for BlockHeightReachedDataItem and cannot be null");
            }
            this.Network = network;
            this.Height = height;
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new ArgumentNullException("hash is a required property for BlockHeightReachedDataItem and cannot be null");
            }
            this.Hash = hash;
            this.Timestamp = timestamp;
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
        /// Defines the exact date/time when this block was mined in seconds since Unix Epoch time.
        /// </summary>
        /// <value>Defines the exact date/time when this block was mined in seconds since Unix Epoch time.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BlockHeightReachedDataItem {\n");
            sb.Append("  Blockchain: ").Append(Blockchain).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
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
            return this.Equals(input as BlockHeightReachedDataItem);
        }

        /// <summary>
        /// Returns true if BlockHeightReachedDataItem instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockHeightReachedDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockHeightReachedDataItem input)
        {
            if (input == null)
            {
                return false;
            }
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
                if (this.Blockchain != null)
                {
                    hashCode = (hashCode * 59) + this.Blockchain.GetHashCode();
                }
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
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
