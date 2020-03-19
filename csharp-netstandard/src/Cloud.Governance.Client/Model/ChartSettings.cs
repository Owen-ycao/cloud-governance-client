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
    /// ChartSettings
    /// </summary>
    [DataContract]
    public partial class ChartSettings :  IEquatable<ChartSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DataSource
        /// </summary>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public ReportDataSource? DataSource { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ChartType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSettings" /> class.
        /// </summary>
        /// <param name="xAxisList">xAxisList.</param>
        /// <param name="yAxisList">yAxisList.</param>
        /// <param name="legendSourceList">legendSourceList.</param>
        /// <param name="legendEntriesList">legendEntriesList.</param>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="dataSource">dataSource.</param>
        /// <param name="type">type.</param>
        /// <param name="xAxis">xAxis.</param>
        /// <param name="yAxis">yAxis.</param>
        /// <param name="enableLegend">enableLegend.</param>
        /// <param name="legendSource">legendSource.</param>
        /// <param name="legendEntries">legendEntries.</param>
        public ChartSettings(List<StringModel> xAxisList = default(List<StringModel>), List<StringModel> yAxisList = default(List<StringModel>), List<StringModel> legendSourceList = default(List<StringModel>), List<StringModel> legendEntriesList = default(List<StringModel>), Guid id = default(Guid), string title = default(string), string description = default(string), ReportDataSource dataSource = default(ReportDataSource), ChartType type = default(ChartType), string xAxis = default(string), string yAxis = default(string), bool enableLegend = default(bool), string legendSource = default(string), List<string> legendEntries = default(List<string>))
        {
            this.XAxisList = xAxisList;
            this.YAxisList = yAxisList;
            this.LegendSourceList = legendSourceList;
            this.LegendEntriesList = legendEntriesList;
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.DataSource = dataSource;
            this.Type = type;
            this.XAxis = xAxis;
            this.YAxis = yAxis;
            this.EnableLegend = enableLegend;
            this.LegendSource = legendSource;
            this.LegendEntries = legendEntries;
        }
        
        /// <summary>
        /// Gets or Sets XAxisList
        /// </summary>
        [DataMember(Name="xAxisList", EmitDefaultValue=true)]
        public List<StringModel> XAxisList { get; set; }

        /// <summary>
        /// Gets or Sets YAxisList
        /// </summary>
        [DataMember(Name="yAxisList", EmitDefaultValue=true)]
        public List<StringModel> YAxisList { get; set; }

        /// <summary>
        /// Gets or Sets LegendSourceList
        /// </summary>
        [DataMember(Name="legendSourceList", EmitDefaultValue=true)]
        public List<StringModel> LegendSourceList { get; set; }

        /// <summary>
        /// Gets or Sets LegendEntriesList
        /// </summary>
        [DataMember(Name="legendEntriesList", EmitDefaultValue=true)]
        public List<StringModel> LegendEntriesList { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets XAxis
        /// </summary>
        [DataMember(Name="xAxis", EmitDefaultValue=true)]
        public string XAxis { get; set; }

        /// <summary>
        /// Gets or Sets YAxis
        /// </summary>
        [DataMember(Name="yAxis", EmitDefaultValue=true)]
        public string YAxis { get; set; }

        /// <summary>
        /// Gets or Sets EnableLegend
        /// </summary>
        [DataMember(Name="enableLegend", EmitDefaultValue=false)]
        public bool EnableLegend { get; set; }

        /// <summary>
        /// Gets or Sets LegendSource
        /// </summary>
        [DataMember(Name="legendSource", EmitDefaultValue=true)]
        public string LegendSource { get; set; }

        /// <summary>
        /// Gets or Sets LegendEntries
        /// </summary>
        [DataMember(Name="legendEntries", EmitDefaultValue=true)]
        public List<string> LegendEntries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartSettings {\n");
            sb.Append("  XAxisList: ").Append(XAxisList).Append("\n");
            sb.Append("  YAxisList: ").Append(YAxisList).Append("\n");
            sb.Append("  LegendSourceList: ").Append(LegendSourceList).Append("\n");
            sb.Append("  LegendEntriesList: ").Append(LegendEntriesList).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  XAxis: ").Append(XAxis).Append("\n");
            sb.Append("  YAxis: ").Append(YAxis).Append("\n");
            sb.Append("  EnableLegend: ").Append(EnableLegend).Append("\n");
            sb.Append("  LegendSource: ").Append(LegendSource).Append("\n");
            sb.Append("  LegendEntries: ").Append(LegendEntries).Append("\n");
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
            return this.Equals(input as ChartSettings);
        }

        /// <summary>
        /// Returns true if ChartSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ChartSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChartSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XAxisList == input.XAxisList ||
                    this.XAxisList != null &&
                    input.XAxisList != null &&
                    this.XAxisList.SequenceEqual(input.XAxisList)
                ) && 
                (
                    this.YAxisList == input.YAxisList ||
                    this.YAxisList != null &&
                    input.YAxisList != null &&
                    this.YAxisList.SequenceEqual(input.YAxisList)
                ) && 
                (
                    this.LegendSourceList == input.LegendSourceList ||
                    this.LegendSourceList != null &&
                    input.LegendSourceList != null &&
                    this.LegendSourceList.SequenceEqual(input.LegendSourceList)
                ) && 
                (
                    this.LegendEntriesList == input.LegendEntriesList ||
                    this.LegendEntriesList != null &&
                    input.LegendEntriesList != null &&
                    this.LegendEntriesList.SequenceEqual(input.LegendEntriesList)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
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
                    this.DataSource == input.DataSource ||
                    this.DataSource.Equals(input.DataSource)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.XAxis == input.XAxis ||
                    (this.XAxis != null &&
                    this.XAxis.Equals(input.XAxis))
                ) && 
                (
                    this.YAxis == input.YAxis ||
                    (this.YAxis != null &&
                    this.YAxis.Equals(input.YAxis))
                ) && 
                (
                    this.EnableLegend == input.EnableLegend ||
                    this.EnableLegend.Equals(input.EnableLegend)
                ) && 
                (
                    this.LegendSource == input.LegendSource ||
                    (this.LegendSource != null &&
                    this.LegendSource.Equals(input.LegendSource))
                ) && 
                (
                    this.LegendEntries == input.LegendEntries ||
                    this.LegendEntries != null &&
                    input.LegendEntries != null &&
                    this.LegendEntries.SequenceEqual(input.LegendEntries)
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
                if (this.XAxisList != null)
                    hashCode = hashCode * 59 + this.XAxisList.GetHashCode();
                if (this.YAxisList != null)
                    hashCode = hashCode * 59 + this.YAxisList.GetHashCode();
                if (this.LegendSourceList != null)
                    hashCode = hashCode * 59 + this.LegendSourceList.GetHashCode();
                if (this.LegendEntriesList != null)
                    hashCode = hashCode * 59 + this.LegendEntriesList.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.DataSource.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.XAxis != null)
                    hashCode = hashCode * 59 + this.XAxis.GetHashCode();
                if (this.YAxis != null)
                    hashCode = hashCode * 59 + this.YAxis.GetHashCode();
                hashCode = hashCode * 59 + this.EnableLegend.GetHashCode();
                if (this.LegendSource != null)
                    hashCode = hashCode * 59 + this.LegendSource.GetHashCode();
                if (this.LegendEntries != null)
                    hashCode = hashCode * 59 + this.LegendEntries.GetHashCode();
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