/*
 * CryptoAPIs
 *
 * Crypto APIs is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2021-03-20
 * Contact: developers@cryptoapis.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using CryptoAPIs.Client;
using CryptoAPIs.Api;
// uncomment below to import models
//using CryptoAPIs.Model;

namespace CryptoAPIs.Test.Api
{
    /// <summary>
    ///  Class for testing AutomaticCoinsForwardingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AutomaticCoinsForwardingApiTests : IDisposable
    {
        private AutomaticCoinsForwardingApi instance;

        public AutomaticCoinsForwardingApiTests()
        {
            instance = new AutomaticCoinsForwardingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AutomaticCoinsForwardingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AutomaticCoinsForwardingApi
            //Assert.IsType<AutomaticCoinsForwardingApi>(instance);
        }

        /// <summary>
        /// Test CreateAutomaticCoinsForwarding
        /// </summary>
        [Fact]
        public void CreateAutomaticCoinsForwardingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //CreateAutomaticCoinsForwardingRB createAutomaticCoinsForwardingRB = null;
            //var response = instance.CreateAutomaticCoinsForwarding(blockchain, network, context, createAutomaticCoinsForwardingRB);
            //Assert.IsType<CreateAutomaticCoinsForwardingR>(response);
        }

        /// <summary>
        /// Test DeleteAutomaticCoinsForwarding
        /// </summary>
        [Fact]
        public void DeleteAutomaticCoinsForwardingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string referenceId = null;
            //string context = null;
            //var response = instance.DeleteAutomaticCoinsForwarding(blockchain, network, referenceId, context);
            //Assert.IsType<DeleteAutomaticCoinsForwardingR>(response);
        }

        /// <summary>
        /// Test ListCoinsForwardingAutomations
        /// </summary>
        [Fact]
        public void ListCoinsForwardingAutomationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //long? limit = null;
            //long? offset = null;
            //var response = instance.ListCoinsForwardingAutomations(blockchain, network, context, limit, offset);
            //Assert.IsType<ListCoinsForwardingAutomationsR>(response);
        }
    }
}
