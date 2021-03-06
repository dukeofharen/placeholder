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
    /// A model for storing metadata of a stub.
    /// </summary>
    [DataContract]
    public partial class StubMetadataDto :  IEquatable<StubMetadataDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StubMetadataDto" /> class.
        /// </summary>
        /// <param name="readOnly">Gets or sets a value indicating whether [read only]..</param>
        public StubMetadataDto(bool readOnly = default(bool))
        {
            this.ReadOnly = readOnly;
        }
        
        /// <summary>
        /// Gets or sets a value indicating whether [read only].
        /// </summary>
        /// <value>Gets or sets a value indicating whether [read only].</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StubMetadataDto {\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
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
            return this.Equals(input as StubMetadataDto);
        }

        /// <summary>
        /// Returns true if StubMetadataDto instances are equal
        /// </summary>
        /// <param name="input">Instance of StubMetadataDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StubMetadataDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReadOnly == input.ReadOnly ||
                    this.ReadOnly.Equals(input.ReadOnly)
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
                hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
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
