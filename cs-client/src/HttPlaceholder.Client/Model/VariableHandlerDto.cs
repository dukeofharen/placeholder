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
    /// A model that is used for displaying what types of variable handlers are available.
    /// </summary>
    [DataContract]
    public partial class VariableHandlerDto :  IEquatable<VariableHandlerDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableHandlerDto" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the variable handler..</param>
        /// <param name="fullName">Gets or sets the full name of the variable handler..</param>
        /// <param name="example">Gets or sets a short instruction on how to use the variable handler..</param>
        public VariableHandlerDto(string name = default(string), string fullName = default(string), string example = default(string))
        {
            this.Name = name;
            this.FullName = fullName;
            this.Example = example;
        }
        
        /// <summary>
        /// Gets or sets the name of the variable handler.
        /// </summary>
        /// <value>Gets or sets the name of the variable handler.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the full name of the variable handler.
        /// </summary>
        /// <value>Gets or sets the full name of the variable handler.</value>
        [DataMember(Name="fullName", EmitDefaultValue=true)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets a short instruction on how to use the variable handler.
        /// </summary>
        /// <value>Gets or sets a short instruction on how to use the variable handler.</value>
        [DataMember(Name="example", EmitDefaultValue=true)]
        public string Example { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableHandlerDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Example: ").Append(Example).Append("\n");
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
            return this.Equals(input as VariableHandlerDto);
        }

        /// <summary>
        /// Returns true if VariableHandlerDto instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableHandlerDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableHandlerDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Example == input.Example ||
                    (this.Example != null &&
                    this.Example.Equals(input.Example))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Example != null)
                    hashCode = hashCode * 59 + this.Example.GetHashCode();
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
