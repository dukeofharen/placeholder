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
    /// A model for storing a condition check result.
    /// </summary>
    [DataContract]
    public partial class ConditionCheckResultDto :  IEquatable<ConditionCheckResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionCheckResultDto" /> class.
        /// </summary>
        /// <param name="checkerName">Gets or sets the name of the checker..</param>
        /// <param name="conditionValidation">Gets or sets the condition validation..</param>
        /// <param name="log">Gets or sets the log..</param>
        public ConditionCheckResultDto(string checkerName = default(string), string conditionValidation = default(string), string log = default(string))
        {
            this.CheckerName = checkerName;
            this.ConditionValidation = conditionValidation;
            this.Log = log;
        }
        
        /// <summary>
        /// Gets or sets the name of the checker.
        /// </summary>
        /// <value>Gets or sets the name of the checker.</value>
        [DataMember(Name="checkerName", EmitDefaultValue=true)]
        public string CheckerName { get; set; }

        /// <summary>
        /// Gets or sets the condition validation.
        /// </summary>
        /// <value>Gets or sets the condition validation.</value>
        [DataMember(Name="conditionValidation", EmitDefaultValue=true)]
        public string ConditionValidation { get; set; }

        /// <summary>
        /// Gets or sets the log.
        /// </summary>
        /// <value>Gets or sets the log.</value>
        [DataMember(Name="log", EmitDefaultValue=true)]
        public string Log { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionCheckResultDto {\n");
            sb.Append("  CheckerName: ").Append(CheckerName).Append("\n");
            sb.Append("  ConditionValidation: ").Append(ConditionValidation).Append("\n");
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
            return this.Equals(input as ConditionCheckResultDto);
        }

        /// <summary>
        /// Returns true if ConditionCheckResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ConditionCheckResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionCheckResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckerName == input.CheckerName ||
                    (this.CheckerName != null &&
                    this.CheckerName.Equals(input.CheckerName))
                ) && 
                (
                    this.ConditionValidation == input.ConditionValidation ||
                    (this.ConditionValidation != null &&
                    this.ConditionValidation.Equals(input.ConditionValidation))
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
                if (this.CheckerName != null)
                    hashCode = hashCode * 59 + this.CheckerName.GetHashCode();
                if (this.ConditionValidation != null)
                    hashCode = hashCode * 59 + this.ConditionValidation.GetHashCode();
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
