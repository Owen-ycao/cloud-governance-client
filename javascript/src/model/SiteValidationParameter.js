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
 * The SiteValidationParameter model module.
 * @module model/SiteValidationParameter
 * @version 1.0
 */
class SiteValidationParameter {
    /**
     * Constructs a new <code>SiteValidationParameter</code>.
     * @alias module:model/SiteValidationParameter
     */
    constructor() { 
        
        SiteValidationParameter.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>SiteValidationParameter</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/SiteValidationParameter} obj Optional instance to populate.
     * @return {module:model/SiteValidationParameter} The populated <code>SiteValidationParameter</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new SiteValidationParameter();

            if (data.hasOwnProperty('uri')) {
                obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
            }
            if (data.hasOwnProperty('ignoreLock')) {
                obj['ignoreLock'] = ApiClient.convertToType(data['ignoreLock'], 'Boolean');
            }
            if (data.hasOwnProperty('isEditTask')) {
                obj['isEditTask'] = ApiClient.convertToType(data['isEditTask'], 'Boolean');
            }
            if (data.hasOwnProperty('isFromQuestionnaire')) {
                obj['isFromQuestionnaire'] = ApiClient.convertToType(data['isFromQuestionnaire'], 'Boolean');
            }
        }
        return obj;
    }


}

/**
 * @member {String} uri
 */
SiteValidationParameter.prototype['uri'] = undefined;

/**
 * @member {Boolean} ignoreLock
 */
SiteValidationParameter.prototype['ignoreLock'] = undefined;

/**
 * @member {Boolean} isEditTask
 */
SiteValidationParameter.prototype['isEditTask'] = undefined;

/**
 * @member {Boolean} isFromQuestionnaire
 */
SiteValidationParameter.prototype['isFromQuestionnaire'] = undefined;






export default SiteValidationParameter;
