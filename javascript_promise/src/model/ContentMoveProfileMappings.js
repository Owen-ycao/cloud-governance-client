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
    define(['ApiClient', 'model/GuidModel'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./GuidModel'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.ContentMoveProfileMappings = factory(root.CgClient.ApiClient, root.CgClient.GuidModel);
  }
}(this, function(ApiClient, GuidModel) {
  'use strict';



  /**
   * The ContentMoveProfileMappings model module.
   * @module model/ContentMoveProfileMappings
   * @version 1.0
   */

  /**
   * Constructs a new <code>ContentMoveProfileMappings</code>.
   * @alias module:model/ContentMoveProfileMappings
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>ContentMoveProfileMappings</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ContentMoveProfileMappings} obj Optional instance to populate.
   * @return {module:model/ContentMoveProfileMappings} The populated <code>ContentMoveProfileMappings</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('columnMapping')) {
        obj['columnMapping'] = GuidModel.constructFromObject(data['columnMapping']);
      }
      if (data.hasOwnProperty('contentTypeMapping')) {
        obj['contentTypeMapping'] = GuidModel.constructFromObject(data['contentTypeMapping']);
      }
      if (data.hasOwnProperty('userMapping')) {
        obj['userMapping'] = GuidModel.constructFromObject(data['userMapping']);
      }
      if (data.hasOwnProperty('languageMapping')) {
        obj['languageMapping'] = GuidModel.constructFromObject(data['languageMapping']);
      }
    }
    return obj;
  }

  /**
   * @member {module:model/GuidModel} columnMapping
   */
  exports.prototype['columnMapping'] = undefined;
  /**
   * @member {module:model/GuidModel} contentTypeMapping
   */
  exports.prototype['contentTypeMapping'] = undefined;
  /**
   * @member {module:model/GuidModel} userMapping
   */
  exports.prototype['userMapping'] = undefined;
  /**
   * @member {module:model/GuidModel} languageMapping
   */
  exports.prototype['languageMapping'] = undefined;



  return exports;
}));


