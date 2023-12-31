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
    public partial class DataVideoUsage : IValidatableObject
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
        public DataVideoUsage(string dateKey = default(string), string interval = default(string), decimal transcoding = default(decimal), decimal hosting = default(decimal), decimal delivery = default(decimal), decimal drm = default(decimal))
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
        public decimal Transcoding { get; set; }

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
        public decimal Delivery { get; set; }

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
