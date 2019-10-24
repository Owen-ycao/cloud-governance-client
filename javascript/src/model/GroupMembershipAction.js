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
* Enum class GroupMembershipAction.
* @enum {}
* @readonly
*/
export default class GroupMembershipAction {
    
        /**
         * value: "None"
         * @const
         */
        "None" = "None";

    
        /**
         * value: "Added"
         * @const
         */
        "Added" = "Added";

    
        /**
         * value: "Deleted"
         * @const
         */
        "Deleted" = "Deleted";

    

    /**
    * Returns a <code>GroupMembershipAction</code> enum value from a Javascript object name.
    * @param {Object} data The plain JavaScript object containing the name of the enum value.
    * @return {module:model/GroupMembershipAction} The enum <code>GroupMembershipAction</code> value.
    */
    static constructFromObject(object) {
        return object;
    }
}
