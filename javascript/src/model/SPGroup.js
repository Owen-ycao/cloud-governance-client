/**
 * Cloud Governance Api
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';
import ApiUser from './ApiUser';
import SPGroupEditOption from './SPGroupEditOption';
import SPGroupViewOption from './SPGroupViewOption';
import SPPrincipal from './SPPrincipal';

/**
 * The SPGroup model module.
 * @module model/SPGroup
 * @version 1.0
 */
class SPGroup {
    /**
     * Constructs a new <code>SPGroup</code>.
     * @alias module:model/SPGroup
     */
    constructor() { 
        
        SPGroup.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>SPGroup</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/SPGroup} obj Optional instance to populate.
     * @return {module:model/SPGroup} The populated <code>SPGroup</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new SPGroup();

            if (data.hasOwnProperty('id')) {
                obj['id'] = ApiClient.convertToType(data['id'], 'Number');
            }
            if (data.hasOwnProperty('name')) {
                obj['name'] = ApiClient.convertToType(data['name'], 'String');
            }
            if (data.hasOwnProperty('description')) {
                obj['description'] = ApiClient.convertToType(data['description'], 'String');
            }
            if (data.hasOwnProperty('owner')) {
                obj['owner'] = SPPrincipal.constructFromObject(data['owner']);
            }
            if (data.hasOwnProperty('members')) {
                obj['members'] = ApiClient.convertToType(data['members'], [ApiUser]);
            }
            if (data.hasOwnProperty('permissionLevels')) {
                obj['permissionLevels'] = ApiClient.convertToType(data['permissionLevels'], ['String']);
            }
            if (data.hasOwnProperty('spGroupViewType')) {
                obj['spGroupViewType'] = SPGroupViewOption.constructFromObject(data['spGroupViewType']);
            }
            if (data.hasOwnProperty('spGroupEditType')) {
                obj['spGroupEditType'] = SPGroupEditOption.constructFromObject(data['spGroupEditType']);
            }
            if (data.hasOwnProperty('isAllowJoinOrLeaveRequest')) {
                obj['isAllowJoinOrLeaveRequest'] = ApiClient.convertToType(data['isAllowJoinOrLeaveRequest'], 'Boolean');
            }
            if (data.hasOwnProperty('autoAcceptRequestToJoinLeave')) {
                obj['autoAcceptRequestToJoinLeave'] = ApiClient.convertToType(data['autoAcceptRequestToJoinLeave'], 'Boolean');
            }
            if (data.hasOwnProperty('requestToJoinLeaveEmailSetting')) {
                obj['requestToJoinLeaveEmailSetting'] = ApiClient.convertToType(data['requestToJoinLeaveEmailSetting'], 'String');
            }
            if (data.hasOwnProperty('isTemporaryGroup')) {
                obj['isTemporaryGroup'] = ApiClient.convertToType(data['isTemporaryGroup'], 'Boolean');
            }
        }
        return obj;
    }


}

/**
 * @member {Number} id
 */
SPGroup.prototype['id'] = undefined;

/**
 * @member {String} name
 */
SPGroup.prototype['name'] = undefined;

/**
 * @member {String} description
 */
SPGroup.prototype['description'] = undefined;

/**
 * @member {module:model/SPPrincipal} owner
 */
SPGroup.prototype['owner'] = undefined;

/**
 * @member {Array.<module:model/ApiUser>} members
 */
SPGroup.prototype['members'] = undefined;

/**
 * @member {Array.<String>} permissionLevels
 */
SPGroup.prototype['permissionLevels'] = undefined;

/**
 * @member {module:model/SPGroupViewOption} spGroupViewType
 */
SPGroup.prototype['spGroupViewType'] = undefined;

/**
 * @member {module:model/SPGroupEditOption} spGroupEditType
 */
SPGroup.prototype['spGroupEditType'] = undefined;

/**
 * @member {Boolean} isAllowJoinOrLeaveRequest
 */
SPGroup.prototype['isAllowJoinOrLeaveRequest'] = undefined;

/**
 * @member {Boolean} autoAcceptRequestToJoinLeave
 */
SPGroup.prototype['autoAcceptRequestToJoinLeave'] = undefined;

/**
 * @member {String} requestToJoinLeaveEmailSetting
 */
SPGroup.prototype['requestToJoinLeaveEmailSetting'] = undefined;

/**
 * @member {Boolean} isTemporaryGroup
 */
SPGroup.prototype['isTemporaryGroup'] = undefined;






export default SPGroup;
