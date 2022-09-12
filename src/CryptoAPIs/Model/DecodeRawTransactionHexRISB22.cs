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
    /// Binance Smart Chain
    /// </summary>
    [DataContract(Name = "DecodeRawTransactionHexRISB22")]
    public partial class DecodeRawTransactionHexRISB22 : IEquatable<DecodeRawTransactionHexRISB22>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRawTransactionHexRISB22" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DecodeRawTransactionHexRISB22() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DecodeRawTransactionHexRISB22" /> class.
        /// </summary>
        /// <param name="approximateFee">Defines the approximate fee value. When isConfirmed is True - Defines the amount of the transaction fee When isConfirmed is False - For ETH-based blockchains this attribute represents the max fee value..</param>
        /// <param name="approximateMinimumRequiredFee">Defines the approximate minimum fee that is required for the transaction..</param>
        /// <param name="gasLimit">Represents the amount of gas used by this specific transaction alone. (required).</param>
        /// <param name="gasPaidForData">Represents the amount of gas paid for the data in the transaction..</param>
        /// <param name="gasPrice">Represents the price offered to the miner to purchase this amount of gas..</param>
        /// <param name="inputData">Represents additional information that is required for the transaction..</param>
        /// <param name="nonce">Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address. (required).</param>
        /// <param name="r">Represents output of an ECDSA signature..</param>
        /// <param name="recipient">The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one recipient. (required).</param>
        /// <param name="s">Represents output of an ECDSA signature..</param>
        /// <param name="sender">Represents the address which sends this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one sender. (required).</param>
        /// <param name="type">Specifies the transaction type as one from three options: if response returns a &#x60;\&quot;0\&quot;&#x60; it means the raw transaction includes legacy transaction data, if it is &#x60;\&quot;1\&quot;&#x60; - includes access lists for EIP2930, and if it is &#x60;\&quot;2\&quot;&#x60; - EIP1559 data. (required).</param>
        /// <param name="v">Defines the the recovery id..</param>
        /// <param name="value">Represents the sent/received amount..</param>
        public DecodeRawTransactionHexRISB22(string approximateFee = default(string), string approximateMinimumRequiredFee = default(string), string gasLimit = default(string), string gasPaidForData = default(string), string gasPrice = default(string), string inputData = default(string), int nonce = default(int), string r = default(string), string recipient = default(string), string s = default(string), string sender = default(string), int type = default(int), string v = default(string), string value = default(string))
        {
            // to ensure "gasLimit" is required (not null)
            if (gasLimit == null)
            {
                throw new ArgumentNullException("gasLimit is a required property for DecodeRawTransactionHexRISB22 and cannot be null");
            }
            this.GasLimit = gasLimit;
            this.Nonce = nonce;
            // to ensure "recipient" is required (not null)
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient is a required property for DecodeRawTransactionHexRISB22 and cannot be null");
            }
            this.Recipient = recipient;
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for DecodeRawTransactionHexRISB22 and cannot be null");
            }
            this.Sender = sender;
            this.Type = type;
            this.ApproximateFee = approximateFee;
            this.ApproximateMinimumRequiredFee = approximateMinimumRequiredFee;
            this.GasPaidForData = gasPaidForData;
            this.GasPrice = gasPrice;
            this.InputData = inputData;
            this.R = r;
            this.S = s;
            this.V = v;
            this.Value = value;
        }

        /// <summary>
        /// Defines the approximate fee value. When isConfirmed is True - Defines the amount of the transaction fee When isConfirmed is False - For ETH-based blockchains this attribute represents the max fee value.
        /// </summary>
        /// <value>Defines the approximate fee value. When isConfirmed is True - Defines the amount of the transaction fee When isConfirmed is False - For ETH-based blockchains this attribute represents the max fee value.</value>
        [DataMember(Name = "approximateFee", EmitDefaultValue = false)]
        public string ApproximateFee { get; set; }

        /// <summary>
        /// Defines the approximate minimum fee that is required for the transaction.
        /// </summary>
        /// <value>Defines the approximate minimum fee that is required for the transaction.</value>
        [DataMember(Name = "approximateMinimumRequiredFee", EmitDefaultValue = false)]
        public string ApproximateMinimumRequiredFee { get; set; }

        /// <summary>
        /// Represents the amount of gas used by this specific transaction alone.
        /// </summary>
        /// <value>Represents the amount of gas used by this specific transaction alone.</value>
        [DataMember(Name = "gasLimit", IsRequired = true, EmitDefaultValue = false)]
        public string GasLimit { get; set; }

        /// <summary>
        /// Represents the amount of gas paid for the data in the transaction.
        /// </summary>
        /// <value>Represents the amount of gas paid for the data in the transaction.</value>
        [DataMember(Name = "gasPaidForData", EmitDefaultValue = false)]
        public string GasPaidForData { get; set; }

        /// <summary>
        /// Represents the price offered to the miner to purchase this amount of gas.
        /// </summary>
        /// <value>Represents the price offered to the miner to purchase this amount of gas.</value>
        [DataMember(Name = "gasPrice", EmitDefaultValue = false)]
        public string GasPrice { get; set; }

        /// <summary>
        /// Represents additional information that is required for the transaction.
        /// </summary>
        /// <value>Represents additional information that is required for the transaction.</value>
        [DataMember(Name = "inputData", EmitDefaultValue = false)]
        public string InputData { get; set; }

        /// <summary>
        /// Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address.
        /// </summary>
        /// <value>Represents the sequential running number for an address, starting from 0 for the first transaction. E.g., if the nonce of a transaction is 10, it would be the 11th transaction sent from the sender&#39;s address.</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = false)]
        public int Nonce { get; set; }

        /// <summary>
        /// Represents output of an ECDSA signature.
        /// </summary>
        /// <value>Represents output of an ECDSA signature.</value>
        [DataMember(Name = "r", EmitDefaultValue = false)]
        public string R { get; set; }

        /// <summary>
        /// The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one recipient.
        /// </summary>
        /// <value>The address which receives this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one recipient.</value>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Represents output of an ECDSA signature.
        /// </summary>
        /// <value>Represents output of an ECDSA signature.</value>
        [DataMember(Name = "s", EmitDefaultValue = false)]
        public string S { get; set; }

        /// <summary>
        /// Represents the address which sends this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one sender.
        /// </summary>
        /// <value>Represents the address which sends this transaction. In UTXO-based protocols like Bitcoin there could be several senders while in account-based protocols like Ethereum there is always only one sender.</value>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = false)]
        public string Sender { get; set; }

        /// <summary>
        /// Specifies the transaction type as one from three options: if response returns a &#x60;\&quot;0\&quot;&#x60; it means the raw transaction includes legacy transaction data, if it is &#x60;\&quot;1\&quot;&#x60; - includes access lists for EIP2930, and if it is &#x60;\&quot;2\&quot;&#x60; - EIP1559 data.
        /// </summary>
        /// <value>Specifies the transaction type as one from three options: if response returns a &#x60;\&quot;0\&quot;&#x60; it means the raw transaction includes legacy transaction data, if it is &#x60;\&quot;1\&quot;&#x60; - includes access lists for EIP2930, and if it is &#x60;\&quot;2\&quot;&#x60; - EIP1559 data.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public int Type { get; set; }

        /// <summary>
        /// Defines the the recovery id.
        /// </summary>
        /// <value>Defines the the recovery id.</value>
        [DataMember(Name = "v", EmitDefaultValue = false)]
        public string V { get; set; }

        /// <summary>
        /// Represents the sent/received amount.
        /// </summary>
        /// <value>Represents the sent/received amount.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DecodeRawTransactionHexRISB22 {\n");
            sb.Append("  ApproximateFee: ").Append(ApproximateFee).Append("\n");
            sb.Append("  ApproximateMinimumRequiredFee: ").Append(ApproximateMinimumRequiredFee).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  GasPaidForData: ").Append(GasPaidForData).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
            sb.Append("  InputData: ").Append(InputData).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  S: ").Append(S).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  V: ").Append(V).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as DecodeRawTransactionHexRISB22);
        }

        /// <summary>
        /// Returns true if DecodeRawTransactionHexRISB22 instances are equal
        /// </summary>
        /// <param name="input">Instance of DecodeRawTransactionHexRISB22 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecodeRawTransactionHexRISB22 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApproximateFee == input.ApproximateFee ||
                    (this.ApproximateFee != null &&
                    this.ApproximateFee.Equals(input.ApproximateFee))
                ) && 
                (
                    this.ApproximateMinimumRequiredFee == input.ApproximateMinimumRequiredFee ||
                    (this.ApproximateMinimumRequiredFee != null &&
                    this.ApproximateMinimumRequiredFee.Equals(input.ApproximateMinimumRequiredFee))
                ) && 
                (
                    this.GasLimit == input.GasLimit ||
                    (this.GasLimit != null &&
                    this.GasLimit.Equals(input.GasLimit))
                ) && 
                (
                    this.GasPaidForData == input.GasPaidForData ||
                    (this.GasPaidForData != null &&
                    this.GasPaidForData.Equals(input.GasPaidForData))
                ) && 
                (
                    this.GasPrice == input.GasPrice ||
                    (this.GasPrice != null &&
                    this.GasPrice.Equals(input.GasPrice))
                ) && 
                (
                    this.InputData == input.InputData ||
                    (this.InputData != null &&
                    this.InputData.Equals(input.InputData))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.R == input.R ||
                    (this.R != null &&
                    this.R.Equals(input.R))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.S == input.S ||
                    (this.S != null &&
                    this.S.Equals(input.S))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.V == input.V ||
                    (this.V != null &&
                    this.V.Equals(input.V))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.ApproximateFee != null)
                {
                    hashCode = (hashCode * 59) + this.ApproximateFee.GetHashCode();
                }
                if (this.ApproximateMinimumRequiredFee != null)
                {
                    hashCode = (hashCode * 59) + this.ApproximateMinimumRequiredFee.GetHashCode();
                }
                if (this.GasLimit != null)
                {
                    hashCode = (hashCode * 59) + this.GasLimit.GetHashCode();
                }
                if (this.GasPaidForData != null)
                {
                    hashCode = (hashCode * 59) + this.GasPaidForData.GetHashCode();
                }
                if (this.GasPrice != null)
                {
                    hashCode = (hashCode * 59) + this.GasPrice.GetHashCode();
                }
                if (this.InputData != null)
                {
                    hashCode = (hashCode * 59) + this.InputData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.R != null)
                {
                    hashCode = (hashCode * 59) + this.R.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.S != null)
                {
                    hashCode = (hashCode * 59) + this.S.GetHashCode();
                }
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.V != null)
                {
                    hashCode = (hashCode * 59) + this.V.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
