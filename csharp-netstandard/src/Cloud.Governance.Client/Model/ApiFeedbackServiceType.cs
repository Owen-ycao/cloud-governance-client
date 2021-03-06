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
    /// CreateSiteCollection&#x3D;0, CreateSite&#x3D;1, CreateList&#x3D;2, &lt;/br&gt;ChangeSiteCollectionSettings&#x3D;3, ChangeSiteCollectionContact&#x3D;4, ChangeSiteContact&#x3D;5, &lt;/br&gt;ChangeSiteMetadata&#x3D;6, ChangeList&#x3D;7, SiteCollectionLifeCycle&#x3D;8, &lt;/br&gt;SiteLifeCycle&#x3D;9, RemovePermission&#x3D;10, GrantPermission&#x3D;11, &lt;/br&gt;TransferPermission&#x3D;12, ContentManager&#x3D;13, CreateTeam&#x3D;14, &lt;/br&gt;CreateGroup&#x3D;15, TeamLifeCycle&#x3D;16, GroupLifeCycle&#x3D;17, &lt;/br&gt;ChangeTeam&#x3D;18, ChangeGroup&#x3D;19
    /// </summary>
    /// <value>CreateSiteCollection&#x3D;0, CreateSite&#x3D;1, CreateList&#x3D;2, &lt;/br&gt;ChangeSiteCollectionSettings&#x3D;3, ChangeSiteCollectionContact&#x3D;4, ChangeSiteContact&#x3D;5, &lt;/br&gt;ChangeSiteMetadata&#x3D;6, ChangeList&#x3D;7, SiteCollectionLifeCycle&#x3D;8, &lt;/br&gt;SiteLifeCycle&#x3D;9, RemovePermission&#x3D;10, GrantPermission&#x3D;11, &lt;/br&gt;TransferPermission&#x3D;12, ContentManager&#x3D;13, CreateTeam&#x3D;14, &lt;/br&gt;CreateGroup&#x3D;15, TeamLifeCycle&#x3D;16, GroupLifeCycle&#x3D;17, &lt;/br&gt;ChangeTeam&#x3D;18, ChangeGroup&#x3D;19</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ApiFeedbackServiceType
    {
        /// <summary>
        /// Enum CreateSiteCollection for value: CreateSiteCollection
        /// </summary>
        [EnumMember(Value = "CreateSiteCollection")]
        CreateSiteCollection = 1,

        /// <summary>
        /// Enum CreateSite for value: CreateSite
        /// </summary>
        [EnumMember(Value = "CreateSite")]
        CreateSite = 2,

        /// <summary>
        /// Enum CreateList for value: CreateList
        /// </summary>
        [EnumMember(Value = "CreateList")]
        CreateList = 3,

        /// <summary>
        /// Enum ChangeSiteCollectionSettings for value: ChangeSiteCollectionSettings
        /// </summary>
        [EnumMember(Value = "ChangeSiteCollectionSettings")]
        ChangeSiteCollectionSettings = 4,

        /// <summary>
        /// Enum ChangeSiteCollectionContact for value: ChangeSiteCollectionContact
        /// </summary>
        [EnumMember(Value = "ChangeSiteCollectionContact")]
        ChangeSiteCollectionContact = 5,

        /// <summary>
        /// Enum ChangeSiteContact for value: ChangeSiteContact
        /// </summary>
        [EnumMember(Value = "ChangeSiteContact")]
        ChangeSiteContact = 6,

        /// <summary>
        /// Enum ChangeSiteMetadata for value: ChangeSiteMetadata
        /// </summary>
        [EnumMember(Value = "ChangeSiteMetadata")]
        ChangeSiteMetadata = 7,

        /// <summary>
        /// Enum ChangeList for value: ChangeList
        /// </summary>
        [EnumMember(Value = "ChangeList")]
        ChangeList = 8,

        /// <summary>
        /// Enum SiteCollectionLifeCycle for value: SiteCollectionLifeCycle
        /// </summary>
        [EnumMember(Value = "SiteCollectionLifeCycle")]
        SiteCollectionLifeCycle = 9,

        /// <summary>
        /// Enum SiteLifeCycle for value: SiteLifeCycle
        /// </summary>
        [EnumMember(Value = "SiteLifeCycle")]
        SiteLifeCycle = 10,

        /// <summary>
        /// Enum RemovePermission for value: RemovePermission
        /// </summary>
        [EnumMember(Value = "RemovePermission")]
        RemovePermission = 11,

        /// <summary>
        /// Enum GrantPermission for value: GrantPermission
        /// </summary>
        [EnumMember(Value = "GrantPermission")]
        GrantPermission = 12,

        /// <summary>
        /// Enum TransferPermission for value: TransferPermission
        /// </summary>
        [EnumMember(Value = "TransferPermission")]
        TransferPermission = 13,

        /// <summary>
        /// Enum ContentManager for value: ContentManager
        /// </summary>
        [EnumMember(Value = "ContentManager")]
        ContentManager = 14,

        /// <summary>
        /// Enum CreateTeam for value: CreateTeam
        /// </summary>
        [EnumMember(Value = "CreateTeam")]
        CreateTeam = 15,

        /// <summary>
        /// Enum CreateGroup for value: CreateGroup
        /// </summary>
        [EnumMember(Value = "CreateGroup")]
        CreateGroup = 16,

        /// <summary>
        /// Enum TeamLifeCycle for value: TeamLifeCycle
        /// </summary>
        [EnumMember(Value = "TeamLifeCycle")]
        TeamLifeCycle = 17,

        /// <summary>
        /// Enum GroupLifeCycle for value: GroupLifeCycle
        /// </summary>
        [EnumMember(Value = "GroupLifeCycle")]
        GroupLifeCycle = 18,

        /// <summary>
        /// Enum ChangeTeam for value: ChangeTeam
        /// </summary>
        [EnumMember(Value = "ChangeTeam")]
        ChangeTeam = 19,

        /// <summary>
        /// Enum ChangeGroup for value: ChangeGroup
        /// </summary>
        [EnumMember(Value = "ChangeGroup")]
        ChangeGroup = 20

    }

}
