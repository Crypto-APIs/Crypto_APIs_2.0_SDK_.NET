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
    /// NewBlockE400
    /// </summary>
    [JsonConverter(typeof(NewBlockE400JsonConverter))]
    [DataContract(Name = "NewBlockE400")]
    public partial class NewBlockE400 : AbstractOpenAPISchema, IEquatable<NewBlockE400>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewBlockE400" /> class
        /// with the <see cref="UriNotFound" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UriNotFound.</param>
        public NewBlockE400(UriNotFound actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewBlockE400" /> class
        /// with the <see cref="LimitGreaterThanAllowed" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of LimitGreaterThanAllowed.</param>
        public NewBlockE400(LimitGreaterThanAllowed actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewBlockE400" /> class
        /// with the <see cref="InvalidPagination" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InvalidPagination.</param>
        public NewBlockE400(InvalidPagination actualInstance)
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
                if (value.GetType() == typeof(InvalidPagination))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(LimitGreaterThanAllowed))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UriNotFound))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: InvalidPagination, LimitGreaterThanAllowed, UriNotFound");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `UriNotFound`. If the actual instance is not `UriNotFound`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UriNotFound</returns>
        public UriNotFound GetUriNotFound()
        {
            return (UriNotFound)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `LimitGreaterThanAllowed`. If the actual instance is not `LimitGreaterThanAllowed`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of LimitGreaterThanAllowed</returns>
        public LimitGreaterThanAllowed GetLimitGreaterThanAllowed()
        {
            return (LimitGreaterThanAllowed)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `InvalidPagination`. If the actual instance is not `InvalidPagination`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InvalidPagination</returns>
        public InvalidPagination GetInvalidPagination()
        {
            return (InvalidPagination)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewBlockE400 {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, NewBlockE400.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of NewBlockE400
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of NewBlockE400</returns>
        public static NewBlockE400 FromJson(string jsonString)
        {
            NewBlockE400 newNewBlockE400 = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newNewBlockE400;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InvalidPagination).GetProperty("AdditionalProperties") == null)
                {
                    newNewBlockE400 = new NewBlockE400(JsonConvert.DeserializeObject<InvalidPagination>(jsonString, NewBlockE400.SerializerSettings));
                }
                else
                {
                    newNewBlockE400 = new NewBlockE400(JsonConvert.DeserializeObject<InvalidPagination>(jsonString, NewBlockE400.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InvalidPagination");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InvalidPagination: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(LimitGreaterThanAllowed).GetProperty("AdditionalProperties") == null)
                {
                    newNewBlockE400 = new NewBlockE400(JsonConvert.DeserializeObject<LimitGreaterThanAllowed>(jsonString, NewBlockE400.SerializerSettings));
                }
                else
                {
                    newNewBlockE400 = new NewBlockE400(JsonConvert.DeserializeObject<LimitGreaterThanAllowed>(jsonString, NewBlockE400.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("LimitGreaterThanAllowed");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into LimitGreaterThanAllowed: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UriNotFound).GetProperty("AdditionalProperties") == null)
                {
                    newNewBlockE400 = new NewBlockE400(JsonConvert.DeserializeObject<UriNotFound>(jsonString, NewBlockE400.SerializerSettings));
                }
                else
                {
                    newNewBlockE400 = new NewBlockE400(JsonConvert.DeserializeObject<UriNotFound>(jsonString, NewBlockE400.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("UriNotFound");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UriNotFound: {1}", jsonString, exception.ToString()));
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
            return newNewBlockE400;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NewBlockE400);
        }

        /// <summary>
        /// Returns true if NewBlockE400 instances are equal
        /// </summary>
        /// <param name="input">Instance of NewBlockE400 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewBlockE400 input)
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
    /// Custom JSON converter for NewBlockE400
    /// </summary>
    public class NewBlockE400JsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(NewBlockE400).GetMethod("ToJson").Invoke(value, null)));
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
                return NewBlockE400.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
