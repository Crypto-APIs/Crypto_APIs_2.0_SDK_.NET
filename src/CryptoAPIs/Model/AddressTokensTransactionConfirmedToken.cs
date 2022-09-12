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
    /// AddressTokensTransactionConfirmedToken
    /// </summary>
    [JsonConverter(typeof(AddressTokensTransactionConfirmedTokenJsonConverter))]
    [DataContract(Name = "AddressTokensTransactionConfirmedToken")]
    public partial class AddressTokensTransactionConfirmedToken : AbstractOpenAPISchema, IEquatable<AddressTokensTransactionConfirmedToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedToken" /> class
        /// with the <see cref="AddressTokensTransactionConfirmedErc20" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressTokensTransactionConfirmedErc20.</param>
        public AddressTokensTransactionConfirmedToken(AddressTokensTransactionConfirmedErc20 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedToken" /> class
        /// with the <see cref="AddressTokensTransactionConfirmedErc721" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressTokensTransactionConfirmedErc721.</param>
        public AddressTokensTransactionConfirmedToken(AddressTokensTransactionConfirmedErc721 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedToken" /> class
        /// with the <see cref="AddressTokensTransactionConfirmedOmni" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressTokensTransactionConfirmedOmni.</param>
        public AddressTokensTransactionConfirmedToken(AddressTokensTransactionConfirmedOmni actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTokensTransactionConfirmedToken" /> class
        /// with the <see cref="AddressTokensTransactionConfirmedBep20" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AddressTokensTransactionConfirmedBep20.</param>
        public AddressTokensTransactionConfirmedToken(AddressTokensTransactionConfirmedBep20 actualInstance)
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
                if (value.GetType() == typeof(AddressTokensTransactionConfirmedBep20))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AddressTokensTransactionConfirmedErc20))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AddressTokensTransactionConfirmedErc721))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AddressTokensTransactionConfirmedOmni))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AddressTokensTransactionConfirmedBep20, AddressTokensTransactionConfirmedErc20, AddressTokensTransactionConfirmedErc721, AddressTokensTransactionConfirmedOmni");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AddressTokensTransactionConfirmedErc20`. If the actual instance is not `AddressTokensTransactionConfirmedErc20`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressTokensTransactionConfirmedErc20</returns>
        public AddressTokensTransactionConfirmedErc20 GetAddressTokensTransactionConfirmedErc20()
        {
            return (AddressTokensTransactionConfirmedErc20)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AddressTokensTransactionConfirmedErc721`. If the actual instance is not `AddressTokensTransactionConfirmedErc721`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressTokensTransactionConfirmedErc721</returns>
        public AddressTokensTransactionConfirmedErc721 GetAddressTokensTransactionConfirmedErc721()
        {
            return (AddressTokensTransactionConfirmedErc721)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AddressTokensTransactionConfirmedOmni`. If the actual instance is not `AddressTokensTransactionConfirmedOmni`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressTokensTransactionConfirmedOmni</returns>
        public AddressTokensTransactionConfirmedOmni GetAddressTokensTransactionConfirmedOmni()
        {
            return (AddressTokensTransactionConfirmedOmni)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AddressTokensTransactionConfirmedBep20`. If the actual instance is not `AddressTokensTransactionConfirmedBep20`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AddressTokensTransactionConfirmedBep20</returns>
        public AddressTokensTransactionConfirmedBep20 GetAddressTokensTransactionConfirmedBep20()
        {
            return (AddressTokensTransactionConfirmedBep20)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressTokensTransactionConfirmedToken {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AddressTokensTransactionConfirmedToken.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AddressTokensTransactionConfirmedToken
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AddressTokensTransactionConfirmedToken</returns>
        public static AddressTokensTransactionConfirmedToken FromJson(string jsonString)
        {
            AddressTokensTransactionConfirmedToken newAddressTokensTransactionConfirmedToken = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAddressTokensTransactionConfirmedToken;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressTokensTransactionConfirmedBep20).GetProperty("AdditionalProperties") == null)
                {
                    newAddressTokensTransactionConfirmedToken = new AddressTokensTransactionConfirmedToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedBep20>(jsonString, AddressTokensTransactionConfirmedToken.SerializerSettings));
                }
                else
                {
                    newAddressTokensTransactionConfirmedToken = new AddressTokensTransactionConfirmedToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedBep20>(jsonString, AddressTokensTransactionConfirmedToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressTokensTransactionConfirmedBep20");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressTokensTransactionConfirmedBep20: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressTokensTransactionConfirmedErc20).GetProperty("AdditionalProperties") == null)
                {
                    newAddressTokensTransactionConfirmedToken = new AddressTokensTransactionConfirmedToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedErc20>(jsonString, AddressTokensTransactionConfirmedToken.SerializerSettings));
                }
                else
                {
                    newAddressTokensTransactionConfirmedToken = new AddressTokensTransactionConfirmedToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedErc20>(jsonString, AddressTokensTransactionConfirmedToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressTokensTransactionConfirmedErc20");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressTokensTransactionConfirmedErc20: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressTokensTransactionConfirmedErc721).GetProperty("AdditionalProperties") == null)
                {
                    newAddressTokensTransactionConfirmedToken = new AddressTokensTransactionConfirmedToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedErc721>(jsonString, AddressTokensTransactionConfirmedToken.SerializerSettings));
                }
                else
                {
                    newAddressTokensTransactionConfirmedToken = new AddressTokensTransactionConfirmedToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedErc721>(jsonString, AddressTokensTransactionConfirmedToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressTokensTransactionConfirmedErc721");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressTokensTransactionConfirmedErc721: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AddressTokensTransactionConfirmedOmni).GetProperty("AdditionalProperties") == null)
                {
                    newAddressTokensTransactionConfirmedToken = new AddressTokensTransactionConfirmedToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedOmni>(jsonString, AddressTokensTransactionConfirmedToken.SerializerSettings));
                }
                else
                {
                    newAddressTokensTransactionConfirmedToken = new AddressTokensTransactionConfirmedToken(JsonConvert.DeserializeObject<AddressTokensTransactionConfirmedOmni>(jsonString, AddressTokensTransactionConfirmedToken.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AddressTokensTransactionConfirmedOmni");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AddressTokensTransactionConfirmedOmni: {1}", jsonString, exception.ToString()));
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
            return newAddressTokensTransactionConfirmedToken;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddressTokensTransactionConfirmedToken);
        }

        /// <summary>
        /// Returns true if AddressTokensTransactionConfirmedToken instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressTokensTransactionConfirmedToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressTokensTransactionConfirmedToken input)
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
    /// Custom JSON converter for AddressTokensTransactionConfirmedToken
    /// </summary>
    public class AddressTokensTransactionConfirmedTokenJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AddressTokensTransactionConfirmedToken).GetMethod("ToJson").Invoke(value, null)));
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
                return AddressTokensTransactionConfirmedToken.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
