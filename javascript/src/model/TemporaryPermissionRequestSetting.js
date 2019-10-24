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
import ApiDurationType from './ApiDurationType';
import ExpirationType from './ExpirationType';

/**
 * The TemporaryPermissionRequestSetting model module.
 * @module model/TemporaryPermissionRequestSetting
 * @version 1.0
 */
class TemporaryPermissionRequestSetting {
    /**
     * Constructs a new <code>TemporaryPermissionRequestSetting</code>.
     * @alias module:model/TemporaryPermissionRequestSetting
     */
    constructor() { 
        
        TemporaryPermissionRequestSetting.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>TemporaryPermissionRequestSetting</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/TemporaryPermissionRequestSetting} obj Optional instance to populate.
     * @return {module:model/TemporaryPermissionRequestSetting} The populated <code>TemporaryPermissionRequestSetting</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new TemporaryPermissionRequestSetting();

            if (data.hasOwnProperty('isGrantTemporaryPermission')) {
                obj['isGrantTemporaryPermission'] = ApiClient.convertToType(data['isGrantTemporaryPermission'], 'Boolean');
            }
            if (data.hasOwnProperty('expirationType')) {
                obj['expirationType'] = ExpirationType.constructFromObject(data['expirationType']);
            }
            if (data.hasOwnProperty('durationInterval')) {
                obj['durationInterval'] = ApiClient.convertToType(data['durationInterval'], 'Number');
            }
            if (data.hasOwnProperty('durationDateType')) {
                obj['durationDateType'] = ApiDurationType.constructFromObject(data['durationDateType']);
            }
            if (data.hasOwnProperty('startTime')) {
                obj['startTime'] = ApiClient.convertToType(data['startTime'], 'Date');
            }
            if (data.hasOwnProperty('endTime')) {
                obj['endTime'] = ApiClient.convertToType(data['endTime'], 'Date');
            }
        }
        return obj;
    }


}

/**
 * @member {Boolean} isGrantTemporaryPermission
 */
TemporaryPermissionRequestSetting.prototype['isGrantTemporaryPermission'] = undefined;

/**
 * @member {module:model/ExpirationType} expirationType
 */
TemporaryPermissionRequestSetting.prototype['expirationType'] = undefined;

/**
 * @member {Number} durationInterval
 */
TemporaryPermissionRequestSetting.prototype['durationInterval'] = undefined;

/**
 * @member {module:model/ApiDurationType} durationDateType
 */
TemporaryPermissionRequestSetting.prototype['durationDateType'] = undefined;

/**
 * @member {Date} startTime
 */
TemporaryPermissionRequestSetting.prototype['startTime'] = undefined;

/**
 * @member {Date} endTime
 */
TemporaryPermissionRequestSetting.prototype['endTime'] = undefined;






export default TemporaryPermissionRequestSetting;
