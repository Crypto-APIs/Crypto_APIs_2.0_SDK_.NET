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
    ///  Class for testing ZilliqaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ZilliqaApiTests : IDisposable
    {
        private ZilliqaApi instance;

        public ZilliqaApiTests()
        {
            instance = new ZilliqaApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ZilliqaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ZilliqaApi
            //Assert.IsType<ZilliqaApi>(instance);
        }

        /// <summary>
        /// Test GetLatestMinedZilliqaBlock
        /// </summary>
        [Fact]
        public void GetLatestMinedZilliqaBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string context = null;
            //var response = instance.GetLatestMinedZilliqaBlock(network, context);
            //Assert.IsType<GetLatestMinedZilliqaBlockR>(response);
        }

        /// <summary>
        /// Test GetZilliqaAddressDetails
        /// </summary>
        [Fact]
        public void GetZilliqaAddressDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string address = null;
            //string context = null;
            //var response = instance.GetZilliqaAddressDetails(network, address, context);
            //Assert.IsType<GetZilliqaAddressDetailsR>(response);
        }

        /// <summary>
        /// Test GetZilliqaBlockDetailsByBlockHash
        /// </summary>
        [Fact]
        public void GetZilliqaBlockDetailsByBlockHashTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string blockHash = null;
            //string context = null;
            //var response = instance.GetZilliqaBlockDetailsByBlockHash(network, blockHash, context);
            //Assert.IsType<GetZilliqaBlockDetailsByBlockHashR>(response);
        }

        /// <summary>
        /// Test GetZilliqaBlockDetailsByBlockHeight
        /// </summary>
        [Fact]
        public void GetZilliqaBlockDetailsByBlockHeightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //int blockHeight = null;
            //string context = null;
            //var response = instance.GetZilliqaBlockDetailsByBlockHeight(network, blockHeight, context);
            //Assert.IsType<GetZilliqaBlockDetailsByBlockHeightR>(response);
        }

        /// <summary>
        /// Test GetZilliqaTransactionDetailsByTransactionID
        /// </summary>
        [Fact]
        public void GetZilliqaTransactionDetailsByTransactionIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string transactionHash = null;
            //string context = null;
            //var response = instance.GetZilliqaTransactionDetailsByTransactionID(network, transactionHash, context);
            //Assert.IsType<GetZilliqaTransactionDetailsByTransactionIDR>(response);
        }

        /// <summary>
        /// Test ListZilliqaTransactionsByAddress
        /// </summary>
        [Fact]
        public void ListZilliqaTransactionsByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string address = null;
            //string context = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListZilliqaTransactionsByAddress(network, address, context, limit, offset);
            //Assert.IsType<ListZilliqaTransactionsByAddressR>(response);
        }

        /// <summary>
        /// Test ListZilliqaTransactionsByBlockHash
        /// </summary>
        [Fact]
        public void ListZilliqaTransactionsByBlockHashTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //string blockHash = null;
            //string context = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListZilliqaTransactionsByBlockHash(network, blockHash, context, limit, offset);
            //Assert.IsType<ListZilliqaTransactionsByBlockHashR>(response);
        }

        /// <summary>
        /// Test ListZilliqaTransactionsByBlockHeight
        /// </summary>
        [Fact]
        public void ListZilliqaTransactionsByBlockHeightTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string network = null;
            //int blockHeight = null;
            //string context = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.ListZilliqaTransactionsByBlockHeight(network, blockHeight, context, limit, offset);
            //Assert.IsType<ListZilliqaTransactionsByBlockHeightR>(response);
        }
    }
}
