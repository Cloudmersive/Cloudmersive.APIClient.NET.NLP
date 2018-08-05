/* 
 * nlpapi
 *
 * The powerful Natural Language Processing APIs let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Api;

namespace Cloudmersive.APIClient.NET.NLP.Test
{
    /// <summary>
    ///  Class for testing ExtractEntitiesStringApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExtractEntitiesStringApiTests
    {
        private ExtractEntitiesStringApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExtractEntitiesStringApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExtractEntitiesStringApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ExtractEntitiesStringApi
            //Assert.IsInstanceOfType(typeof(ExtractEntitiesStringApi), instance, "instance is a ExtractEntitiesStringApi");
        }

        
        /// <summary>
        /// Test ExtractEntitiesStringPost
        /// </summary>
        [Test]
        public void ExtractEntitiesStringPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string value = null;
            //var response = instance.ExtractEntitiesStringPost(value);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
