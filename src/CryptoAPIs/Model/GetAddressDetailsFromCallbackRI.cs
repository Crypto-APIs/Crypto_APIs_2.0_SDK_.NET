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
    /// GetAddressDetailsFromCallbackRI
    /// </summary>
    [DataContract(Name = "GetAddressDetailsFromCallbackRI")]
    public partial class GetAddressDetailsFromCallbackRI : IEquatable<GetAddressDetailsFromCallbackRI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddressDetailsFromCallbackRI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAddressDetailsFromCallbackRI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAddressDetailsFromCallbackRI" /> class.
        /// </summary>
        /// <param name="incomingTransactionsCount">Defines the received transaction count to the address. (required).</param>
        /// <param name="outgoingTransactionsCount">Defines the sent transaction count from the address. (required).</param>
        /// <param name="transactionsCount">Represents the total number of confirmed coins transactions for this address, both incoming and outgoing. Applies for coins only and not tokens transfers e.g. for Ethereum. transactionsCount could result as less than incoming and outgoing transactions put together (e.g. in Bitcoin), due to the fact that one and the same address could be in senders and receivers addresses. (required).</param>
        /// <param name="confirmedBalance">confirmedBalance (required).</param>
        /// <param name="totalReceived">totalReceived (required).</param>
        /// <param name="totalSpent">totalSpent (required).</param>
        /// <param name="sequence">Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime..</param>
        public GetAddressDetailsFromCallbackRI(int incomingTransactionsCount = default(int), int outgoingTransactionsCount = default(int), int transactionsCount = default(int), GetAddressDetailsFromCallbackRIConfirmedBalance confirmedBalance = default(GetAddressDetailsFromCallbackRIConfirmedBalance), GetAddressDetailsFromCallbackRITotalReceived totalReceived = default(GetAddressDetailsFromCallbackRITotalReceived), GetAddressDetailsFromCallbackRITotalSpent totalSpent = default(GetAddressDetailsFromCallbackRITotalSpent), long sequence = default(long))
        {
            this.IncomingTransactionsCount = incomingTransactionsCount;
            this.OutgoingTransactionsCount = outgoingTransactionsCount;
            this.TransactionsCount = transactionsCount;
            // to ensure "confirmedBalance" is required (not null)
            if (confirmedBalance == null)
            {
                throw new ArgumentNullException("confirmedBalance is a required property for GetAddressDetailsFromCallbackRI and cannot be null");
            }
            this.ConfirmedBalance = confirmedBalance;
            // to ensure "totalReceived" is required (not null)
            if (totalReceived == null)
            {
                throw new ArgumentNullException("totalReceived is a required property for GetAddressDetailsFromCallbackRI and cannot be null");
            }
            this.TotalReceived = totalReceived;
            // to ensure "totalSpent" is required (not null)
            if (totalSpent == null)
            {
                throw new ArgumentNullException("totalSpent is a required property for GetAddressDetailsFromCallbackRI and cannot be null");
            }
            this.TotalSpent = totalSpent;
            this.Sequence = sequence;
        }

        /// <summary>
        /// Defines the received transaction count to the address.
        /// </summary>
        /// <value>Defines the received transaction count to the address.</value>
        [DataMember(Name = "incomingTransactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int IncomingTransactionsCount { get; set; }

        /// <summary>
        /// Defines the sent transaction count from the address.
        /// </summary>
        /// <value>Defines the sent transaction count from the address.</value>
        [DataMember(Name = "outgoingTransactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int OutgoingTransactionsCount { get; set; }

        /// <summary>
        /// Represents the total number of confirmed coins transactions for this address, both incoming and outgoing. Applies for coins only and not tokens transfers e.g. for Ethereum. transactionsCount could result as less than incoming and outgoing transactions put together (e.g. in Bitcoin), due to the fact that one and the same address could be in senders and receivers addresses.
        /// </summary>
        /// <value>Represents the total number of confirmed coins transactions for this address, both incoming and outgoing. Applies for coins only and not tokens transfers e.g. for Ethereum. transactionsCount could result as less than incoming and outgoing transactions put together (e.g. in Bitcoin), due to the fact that one and the same address could be in senders and receivers addresses.</value>
        [DataMember(Name = "transactionsCount", IsRequired = true, EmitDefaultValue = false)]
        public int TransactionsCount { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedBalance
        /// </summary>
        [DataMember(Name = "confirmedBalance", IsRequired = true, EmitDefaultValue = false)]
        public GetAddressDetailsFromCallbackRIConfirmedBalance ConfirmedBalance { get; set; }

        /// <summary>
        /// Gets or Sets TotalReceived
        /// </summary>
        [DataMember(Name = "totalReceived", IsRequired = true, EmitDefaultValue = false)]
        public GetAddressDetailsFromCallbackRITotalReceived TotalReceived { get; set; }

        /// <summary>
        /// Gets or Sets TotalSpent
        /// </summary>
        [DataMember(Name = "totalSpent", IsRequired = true, EmitDefaultValue = false)]
        public GetAddressDetailsFromCallbackRITotalSpent TotalSpent { get; set; }

        /// <summary>
        /// Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime.
        /// </summary>
        /// <value>Defines the transaction input&#39;s sequence as an integer, which is is used when transactions are replaced with newer versions before LockTime.</value>
        [DataMember(Name = "sequence", EmitDefaultValue = false)]
        public long Sequence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAddressDetailsFromCallbackRI {\n");
            sb.Append("  IncomingTransactionsCount: ").Append(IncomingTransactionsCount).Append("\n");
            sb.Append("  OutgoingTransactionsCount: ").Append(OutgoingTransactionsCount).Append("\n");
            sb.Append("  TransactionsCount: ").Append(TransactionsCount).Append("\n");
            sb.Append("  ConfirmedBalance: ").Append(ConfirmedBalance).Append("\n");
            sb.Append("  TotalReceived: ").Append(TotalReceived).Append("\n");
            sb.Append("  TotalSpent: ").Append(TotalSpent).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
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
            return this.Equals(input as GetAddressDetailsFromCallbackRI);
        }

        /// <summary>
        /// Returns true if GetAddressDetailsFromCallbackRI instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAddressDetailsFromCallbackRI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAddressDetailsFromCallbackRI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IncomingTransactionsCount == input.IncomingTransactionsCount ||
                    this.IncomingTransactionsCount.Equals(input.IncomingTransactionsCount)
                ) && 
                (
                    this.OutgoingTransactionsCount == input.OutgoingTransactionsCount ||
                    this.OutgoingTransactionsCount.Equals(input.OutgoingTransactionsCount)
                ) && 
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
                    this.Sequence == input.Sequence ||
                    this.Sequence.Equals(input.Sequence)
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
                hashCode = (hashCode * 59) + this.IncomingTransactionsCount.GetHashCode();
                hashCode = (hashCode * 59) + this.OutgoingTransactionsCount.GetHashCode();
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
                hashCode = (hashCode * 59) + this.Sequence.GetHashCode();
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
