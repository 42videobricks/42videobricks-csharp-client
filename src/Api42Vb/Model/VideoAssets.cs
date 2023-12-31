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
    /// Video Assets Object
    /// </summary>
    [DataContract(Name = "VideoAssets")]
    public partial class VideoAssets : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAssets" /> class.
        /// </summary>
        /// <param name="thumbnail">Url of the video thumbnail (cann be empty ?).</param>
        /// <param name="player">Url to the video player code.</param>
        /// <param name="stream">Url to the video player stream.</param>
        /// <param name="iframe">html code to integrate the player in an iframe.</param>
        public VideoAssets(string thumbnail = default(string), string player = default(string), string stream = default(string), string iframe = default(string))
        {
            this.Thumbnail = thumbnail;
            this.Player = player;
            this.Stream = stream;
            this.Iframe = iframe;
        }

        /// <summary>
        /// Url of the video thumbnail (cann be empty ?)
        /// </summary>
        /// <value>Url of the video thumbnail (cann be empty ?)</value>
        /// <example>https://media-delivery-cdn.alchimie-services.net/image/v1/mediadb-product-filetype-dev/1002541/COVER.jpg</example>
        [DataMember(Name = "thumbnail", EmitDefaultValue = false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Url to the video player code
        /// </summary>
        /// <value>Url to the video player code</value>
        /// <example>https://stream.video-bricks.com/STNQM2FIN1Bpa3I3bC9IRw&#x3D;&#x3D;/player</example>
        [DataMember(Name = "player", EmitDefaultValue = false)]
        public string Player { get; set; }

        /// <summary>
        /// Url to the video player stream
        /// </summary>
        /// <value>Url to the video player stream</value>
        /// <example>https://stream.video-bricks.com/STNQM2FIN1Bpa3I3bC9IRw&#x3D;&#x3D;</example>
        [DataMember(Name = "stream", EmitDefaultValue = false)]
        public string Stream { get; set; }

        /// <summary>
        /// html code to integrate the player in an iframe
        /// </summary>
        /// <value>html code to integrate the player in an iframe</value>
        /// <example>&lt;iframe src&#x3D;&quot;https://player.video-bricks.com/STNQM2FIN1Bpa3I3bC9IRw&#x3D;&#x3D;/player&quot; gesture&#x3D;&quot;media&quot; allow&#x3D;&quot;encrypted-media&quot; allowfullscreen&#x3D;&quot;allowfullscreen&quot; width&#x3D;&quot;100%&quot;&gt;&lt;/iframe&gt;</example>
        [DataMember(Name = "iframe", EmitDefaultValue = false)]
        public string Iframe { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VideoAssets {\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Stream: ").Append(Stream).Append("\n");
            sb.Append("  Iframe: ").Append(Iframe).Append("\n");
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
