/*
 * CryptoAPIs
 *
 * Crypto APIs 2.0 is a complex and innovative infrastructure layer that radically simplifies the development of any Blockchain and Crypto related applications. Organized around REST, Crypto APIs 2.0 can assist both novice Bitcoin/Ethereum enthusiasts and crypto experts with the development of their blockchain applications. Crypto APIs 2.0 provides unified endpoints and data, raw data, automatic tokens and coins forwardings, callback functionalities, and much more.
 *
 * The version of the OpenAPI document: 2.0.0
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
    ///  Class for testing InternalApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InternalApiTests : IDisposable
    {
        private InternalApi instance;

        public InternalApiTests()
        {
            instance = new InternalApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InternalApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InternalApi
            //Assert.IsType<InternalApi>(instance);
        }

        /// <summary>
        /// Test GetInternalTransactionByTransactionHashAndOperationId
        /// </summary>
        [Fact]
        public void GetInternalTransactionByTransactionHashAndOperationIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string operationId = null;
            //string transactionHash = null;
            //string context = null;
            //var response = instance.GetInternalTransactionByTransactionHashAndOperationId(blockchain, network, operationId, transactionHash, context);
            //Assert.IsType<GetInternalTransactionByTransactionHashAndOperationIdR>(response);
        }

        /// <summary>
        /// Test ListInternalTransactionDetailsByTransactionHash
        /// </summary>
        [Fact]
        public void ListInternalTransactionDetailsByTransactionHashTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string transactionHash = null;
            //string context = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListInternalTransactionDetailsByTransactionHash(blockchain, network, transactionHash, context, limit, offset);
            //Assert.IsType<ListInternalTransactionDetailsByTransactionHashR>(response);
        }
    }
}
