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

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', process.cwd()+'/src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require(process.cwd()+'/src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.CloudGovernanceApi);
  }
}(this, function(expect, CloudGovernanceApi) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new CloudGovernanceApi.DeploymentManagerPlanSettings();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('DeploymentManagerPlanSettings', function() {
    it('should create an instance of DeploymentManagerPlanSettings', function() {
      // uncomment below and update the code to test DeploymentManagerPlanSettings
      //var instane = new CloudGovernanceApi.DeploymentManagerPlanSettings();
      //expect(instance).to.be.a(CloudGovernanceApi.DeploymentManagerPlanSettings);
    });

    it('should have the property enabled (base name: "enabled")', function() {
      // uncomment below and update the code to test the property enabled
      //var instane = new CloudGovernanceApi.DeploymentManagerPlanSettings();
      //expect(instance).to.be();
    });

    it('should have the property plans (base name: "plans")', function() {
      // uncomment below and update the code to test the property plans
      //var instane = new CloudGovernanceApi.DeploymentManagerPlanSettings();
      //expect(instance).to.be();
    });

    it('should have the property assignBy (base name: "assignBy")', function() {
      // uncomment below and update the code to test the property assignBy
      //var instane = new CloudGovernanceApi.DeploymentManagerPlanSettings();
      //expect(instance).to.be();
    });

    it('should have the property _default (base name: "default")', function() {
      // uncomment below and update the code to test the property _default
      //var instane = new CloudGovernanceApi.DeploymentManagerPlanSettings();
      //expect(instance).to.be();
    });

  });

}));