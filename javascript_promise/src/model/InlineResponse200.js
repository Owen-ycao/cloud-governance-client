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
    define(['ApiClient', 'model/DynamicRuleElement'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./DynamicRuleElement'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.InlineResponse200 = factory(root.CgClient.ApiClient, root.CgClient.DynamicRuleElement);
  }
}(this, function(ApiClient, DynamicRuleElement) {
  'use strict';



  /**
   * The InlineResponse200 model module.
   * @module model/InlineResponse200
   * @version 1.0
   */

  /**
   * Constructs a new <code>InlineResponse200</code>.
   * @alias module:model/InlineResponse200
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>InlineResponse200</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/InlineResponse200} obj Optional instance to populate.
   * @return {module:model/InlineResponse200} The populated <code>InlineResponse200</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('Contact')) {
        obj['Contact'] = ApiClient.convertToType(data['Contact'], [DynamicRuleElement]);
      }
      if (data.hasOwnProperty('License')) {
        obj['License'] = ApiClient.convertToType(data['License'], [DynamicRuleElement]);
      }
      if (data.hasOwnProperty('Organization')) {
        obj['Organization'] = ApiClient.convertToType(data['Organization'], [DynamicRuleElement]);
      }
    }
    return obj;
  }

  /**
   * @member {Array.<module:model/DynamicRuleElement>} Contact
   */
  exports.prototype['Contact'] = undefined;
  /**
   * @member {Array.<module:model/DynamicRuleElement>} License
   */
  exports.prototype['License'] = undefined;
  /**
   * @member {Array.<module:model/DynamicRuleElement>} Organization
   */
  exports.prototype['Organization'] = undefined;



  return exports;
}));


