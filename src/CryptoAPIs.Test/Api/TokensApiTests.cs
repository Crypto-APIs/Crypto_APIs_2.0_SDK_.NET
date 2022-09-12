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
    ///  Class for testing TokensApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TokensApiTests : IDisposable
    {
        private TokensApi instance;

        public TokensApiTests()
        {
            instance = new TokensApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TokensApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TokensApi
            //Assert.IsType<TokensApi>(instance);
        }

        /// <summary>
        /// Test GetTokenDetailsByContractAddress
        /// </summary>
        [Fact]
        public void GetTokenDetailsByContractAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string contractAddress = null;
            //string context = null;
            //var response = instance.GetTokenDetailsByContractAddress(blockchain, network, contractAddress, context);
            //Assert.IsType<GetTokenDetailsByContractAddressR>(response);
        }

        /// <summary>
        /// Test ListConfirmedTokensTransfersByAddress
        /// </summary>
        [Fact]
        public void ListConfirmedTokensTransfersByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string address = null;
            //string context = null;
            //long? limit = null;
            //long? offset = null;
            //var response = instance.ListConfirmedTokensTransfersByAddress(blockchain, network, address, context, limit, offset);
            //Assert.IsType<ListConfirmedTokensTransfersByAddressR>(response);
        }

        /// <summary>
        /// Test ListTokensByAddress
        /// </summary>
        [Fact]
        public void ListTokensByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string address = null;
            //string context = null;
            //long? limit = null;
            //long? offset = null;
            //var response = instance.ListTokensByAddress(blockchain, network, address, context, limit, offset);
            //Assert.IsType<ListTokensByAddressR>(response);
        }

        /// <summary>
        /// Test ListTokensTransfersByTransactionHash
        /// </summary>
        [Fact]
        public void ListTokensTransfersByTransactionHashTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string transactionHash = null;
            //string context = null;
            //long? limit = null;
            //long? offset = null;
            //var response = instance.ListTokensTransfersByTransactionHash(blockchain, network, transactionHash, context, limit, offset);
            //Assert.IsType<ListTokensTransfersByTransactionHashR>(response);
        }

        /// <summary>
        /// Test ListUnconfirmedTokensTransfersByAddress
        /// </summary>
        [Fact]
        public void ListUnconfirmedTokensTransfersByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string address = null;
            //string context = null;
            //long? limit = null;
            //long? offset = null;
            //var response = instance.ListUnconfirmedTokensTransfersByAddress(blockchain, network, address, context, limit, offset);
            //Assert.IsType<ListUnconfirmedTokensTransfersByAddressR>(response);
        }
    }
}
