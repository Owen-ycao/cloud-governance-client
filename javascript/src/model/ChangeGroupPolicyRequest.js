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
import GuidModel from './GuidModel';
import RequestMetadata from './RequestMetadata';
import RequestStatus from './RequestStatus';
import ServiceType from './ServiceType';

/**
 * The ChangeGroupPolicyRequest model module.
 * @module model/ChangeGroupPolicyRequest
 * @version 1.0
 */
class ChangeGroupPolicyRequest {
    /**
     * Constructs a new <code>ChangeGroupPolicyRequest</code>.
     * @alias module:model/ChangeGroupPolicyRequest
     */
    constructor() { 
        
        ChangeGroupPolicyRequest.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>ChangeGroupPolicyRequest</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/ChangeGroupPolicyRequest} obj Optional instance to populate.
     * @return {module:model/ChangeGroupPolicyRequest} The populated <code>ChangeGroupPolicyRequest</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new ChangeGroupPolicyRequest();

            if (data.hasOwnProperty('policy')) {
                obj['policy'] = GuidModel.constructFromObject(data['policy']);
            }
            if (data.hasOwnProperty('originalPolicy')) {
                obj['originalPolicy'] = GuidModel.constructFromObject(data['originalPolicy']);
            }
            if (data.hasOwnProperty('groupId')) {
                obj['groupId'] = ApiClient.convertToType(data['groupId'], 'String');
            }
            if (data.hasOwnProperty('groupName')) {
                obj['groupName'] = ApiClient.convertToType(data['groupName'], 'String');
            }
            if (data.hasOwnProperty('groupEmail')) {
                obj['groupEmail'] = ApiClient.convertToType(data['groupEmail'], 'String');
            }
            if (data.hasOwnProperty('id')) {
                obj['id'] = ApiClient.convertToType(data['id'], 'String');
            }
            if (data.hasOwnProperty('serviceId')) {
                obj['serviceId'] = ApiClient.convertToType(data['serviceId'], 'String');
            }
            if (data.hasOwnProperty('department')) {
                obj['department'] = ApiClient.convertToType(data['department'], 'String');
            }
            if (data.hasOwnProperty('summary')) {
                obj['summary'] = ApiClient.convertToType(data['summary'], 'String');
            }
            if (data.hasOwnProperty('notesToApprovers')) {
                obj['notesToApprovers'] = ApiClient.convertToType(data['notesToApprovers'], 'String');
            }
            if (data.hasOwnProperty('questionnaireId')) {
                obj['questionnaireId'] = ApiClient.convertToType(data['questionnaireId'], 'String');
            }
            if (data.hasOwnProperty('metadatas')) {
                obj['metadatas'] = ApiClient.convertToType(data['metadatas'], [RequestMetadata]);
            }
            if (data.hasOwnProperty('ticketNumber')) {
                obj['ticketNumber'] = ApiClient.convertToType(data['ticketNumber'], 'Number');
            }
            if (data.hasOwnProperty('type')) {
                obj['type'] = ServiceType.constructFromObject(data['type']);
            }
            if (data.hasOwnProperty('typeDescription')) {
                obj['typeDescription'] = ApiClient.convertToType(data['typeDescription'], 'String');
            }
            if (data.hasOwnProperty('requester')) {
                obj['requester'] = ApiClient.convertToType(data['requester'], 'String');
            }
            if (data.hasOwnProperty('status')) {
                obj['status'] = RequestStatus.constructFromObject(data['status']);
            }
            if (data.hasOwnProperty('progressStatus')) {
                obj['progressStatus'] = ApiClient.convertToType(data['progressStatus'], 'Number');
            }
            if (data.hasOwnProperty('progressStatusDescription')) {
                obj['progressStatusDescription'] = ApiClient.convertToType(data['progressStatusDescription'], 'String');
            }
            if (data.hasOwnProperty('submittedTime')) {
                obj['submittedTime'] = ApiClient.convertToType(data['submittedTime'], 'Date');
            }
            if (data.hasOwnProperty('lastUpdated')) {
                obj['lastUpdated'] = ApiClient.convertToType(data['lastUpdated'], 'Date');
            }
            if (data.hasOwnProperty('createdTime')) {
                obj['createdTime'] = ApiClient.convertToType(data['createdTime'], 'Date');
            }
            if (data.hasOwnProperty('assignTo')) {
                obj['assignTo'] = ApiClient.convertToType(data['assignTo'], 'String');
            }
            if (data.hasOwnProperty('fullPath')) {
                obj['fullPath'] = ApiClient.convertToType(data['fullPath'], 'String');
            }
        }
        return obj;
    }


}

