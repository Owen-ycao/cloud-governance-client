/**
 * Cloud Governance Api
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 *
 * OpenAPI Generator version: 4.2.2
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/ApiUser', 'model/AssignBy', 'model/CommonStatus', 'model/CustomActionSettings', 'model/CustomMetadata', 'model/GroupRestrictionType', 'model/ServiceType', 'model/UserLevelRestrictionType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ApiUser'), require('./AssignBy'), require('./CommonStatus'), require('./CustomActionSettings'), require('./CustomMetadata'), require('./GroupRestrictionType'), require('./ServiceType'), require('./UserLevelRestrictionType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.ChangeGroupSettingService = factory(root.CgClient.ApiClient, root.CgClient.ApiUser, root.CgClient.AssignBy, root.CgClient.CommonStatus, root.CgClient.CustomActionSettings, root.CgClient.CustomMetadata, root.CgClient.GroupRestrictionType, root.CgClient.ServiceType, root.CgClient.UserLevelRestrictionType);
  }
}(this, function(ApiClient, ApiUser, AssignBy, CommonStatus, CustomActionSettings, CustomMetadata, GroupRestrictionType, ServiceType, UserLevelRestrictionType) {
  'use strict';



  /**
   * The ChangeGroupSettingService model module.
   * @module model/ChangeGroupSettingService
   * @version 1.0
   */

  /**
   * Constructs a new <code>ChangeGroupSettingService</code>.
   * @alias module:model/ChangeGroupSettingService
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>ChangeGroupSettingService</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ChangeGroupSettingService} obj Optional instance to populate.
   * @return {module:model/ChangeGroupSettingService} The populated <code>ChangeGroupSettingService</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('tenantId')) {
        obj['tenantId'] = ApiClient.convertToType(data['tenantId'], 'String');
      }
      if (data.hasOwnProperty('groupRestriction')) {
        obj['groupRestriction'] = GroupRestrictionType.constructFromObject(data['groupRestriction']);
      }
      if (data.hasOwnProperty('enableChangeName')) {
        obj['enableChangeName'] = ApiClient.convertToType(data['enableChangeName'], 'Boolean');
      }
      if (data.hasOwnProperty('enableChangeDescription')) {
        obj['enableChangeDescription'] = ApiClient.convertToType(data['enableChangeDescription'], 'Boolean');
      }
      if (data.hasOwnProperty('enableChangeMemberSubscription')) {
        obj['enableChangeMemberSubscription'] = ApiClient.convertToType(data['enableChangeMemberSubscription'], 'Boolean');
      }
      if (data.hasOwnProperty('enableChangeOutsideSenders')) {
        obj['enableChangeOutsideSenders'] = ApiClient.convertToType(data['enableChangeOutsideSenders'], 'Boolean');
      }
      if (data.hasOwnProperty('enableChangePrimaryContact')) {
        obj['enableChangePrimaryContact'] = ApiClient.convertToType(data['enableChangePrimaryContact'], 'Boolean');
      }
      if (data.hasOwnProperty('enableChangeSecondaryContact')) {
        obj['enableChangeSecondaryContact'] = ApiClient.convertToType(data['enableChangeSecondaryContact'], 'Boolean');
      }
      if (data.hasOwnProperty('enableAddOwners')) {
        obj['enableAddOwners'] = ApiClient.convertToType(data['enableAddOwners'], 'Boolean');
      }
      if (data.hasOwnProperty('addOwnerRestriction')) {
        obj['addOwnerRestriction'] = UserLevelRestrictionType.constructFromObject(data['addOwnerRestriction']);
      }
      if (data.hasOwnProperty('enableRemoveOwners')) {
        obj['enableRemoveOwners'] = ApiClient.convertToType(data['enableRemoveOwners'], 'Boolean');
      }
      if (data.hasOwnProperty('enableAddMembers')) {
        obj['enableAddMembers'] = ApiClient.convertToType(data['enableAddMembers'], 'Boolean');
      }
      if (data.hasOwnProperty('addMemberRestriction')) {
        obj['addMemberRestriction'] = UserLevelRestrictionType.constructFromObject(data['addMemberRestriction']);
      }
      if (data.hasOwnProperty('enableRemoveMembers')) {
        obj['enableRemoveMembers'] = ApiClient.convertToType(data['enableRemoveMembers'], 'Boolean');
      }
      if (data.hasOwnProperty('enableChangeDynamicMembershipRules')) {
        obj['enableChangeDynamicMembershipRules'] = ApiClient.convertToType(data['enableChangeDynamicMembershipRules'], 'Boolean');
      }
      if (data.hasOwnProperty('enableChangeTeamCollaboration')) {
        obj['enableChangeTeamCollaboration'] = ApiClient.convertToType(data['enableChangeTeamCollaboration'], 'Boolean');
      }
      if (data.hasOwnProperty('enableChangeHubSite')) {
        obj['enableChangeHubSite'] = ApiClient.convertToType(data['enableChangeHubSite'], 'Boolean');
      }
      if (data.hasOwnProperty('enableChangeClassification')) {
        obj['enableChangeClassification'] = ApiClient.convertToType(data['enableChangeClassification'], 'Boolean');
      }
      if (data.hasOwnProperty('classificationList')) {
        obj['classificationList'] = ApiClient.convertToType(data['classificationList'], ['String']);
      }
      if (data.hasOwnProperty('enableChangeMetadata')) {
        obj['enableChangeMetadata'] = ApiClient.convertToType(data['enableChangeMetadata'], 'Boolean');
      }
      if (data.hasOwnProperty('enableAddOrDeleteMetadata')) {
        obj['enableAddOrDeleteMetadata'] = ApiClient.convertToType(data['enableAddOrDeleteMetadata'], 'Boolean');
      }
      if (data.hasOwnProperty('metadataList')) {
        obj['metadataList'] = ApiClient.convertToType(data['metadataList'], [CustomMetadata]);
      }
      if (data.hasOwnProperty('departmentAssignBy')) {
        obj['departmentAssignBy'] = AssignBy.constructFromObject(data['departmentAssignBy']);
      }
      if (data.hasOwnProperty('metadatas')) {
        obj['metadatas'] = ApiClient.convertToType(data['metadatas'], [CustomMetadata]);
      }
      if (data.hasOwnProperty('hideRequestSummary')) {
        obj['hideRequestSummary'] = ApiClient.convertToType(data['hideRequestSummary'], 'Boolean');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('description')) {
        obj['description'] = ApiClient.convertToType(data['description'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ServiceType.constructFromObject(data['type']);
      }
      if (data.hasOwnProperty('department')) {
        obj['department'] = ApiClient.convertToType(data['department'], 'String');
      }
      if (data.hasOwnProperty('loadDepartmentFromUps')) {
        obj['loadDepartmentFromUps'] = ApiClient.convertToType(data['loadDepartmentFromUps'], 'Boolean');
      }
      if (data.hasOwnProperty('departments')) {
        obj['departments'] = ApiClient.convertToType(data['departments'], ['String']);
      }
      if (data.hasOwnProperty('serviceContact')) {
        obj['serviceContact'] = ApiUser.constructFromObject(data['serviceContact']);
      }
      if (data.hasOwnProperty('serviceAdminContact')) {
        obj['serviceAdminContact'] = ApiUser.constructFromObject(data['serviceAdminContact']);
      }
      if (data.hasOwnProperty('approversContainManagerRole')) {
        obj['approversContainManagerRole'] = ApiClient.convertToType(data['approversContainManagerRole'], 'Boolean');
      }
      if (data.hasOwnProperty('status')) {
        obj['status'] = CommonStatus.constructFromObject(data['status']);
      }
      if (data.hasOwnProperty('showServiceInCatalog')) {
        obj['showServiceInCatalog'] = ApiClient.convertToType(data['showServiceInCatalog'], 'Boolean');
      }
      if (data.hasOwnProperty('customActions')) {
        obj['customActions'] = CustomActionSettings.constructFromObject(data['customActions']);
      }
      if (data.hasOwnProperty('approvalProcessId')) {
        obj['approvalProcessId'] = ApiClient.convertToType(data['approvalProcessId'], 'String');
      }
      if (data.hasOwnProperty('languageId')) {
        obj['languageId'] = ApiClient.convertToType(data['languageId'], 'Number');
      }
      if (data.hasOwnProperty('categoryId')) {
        obj['categoryId'] = ApiClient.convertToType(data['categoryId'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {String} tenantId
   */
  exports.prototype['tenantId'] = undefined;
  /**
   * @member {module:model/GroupRestrictionType} groupRestriction
   */
  exports.prototype['groupRestriction'] = undefined;
  /**
   * @member {Boolean} enableChangeName
   */
  exports.prototype['enableChangeName'] = undefined;
  /**
   * @member {Boolean} enableChangeDescription
   */
  exports.prototype['enableChangeDescription'] = undefined;
  /**
   * @member {Boolean} enableChangeMemberSubscription
   */
  exports.prototype['enableChangeMemberSubscription'] = undefined;
  /**
   * @member {Boolean} enableChangeOutsideSenders
   */
  exports.prototype['enableChangeOutsideSenders'] = undefined;
  /**
   * @member {Boolean} enableChangePrimaryContact
   */
  exports.prototype['enableChangePrimaryContact'] = undefined;
  /**
   * @member {Boolean} enableChangeSecondaryContact
   */
  exports.prototype['enableChangeSecondaryContact'] = undefined;
  /**
   * @member {Boolean} enableAddOwners
   */
  exports.prototype['enableAddOwners'] = undefined;
  /**
   * @member {module:model/UserLevelRestrictionType} addOwnerRestriction
   */
  exports.prototype['addOwnerRestriction'] = undefined;
  /**
   * @member {Boolean} enableRemoveOwners
   */
  exports.prototype['enableRemoveOwners'] = undefined;
  /**
   * @member {Boolean} enableAddMembers
   */
  exports.prototype['enableAddMembers'] = undefined;
  /**
   * @member {module:model/UserLevelRestrictionType} addMemberRestriction
   */
  exports.prototype['addMemberRestriction'] = undefined;
  /**
   * @member {Boolean} enableRemoveMembers
   */
  exports.prototype['enableRemoveMembers'] = undefined;
  /**
   * @member {Boolean} enableChangeDynamicMembershipRules
   */
  exports.prototype['enableChangeDynamicMembershipRules'] = undefined;
  /**
   * @member {Boolean} enableChangeTeamCollaboration
   */
  exports.prototype['enableChangeTeamCollaboration'] = undefined;
  /**
   * @member {Boolean} enableChangeHubSite
   */
  exports.prototype['enableChangeHubSite'] = undefined;
  /**
   * @member {Boolean} enableChangeClassification
   */
  exports.prototype['enableChangeClassification'] = undefined;
  /**
   * @member {Array.<String>} classificationList
   */
  exports.prototype['classificationList'] = undefined;
  /**
   * @member {Boolean} enableChangeMetadata
   */
  exports.prototype['enableChangeMetadata'] = undefined;
  /**
   * @member {Boolean} enableAddOrDeleteMetadata
   */
  exports.prototype['enableAddOrDeleteMetadata'] = undefined;
  /**
   * @member {Array.<module:model/CustomMetadata>} metadataList
   */
  exports.prototype['metadataList'] = undefined;
  /**
   * @member {module:model/AssignBy} departmentAssignBy
   */
  exports.prototype['departmentAssignBy'] = undefined;
  /**
   * @member {Array.<module:model/CustomMetadata>} metadatas
   */
  exports.prototype['metadatas'] = undefined;
  /**
   * @member {Boolean} hideRequestSummary
   */
  exports.prototype['hideRequestSummary'] = undefined;
  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * @member {String} description
   */
  exports.prototype['description'] = undefined;
  /**
   * @member {module:model/ServiceType} type
   */
  exports.prototype['type'] = undefined;
  /**
   * @member {String} department
   */
  exports.prototype['department'] = undefined;
  /**
   * @member {Boolean} loadDepartmentFromUps
   */
  exports.prototype['loadDepartmentFromUps'] = undefined;
  /**
   * @member {Array.<String>} departments
   */
  exports.prototype['departments'] = undefined;
  /**
   * @member {module:model/ApiUser} serviceContact
   */
  exports.prototype['serviceContact'] = undefined;
  /**
   * @member {module:model/ApiUser} serviceAdminContact
   */
  exports.prototype['serviceAdminContact'] = undefined;
  /**
   * @member {Boolean} approversContainManagerRole
   */
  exports.prototype['approversContainManagerRole'] = undefined;
  /**
   * @member {module:model/CommonStatus} status
   */
  exports.prototype['status'] = undefined;
  /**
   * @member {Boolean} showServiceInCatalog
   */
  exports.prototype['showServiceInCatalog'] = undefined;
  /**
   * @member {module:model/CustomActionSettings} customActions
   */
  exports.prototype['customActions'] = undefined;
  /**
   * @member {String} approvalProcessId
   */
  exports.prototype['approvalProcessId'] = undefined;
  /**
   * @member {Number} languageId
   */
  exports.prototype['languageId'] = undefined;
  /**
   * @member {String} categoryId
   */
  exports.prototype['categoryId'] = undefined;



  return exports;
}));


