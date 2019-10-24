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
* Enum class SiteLifecycleActionType.
* @enum {}
* @readonly
*/
export default class SiteLifecycleActionType {
    
        /**
         * value: "None"
         * @const
         */
        "None" = "None";

    
        /**
         * value: "Extend"
         * @const
         */
        "Extend" = "Extend";

    
        /**
         * value: "Delete"
         * @const
         */
        "Delete" = "Delete";

    
        /**
         * value: "Archive"
         * @const
         */
        "Archive" = "Archive";

    
        /**
         * value: "ChangePolicy"
         * @const
         */
        "ChangePolicy" = "ChangePolicy";

    
        /**
         * value: "Unlock"
         * @const
         */
        "Unlock" = "Unlock";

    
        /**
         * value: "Lock"
         * @const
         */
        "Lock" = "Lock";

    
        /**
         * value: "ChangeQuota"
         * @const
         */
        "ChangeQuota" = "ChangeQuota";

    

    /**
    * Returns a <code>SiteLifecycleActionType</code> enum value from a Javascript object name.
    * @param {Object} data The plain JavaScript object containing the name of the enum value.
    * @return {module:model/SiteLifecycleActionType} The enum <code>SiteLifecycleActionType</code> value.
    */
    static constructFromObject(object) {
        return object;
    }
}
