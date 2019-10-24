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
import ChangeWebSPObject from './ChangeWebSPObject';
import CustomMetadata from './CustomMetadata';

/**
 * The ChangeWebUrlValidateResult model module.
 * @module model/ChangeWebUrlValidateResult
 * @version 1.0
 */
class ChangeWebUrlValidateResult {
    /**
     * Constructs a new <code>ChangeWebUrlValidateResult</code>.
     * @alias module:model/ChangeWebUrlValidateResult
     */
    constructor() { 
        
        ChangeWebUrlValidateResult.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>ChangeWebUrlValidateResult</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/ChangeWebUrlValidateResult} obj Optional instance to populate.
     * @return {module:model/ChangeWebUrlValidateResult} The populated <code>ChangeWebUrlValidateResult</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new ChangeWebUrlValidateResult();

            if (data.hasOwnProperty('url')) {
                obj['url'] = ChangeWebSPObject.constructFromObject(data['url']);
            }
            if (data.hasOwnProperty('webTitle')) {
                obj['webTitle'] = ApiClient.convertToType(data['webTitle'], 'String');
            }
            if (data.hasOwnProperty('webDescription')) {
                obj['webDescription'] = ApiClient.convertToType(data['webDescription'], 'String');
            }
            if (data.hasOwnProperty('metadatas')) {
                obj['metadatas'] = ApiClient.convertToType(data['metadatas'], [CustomMetadata]);
            }
            if (data.hasOwnProperty('isValid')) {
                obj['isValid'] = ApiClient.convertToType(data['isValid'], 'Boolean');
            }
            if (data.hasOwnProperty('errorMessage')) {
                obj['errorMessage'] = ApiClient.convertToType(data['errorMessage'], 'String');
            }
        }
        return obj;
    }


}

/**
 * @member {module:model/ChangeWebSPObject} url
 */
ChangeWebUrlValidateResult.prototype['url'] = undefined;

/**
 * @member {String} webTitle
 */
ChangeWebUrlValidateResult.prototype['webTitle'] = undefined;

/**
 * @member {String} webDescription
 */
ChangeWebUrlValidateResult.prototype['webDescription'] = undefined;

/**
 * @member {Array.<module:model/CustomMetadata>} metadatas
 */
ChangeWebUrlValidateResult.prototype['metadatas'] = undefined;

/**
 * @member {Boolean} isValid
 */
ChangeWebUrlValidateResult.prototype['isValid'] = undefined;

/**
 * @member {String} errorMessage
 */
ChangeWebUrlValidateResult.prototype['errorMessage'] = undefined;






export default ChangeWebUrlValidateResult;
