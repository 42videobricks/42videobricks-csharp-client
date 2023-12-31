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
    /// Video Single Upload Init response object
    /// </summary>
    [DataContract(Name = "VideoUploadInitResponse")]
    public partial class VideoUploadInitResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoUploadInitResponse" /> class.
        /// </summary>
        /// <param name="signedUrl">signed url.</param>
        public VideoUploadInitResponse(string signedUrl = default(string))
        {
            this.SignedUrl = signedUrl;
        }

        /// <summary>
        /// signed url
        /// </summary>
        /// <value>signed url</value>
        /// <example>https://alchimie-vpaas-client-uploads.s3.amazonaws.com/ABkWl5kVPykAMSyu/toto?uploadId&#x3D;5Fu8SetDoWjk3wwReTuWzLat6KubZECxfek863H9nsYreaEaKUmQ4G5iyEAETMK9X_DYJ8QBsgnEoM5bM8B.HQBe9eBtpSxLuXM.THMzKy1JBd0b5XGZ7OT6z.RfZAafc4B4PJ.KyQFarsAY4X7j_Eq2bz6ydqfQHdPyE73vl0Q-&amp;partNumber&#x3D;1&amp;AWSAccessKeyId&#x3D;XXXXXXXXXXX&amp;Signature&#x3D;8mCPTseHxpgP73GT0p7ADyWcwmM%3D&amp;x-amz-security-token&#x3D;IQoJb3JpZ2luX2VjEG4aCWV1LXdlc3QtMSJGMEQCIEiVvECtKd5v3fq5irCP7lL7OYF5TJgRopk4CzLooWGQAiBkTzXTxwjLQBEqjG%2FoNmVEOvVRZE0N059PR4OLhe9FoSrEAwin%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F8BEAAaDDQ4OTE0MzIzNDE5OSIMlmuGOIiRddNi%2FwP5KpgDxldMYVS3L%2BAG%2Bl0glvUlqzSwaWuhSJQeYFvDHSF7mMcy%2B8wXzg7GH8B6DkAjQtDITWpdmIBTbpKK7WcDCLfxOobixWz9CkKyBsHuKvbxC0WdoKRpg6UgTA7ZrB9flETvHGgqaYbE%2FJxIzCPy3x79E2y1egpLOwHMGwxg4TBC7OrqIuJjR9v7x%2FYoUTU54%2F7x1VZYHUfhv5rxiE9Pmy91klwYYY2Ht8OIUnDDtWWZoSAvyVXxtSXGsu0yI9HfP9rMtK6DbNX3sNlws97rPQkuBh97gFfr%2Fh39SVKTwGEbz4vqD9DFVPMzJj0%2BBfbWUzMrUzWU1%2FUXskxR4SCTEWuCEiv%2FvAQWAYbCW4ItXnnePh3gTQPXAikwkqSgYOGfWsSpYYkzegvkAuzA03ej9H4Ud6lV0y8Rh8ujB%2F8uwlMsG1DFJnoDMfkNv5WK5zws6rzVJ90PA5j%2BwI7bGA5ejO1cPjC1dp1H5UmYFDDzE2ZxPmd%2BJkTrVnpon4jMkwBkIWZoSQ7gRFfuraiiTJ8jWpTW4MemXHe5kDRaMP%2Bg3aMGOp8BVkQUKhbtZKskDCy1cis%2BXH30kmpjThcQdXcgS6aV5PUQsLx2wn%2BNl66m2zZGZMfh5PCMB0AYs3eXFVgJVGd5sCsP4u20JHKBBfQYAPidGpAIDL2NWrR71pr4vFR0vB32TB4wWzCjM%2BmVgub6Je17mMi19KZCLAtrhyKpxi1ajjG8TGxaNxERrG0LWasiddcuMiEe7QbXjxQvnhg7Jg6d&amp;Expires&#x3D;1685541291</example>
        [DataMember(Name = "signedUrl", EmitDefaultValue = false)]
        public string SignedUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VideoUploadInitResponse {\n");
            sb.Append("  SignedUrl: ").Append(SignedUrl).Append("\n");
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
