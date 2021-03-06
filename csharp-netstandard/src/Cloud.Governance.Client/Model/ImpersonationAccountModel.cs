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
    /// ImpersonationAccountModel
    /// </summary>
    [DataContract]
    public partial class ImpersonationAccountModel :  IEquatable<ImpersonationAccountModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImpersonationAccountModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImpersonationAccountModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImpersonationAccountModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="domain">domain (required).</param>
        /// <param name="user">user (required).</param>
        /// <param name="tenant">tenant (required).</param>
        /// <param name="tenants">tenants.</param>
        public ImpersonationAccountModel(Guid id = default(Guid), string domain = default(string), ApiUser user = default(ApiUser), GuidModel tenant = default(GuidModel), List<StringModel> tenants = default(List<StringModel>))
        {
            // to ensure "domain" is required (not null)
            this.Domain = domain ?? throw new ArgumentNullException("domain is a required property for ImpersonationAccountModel and cannot be null");;
            // to ensure "user" is required (not null)
            this.User = user ?? throw new ArgumentNullException("user is a required property for ImpersonationAccountModel and cannot be null");;
            // to ensure "tenant" is required (not null)
            this.Tenant = tenant ?? throw new ArgumentNullException("tenant is a required property for ImpersonationAccountModel and cannot be null");;
            this.Id = id;
            this.Tenants = tenants;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public ApiUser User { get; set; }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name="tenant", EmitDefaultValue=true)]
        public GuidModel Tenant { get; set; }

        /// <summary>
        /// Gets or Sets Tenants
        /// </summary>
        [DataMember(Name="tenants", EmitDefaultValue=true)]
        public List<StringModel> Tenants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImpersonationAccountModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  Tenants: ").Append(Tenants).Append("\n");
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
            return this.Equals(input as ImpersonationAccountModel);
        }

        /// <summary>
        /// Returns true if ImpersonationAccountModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ImpersonationAccountModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImpersonationAccountModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.Tenants == input.Tenants ||
                    this.Tenants != null &&
                    input.Tenants != null &&
                    this.Tenants.SequenceEqual(input.Tenants)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.Tenants != null)
                    hashCode = hashCode * 59 + this.Tenants.GetHashCode();
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