/**
 * @member {module:model/GuidModel} policy
 */
ChangeGroupPolicyRequest.prototype['policy'] = undefined;

/**
 * @member {module:model/GuidModel} originalPolicy
 */
ChangeGroupPolicyRequest.prototype['originalPolicy'] = undefined;

/**
 * @member {String} groupId
 */
ChangeGroupPolicyRequest.prototype['groupId'] = undefined;

/**
 * @member {String} groupName
 */
ChangeGroupPolicyRequest.prototype['groupName'] = undefined;

/**
 * @member {String} groupEmail
 */
ChangeGroupPolicyRequest.prototype['groupEmail'] = undefined;

/**
 * @member {String} id
 */
ChangeGroupPolicyRequest.prototype['id'] = undefined;

/**
 * @member {String} serviceId
 */
ChangeGroupPolicyRequest.prototype['serviceId'] = undefined;

/**
 * @member {String} department
 */
ChangeGroupPolicyRequest.prototype['department'] = undefined;

/**
 * @member {String} summary
 */
ChangeGroupPolicyRequest.prototype['summary'] = undefined;

/**
 * @member {String} notesToApprovers
 */
ChangeGroupPolicyRequest.prototype['notesToApprovers'] = undefined;

/**
 * @member {String} questionnaireId
 */
ChangeGroupPolicyRequest.prototype['questionnaireId'] = undefined;

/**
 * @member {Array.<module:model/RequestMetadata>} metadatas
 */
ChangeGroupPolicyRequest.prototype['metadatas'] = undefined;

/**
 * @member {Number} ticketNumber
 */
ChangeGroupPolicyRequest.prototype['ticketNumber'] = undefined;

/**
 * @member {module:model/ServiceType} type
 */
ChangeGroupPolicyRequest.prototype['type'] = undefined;

/**
 * @member {String} typeDescription
 */
ChangeGroupPolicyRequest.prototype['typeDescription'] = undefined;

/**
 * @member {String} requester
 */
ChangeGroupPolicyRequest.prototype['requester'] = undefined;

/**
 * @member {module:model/RequestStatus} status
 */
ChangeGroupPolicyRequest.prototype['status'] = undefined;

/**
 * @member {Number} progressStatus
 */
ChangeGroupPolicyRequest.prototype['progressStatus'] = undefined;

/**
 * @member {String} progressStatusDescription
 */
ChangeGroupPolicyRequest.prototype['progressStatusDescription'] = undefined;

/**
 * @member {Date} submittedTime
 */
ChangeGroupPolicyRequest.prototype['submittedTime'] = undefined;

/**
 * @member {Date} lastUpdated
 */
ChangeGroupPolicyRequest.prototype['lastUpdated'] = undefined;

/**
 * @member {Date} createdTime
 */
ChangeGroupPolicyRequest.prototype['createdTime'] = undefined;

/**
 * @member {String} assignTo
 */
ChangeGroupPolicyRequest.prototype['assignTo'] = undefined;

/**
 * @member {String} fullPath
 */
ChangeGroupPolicyRequest.prototype['fullPath'] = undefined;






export default ChangeGroupPolicyRequest;
