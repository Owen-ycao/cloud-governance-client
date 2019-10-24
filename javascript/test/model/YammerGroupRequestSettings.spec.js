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
    instance = new CloudGovernanceApi.YammerGroupRequestSettings();
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

  describe('YammerGroupRequestSettings', function() {
    it('should create an instance of YammerGroupRequestSettings', function() {
      // uncomment below and update the code to test YammerGroupRequestSettings
      //var instane = new CloudGovernanceApi.YammerGroupRequestSettings();
      //expect(instance).to.be.a(CloudGovernanceApi.YammerGroupRequestSettings);
    });

    it('should have the property nameOrId (base name: "nameOrId")', function() {
      // uncomment below and update the code to test the property nameOrId
      //var instane = new CloudGovernanceApi.YammerGroupRequestSettings();
      //expect(instance).to.be();
    });

    it('should have the property description (base name: "description")', function() {
      // uncomment below and update the code to test the property description
      //var instane = new CloudGovernanceApi.YammerGroupRequestSettings();
      //expect(instance).to.be();
    });

    it('should have the property type (base name: "type")', function() {
      // uncomment below and update the code to test the property type
      //var instane = new CloudGovernanceApi.YammerGroupRequestSettings();
      //expect(instance).to.be();
    });

    it('should have the property joinType (base name: "joinType")', function() {
      // uncomment below and update the code to test the property joinType
      //var instane = new CloudGovernanceApi.YammerGroupRequestSettings();
      //expect(instance).to.be();
    });

    it('should have the property isListInDirectory (base name: "isListInDirectory")', function() {
      // uncomment below and update the code to test the property isListInDirectory
      //var instane = new CloudGovernanceApi.YammerGroupRequestSettings();
      //expect(instance).to.be();
    });

    it('should have the property isGroupAlreadyExisted (base name: "isGroupAlreadyExisted")', function() {
      // uncomment below and update the code to test the property isGroupAlreadyExisted
      //var instane = new CloudGovernanceApi.YammerGroupRequestSettings();
      //expect(instance).to.be();
    });

  });

}));