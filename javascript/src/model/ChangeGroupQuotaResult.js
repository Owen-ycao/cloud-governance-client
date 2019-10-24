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
 * The ChangeGroupQuotaResult model module.
 * @module model/ChangeGroupQuotaResult
 * @version 1.0
 */
class ChangeGroupQuotaResult {
    /**
     * Constructs a new <code>ChangeGroupQuotaResult</code>.
     * @alias module:model/ChangeGroupQuotaResult
     */
    constructor() { 
        
        ChangeGroupQuotaResult.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>ChangeGroupQuotaResult</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/ChangeGroupQuotaResult} obj Optional instance to populate.
     * @return {module:model/ChangeGroupQuotaResult} The populated <code>ChangeGroupQuotaResult</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new ChangeGroupQuotaResult();

            if (data.hasOwnProperty('allowedAnySize')) {
                obj['allowedAnySize'] = ApiClient.convertToType(data['allowedAnySize'], 'Boolean');
            }
            if (data.hasOwnProperty('minQuotaSize')) {
                obj['minQuotaSize'] = ApiClient.convertToType(data['minQuotaSize'], 'Number');
            }
            if (data.hasOwnProperty('maxQuotaSize')) {
                obj['maxQuotaSize'] = ApiClient.convertToType(data['maxQuotaSize'], 'Number');
            }
            if (data.hasOwnProperty('currentQuotaSize')) {
                obj['currentQuotaSize'] = ApiClient.convertToType(data['currentQuotaSize'], 'Number');
            }
        }
        return obj;
    }


}

/**
 * @member {Boolean} allowedAnySize
 */
ChangeGroupQuotaResult.prototype['allowedAnySize'] = undefined;

/**
 * @member {Number} minQuotaSize
 */
ChangeGroupQuotaResult.prototype['minQuotaSize'] = undefined;

/**
 * @member {Number} maxQuotaSize
 */
ChangeGroupQuotaResult.prototype['maxQuotaSize'] = undefined;

/**
 * @member {Number} currentQuotaSize
 */
ChangeGroupQuotaResult.prototype['currentQuotaSize'] = undefined;






export default ChangeGroupQuotaResult;
