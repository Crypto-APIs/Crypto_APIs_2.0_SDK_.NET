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
    /// GetAddressDetailsRI
    /// </summary>
    [DataContract(Name = "GetAddressDetailsRI")]
    public partial class GetAddressDetailsRI : IEquatable<GetAddressDetailsRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddressDetailsRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAddressDetailsRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddressDetailsRI" /> class.
        /// </summary>
        /// <param name="transactionsCount">Represents the total number of confirmed coins transactions for this address, both incoming and outgoing. Applies for coins only **and not** tokens transfers e.g. for Ethereum. &#x60;transactionsCount&#x60; could result as less than incoming and outgoing transactions put together (e.g. in Bitcoin), due to the fact that one and the same address could be in senders and receivers addresses. (required).</param>
        /// <param name="confirmedBalance">confirmedBalance (required).</param>
        /// <param name="totalReceived">totalReceived (required).</param>
        /// <param name="totalSpent">totalSpent (required).</param>
        /// <param name="incomingTransactionsCount">Numeric representation of the received transaction count of the address (required).</param>
        /// <param name="outgoingTransactionsCount">Numeric representation of the sent transaction count of the address (required).</param>
        public GetAddressDetailsRI(int transactionsCount = default(int), GetAddressDetailsRIConfirmedBalance confirmedBalance = default(GetAddressDetailsRIConfirmedBalance), GetAddressDetailsRITotalReceived totalReceived = default(GetAddressDetailsRITotalReceived), GetAddressDetailsRITotalSpent totalSpent = default(GetAddressDetailsRITotalSpent), int incomingTransactionsCount = default(int), int outgoingTransactionsCount = default(int))
        {
            this.TransactionsCount = transactionsCount;
            // to ensure "confirmedBalance" is required (not null)
            if (confirmedBalance == null)
            {
                throw new ArgumentNullException("confirmedBalance is a required property for GetAddressDetailsRI and cannot be null");
            }
            this.ConfirmedBalance = confirmedBalance;
            // to ensure "totalReceived" is required (not null)
            if (totalReceived == null)
            {
                throw new ArgumentNullException("totalReceived is a required property for GetAddressDetailsRI and cannot be null");
            }
            this.TotalReceived = totalReceived;
            // to ensure "totalSpent" is required (not null)
            if (totalSpent == null)
            {
                throw new ArgumentNullException("totalSpent is a required property for GetAddressDetailsRI and cannot be null");
            }
            this.TotalSpent = totalSpent;
            this.IncomingTransactionsCount = incomingTransactionsCount;
            this.OutgoingTransactionsCount = outgoingTransactionsCount;
        }

        /// <summary>
        /// Represents the total number of confirmed coins transactions for this address, both incoming and outgoing. Applies for coins only **and not** tokens transfers e.g. for Ethereum. &#x60;transactionsCount&#x60; could result as less than incoming and outgoing transactions put together (e.g. in Bitcoin), due to the fact that one and the same address could be in senders and receivers addresses.
        /// </summary>
        /// <value>Represents the total number of confirmed coins transactions for this address, both incoming and outgoing. Applies for coins only **and not** tokens transfers e.g. for Ethereum. &#x60;transactionsCount&#x60; could result as less than incoming and outgoing transactions put together (e.g. in Bitcoin), due to the fact that one and the same address could be in senders and receivers addresses.</value>
        [DataMember(Name = "transactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int TransactionsCount { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedBalance
        /// </summary>
        [DataMember(Name = "confirmedBalance", IsRequired = true, EmitDefaultValue = false)]
        public GetAddressDetailsRIConfirmedBalance ConfirmedBalance { get; set; }

        /// <summary>
        /// Gets or Sets TotalReceived
        /// </summary>
        [DataMember(Name = "totalReceived", IsRequired = true, EmitDefaultValue = false)]
        public GetAddressDetailsRITotalReceived TotalReceived { get; set; }

        /// <summary>
        /// Gets or Sets TotalSpent
        /// </summary>
        [DataMember(Name = "totalSpent", IsRequired = true, EmitDefaultValue = false)]
        public GetAddressDetailsRITotalSpent TotalSpent { get; set; }

        /// <summary>
        /// Numeric representation of the received transaction count of the address
        /// </summary>
        /// <value>Numeric representation of the received transaction count of the address</value>
        [DataMember(Name = "incomingTransactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int IncomingTransactionsCount { get; set; }

        /// <summary>
        /// Numeric representation of the sent transaction count of the address
        /// </summary>
        /// <value>Numeric representation of the sent transaction count of the address</value>
        [DataMember(Name = "outgoingTransactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int OutgoingTransactionsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAddressDetailsRI {\n");
            sb.Append("  TransactionsCount: ").Append(TransactionsCount).Append("\n");
            sb.Append("  ConfirmedBalance: ").Append(ConfirmedBalance).Append("\n");
            sb.Append("  TotalReceived: ").Append(TotalReceived).Append("\n");
            sb.Append("  TotalSpent: ").Append(TotalSpent).Append("\n");
            sb.Append("  IncomingTransactionsCount: ").Append(IncomingTransactionsCount).Append("\n");
            sb.Append("  OutgoingTransactionsCount: ").Append(OutgoingTransactionsCount).Append("\n");
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
            return this.Equals(input as GetAddressDetailsRI);
        }

        /// <summary>
        /// Returns true if GetAddressDetailsRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAddressDetailsRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAddressDetailsRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionsCount == input.TransactionsCount ||
                    this.TransactionsCount.Equals(input.TransactionsCount)
                ) && 
                (
                    this.ConfirmedBalance == input.ConfirmedBalance ||
                    (this.ConfirmedBalance != null &&
                    this.ConfirmedBalance.Equals(input.ConfirmedBalance))
                ) && 
                (
                    this.TotalReceived == input.TotalReceived ||
                    (this.TotalReceived != null &&
                    this.TotalReceived.Equals(input.TotalReceived))
                ) && 
                (
                    this.TotalSpent == input.TotalSpent ||
                    (this.TotalSpent != null &&
                    this.TotalSpent.Equals(input.TotalSpent))
                ) && 
                (
                    this.IncomingTransactionsCount == input.IncomingTransactionsCount ||
                    this.IncomingTransactionsCount.Equals(input.IncomingTransactionsCount)
                ) && 
                (
                    this.OutgoingTransactionsCount == input.OutgoingTransactionsCount ||
                    this.OutgoingTransactionsCount.Equals(input.OutgoingTransactionsCount)
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
                hashCode = (hashCode * 59) + this.TransactionsCount.GetHashCode();
                if (this.ConfirmedBalance != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmedBalance.GetHashCode();
                }
                if (this.TotalReceived != null)
                {
                    hashCode = (hashCode * 59) + this.TotalReceived.GetHashCode();
                }
                if (this.TotalSpent != null)
                {
                    hashCode = (hashCode * 59) + this.TotalSpent.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncomingTransactionsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.OutgoingTransactionsCount.GetHashCode();
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
