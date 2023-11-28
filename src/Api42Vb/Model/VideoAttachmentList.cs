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
    /// Video Attachment Object list
    /// </summary>
    [DataContract(Name = "VideoAttachmentList")]
    public partial class VideoAttachmentList : IEquatable<VideoAttachmentList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAttachmentList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoAttachmentList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAttachmentList" /> class.
        /// </summary>
        /// <param name="offset">offset (required).</param>
        /// <param name="limit">limit (required).</param>
        /// <param name="total">total (required).</param>
        /// <param name="data">data.</param>
        public VideoAttachmentList(int offset = default(int), int limit = default(int), int total = default(int), List<VideoAttachment> data = default(List<VideoAttachment>))
        {
            this.Offset = offset;
            this.Limit = limit;
            this.Total = total;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        /// <example>30</example>
        [DataMember(Name = "offset", IsRequired = true, EmitDefaultValue = true)]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "limit", IsRequired = true, EmitDefaultValue = true)]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        /// <example>355</example>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<VideoAttachment> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VideoAttachmentList {\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as VideoAttachmentList);
        }

        /// <summary>
        /// Returns true if VideoAttachmentList instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoAttachmentList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoAttachmentList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Offset == input.Offset ||
                    this.Offset.Equals(input.Offset)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                hashCode = (hashCode * 59) + this.Offset.GetHashCode();
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
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
