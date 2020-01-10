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
    define(['ApiClient', 'model/RequestGroupWithPermissions', 'model/RequestUserWithPermissions'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./RequestGroupWithPermissions'), require('./RequestUserWithPermissions'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.ListPermissionSettings = factory(root.CgClient.ApiClient, root.CgClient.RequestGroupWithPermissions, root.CgClient.RequestUserWithPermissions);
  }
}(this, function(ApiClient, RequestGroupWithPermissions, RequestUserWithPermissions) {
  'use strict';



  /**
   * The ListPermissionSettings model module.
   * @module model/ListPermissionSettings
   * @version 1.0
   */

  /**
   * Constructs a new <code>ListPermissionSettings</code>.
   * @alias module:model/ListPermissionSettings
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>ListPermissionSettings</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ListPermissionSettings} obj Optional instance to populate.
   * @return {module:model/ListPermissionSettings} The populated <code>ListPermissionSettings</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('stopInheritingPermissions')) {
        obj['stopInheritingPermissions'] = ApiClient.convertToType(data['stopInheritingPermissions'], 'Boolean');
      }
      if (data.hasOwnProperty('userPermissions')) {
        obj['userPermissions'] = ApiClient.convertToType(data['userPermissions'], [RequestUserWithPermissions]);
      }
      if (data.hasOwnProperty('groupPermissions')) {
        obj['groupPermissions'] = ApiClient.convertToType(data['groupPermissions'], [RequestGroupWithPermissions]);
      }
    }
    return obj;
  }

  /**
   * @member {Boolean} stopInheritingPermissions
   */
  exports.prototype['stopInheritingPermissions'] = undefined;
  /**
   * @member {Array.<module:model/RequestUserWithPermissions>} userPermissions
   */
  exports.prototype['userPermissions'] = undefined;
  /**
   * @member {Array.<module:model/RequestGroupWithPermissions>} groupPermissions
   */
  exports.prototype['groupPermissions'] = undefined;



  return exports;
}));

