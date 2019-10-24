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
 * The IntModel model module.
 * @module model/IntModel
 * @version 1.0
 */
class IntModel {
    /**
     * Constructs a new <code>IntModel</code>.
     * @alias module:model/IntModel
     */
    constructor() { 
        
        IntModel.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>IntModel</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/IntModel} obj Optional instance to populate.
     * @return {module:model/IntModel} The populated <code>IntModel</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new IntModel();

            if (data.hasOwnProperty('id')) {
                obj['id'] = ApiClient.convertToType(data['id'], 'Number');
            }
            if (data.hasOwnProperty('name')) {
                obj['name'] = ApiClient.convertToType(data['name'], 'String');
            }
            if (data.hasOwnProperty('description')) {
                obj['description'] = ApiClient.convertToType(data['description'], 'String');
            }
        }
        return obj;
    }


}

/**
 * @member {Number} id
 */
IntModel.prototype['id'] = undefined;

/**
 * @member {String} name
 */
IntModel.prototype['name'] = undefined;

/**
 * @member {String} description
 */
IntModel.prototype['description'] = undefined;






export default IntModel;
