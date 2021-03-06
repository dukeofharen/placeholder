/* 
 * HttPlaceholder API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HttPlaceholder.Client.Client.OpenAPIDateConverter;

namespace HttPlaceholder.Client.Model
{
    /// <summary>
    /// A model for storing the request data for a request.
    /// </summary>
    [DataContract]
    public partial class RequestParametersDto :  IEquatable<RequestParametersDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestParametersDto" /> class.
        /// </summary>
        /// <param name="method">Gets or sets the method..</param>
        /// <param name="url">Gets or sets the URL..</param>
        /// <param name="body">Gets or sets the body..</param>
        /// <param name="headers">Gets or sets the headers..</param>
        /// <param name="clientIp">Gets or sets the client ip..</param>
        public RequestParametersDto(string method = default(string), string url = default(string), string body = default(string), Dictionary<string, string> headers = default(Dictionary<string, string>), string clientIp = default(string))
        {
            this.Method = method;
            this.Url = url;
            this.Body = body;
            this.Headers = headers;
            this.ClientIp = clientIp;
        }
        
        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        /// <value>Gets or sets the method.</value>
        [DataMember(Name="method", EmitDefaultValue=true)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>Gets or sets the URL.</value>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>Gets or sets the body.</value>
        [DataMember(Name="body", EmitDefaultValue=true)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the headers.
        /// </summary>
        /// <value>Gets or sets the headers.</value>
        [DataMember(Name="headers", EmitDefaultValue=true)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or sets the client ip.
        /// </summary>
        /// <value>Gets or sets the client ip.</value>
        [DataMember(Name="clientIp", EmitDefaultValue=true)]
        public string ClientIp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestParametersDto {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  ClientIp: ").Append(ClientIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequestParametersDto);
        }

        /// <summary>
        /// Returns true if RequestParametersDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestParametersDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestParametersDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.ClientIp == input.ClientIp ||
                    (this.ClientIp != null &&
                    this.ClientIp.Equals(input.ClientIp))
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
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.ClientIp != null)
                    hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
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
