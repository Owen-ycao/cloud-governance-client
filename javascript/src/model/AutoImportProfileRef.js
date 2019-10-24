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
import CustomMetadata from './CustomMetadata';
import PolicyRef from './PolicyRef';

/**
 * The AutoImportProfileRef model module.
 * @module model/AutoImportProfileRef
 * @version 1.0
 */
class AutoImportProfileRef {
    /**
     * Constructs a new <code>AutoImportProfileRef</code>.
     * @alias module:model/AutoImportProfileRef
     */
    constructor() { 
        
        AutoImportProfileRef.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>AutoImportProfileRef</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/AutoImportProfileRef} obj Optional instance to populate.
     * @return {module:model/AutoImportProfileRef} The populated <code>AutoImportProfileRef</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new AutoImportProfileRef();

            if (data.hasOwnProperty('id')) {
                obj['id'] = ApiClient.convertToType(data['id'], 'String');
            }
            if (data.hasOwnProperty('objectName')) {
                obj['objectName'] = ApiClient.convertToType(data['objectName'], 'String');
            }
            if (data.hasOwnProperty('notesToPrimaryContact')) {
                obj['notesToPrimaryContact'] = ApiClient.convertToType(data['notesToPrimaryContact'], 'String');
            }
            if (data.hasOwnProperty('name')) {
                obj['name'] = ApiClient.convertToType(data['name'], 'String');
            }
            if (data.hasOwnProperty('description')) {
                obj['description'] = ApiClient.convertToType(data['description'], 'String');
            }
            if (data.hasOwnProperty('defaultSecondaryContact')) {
                obj['defaultSecondaryContact'] = ApiUser.constructFromObject(data['defaultSecondaryContact']);
            }
            if (data.hasOwnProperty('defaultPolicyId')) {
                obj['defaultPolicyId'] = ApiClient.convertToType(data['defaultPolicyId'], 'String');
            }
            if (data.hasOwnProperty('departments')) {
                obj['departments'] = ApiClient.convertToType(data['departments'], ['String']);
            }
            if (data.hasOwnProperty('policies')) {
                obj['policies'] = ApiClient.convertToType(data['policies'], [PolicyRef]);
            }
            if (data.hasOwnProperty('loadDepartmentFromUps')) {
                obj['loadDepartmentFromUps'] = ApiClient.convertToType(data['loadDepartmentFromUps'], 'Boolean');
            }
            if (data.hasOwnProperty('isLastStep')) {
                obj['isLastStep'] = ApiClient.convertToType(data['isLastStep'], 'Boolean');
            }
            if (data.hasOwnProperty('metadatas')) {
                obj['metadatas'] = ApiClient.convertToType(data['metadatas'], [CustomMetadata]);
            }
        }
        return obj;
    }


}

/**
 * @member {String} id
 */
AutoImportProfileRef.prototype['id'] = undefined;

/**
 * @member {String} objectName
 */
AutoImportProfileRef.prototype['objectName'] = undefined;

/**
 * @member {String} notesToPrimaryContact
 */
AutoImportProfileRef.prototype['notesToPrimaryContact'] = undefined;

/**
 * @member {String} name
 */
AutoImportProfileRef.prototype['name'] = undefined;

/**
 * @member {String} description
 */
AutoImportProfileRef.prototype['description'] = undefined;

/**
 * @member {module:model/ApiUser} defaultSecondaryContact
 */
AutoImportProfileRef.prototype['defaultSecondaryContact'] = undefined;

/**
 * @member {String} defaultPolicyId
 */
AutoImportProfileRef.prototype['defaultPolicyId'] = undefined;

/**
 * @member {Array.<String>} departments
 */
AutoImportProfileRef.prototype['departments'] = undefined;

/**
 * @member {Array.<module:model/PolicyRef>} policies
 */
AutoImportProfileRef.prototype['policies'] = undefined;

/**
 * @member {Boolean} loadDepartmentFromUps
 */
AutoImportProfileRef.prototype['loadDepartmentFromUps'] = undefined;

/**
 * @member {Boolean} isLastStep
 */
AutoImportProfileRef.prototype['isLastStep'] = undefined;

/**
 * @member {Array.<module:model/CustomMetadata>} metadatas
 */
AutoImportProfileRef.prototype['metadatas'] = undefined;






export default AutoImportProfileRef;
