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
    /// Video Mutlipart Upload Init response object
    /// </summary>
    [DataContract(Name = "VideoMultipartUploadInitResponse")]
    public partial class VideoMultipartUploadInitResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMultipartUploadInitResponse" /> class.
        /// </summary>
        /// <param name="chunkSize">part chunk size.</param>
        /// <param name="fileId">file id.</param>
        /// <param name="fileKey">file key.</param>
        /// <param name="parts">parts.</param>
        public VideoMultipartUploadInitResponse(int chunkSize = default(int), string fileId = default(string), string fileKey = default(string), List<VideoMultipartUploadInitResponsePartsInner> parts = default(List<VideoMultipartUploadInitResponsePartsInner>))
        {
            this.ChunkSize = chunkSize;
            this.FileId = fileId;
            this.FileKey = fileKey;
            this.Parts = parts;
        }

        /// <summary>
        /// part chunk size
        /// </summary>
        /// <value>part chunk size</value>
        /// <example>1000000</example>
        [DataMember(Name = "chunkSize", EmitDefaultValue = false)]
        public int ChunkSize { get; set; }

        /// <summary>
        /// file id
        /// </summary>
        /// <value>file id</value>
        /// <example>5Fu8SetDoWjk3wwReTuWzLat6KubZECxfek863H9nsYreaEaKUmQ4G5iyEAETMK9X_DYJ8QBsgnEoM5bM8B.HQBe9eBtpSxLuXM.THMzKy1JBd0b5XGZ7OT6z.RfZAafc4B4PJ.KyQFarsAY4X7j_Eq2bz6ydqfQHdPyE73vl0Q-</example>
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public string FileId { get; set; }

        /// <summary>
        /// file key
        /// </summary>
        /// <value>file key</value>
        /// <example>ABkWl5kVPykAMSyu/myvideo.mov</example>
        [DataMember(Name = "fileKey", EmitDefaultValue = false)]
        public string FileKey { get; set; }

        /// <summary>
        /// Gets or Sets Parts
        /// </summary>
        [DataMember(Name = "parts", EmitDefaultValue = false)]
        public List<VideoMultipartUploadInitResponsePartsInner> Parts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VideoMultipartUploadInitResponse {\n");
            sb.Append("  ChunkSize: ").Append(ChunkSize).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  FileKey: ").Append(FileKey).Append("\n");
            sb.Append("  Parts: ").Append(Parts).Append("\n");
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
