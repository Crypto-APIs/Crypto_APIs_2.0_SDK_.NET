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
using System.Reflection;

namespace CryptoAPIs.Model
{
    /// <summary>
    /// AddTokensToExistingFromAddressRBTokenData
    /// </summary>
    [JsonConverter(typeof(AddTokensToExistingFromAddressRBTokenDataJsonConverter))]
    [DataContract(Name = "AddTokensToExistingFromAddressRBTokenData")]
    public partial class AddTokensToExistingFromAddressRBTokenData : AbstractOpenAPISchema, IEquatable<AddTokensToExistingFromAddressRBTokenData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTokensToExistingFromAddressRBTokenData" /> class
        /// with the <see cref="AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken.</param>
        public AddTokensToExistingFromAddressRBTokenData(AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTokensToExistingFromAddressRBTokenData" /> class
        /// with the <see cref="AddTokensToExistingFromAddressRBTokenDataEthereumToken" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddTokensToExistingFromAddressRBTokenDataEthereumToken.</param>
        public AddTokensToExistingFromAddressRBTokenData(AddTokensToExistingFromAddressRBTokenDataEthereumToken actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AddTokensToExistingFromAddressRBTokenDataEthereumToken))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken, AddTokensToExistingFromAddressRBTokenDataEthereumToken");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken`. If the actual instance is not `AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken</returns>
        public AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken GetAddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken()
        {
            return (AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AddTokensToExistingFromAddressRBTokenDataEthereumToken`. If the actual instance is not `AddTokensToExistingFromAddressRBTokenDataEthereumToken`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddTokensToExistingFromAddressRBTokenDataEthereumToken</returns>
        public AddTokensToExistingFromAddressRBTokenDataEthereumToken GetAddTokensToExistingFromAddressRBTokenDataEthereumToken()
        {
            return (AddTokensToExistingFromAddressRBTokenDataEthereumToken)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddTokensToExistingFromAddressRBTokenData {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, AddTokensToExistingFromAddressRBTokenData.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AddTokensToExistingFromAddressRBTokenData
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AddTokensToExistingFromAddressRBTokenData</returns>
        public static AddTokensToExistingFromAddressRBTokenData FromJson(string jsonString)
        {
            AddTokensToExistingFromAddressRBTokenData newAddTokensToExistingFromAddressRBTokenData = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAddTokensToExistingFromAddressRBTokenData;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken).GetProperty("AdditionalProperties") == null)
                {
                    newAddTokensToExistingFromAddressRBTokenData = new AddTokensToExistingFromAddressRBTokenData(JsonConvert.DeserializeObject<AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken>(jsonString, AddTokensToExistingFromAddressRBTokenData.SerializerSettings));
                }
                else
                {
                    newAddTokensToExistingFromAddressRBTokenData = new AddTokensToExistingFromAddressRBTokenData(JsonConvert.DeserializeObject<AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken>(jsonString, AddTokensToExistingFromAddressRBTokenData.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddTokensToExistingFromAddressRBTokenDataBitcoinOmniToken: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddTokensToExistingFromAddressRBTokenDataEthereumToken).GetProperty("AdditionalProperties") == null)
                {
                    newAddTokensToExistingFromAddressRBTokenData = new AddTokensToExistingFromAddressRBTokenData(JsonConvert.DeserializeObject<AddTokensToExistingFromAddressRBTokenDataEthereumToken>(jsonString, AddTokensToExistingFromAddressRBTokenData.SerializerSettings));
                }
                else
                {
                    newAddTokensToExistingFromAddressRBTokenData = new AddTokensToExistingFromAddressRBTokenData(JsonConvert.DeserializeObject<AddTokensToExistingFromAddressRBTokenDataEthereumToken>(jsonString, AddTokensToExistingFromAddressRBTokenData.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddTokensToExistingFromAddressRBTokenDataEthereumToken");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddTokensToExistingFromAddressRBTokenDataEthereumToken: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newAddTokensToExistingFromAddressRBTokenData;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddTokensToExistingFromAddressRBTokenData);
        }

        /// <summary>
        /// Returns true if AddTokensToExistingFromAddressRBTokenData instances are equal
        /// </summary>
        /// <param name="input">Instance of AddTokensToExistingFromAddressRBTokenData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddTokensToExistingFromAddressRBTokenData input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for AddTokensToExistingFromAddressRBTokenData
    /// </summary>
    public class AddTokensToExistingFromAddressRBTokenDataJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AddTokensToExistingFromAddressRBTokenData).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return AddTokensToExistingFromAddressRBTokenData.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
