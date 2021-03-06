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
    define(['ApiClient', 'model/GiphyRatingType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./GiphyRatingType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.RequestTeamsSettings = factory(root.CgClient.ApiClient, root.CgClient.GiphyRatingType);
  }
}(this, function(ApiClient, GiphyRatingType) {
  'use strict';



  /**
   * The RequestTeamsSettings model module.
   * @module model/RequestTeamsSettings
   * @version 1.0
   */

  /**
   * Constructs a new <code>RequestTeamsSettings</code>.
   * @alias module:model/RequestTeamsSettings
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>RequestTeamsSettings</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RequestTeamsSettings} obj Optional instance to populate.
   * @return {module:model/RequestTeamsSettings} The populated <code>RequestTeamsSettings</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('allowMembersCreateUpdateChannels')) {
        obj['allowMembersCreateUpdateChannels'] = ApiClient.convertToType(data['allowMembersCreateUpdateChannels'], 'Boolean');
      }
      if (data.hasOwnProperty('allowMembersCreatePrivateChannels')) {
        obj['allowMembersCreatePrivateChannels'] = ApiClient.convertToType(data['allowMembersCreatePrivateChannels'], 'Boolean');
      }
      if (data.hasOwnProperty('allowMemberDeleteRestoreChannels')) {
        obj['allowMemberDeleteRestoreChannels'] = ApiClient.convertToType(data['allowMemberDeleteRestoreChannels'], 'Boolean');
      }
      if (data.hasOwnProperty('allowMembersAddRemoveApps')) {
        obj['allowMembersAddRemoveApps'] = ApiClient.convertToType(data['allowMembersAddRemoveApps'], 'Boolean');
      }
      if (data.hasOwnProperty('allowMembersCreateUpdateRemoveTabs')) {
        obj['allowMembersCreateUpdateRemoveTabs'] = ApiClient.convertToType(data['allowMembersCreateUpdateRemoveTabs'], 'Boolean');
      }
      if (data.hasOwnProperty('allowMembersCreateUpdateRemoveConnections')) {
        obj['allowMembersCreateUpdateRemoveConnections'] = ApiClient.convertToType(data['allowMembersCreateUpdateRemoveConnections'], 'Boolean');
      }
      if (data.hasOwnProperty('allowMembersDeleteMessages')) {
        obj['allowMembersDeleteMessages'] = ApiClient.convertToType(data['allowMembersDeleteMessages'], 'Boolean');
      }
      if (data.hasOwnProperty('allowMembersEditMessages')) {
        obj['allowMembersEditMessages'] = ApiClient.convertToType(data['allowMembersEditMessages'], 'Boolean');
      }
      if (data.hasOwnProperty('allowGuestsCreateUpdateChannels')) {
        obj['allowGuestsCreateUpdateChannels'] = ApiClient.convertToType(data['allowGuestsCreateUpdateChannels'], 'Boolean');
      }
      if (data.hasOwnProperty('allowGuestsDeleteChannels')) {
        obj['allowGuestsDeleteChannels'] = ApiClient.convertToType(data['allowGuestsDeleteChannels'], 'Boolean');
      }
      if (data.hasOwnProperty('allowMentionsTeam')) {
        obj['allowMentionsTeam'] = ApiClient.convertToType(data['allowMentionsTeam'], 'Boolean');
      }
      if (data.hasOwnProperty('allowMentionsChannel')) {
        obj['allowMentionsChannel'] = ApiClient.convertToType(data['allowMentionsChannel'], 'Boolean');
      }
      if (data.hasOwnProperty('enableGiphy')) {
        obj['enableGiphy'] = ApiClient.convertToType(data['enableGiphy'], 'Boolean');
      }
      if (data.hasOwnProperty('enableStickersAndMemes')) {
        obj['enableStickersAndMemes'] = ApiClient.convertToType(data['enableStickersAndMemes'], 'Boolean');
      }
      if (data.hasOwnProperty('enableCustomMemes')) {
        obj['enableCustomMemes'] = ApiClient.convertToType(data['enableCustomMemes'], 'Boolean');
      }
      if (data.hasOwnProperty('giphyRatingType')) {
        obj['giphyRatingType'] = GiphyRatingType.constructFromObject(data['giphyRatingType']);
      }
    }
    return obj;
  }

  /**
   * @member {Boolean} allowMembersCreateUpdateChannels
   */
  exports.prototype['allowMembersCreateUpdateChannels'] = undefined;
  /**
   * @member {Boolean} allowMembersCreatePrivateChannels
   */
  exports.prototype['allowMembersCreatePrivateChannels'] = undefined;
  /**
   * @member {Boolean} allowMemberDeleteRestoreChannels
   */
  exports.prototype['allowMemberDeleteRestoreChannels'] = undefined;
  /**
   * @member {Boolean} allowMembersAddRemoveApps
   */
  exports.prototype['allowMembersAddRemoveApps'] = undefined;
  /**
   * @member {Boolean} allowMembersCreateUpdateRemoveTabs
   */
  exports.prototype['allowMembersCreateUpdateRemoveTabs'] = undefined;
  /**
   * @member {Boolean} allowMembersCreateUpdateRemoveConnections
   */
  exports.prototype['allowMembersCreateUpdateRemoveConnections'] = undefined;
  /**
   * @member {Boolean} allowMembersDeleteMessages
   */
  exports.prototype['allowMembersDeleteMessages'] = undefined;
  /**
   * @member {Boolean} allowMembersEditMessages
   */
  exports.prototype['allowMembersEditMessages'] = undefined;
  /**
   * @member {Boolean} allowGuestsCreateUpdateChannels
   */
  exports.prototype['allowGuestsCreateUpdateChannels'] = undefined;
  /**
   * @member {Boolean} allowGuestsDeleteChannels
   */
  exports.prototype['allowGuestsDeleteChannels'] = undefined;
  /**
   * @member {Boolean} allowMentionsTeam
   */
  exports.prototype['allowMentionsTeam'] = undefined;
  /**
   * @member {Boolean} allowMentionsChannel
   */
  exports.prototype['allowMentionsChannel'] = undefined;
  /**
   * @member {Boolean} enableGiphy
   */
  exports.prototype['enableGiphy'] = undefined;
  /**
   * @member {Boolean} enableStickersAndMemes
   */
  exports.prototype['enableStickersAndMemes'] = undefined;
  /**
   * @member {Boolean} enableCustomMemes
   */
  exports.prototype['enableCustomMemes'] = undefined;
  /**
   * @member {module:model/GiphyRatingType} giphyRatingType
   */
  exports.prototype['giphyRatingType'] = undefined;



  return exports;
}));


