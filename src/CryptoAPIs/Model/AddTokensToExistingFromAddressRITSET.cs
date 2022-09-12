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
    /// Ethereum Token
    /// </summary>
    [DataContract(Name = "AddTokensToExistingFromAddressRITSET")]
    public partial class AddTokensToExistingFromAddressRITSET : IEquatable<AddTokensToExistingFromAddressRITSET>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTokensToExistingFromAddressRITSET" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddTokensToExistingFromAddressRITSET() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTokensToExistingFromAddressRITSET" /> class.
        /// </summary>
        /// <param name="contractAddress">Token contract address to be transferred (required).</param>
        public AddTokensToExistingFromAddressRITSET(string contractAddress = default(string))
        {
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for AddTokensToExistingFromAddressRITSET and cannot be null");
            }
            this.ContractAddress = contractAddress;
        }

        /// <summary>
        /// Token contract address to be transferred
        /// </summary>
        /// <value>Token contract address to be transferred</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = false)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddTokensToExistingFromAddressRITSET {\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
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
            return this.Equals(input as AddTokensToExistingFromAddressRITSET);
        }

        /// <summary>
        /// Returns true if AddTokensToExistingFromAddressRITSET instances are equal
        /// </summary>
        /// <param name="input">Instance of AddTokensToExistingFromAddressRITSET to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddTokensToExistingFromAddressRITSET input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
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
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
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
