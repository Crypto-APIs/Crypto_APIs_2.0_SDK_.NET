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
    /// SyncNewHDWalletXPubYPubZPubE422
    /// </summary>
    [JsonConverter(typeof(SyncNewHDWalletXPubYPubZPubE422JsonConverter))]
    [DataContract(Name = "SyncNewHDWalletXPubYPubZPubE422")]
    public partial class SyncNewHDWalletXPubYPubZPubE422 : AbstractOpenAPISchema, IEquatable<SyncNewHDWalletXPubYPubZPubE422>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncNewHDWalletXPubYPubZPubE422" /> class
        /// with the <see cref="InvalidRequestBodyStructure" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of InvalidRequestBodyStructure.</param>
        public SyncNewHDWalletXPubYPubZPubE422(InvalidRequestBodyStructure actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncNewHDWalletXPubYPubZPubE422" /> class
        /// with the <see cref="XpubSyncInProgress" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of XpubSyncInProgress.</param>
        public SyncNewHDWalletXPubYPubZPubE422(XpubSyncInProgress actualInstance)
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
                if (value.GetType() == typeof(InvalidRequestBodyStructure))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(XpubSyncInProgress))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: InvalidRequestBodyStructure, XpubSyncInProgress");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `InvalidRequestBodyStructure`. If the actual instance is not `InvalidRequestBodyStructure`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of InvalidRequestBodyStructure</returns>
        public InvalidRequestBodyStructure GetInvalidRequestBodyStructure()
        {
            return (InvalidRequestBodyStructure)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `XpubSyncInProgress`. If the actual instance is not `XpubSyncInProgress`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of XpubSyncInProgress</returns>
        public XpubSyncInProgress GetXpubSyncInProgress()
        {
            return (XpubSyncInProgress)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncNewHDWalletXPubYPubZPubE422 {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, SyncNewHDWalletXPubYPubZPubE422.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SyncNewHDWalletXPubYPubZPubE422
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SyncNewHDWalletXPubYPubZPubE422</returns>
        public static SyncNewHDWalletXPubYPubZPubE422 FromJson(string jsonString)
        {
            SyncNewHDWalletXPubYPubZPubE422 newSyncNewHDWalletXPubYPubZPubE422 = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSyncNewHDWalletXPubYPubZPubE422;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(InvalidRequestBodyStructure).GetProperty("AdditionalProperties") == null)
                {
                    newSyncNewHDWalletXPubYPubZPubE422 = new SyncNewHDWalletXPubYPubZPubE422(JsonConvert.DeserializeObject<InvalidRequestBodyStructure>(jsonString, SyncNewHDWalletXPubYPubZPubE422.SerializerSettings));
                }
                else
                {
                    newSyncNewHDWalletXPubYPubZPubE422 = new SyncNewHDWalletXPubYPubZPubE422(JsonConvert.DeserializeObject<InvalidRequestBodyStructure>(jsonString, SyncNewHDWalletXPubYPubZPubE422.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("InvalidRequestBodyStructure");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into InvalidRequestBodyStructure: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(XpubSyncInProgress).GetProperty("AdditionalProperties") == null)
                {
                    newSyncNewHDWalletXPubYPubZPubE422 = new SyncNewHDWalletXPubYPubZPubE422(JsonConvert.DeserializeObject<XpubSyncInProgress>(jsonString, SyncNewHDWalletXPubYPubZPubE422.SerializerSettings));
                }
                else
                {
                    newSyncNewHDWalletXPubYPubZPubE422 = new SyncNewHDWalletXPubYPubZPubE422(JsonConvert.DeserializeObject<XpubSyncInProgress>(jsonString, SyncNewHDWalletXPubYPubZPubE422.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("XpubSyncInProgress");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into XpubSyncInProgress: {1}", jsonString, exception.ToString()));
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
            return newSyncNewHDWalletXPubYPubZPubE422;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SyncNewHDWalletXPubYPubZPubE422);
        }

        /// <summary>
        /// Returns true if SyncNewHDWalletXPubYPubZPubE422 instances are equal
        /// </summary>
        /// <param name="input">Instance of SyncNewHDWalletXPubYPubZPubE422 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncNewHDWalletXPubYPubZPubE422 input)
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
    /// Custom JSON converter for SyncNewHDWalletXPubYPubZPubE422
    /// </summary>
    public class SyncNewHDWalletXPubYPubZPubE422JsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SyncNewHDWalletXPubYPubZPubE422).GetMethod("ToJson").Invoke(value, null)));
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
                return SyncNewHDWalletXPubYPubZPubE422.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
