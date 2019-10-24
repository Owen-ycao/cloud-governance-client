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
* Enum class RecertificationStatus.
* @enum {}
* @readonly
*/
export default class RecertificationStatus {
    
        /**
         * value: "None"
         * @const
         */
        "None" = "None";

    
        /**
         * value: "InProgress"
         * @const
         */
        "InProgress" = "InProgress";

    
        /**
         * value: "Overdue"
         * @const
         */
        "Overdue" = "Overdue";

    
        /**
         * value: "Completed"
         * @const
         */
        "Completed" = "Completed";

    
        /**
         * value: "Exception"
         * @const
         */
        "Exception" = "Exception";

    
        /**
         * value: "Rejected"
         * @const
         */
        "Rejected" = "Rejected";

    

    /**
    * Returns a <code>RecertificationStatus</code> enum value from a Javascript object name.
    * @param {Object} data The plain JavaScript object containing the name of the enum value.
    * @return {module:model/RecertificationStatus} The enum <code>RecertificationStatus</code> value.
    */
    static constructFromObject(object) {
        return object;
    }
}
