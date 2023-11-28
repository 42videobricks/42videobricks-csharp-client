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
    /// Video Object
    /// </summary>
    [DataContract(Name = "Video")]
    public partial class Video : IEquatable<Video>, IValidatableObject
    {
        /// <summary>
        /// Status of the video : * &#39;REQUESTED&#39;: video as been submited, waiting for its creation * &#39;CREATED&#39;: video has been created and file can be uploaded          * &#39;TRANSCODING&#39;: video is unvailable because still in the creation  &amp; in encoding process * &#39;TRANSCODING_ERROR&#39;: video is unvailable because the encoding failed  * &#39;AVAILABLE&#39;: video is ready to be stream
        /// </summary>
        /// <value>Status of the video : * &#39;REQUESTED&#39;: video as been submited, waiting for its creation * &#39;CREATED&#39;: video has been created and file can be uploaded          * &#39;TRANSCODING&#39;: video is unvailable because still in the creation  &amp; in encoding process * &#39;TRANSCODING_ERROR&#39;: video is unvailable because the encoding failed  * &#39;AVAILABLE&#39;: video is ready to be stream</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum REQUESTED for value: REQUESTED
            /// </summary>
            [EnumMember(Value = "REQUESTED")]
            REQUESTED = 1,

            /// <summary>
            /// Enum CREATED for value: CREATED
            /// </summary>
            [EnumMember(Value = "CREATED")]
            CREATED = 2,

            /// <summary>
            /// Enum TRANSCODING for value: TRANSCODING
            /// </summary>
            [EnumMember(Value = "TRANSCODING")]
            TRANSCODING = 3,

            /// <summary>
            /// Enum TRANSCODINGERROR for value: TRANSCODING_ERROR
            /// </summary>
            [EnumMember(Value = "TRANSCODING_ERROR")]
            TRANSCODINGERROR = 4,

            /// <summary>
            /// Enum AVAILABLE for value: AVAILABLE
            /// </summary>
            [EnumMember(Value = "AVAILABLE")]
            AVAILABLE = 5
        }


        /// <summary>
        /// Status of the video : * &#39;REQUESTED&#39;: video as been submited, waiting for its creation * &#39;CREATED&#39;: video has been created and file can be uploaded          * &#39;TRANSCODING&#39;: video is unvailable because still in the creation  &amp; in encoding process * &#39;TRANSCODING_ERROR&#39;: video is unvailable because the encoding failed  * &#39;AVAILABLE&#39;: video is ready to be stream
        /// </summary>
        /// <value>Status of the video : * &#39;REQUESTED&#39;: video as been submited, waiting for its creation * &#39;CREATED&#39;: video has been created and file can be uploaded          * &#39;TRANSCODING&#39;: video is unvailable because still in the creation  &amp; in encoding process * &#39;TRANSCODING_ERROR&#39;: video is unvailable because the encoding failed  * &#39;AVAILABLE&#39;: video is ready to be stream</value>
        /// <example>AVAILABLE</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Video" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Video() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Video" /> class.
        /// </summary>
        /// <param name="title">title of the video.</param>
        /// <param name="description">description of the video.</param>
        /// <param name="varPublic">Define if the video is public (it can be accessible by anybody with the video url). Default &#x3D; tue.</param>
        /// <param name="tags">tags list linked to video.</param>
        /// <param name="id">id of the video (null when adding a new video) (required).</param>
        /// <param name="status">Status of the video : * &#39;REQUESTED&#39;: video as been submited, waiting for its creation * &#39;CREATED&#39;: video has been created and file can be uploaded          * &#39;TRANSCODING&#39;: video is unvailable because still in the creation  &amp; in encoding process * &#39;TRANSCODING_ERROR&#39;: video is unvailable because the encoding failed  * &#39;AVAILABLE&#39;: video is ready to be stream.</param>
        /// <param name="duration">video duration in second.</param>
        /// <param name="ctime">Creation date (timestamp).</param>
        /// <param name="mtime">Modification date (timestamp).</param>
        /// <param name="assets">assets.</param>
        /// <param name="metas">metas data  free-form object: refere to the documentation.</param>
        public Video(string title = default(string), string description = default(string), bool varPublic = default(bool), List<string> tags = default(List<string>), string id = default(string), StatusEnum? status = default(StatusEnum?), int duration = default(int), int ctime = default(int), int mtime = default(int), VideoAssets assets = default(VideoAssets), Dictionary<string, Object> metas = default(Dictionary<string, Object>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Video and cannot be null");
            }
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.VarPublic = varPublic;
            this.Tags = tags;
            this.Status = status;
            this.Duration = duration;
            this.Ctime = ctime;
            this.Mtime = mtime;
            this.Assets = assets;
            this.Metas = metas;
        }

        /// <summary>
        /// title of the video
        /// </summary>
        /// <value>title of the video</value>
        /// <example>My video title</example>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// description of the video
        /// </summary>
        /// <value>description of the video</value>
        /// <example>My video description</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Define if the video is public (it can be accessible by anybody with the video url). Default &#x3D; tue
        /// </summary>
        /// <value>Define if the video is public (it can be accessible by anybody with the video url). Default &#x3D; tue</value>
        /// <example>true</example>
        [DataMember(Name = "public", EmitDefaultValue = true)]
        public bool VarPublic { get; set; }

        /// <summary>
        /// tags list linked to video
        /// </summary>
        /// <value>tags list linked to video</value>
        /// <example>[&quot;MyTag&quot;]</example>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// id of the video (null when adding a new video)
        /// </summary>
        /// <value>id of the video (null when adding a new video)</value>
        /// <example>STNQM2FIN1Bpa3I3bC9IRw&#x3D;&#x3D;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// video duration in second
        /// </summary>
        /// <value>video duration in second</value>
        /// <example>3600</example>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public int Duration { get; set; }

        /// <summary>
        /// Creation date (timestamp)
        /// </summary>
        /// <value>Creation date (timestamp)</value>
        /// <example>1677020400</example>
        [DataMember(Name = "ctime", EmitDefaultValue = false)]
        public int Ctime { get; set; }

        /// <summary>
        /// Modification date (timestamp)
        /// </summary>
        /// <value>Modification date (timestamp)</value>
        /// <example>1679526000</example>
        [DataMember(Name = "mtime", EmitDefaultValue = false)]
        public int Mtime { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public VideoAssets Assets { get; set; }

        /// <summary>
        /// metas data  free-form object: refere to the documentation
        /// </summary>
        /// <value>metas data  free-form object: refere to the documentation</value>
        [DataMember(Name = "metas", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Video {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  VarPublic: ").Append(VarPublic).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Ctime: ").Append(Ctime).Append("\n");
            sb.Append("  Mtime: ").Append(Mtime).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Metas: ").Append(Metas).Append("\n");
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
            return this.Equals(input as Video);
        }

        /// <summary>
        /// Returns true if Video instances are equal
        /// </summary>
        /// <param name="input">Instance of Video to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Video input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.VarPublic == input.VarPublic ||
                    this.VarPublic.Equals(input.VarPublic)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.Ctime == input.Ctime ||
                    this.Ctime.Equals(input.Ctime)
                ) && 
                (
                    this.Mtime == input.Mtime ||
                    this.Mtime.Equals(input.Mtime)
                ) && 
                (
                    this.Assets == input.Assets ||
                    (this.Assets != null &&
                    this.Assets.Equals(input.Assets))
                ) && 
                (
                    this.Metas == input.Metas ||
                    this.Metas != null &&
                    input.Metas != null &&
                    this.Metas.SequenceEqual(input.Metas)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarPublic.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                hashCode = (hashCode * 59) + this.Ctime.GetHashCode();
                hashCode = (hashCode * 59) + this.Mtime.GetHashCode();
                if (this.Assets != null)
                {
                    hashCode = (hashCode * 59) + this.Assets.GetHashCode();
                }
                if (this.Metas != null)
                {
                    hashCode = (hashCode * 59) + this.Metas.GetHashCode();
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
            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 256.", new [] { "Title" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 500.", new [] { "Description" });
            }

            yield break;
        }
    }

}