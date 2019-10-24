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

/**
 * The UnlockSiteSetting model module.
 * @module model/UnlockSiteSetting
 * @version 1.0
 */
class UnlockSiteSetting {
    /**
     * Constructs a new <code>UnlockSiteSetting</code>.
     * @alias module:model/UnlockSiteSetting
     */
    constructor() { 
        
        UnlockSiteSetting.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>UnlockSiteSetting</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/UnlockSiteSetting} obj Optional instance to populate.
     * @return {module:model/UnlockSiteSetting} The populated <code>UnlockSiteSetting</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new UnlockSiteSetting();

            if (data.hasOwnProperty('isExpired')) {
                obj['isExpired'] = ApiClient.convertToType(data['isExpired'], 'Boolean');
            }
            if (data.hasOwnProperty('isExtendEnabled')) {
                obj['isExtendEnabled'] = ApiClient.convertToType(data['isExtendEnabled'], 'Boolean');
            }
        }
        return obj;
    }


}

/**
 * @member {Boolean} isExpired
 */
UnlockSiteSetting.prototype['isExpired'] = undefined;

/**
 * @member {Boolean} isExtendEnabled
 */
UnlockSiteSetting.prototype['isExtendEnabled'] = undefined;






export default UnlockSiteSetting;
