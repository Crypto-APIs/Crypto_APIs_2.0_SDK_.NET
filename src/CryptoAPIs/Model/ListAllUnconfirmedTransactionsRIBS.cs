/*
 * CryptoAPIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
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
    /// ListAllUnconfirmedTransactionsRIBS
    /// </summary>
    [JsonConverter(typeof(ListAllUnconfirmedTransactionsRIBSJsonConverter))]
    [DataContract(Name = "ListAllUnconfirmedTransactionsRIBS")]
    public partial class ListAllUnconfirmedTransactionsRIBS : AbstractOpenAPISchema, IEquatable<ListAllUnconfirmedTransactionsRIBS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBS" /> class
        /// with the <see cref="ListAllUnconfirmedTransactionsRIBSB" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListAllUnconfirmedTransactionsRIBSB.</param>
        public ListAllUnconfirmedTransactionsRIBS(ListAllUnconfirmedTransactionsRIBSB actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBS" /> class
        /// with the <see cref="ListAllUnconfirmedTransactionsRIBSBC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListAllUnconfirmedTransactionsRIBSBC.</param>
        public ListAllUnconfirmedTransactionsRIBS(ListAllUnconfirmedTransactionsRIBSBC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBS" /> class
        /// with the <see cref="ListAllUnconfirmedTransactionsRIBSL" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListAllUnconfirmedTransactionsRIBSL.</param>
        public ListAllUnconfirmedTransactionsRIBS(ListAllUnconfirmedTransactionsRIBSL actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBS" /> class
        /// with the <see cref="ListAllUnconfirmedTransactionsRIBSD" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListAllUnconfirmedTransactionsRIBSD.</param>
        public ListAllUnconfirmedTransactionsRIBS(ListAllUnconfirmedTransactionsRIBSD actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBS" /> class
        /// with the <see cref="ListAllUnconfirmedTransactionsRIBSD2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListAllUnconfirmedTransactionsRIBSD2.</param>
        public ListAllUnconfirmedTransactionsRIBS(ListAllUnconfirmedTransactionsRIBSD2 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBS" /> class
        /// with the <see cref="ListAllUnconfirmedTransactionsRIBSE" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListAllUnconfirmedTransactionsRIBSE.</param>
        public ListAllUnconfirmedTransactionsRIBS(ListAllUnconfirmedTransactionsRIBSE actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBS" /> class
        /// with the <see cref="ListAllUnconfirmedTransactionsRIBSEC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListAllUnconfirmedTransactionsRIBSEC.</param>
        public ListAllUnconfirmedTransactionsRIBS(ListAllUnconfirmedTransactionsRIBSEC actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBS" /> class
        /// with the <see cref="ListAllUnconfirmedTransactionsRIBSZ" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListAllUnconfirmedTransactionsRIBSZ.</param>
        public ListAllUnconfirmedTransactionsRIBS(ListAllUnconfirmedTransactionsRIBSZ actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllUnconfirmedTransactionsRIBS" /> class
        /// with the <see cref="ListAllUnconfirmedTransactionsRIBSBSC" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ListAllUnconfirmedTransactionsRIBSBSC.</param>
        public ListAllUnconfirmedTransactionsRIBS(ListAllUnconfirmedTransactionsRIBSBSC actualInstance)
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
                if (value.GetType() == typeof(ListAllUnconfirmedTransactionsRIBSB))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListAllUnconfirmedTransactionsRIBSBC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListAllUnconfirmedTransactionsRIBSBSC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListAllUnconfirmedTransactionsRIBSD))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListAllUnconfirmedTransactionsRIBSD2))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListAllUnconfirmedTransactionsRIBSE))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListAllUnconfirmedTransactionsRIBSEC))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListAllUnconfirmedTransactionsRIBSL))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ListAllUnconfirmedTransactionsRIBSZ))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ListAllUnconfirmedTransactionsRIBSB, ListAllUnconfirmedTransactionsRIBSBC, ListAllUnconfirmedTransactionsRIBSBSC, ListAllUnconfirmedTransactionsRIBSD, ListAllUnconfirmedTransactionsRIBSD2, ListAllUnconfirmedTransactionsRIBSE, ListAllUnconfirmedTransactionsRIBSEC, ListAllUnconfirmedTransactionsRIBSL, ListAllUnconfirmedTransactionsRIBSZ");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ListAllUnconfirmedTransactionsRIBSB`. If the actual instance is not `ListAllUnconfirmedTransactionsRIBSB`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListAllUnconfirmedTransactionsRIBSB</returns>
        public ListAllUnconfirmedTransactionsRIBSB GetListAllUnconfirmedTransactionsRIBSB()
        {
            return (ListAllUnconfirmedTransactionsRIBSB)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListAllUnconfirmedTransactionsRIBSBC`. If the actual instance is not `ListAllUnconfirmedTransactionsRIBSBC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListAllUnconfirmedTransactionsRIBSBC</returns>
        public ListAllUnconfirmedTransactionsRIBSBC GetListAllUnconfirmedTransactionsRIBSBC()
        {
            return (ListAllUnconfirmedTransactionsRIBSBC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListAllUnconfirmedTransactionsRIBSL`. If the actual instance is not `ListAllUnconfirmedTransactionsRIBSL`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListAllUnconfirmedTransactionsRIBSL</returns>
        public ListAllUnconfirmedTransactionsRIBSL GetListAllUnconfirmedTransactionsRIBSL()
        {
            return (ListAllUnconfirmedTransactionsRIBSL)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListAllUnconfirmedTransactionsRIBSD`. If the actual instance is not `ListAllUnconfirmedTransactionsRIBSD`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListAllUnconfirmedTransactionsRIBSD</returns>
        public ListAllUnconfirmedTransactionsRIBSD GetListAllUnconfirmedTransactionsRIBSD()
        {
            return (ListAllUnconfirmedTransactionsRIBSD)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListAllUnconfirmedTransactionsRIBSD2`. If the actual instance is not `ListAllUnconfirmedTransactionsRIBSD2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListAllUnconfirmedTransactionsRIBSD2</returns>
        public ListAllUnconfirmedTransactionsRIBSD2 GetListAllUnconfirmedTransactionsRIBSD2()
        {
            return (ListAllUnconfirmedTransactionsRIBSD2)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListAllUnconfirmedTransactionsRIBSE`. If the actual instance is not `ListAllUnconfirmedTransactionsRIBSE`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListAllUnconfirmedTransactionsRIBSE</returns>
        public ListAllUnconfirmedTransactionsRIBSE GetListAllUnconfirmedTransactionsRIBSE()
        {
            return (ListAllUnconfirmedTransactionsRIBSE)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListAllUnconfirmedTransactionsRIBSEC`. If the actual instance is not `ListAllUnconfirmedTransactionsRIBSEC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListAllUnconfirmedTransactionsRIBSEC</returns>
        public ListAllUnconfirmedTransactionsRIBSEC GetListAllUnconfirmedTransactionsRIBSEC()
        {
            return (ListAllUnconfirmedTransactionsRIBSEC)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListAllUnconfirmedTransactionsRIBSZ`. If the actual instance is not `ListAllUnconfirmedTransactionsRIBSZ`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListAllUnconfirmedTransactionsRIBSZ</returns>
        public ListAllUnconfirmedTransactionsRIBSZ GetListAllUnconfirmedTransactionsRIBSZ()
        {
            return (ListAllUnconfirmedTransactionsRIBSZ)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ListAllUnconfirmedTransactionsRIBSBSC`. If the actual instance is not `ListAllUnconfirmedTransactionsRIBSBSC`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ListAllUnconfirmedTransactionsRIBSBSC</returns>
        public ListAllUnconfirmedTransactionsRIBSBSC GetListAllUnconfirmedTransactionsRIBSBSC()
        {
            return (ListAllUnconfirmedTransactionsRIBSBSC)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllUnconfirmedTransactionsRIBS {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ListAllUnconfirmedTransactionsRIBS.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ListAllUnconfirmedTransactionsRIBS
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ListAllUnconfirmedTransactionsRIBS</returns>
        public static ListAllUnconfirmedTransactionsRIBS FromJson(string jsonString)
        {
            ListAllUnconfirmedTransactionsRIBS newListAllUnconfirmedTransactionsRIBS = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newListAllUnconfirmedTransactionsRIBS;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListAllUnconfirmedTransactionsRIBSB).GetProperty("AdditionalProperties") == null)
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSB>(jsonString, ListAllUnconfirmedTransactionsRIBS.SerializerSettings));
                }
                else
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSB>(jsonString, ListAllUnconfirmedTransactionsRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListAllUnconfirmedTransactionsRIBSB");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListAllUnconfirmedTransactionsRIBSB: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListAllUnconfirmedTransactionsRIBSBC).GetProperty("AdditionalProperties") == null)
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSBC>(jsonString, ListAllUnconfirmedTransactionsRIBS.SerializerSettings));
                }
                else
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSBC>(jsonString, ListAllUnconfirmedTransactionsRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListAllUnconfirmedTransactionsRIBSBC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListAllUnconfirmedTransactionsRIBSBC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListAllUnconfirmedTransactionsRIBSBSC).GetProperty("AdditionalProperties") == null)
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSBSC>(jsonString, ListAllUnconfirmedTransactionsRIBS.SerializerSettings));
                }
                else
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSBSC>(jsonString, ListAllUnconfirmedTransactionsRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListAllUnconfirmedTransactionsRIBSBSC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListAllUnconfirmedTransactionsRIBSBSC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListAllUnconfirmedTransactionsRIBSD).GetProperty("AdditionalProperties") == null)
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSD>(jsonString, ListAllUnconfirmedTransactionsRIBS.SerializerSettings));
                }
                else
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSD>(jsonString, ListAllUnconfirmedTransactionsRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListAllUnconfirmedTransactionsRIBSD");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListAllUnconfirmedTransactionsRIBSD: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListAllUnconfirmedTransactionsRIBSD2).GetProperty("AdditionalProperties") == null)
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSD2>(jsonString, ListAllUnconfirmedTransactionsRIBS.SerializerSettings));
                }
                else
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSD2>(jsonString, ListAllUnconfirmedTransactionsRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListAllUnconfirmedTransactionsRIBSD2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListAllUnconfirmedTransactionsRIBSD2: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListAllUnconfirmedTransactionsRIBSE).GetProperty("AdditionalProperties") == null)
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSE>(jsonString, ListAllUnconfirmedTransactionsRIBS.SerializerSettings));
                }
                else
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSE>(jsonString, ListAllUnconfirmedTransactionsRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListAllUnconfirmedTransactionsRIBSE");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListAllUnconfirmedTransactionsRIBSE: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListAllUnconfirmedTransactionsRIBSEC).GetProperty("AdditionalProperties") == null)
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSEC>(jsonString, ListAllUnconfirmedTransactionsRIBS.SerializerSettings));
                }
                else
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSEC>(jsonString, ListAllUnconfirmedTransactionsRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListAllUnconfirmedTransactionsRIBSEC");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListAllUnconfirmedTransactionsRIBSEC: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListAllUnconfirmedTransactionsRIBSL).GetProperty("AdditionalProperties") == null)
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSL>(jsonString, ListAllUnconfirmedTransactionsRIBS.SerializerSettings));
                }
                else
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSL>(jsonString, ListAllUnconfirmedTransactionsRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListAllUnconfirmedTransactionsRIBSL");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListAllUnconfirmedTransactionsRIBSL: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ListAllUnconfirmedTransactionsRIBSZ).GetProperty("AdditionalProperties") == null)
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSZ>(jsonString, ListAllUnconfirmedTransactionsRIBS.SerializerSettings));
                }
                else
                {
                    newListAllUnconfirmedTransactionsRIBS = new ListAllUnconfirmedTransactionsRIBS(JsonConvert.DeserializeObject<ListAllUnconfirmedTransactionsRIBSZ>(jsonString, ListAllUnconfirmedTransactionsRIBS.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ListAllUnconfirmedTransactionsRIBSZ");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ListAllUnconfirmedTransactionsRIBSZ: {1}", jsonString, exception.ToString()));
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
            return newListAllUnconfirmedTransactionsRIBS;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllUnconfirmedTransactionsRIBS);
        }

        /// <summary>
        /// Returns true if ListAllUnconfirmedTransactionsRIBS instances are equal
        /// </summary>
        /// <param name="input">Instance of ListAllUnconfirmedTransactionsRIBS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListAllUnconfirmedTransactionsRIBS input)
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
    /// Custom JSON converter for ListAllUnconfirmedTransactionsRIBS
    /// </summary>
    public class ListAllUnconfirmedTransactionsRIBSJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ListAllUnconfirmedTransactionsRIBS).GetMethod("ToJson").Invoke(value, null)));
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
                return ListAllUnconfirmedTransactionsRIBS.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
