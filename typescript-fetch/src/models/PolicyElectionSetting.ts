// tslint:disable
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
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface PolicyElectionSetting
 */
export interface PolicyElectionSetting {
    /**
     * 
     * @type {boolean}
     * @memberof PolicyElectionSetting
     */
    isEnabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof PolicyElectionSetting
     */
    excludeUsers?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof PolicyElectionSetting
     */
    isNotifyTaskEnabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof PolicyElectionSetting
     */
    taskEmailTemplate?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof PolicyElectionSetting
     */
    isNotifyPrimaryContactEnabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof PolicyElectionSetting
     */
    notifyPrimaryContactTemplate?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof PolicyElectionSetting
     */
    isNotifySecondaryContactEnabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof PolicyElectionSetting
     */
    notifySecondaryContactTemplate?: string | null;
    /**
     * 
     * @type {number}
     * @memberof PolicyElectionSetting
     */
    duration?: number;
    /**
     * 
     * @type {number}
     * @memberof PolicyElectionSetting
     */
    durationType?: number;
    /**
     * 
     * @type {boolean}
     * @memberof PolicyElectionSetting
     */
    isReminderEnabled?: boolean;
    /**
     * 
     * @type {string}
     * @memberof PolicyElectionSetting
     */
    reminderProfileId?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof PolicyElectionSetting
     */
    enableOnlyOtherContactElection?: boolean;
}

export function PolicyElectionSettingFromJSON(json: any): PolicyElectionSetting {
    return PolicyElectionSettingFromJSONTyped(json, false);
}

export function PolicyElectionSettingFromJSONTyped(json: any, ignoreDiscriminator: boolean): PolicyElectionSetting {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'isEnabled': !exists(json, 'isEnabled') ? undefined : json['isEnabled'],
        'excludeUsers': !exists(json, 'excludeUsers') ? undefined : json['excludeUsers'],
        'isNotifyTaskEnabled': !exists(json, 'isNotifyTaskEnabled') ? undefined : json['isNotifyTaskEnabled'],
        'taskEmailTemplate': !exists(json, 'taskEmailTemplate') ? undefined : json['taskEmailTemplate'],
        'isNotifyPrimaryContactEnabled': !exists(json, 'isNotifyPrimaryContactEnabled') ? undefined : json['isNotifyPrimaryContactEnabled'],
        'notifyPrimaryContactTemplate': !exists(json, 'notifyPrimaryContactTemplate') ? undefined : json['notifyPrimaryContactTemplate'],
        'isNotifySecondaryContactEnabled': !exists(json, 'isNotifySecondaryContactEnabled') ? undefined : json['isNotifySecondaryContactEnabled'],
        'notifySecondaryContactTemplate': !exists(json, 'notifySecondaryContactTemplate') ? undefined : json['notifySecondaryContactTemplate'],
        'duration': !exists(json, 'duration') ? undefined : json['duration'],
        'durationType': !exists(json, 'durationType') ? undefined : json['durationType'],
        'isReminderEnabled': !exists(json, 'isReminderEnabled') ? undefined : json['isReminderEnabled'],
        'reminderProfileId': !exists(json, 'reminderProfileId') ? undefined : json['reminderProfileId'],
        'enableOnlyOtherContactElection': !exists(json, 'enableOnlyOtherContactElection') ? undefined : json['enableOnlyOtherContactElection'],
    };
}

export function PolicyElectionSettingToJSON(value?: PolicyElectionSetting | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'isEnabled': value.isEnabled,
        'excludeUsers': value.excludeUsers,
        'isNotifyTaskEnabled': value.isNotifyTaskEnabled,
        'taskEmailTemplate': value.taskEmailTemplate,
        'isNotifyPrimaryContactEnabled': value.isNotifyPrimaryContactEnabled,
        'notifyPrimaryContactTemplate': value.notifyPrimaryContactTemplate,
        'isNotifySecondaryContactEnabled': value.isNotifySecondaryContactEnabled,
        'notifySecondaryContactTemplate': value.notifySecondaryContactTemplate,
        'duration': value.duration,
        'durationType': value.durationType,
        'isReminderEnabled': value.isReminderEnabled,
        'reminderProfileId': value.reminderProfileId,
        'enableOnlyOtherContactElection': value.enableOnlyOtherContactElection,
    };
}

