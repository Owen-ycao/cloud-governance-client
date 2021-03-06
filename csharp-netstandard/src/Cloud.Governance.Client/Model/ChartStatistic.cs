/* 
 * Cloud Governance Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
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
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// ChartStatistic
    /// </summary>
    [DataContract]
    public partial class ChartStatistic :  IEquatable<ChartStatistic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartStatistic" /> class.
        /// </summary>
        /// <param name="xAxis">xAxis.</param>
        /// <param name="yAxis">yAxis.</param>
        /// <param name="legendSource">legendSource.</param>
        public ChartStatistic(List<StringModel> xAxis = default(List<StringModel>), List<StringModel> yAxis = default(List<StringModel>), List<StringModel> legendSource = default(List<StringModel>))
        {
            this.XAxis = xAxis;
            this.YAxis = yAxis;
            this.LegendSource = legendSource;
        }
        
        /// <summary>
        /// Gets or Sets XAxis
        /// </summary>
        [DataMember(Name="xAxis", EmitDefaultValue=true)]
        public List<StringModel> XAxis { get; set; }

        /// <summary>
        /// Gets or Sets YAxis
        /// </summary>
        [DataMember(Name="yAxis", EmitDefaultValue=true)]
        public List<StringModel> YAxis { get; set; }

        /// <summary>
        /// Gets or Sets LegendSource
        /// </summary>
        [DataMember(Name="legendSource", EmitDefaultValue=true)]
        public List<StringModel> LegendSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartStatistic {\n");
            sb.Append("  XAxis: ").Append(XAxis).Append("\n");
            sb.Append("  YAxis: ").Append(YAxis).Append("\n");
            sb.Append("  LegendSource: ").Append(LegendSource).Append("\n");
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
            return this.Equals(input as ChartStatistic);
        }

        /// <summary>
        /// Returns true if ChartStatistic instances are equal
        /// </summary>
        /// <param name="input">Instance of ChartStatistic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChartStatistic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XAxis == input.XAxis ||
                    this.XAxis != null &&
                    input.XAxis != null &&
                    this.XAxis.SequenceEqual(input.XAxis)
                ) && 
                (
                    this.YAxis == input.YAxis ||
                    this.YAxis != null &&
                    input.YAxis != null &&
                    this.YAxis.SequenceEqual(input.YAxis)
                ) && 
                (
                    this.LegendSource == input.LegendSource ||
                    this.LegendSource != null &&
                    input.LegendSource != null &&
                    this.LegendSource.SequenceEqual(input.LegendSource)
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
                if (this.XAxis != null)
                    hashCode = hashCode * 59 + this.XAxis.GetHashCode();
                if (this.YAxis != null)
                    hashCode = hashCode * 59 + this.YAxis.GetHashCode();
                if (this.LegendSource != null)
                    hashCode = hashCode * 59 + this.LegendSource.GetHashCode();
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
