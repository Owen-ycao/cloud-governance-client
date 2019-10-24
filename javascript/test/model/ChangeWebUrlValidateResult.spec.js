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
    instance = new CloudGovernanceApi.ChangeWebUrlValidateResult();
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

  describe('ChangeWebUrlValidateResult', function() {
    it('should create an instance of ChangeWebUrlValidateResult', function() {
      // uncomment below and update the code to test ChangeWebUrlValidateResult
      //var instane = new CloudGovernanceApi.ChangeWebUrlValidateResult();
      //expect(instance).to.be.a(CloudGovernanceApi.ChangeWebUrlValidateResult);
    });

    it('should have the property url (base name: "url")', function() {
      // uncomment below and update the code to test the property url
      //var instane = new CloudGovernanceApi.ChangeWebUrlValidateResult();
      //expect(instance).to.be();
    });

    it('should have the property webTitle (base name: "webTitle")', function() {
      // uncomment below and update the code to test the property webTitle
      //var instane = new CloudGovernanceApi.ChangeWebUrlValidateResult();
      //expect(instance).to.be();
    });

    it('should have the property webDescription (base name: "webDescription")', function() {
      // uncomment below and update the code to test the property webDescription
      //var instane = new CloudGovernanceApi.ChangeWebUrlValidateResult();
      //expect(instance).to.be();
    });

    it('should have the property metadatas (base name: "metadatas")', function() {
      // uncomment below and update the code to test the property metadatas
      //var instane = new CloudGovernanceApi.ChangeWebUrlValidateResult();
      //expect(instance).to.be();
    });

    it('should have the property isValid (base name: "isValid")', function() {
      // uncomment below and update the code to test the property isValid
      //var instane = new CloudGovernanceApi.ChangeWebUrlValidateResult();
      //expect(instance).to.be();
    });

    it('should have the property errorMessage (base name: "errorMessage")', function() {
      // uncomment below and update the code to test the property errorMessage
      //var instane = new CloudGovernanceApi.ChangeWebUrlValidateResult();
      //expect(instance).to.be();
    });

  });

}));