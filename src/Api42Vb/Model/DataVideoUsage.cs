/*
 * 42videobricks
 *
 * 42videobricks is a Video Platform As A Service (VPaaS)
 *
 * The version of the OpenAPI document: 1.2
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
using OpenAPIDateConverter = Api42Vb.Client.OpenAPIDateConverter;

namespace Api42Vb.Model
{
    /// <summary>
    /// Video Usage KPIs
    /// </summary>
    [DataContract(Name = "DataVideoUsage")]
    public partial class DataVideoUsage : IEquatable<DataVideoUsage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataVideoUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataVideoUsage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataVideoUsage" /> class.
        /// </summary>
        /// <param name="dateKey">Date of the kpis.  Format:  - day:YYYY-MM-DD (2023-10-16) - week: YYYY-Www (2023-W42) - month: YYYY-MM (2023-10).</param>
        /// <param name="interval">Unit of the period (day|month|week).</param>
        /// <param name="transcoding">total of transcoding second since the begining of the month (required).</param>
        /// <param name="hosting">total of hosting second since the begining of the month (required).</param>
        /// <param name="delivery">total of delivery (stream) second since the begining of the month.</param>
        /// <param name="drm">total of delivery (stream) second since the begining of the month.</param>
        public DataVideoUsage(string dateKey = default(string), string interval = default(string), float transcoding = default(float), decimal hosting = default(decimal), double delivery = default(double), decimal drm = default(decimal))
        {
            this.Transcoding = transcoding;
            this.Hosting = hosting;
            this.DateKey = dateKey;
            this.Interval = interval;
            this.Delivery = delivery;
            this.Drm = drm;
        }

        /// <summary>
        /// Date of the kpis.  Format:  - day:YYYY-MM-DD (2023-10-16) - week: YYYY-Www (2023-W42) - month: YYYY-MM (2023-10)
        /// </summary>
        /// <value>Date of the kpis.  Format:  - day:YYYY-MM-DD (2023-10-16) - week: YYYY-Www (2023-W42) - month: YYYY-MM (2023-10)</value>
        /// <example>2023-10</example>
        [DataMember(Name = "dateKey", EmitDefaultValue = false)]
        public string DateKey { get; set; }

        /// <summary>
        /// Unit of the period (day|month|week)
        /// </summary>
        /// <value>Unit of the period (day|month|week)</value>
        /// <example>month</example>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public string Interval { get; set; }

        /// <summary>
        /// total of transcoding second since the begining of the month
        /// </summary>
        /// <value>total of transcoding second since the begining of the month</value>
        /// <example>15715.23</example>
        [DataMember(Name = "transcoding", IsRequired = true, EmitDefaultValue = true)]
        public float Transcoding { get; set; }

        /// <summary>
        /// total of hosting second since the begining of the month
        /// </summary>
        /// <value>total of hosting second since the begining of the month</value>
        /// <example>171523.34</example>
        [DataMember(Name = "hosting", IsRequired = true, EmitDefaultValue = true)]
        public decimal Hosting { get; set; }

        /// <summary>
        /// total of delivery (stream) second since the begining of the month
        /// </summary>
        /// <value>total of delivery (stream) second since the begining of the month</value>
        /// <example>171523.34</example>
        [DataMember(Name = "delivery", EmitDefaultValue = false)]
        public double Delivery { get; set; }

        /// <summary>
        /// total of delivery (stream) second since the begining of the month
        /// </summary>
        /// <value>total of delivery (stream) second since the begining of the month</value>
        /// <example>171523.34</example>
        [DataMember(Name = "drm", EmitDefaultValue = false)]
        public decimal Drm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataVideoUsage {\n");
            sb.Append("  DateKey: ").Append(DateKey).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Transcoding: ").Append(Transcoding).Append("\n");
            sb.Append("  Hosting: ").Append(Hosting).Append("\n");
            sb.Append("  Delivery: ").Append(Delivery).Append("\n");
            sb.Append("  Drm: ").Append(Drm).Append("\n");
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
            return this.Equals(input as DataVideoUsage);
        }

        /// <summary>
        /// Returns true if DataVideoUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of DataVideoUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataVideoUsage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DateKey == input.DateKey ||
                    (this.DateKey != null &&
                    this.DateKey.Equals(input.DateKey))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.Transcoding == input.Transcoding ||
                    this.Transcoding.Equals(input.Transcoding)
                ) && 
                (
                    this.Hosting == input.Hosting ||
                    this.Hosting.Equals(input.Hosting)
                ) && 
                (
                    this.Delivery == input.Delivery ||
                    this.Delivery.Equals(input.Delivery)
                ) && 
                (
                    this.Drm == input.Drm ||
                    this.Drm.Equals(input.Drm)
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
                if (this.DateKey != null)
                {
                    hashCode = (hashCode * 59) + this.DateKey.GetHashCode();
                }
                if (this.Interval != null)
                {
                    hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Transcoding.GetHashCode();
                hashCode = (hashCode * 59) + this.Hosting.GetHashCode();
                hashCode = (hashCode * 59) + this.Delivery.GetHashCode();
                hashCode = (hashCode * 59) + this.Drm.GetHashCode();
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

}