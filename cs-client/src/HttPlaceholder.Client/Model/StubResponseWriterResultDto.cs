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
    /// A model for storing the execution result of a specific response writer.
    /// </summary>
    [DataContract]
    public partial class StubResponseWriterResultDto :  IEquatable<StubResponseWriterResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StubResponseWriterResultDto" /> class.
        /// </summary>
        /// <param name="responseWriterName">Gets or sets the name of the response writer..</param>
        /// <param name="executed">Gets or sets a value indicating whether this StubResponseWriterResultDto is executed..</param>
        /// <param name="log">Gets or sets the log string of the executed response writer..</param>
        public StubResponseWriterResultDto(string responseWriterName = default(string), bool executed = default(bool), string log = default(string))
        {
            this.ResponseWriterName = responseWriterName;
            this.Executed = executed;
            this.Log = log;
        }
        
        /// <summary>
        /// Gets or sets the name of the response writer.
        /// </summary>
        /// <value>Gets or sets the name of the response writer.</value>
        [DataMember(Name="responseWriterName", EmitDefaultValue=true)]
        public string ResponseWriterName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this StubResponseWriterResultDto is executed.
        /// </summary>
        /// <value>Gets or sets a value indicating whether this StubResponseWriterResultDto is executed.</value>
        [DataMember(Name="executed", EmitDefaultValue=false)]
        public bool Executed { get; set; }

        /// <summary>
        /// Gets or sets the log string of the executed response writer.
        /// </summary>
        /// <value>Gets or sets the log string of the executed response writer.</value>
        [DataMember(Name="log", EmitDefaultValue=true)]
        public string Log { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StubResponseWriterResultDto {\n");
            sb.Append("  ResponseWriterName: ").Append(ResponseWriterName).Append("\n");
            sb.Append("  Executed: ").Append(Executed).Append("\n");
            sb.Append("  Log: ").Append(Log).Append("\n");
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
            return this.Equals(input as StubResponseWriterResultDto);
        }

        /// <summary>
        /// Returns true if StubResponseWriterResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of StubResponseWriterResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StubResponseWriterResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseWriterName == input.ResponseWriterName ||
                    (this.ResponseWriterName != null &&
                    this.ResponseWriterName.Equals(input.ResponseWriterName))
                ) && 
                (
                    this.Executed == input.Executed ||
                    this.Executed.Equals(input.Executed)
                ) && 
                (
                    this.Log == input.Log ||
                    (this.Log != null &&
                    this.Log.Equals(input.Log))
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
                if (this.ResponseWriterName != null)
                    hashCode = hashCode * 59 + this.ResponseWriterName.GetHashCode();
                hashCode = hashCode * 59 + this.Executed.GetHashCode();
                if (this.Log != null)
                    hashCode = hashCode * 59 + this.Log.GetHashCode();
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
