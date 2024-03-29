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
    /// GetBlockDetailsByBlockHashRIBS
    /// </summary>
    [JsonConverter(typeof(GetBlockDetailsByBlockHashRIBSJsonConverter))]
    [DataContract(Name = "GetBlockDetailsByBlockHashRIBS")]
    public partial class GetBlockDetailsByBlockHashRIBS : AbstractOpenAPISchema, IEquatable<GetBlockDetailsByBlockHashRIBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashRIBSB" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashRIBSB.</param>
        public GetBlockDetailsByBlockHashRIBS(GetBlockDetailsByBlockHashRIBSB actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashRIBSE" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashRIBSE.</param>
        public GetBlockDetailsByBlockHashRIBS(GetBlockDetailsByBlockHashRIBSE actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashRIBSEC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashRIBSEC.</param>
        public GetBlockDetailsByBlockHashRIBS(GetBlockDetailsByBlockHashRIBSEC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashRIBSBC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashRIBSBC.</param>
        public GetBlockDetailsByBlockHashRIBS(GetBlockDetailsByBlockHashRIBSBC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashRIBSL" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashRIBSL.</param>
        public GetBlockDetailsByBlockHashRIBS(GetBlockDetailsByBlockHashRIBSL actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashRIBSD" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashRIBSD.</param>
        public GetBlockDetailsByBlockHashRIBS(GetBlockDetailsByBlockHashRIBSD actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashRIBSD2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashRIBSD2.</param>
        public GetBlockDetailsByBlockHashRIBS(GetBlockDetailsByBlockHashRIBSD2 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashRIBSBSC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashRIBSBSC.</param>
        public GetBlockDetailsByBlockHashRIBS(GetBlockDetailsByBlockHashRIBSBSC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashRIBSZ" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashRIBSZ.</param>
        public GetBlockDetailsByBlockHashRIBS(GetBlockDetailsByBlockHashRIBSZ actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockDetailsByBlockHashRIBS" /> class
        /// with the <see cref="GetBlockDetailsByBlockHashRIBSZ2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetBlockDetailsByBlockHashRIBSZ2.</param>
        public GetBlockDetailsByBlockHashRIBS(GetBlockDetailsByBlockHashRIBSZ2 actualInstance)
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
                if (value.GetType() == typeof(GetBlockDetailsByBlockHashRIBSB))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashRIBSBC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashRIBSBSC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashRIBSD))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashRIBSD2))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashRIBSE))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashRIBSEC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashRIBSL))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashRIBSZ))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(GetBlockDetailsByBlockHashRIBSZ2))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: GetBlockDetailsByBlockHashRIBSB, GetBlockDetailsByBlockHashRIBSBC, GetBlockDetailsByBlockHashRIBSBSC, GetBlockDetailsByBlockHashRIBSD, GetBlockDetailsByBlockHashRIBSD2, GetBlockDetailsByBlockHashRIBSE, GetBlockDetailsByBlockHashRIBSEC, GetBlockDetailsByBlockHashRIBSL, GetBlockDetailsByBlockHashRIBSZ, GetBlockDetailsByBlockHashRIBSZ2");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashRIBSB`. If the actual instance is not `GetBlockDetailsByBlockHashRIBSB`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBSB</returns>
        public GetBlockDetailsByBlockHashRIBSB GetGetBlockDetailsByBlockHashRIBSB()
        {
            return (GetBlockDetailsByBlockHashRIBSB)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashRIBSE`. If the actual instance is not `GetBlockDetailsByBlockHashRIBSE`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBSE</returns>
        public GetBlockDetailsByBlockHashRIBSE GetGetBlockDetailsByBlockHashRIBSE()
        {
            return (GetBlockDetailsByBlockHashRIBSE)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashRIBSEC`. If the actual instance is not `GetBlockDetailsByBlockHashRIBSEC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBSEC</returns>
        public GetBlockDetailsByBlockHashRIBSEC GetGetBlockDetailsByBlockHashRIBSEC()
        {
            return (GetBlockDetailsByBlockHashRIBSEC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashRIBSBC`. If the actual instance is not `GetBlockDetailsByBlockHashRIBSBC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBSBC</returns>
        public GetBlockDetailsByBlockHashRIBSBC GetGetBlockDetailsByBlockHashRIBSBC()
        {
            return (GetBlockDetailsByBlockHashRIBSBC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashRIBSL`. If the actual instance is not `GetBlockDetailsByBlockHashRIBSL`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBSL</returns>
        public GetBlockDetailsByBlockHashRIBSL GetGetBlockDetailsByBlockHashRIBSL()
        {
            return (GetBlockDetailsByBlockHashRIBSL)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashRIBSD`. If the actual instance is not `GetBlockDetailsByBlockHashRIBSD`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBSD</returns>
        public GetBlockDetailsByBlockHashRIBSD GetGetBlockDetailsByBlockHashRIBSD()
        {
            return (GetBlockDetailsByBlockHashRIBSD)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashRIBSD2`. If the actual instance is not `GetBlockDetailsByBlockHashRIBSD2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBSD2</returns>
        public GetBlockDetailsByBlockHashRIBSD2 GetGetBlockDetailsByBlockHashRIBSD2()
        {
            return (GetBlockDetailsByBlockHashRIBSD2)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashRIBSBSC`. If the actual instance is not `GetBlockDetailsByBlockHashRIBSBSC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBSBSC</returns>
        public GetBlockDetailsByBlockHashRIBSBSC GetGetBlockDetailsByBlockHashRIBSBSC()
        {
            return (GetBlockDetailsByBlockHashRIBSBSC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashRIBSZ`. If the actual instance is not `GetBlockDetailsByBlockHashRIBSZ`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBSZ</returns>
        public GetBlockDetailsByBlockHashRIBSZ GetGetBlockDetailsByBlockHashRIBSZ()
        {
            return (GetBlockDetailsByBlockHashRIBSZ)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetBlockDetailsByBlockHashRIBSZ2`. If the actual instance is not `GetBlockDetailsByBlockHashRIBSZ2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBSZ2</returns>
        public GetBlockDetailsByBlockHashRIBSZ2 GetGetBlockDetailsByBlockHashRIBSZ2()
        {
            return (GetBlockDetailsByBlockHashRIBSZ2)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetBlockDetailsByBlockHashRIBS {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, GetBlockDetailsByBlockHashRIBS.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GetBlockDetailsByBlockHashRIBS
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GetBlockDetailsByBlockHashRIBS</returns>
        public static GetBlockDetailsByBlockHashRIBS FromJson(string jsonString)
        {
            GetBlockDetailsByBlockHashRIBS newGetBlockDetailsByBlockHashRIBS = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGetBlockDetailsByBlockHashRIBS;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashRIBSB).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSB>(jsonString, GetBlockDetailsByBlockHashRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSB>(jsonString, GetBlockDetailsByBlockHashRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashRIBSB");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashRIBSB: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashRIBSBC).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSBC>(jsonString, GetBlockDetailsByBlockHashRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSBC>(jsonString, GetBlockDetailsByBlockHashRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashRIBSBC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashRIBSBC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashRIBSBSC).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSBSC>(jsonString, GetBlockDetailsByBlockHashRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSBSC>(jsonString, GetBlockDetailsByBlockHashRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashRIBSBSC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashRIBSBSC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashRIBSD).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSD>(jsonString, GetBlockDetailsByBlockHashRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSD>(jsonString, GetBlockDetailsByBlockHashRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashRIBSD");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashRIBSD: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashRIBSD2).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSD2>(jsonString, GetBlockDetailsByBlockHashRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSD2>(jsonString, GetBlockDetailsByBlockHashRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashRIBSD2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashRIBSD2: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashRIBSE).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSE>(jsonString, GetBlockDetailsByBlockHashRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSE>(jsonString, GetBlockDetailsByBlockHashRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashRIBSE");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashRIBSE: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashRIBSEC).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSEC>(jsonString, GetBlockDetailsByBlockHashRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSEC>(jsonString, GetBlockDetailsByBlockHashRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashRIBSEC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashRIBSEC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashRIBSL).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSL>(jsonString, GetBlockDetailsByBlockHashRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSL>(jsonString, GetBlockDetailsByBlockHashRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashRIBSL");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashRIBSL: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashRIBSZ).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSZ>(jsonString, GetBlockDetailsByBlockHashRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSZ>(jsonString, GetBlockDetailsByBlockHashRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashRIBSZ");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashRIBSZ: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetBlockDetailsByBlockHashRIBSZ2).GetProperty("AdditionalProperties") == null)
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSZ2>(jsonString, GetBlockDetailsByBlockHashRIBS.SerializerSettings));
                }
                else
                {
                    newGetBlockDetailsByBlockHashRIBS = new GetBlockDetailsByBlockHashRIBS(JsonConvert.DeserializeObject<GetBlockDetailsByBlockHashRIBSZ2>(jsonString, GetBlockDetailsByBlockHashRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetBlockDetailsByBlockHashRIBSZ2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetBlockDetailsByBlockHashRIBSZ2: {1}", jsonString, exception.ToString()));
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
            return newGetBlockDetailsByBlockHashRIBS;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetBlockDetailsByBlockHashRIBS);
        }

        /// <summary>
        /// Returns true if GetBlockDetailsByBlockHashRIBS instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBlockDetailsByBlockHashRIBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBlockDetailsByBlockHashRIBS input)
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
    /// Custom JSON converter for GetBlockDetailsByBlockHashRIBS
    /// </summary>
    public class GetBlockDetailsByBlockHashRIBSJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GetBlockDetailsByBlockHashRIBS).GetMethod("ToJson").Invoke(value, null)));
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
                return GetBlockDetailsByBlockHashRIBS.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
