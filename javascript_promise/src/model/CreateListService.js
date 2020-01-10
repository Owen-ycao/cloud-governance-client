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
    define(['ApiClient', 'model/ApiUser', 'model/AssignBy', 'model/CommonStatus', 'model/CreateListUrlSettings', 'model/CustomActionSettings', 'model/CustomMetadata', 'model/ListTemplateSettings', 'model/ListType', 'model/ListVersionSettings', 'model/PermissionSettings', 'model/ServiceScopeSettings', 'model/ServiceType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ApiUser'), require('./AssignBy'), require('./CommonStatus'), require('./CreateListUrlSettings'), require('./CustomActionSettings'), require('./CustomMetadata'), require('./ListTemplateSettings'), require('./ListType'), require('./ListVersionSettings'), require('./PermissionSettings'), require('./ServiceScopeSettings'), require('./ServiceType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.CreateListService = factory(root.CgClient.ApiClient, root.CgClient.ApiUser, root.CgClient.AssignBy, root.CgClient.CommonStatus, root.CgClient.CreateListUrlSettings, root.CgClient.CustomActionSettings, root.CgClient.CustomMetadata, root.CgClient.ListTemplateSettings, root.CgClient.ListType, root.CgClient.ListVersionSettings, root.CgClient.PermissionSettings, root.CgClient.ServiceScopeSettings, root.CgClient.ServiceType);
  }
}(this, function(ApiClient, ApiUser, AssignBy, CommonStatus, CreateListUrlSettings, CustomActionSettings, CustomMetadata, ListTemplateSettings, ListType, ListVersionSettings, PermissionSettings, ServiceScopeSettings, ServiceType) {
  'use strict';



  /**
   * The CreateListService model module.
   * @module model/CreateListService
   * @version 1.0
   */

  /**
   * Constructs a new <code>CreateListService</code>.
   * @alias module:model/CreateListService
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>CreateListService</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/CreateListService} obj Optional instance to populate.
   * @return {module:model/CreateListService} The populated <code>CreateListService</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('enableNavigation')) {
        obj['enableNavigation'] = ApiClient.convertToType(data['enableNavigation'], 'Boolean');
      }
      if (data.hasOwnProperty('defaultListType')) {
        obj['defaultListType'] = ListType.constructFromObject(data['defaultListType']);
      }
      if (data.hasOwnProperty('versionSettings')) {
        obj['versionSettings'] = ListVersionSettings.constructFromObject(data['versionSettings']);
      }
      if (data.hasOwnProperty('listTemplateSettings')) {
        obj['listTemplateSettings'] = ListTemplateSettings.constructFromObject(data['listTemplateSettings']);
      }
      if (data.hasOwnProperty('urlSettings')) {
        obj['urlSettings'] = CreateListUrlSettings.constructFromObject(data['urlSettings']);
      }
      if (data.hasOwnProperty('allowBreakPermissionInheritance')) {
        obj['allowBreakPermissionInheritance'] = ApiClient.convertToType(data['allowBreakPermissionInheritance'], 'Boolean');
      }
      if (data.hasOwnProperty('permissionSettings')) {
        obj['permissionSettings'] = PermissionSettings.constructFromObject(data['permissionSettings']);
      }
      if (data.hasOwnProperty('scopeSettings')) {
        obj['scopeSettings'] = ServiceScopeSettings.constructFromObject(data['scopeSettings']);
      }
      if (data.hasOwnProperty('listVersionAssignBy')) {
        obj['listVersionAssignBy'] = AssignBy.constructFromObject(data['listVersionAssignBy']);
      }
      if (data.hasOwnProperty('listTemplateAssignBy')) {
        obj['listTemplateAssignBy'] = AssignBy.constructFromObject(data['listTemplateAssignBy']);
      }
      if (data.hasOwnProperty('navigationAssignBy')) {
        obj['navigationAssignBy'] = AssignBy.constructFromObject(data['navigationAssignBy']);
      }
      if (data.hasOwnProperty('listTypeAssignBy')) {
        obj['listTypeAssignBy'] = AssignBy.constructFromObject(data['listTypeAssignBy']);
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
   * @member {Boolean} enableNavigation
   */
  exports.prototype['enableNavigation'] = undefined;
  /**
   * @member {module:model/ListType} defaultListType
   */
  exports.prototype['defaultListType'] = undefined;
  /**
   * @member {module:model/ListVersionSettings} versionSettings
   */
  exports.prototype['versionSettings'] = undefined;
  /**
   * @member {module:model/ListTemplateSettings} listTemplateSettings
   */
  exports.prototype['listTemplateSettings'] = undefined;
  /**
   * @member {module:model/CreateListUrlSettings} urlSettings
   */
  exports.prototype['urlSettings'] = undefined;
  /**
   * @member {Boolean} allowBreakPermissionInheritance
   */
  exports.prototype['allowBreakPermissionInheritance'] = undefined;
  /**
   * @member {module:model/PermissionSettings} permissionSettings
   */
  exports.prototype['permissionSettings'] = undefined;
  /**
   * @member {module:model/ServiceScopeSettings} scopeSettings
   */
  exports.prototype['scopeSettings'] = undefined;
  /**
   * @member {module:model/AssignBy} listVersionAssignBy
   */
  exports.prototype['listVersionAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} listTemplateAssignBy
   */
  exports.prototype['listTemplateAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} navigationAssignBy
   */
  exports.prototype['navigationAssignBy'] = undefined;
  /**
   * @member {module:model/AssignBy} listTypeAssignBy
   */
  exports.prototype['listTypeAssignBy'] = undefined;
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

