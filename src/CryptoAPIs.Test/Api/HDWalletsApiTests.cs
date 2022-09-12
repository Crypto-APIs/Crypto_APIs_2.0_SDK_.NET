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
    ///  Class for testing HDWalletsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HDWalletsApiTests : IDisposable
    {
        private HDWalletsApi instance;

        public HDWalletsApiTests()
        {
            instance = new HDWalletsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HDWalletsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' HDWalletsApi
            //Assert.IsType<HDWalletsApi>(instance);
        }

        /// <summary>
        /// Test DeriveAndSyncNewChangeAddresses
        /// </summary>
        [Fact]
        public void DeriveAndSyncNewChangeAddressesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //DeriveAndSyncNewChangeAddressesRB deriveAndSyncNewChangeAddressesRB = null;
            //var response = instance.DeriveAndSyncNewChangeAddresses(blockchain, network, context, deriveAndSyncNewChangeAddressesRB);
            //Assert.IsType<DeriveAndSyncNewChangeAddressesR>(response);
        }

        /// <summary>
        /// Test DeriveAndSyncNewReceivingAddresses
        /// </summary>
        [Fact]
        public void DeriveAndSyncNewReceivingAddressesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //DeriveAndSyncNewReceivingAddressesRB deriveAndSyncNewReceivingAddressesRB = null;
            //var response = instance.DeriveAndSyncNewReceivingAddresses(blockchain, network, context, deriveAndSyncNewReceivingAddressesRB);
            //Assert.IsType<DeriveAndSyncNewReceivingAddressesR>(response);
        }

        /// <summary>
        /// Test GetHDWalletXPubYPubZPubAssets
        /// </summary>
        [Fact]
        public void GetHDWalletXPubYPubZPubAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string extendedPublicKey = null;
            //string network = null;
            //string context = null;
            //string derivation = null;
            //var response = instance.GetHDWalletXPubYPubZPubAssets(blockchain, extendedPublicKey, network, context, derivation);
            //Assert.IsType<GetHDWalletXPubYPubZPubAssetsR>(response);
        }

        /// <summary>
        /// Test GetHDWalletXPubYPubZPubDetails
        /// </summary>
        [Fact]
        public void GetHDWalletXPubYPubZPubDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string extendedPublicKey = null;
            //string network = null;
            //string context = null;
            //string derivation = null;
            //var response = instance.GetHDWalletXPubYPubZPubDetails(blockchain, extendedPublicKey, network, context, derivation);
            //Assert.IsType<GetHDWalletXPubYPubZPubDetailsR>(response);
        }

        /// <summary>
        /// Test ListHDWalletXPubYPubZPubTransactions
        /// </summary>
        [Fact]
        public void ListHDWalletXPubYPubZPubTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string extendedPublicKey = null;
            //string network = null;
            //string context = null;
            //string derivation = null;
            //long? limit = null;
            //long? offset = null;
            //var response = instance.ListHDWalletXPubYPubZPubTransactions(blockchain, extendedPublicKey, network, context, derivation, limit, offset);
            //Assert.IsType<ListHDWalletXPubYPubZPubTransactionsR>(response);
        }

        /// <summary>
        /// Test ListHDWalletXPubYPubZPubUTXOs
        /// </summary>
        [Fact]
        public void ListHDWalletXPubYPubZPubUTXOsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string extendedPublicKey = null;
            //string network = null;
            //string context = null;
            //string derivation = null;
            //long? limit = null;
            //long? offset = null;
            //var response = instance.ListHDWalletXPubYPubZPubUTXOs(blockchain, extendedPublicKey, network, context, derivation, limit, offset);
            //Assert.IsType<ListHDWalletXPubYPubZPubUTXOsR>(response);
        }

        /// <summary>
        /// Test ListSyncedAddresses
        /// </summary>
        [Fact]
        public void ListSyncedAddressesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string extendedPublicKey = null;
            //string network = null;
            //string context = null;
            //string addressFormat = null;
            //bool? isChangeAddress = null;
            //long? limit = null;
            //long? offset = null;
            //var response = instance.ListSyncedAddresses(blockchain, extendedPublicKey, network, context, addressFormat, isChangeAddress, limit, offset);
            //Assert.IsType<ListSyncedAddressesR>(response);
        }

        /// <summary>
        /// Test PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPub
        /// </summary>
        [Fact]
        public void PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRB prepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRB = null;
            //var response = instance.PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPub(blockchain, network, context, prepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubRB);
            //Assert.IsType<PrepareAUTXOBasedTransactionFromHDWalletXPubYPubZPubR>(response);
        }

        /// <summary>
        /// Test PrepareAnAccountBasedTransactionFromHDWalletXPubYPubZPub
        /// </summary>
        [Fact]
        public void PrepareAnAccountBasedTransactionFromHDWalletXPubYPubZPubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //PrepareAnAccountBasedTransactionFromHDWalletXPubYPubZPubRB prepareAnAccountBasedTransactionFromHDWalletXPubYPubZPubRB = null;
            //var response = instance.PrepareAnAccountBasedTransactionFromHDWalletXPubYPubZPub(blockchain, network, context, prepareAnAccountBasedTransactionFromHDWalletXPubYPubZPubRB);
            //Assert.IsType<PrepareAnAccountBasedTransactionFromHDWalletXPubYPubZPubR>(response);
        }

        /// <summary>
        /// Test SyncHDWalletXPubYPubZPub
        /// </summary>
        [Fact]
        public void SyncHDWalletXPubYPubZPubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //SyncHDWalletXPubYPubZPubRB syncHDWalletXPubYPubZPubRB = null;
            //var response = instance.SyncHDWalletXPubYPubZPub(blockchain, network, context, syncHDWalletXPubYPubZPubRB);
            //Assert.IsType<SyncHDWalletXPubYPubZPubR>(response);
        }

        /// <summary>
        /// Test SyncNewHDWalletXPubYPubZPub
        /// </summary>
        [Fact]
        public void SyncNewHDWalletXPubYPubZPubTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string blockchain = null;
            //string network = null;
            //string context = null;
            //SyncNewHDWalletXPubYPubZPubRB syncNewHDWalletXPubYPubZPubRB = null;
            //var response = instance.SyncNewHDWalletXPubYPubZPub(blockchain, network, context, syncNewHDWalletXPubYPubZPubRB);
            //Assert.IsType<SyncNewHDWalletXPubYPubZPubR>(response);
        }
    }
}
