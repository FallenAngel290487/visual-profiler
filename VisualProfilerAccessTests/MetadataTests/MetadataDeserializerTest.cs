﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using VisualProfilerAccess.Metadata;

namespace VisualProfilerAccessTests.MetadataTests
{
    [TestFixture]
    public class MetadataDeserializerTest
    {
        private byte[] _metadataBytes = {
                                            0x5C, 0x01, 0x00, 0x00, 0x0B, 0x00, 0x00, 0x00, 0x68, 0x3A, 0x7F, 0x00, 0x01,
                                            0x00, 0x00, 0x20, 0x18, 0x00, 0x00, 0x00, 0x54, 0x00, 0x65, 0x00, 0x73, 0x00,
                                            0x74, 0x00, 0x41, 0x00, 0x73, 0x00, 0x73, 0x00, 0x65, 0x00, 0x6D, 0x00, 0x62,
                                            0x00, 0x6C, 0x00, 0x79, 0x00, 0x01, 0x0C, 0x00, 0x00, 0x00, 0x9C, 0x2E, 0x15,
                                            0x00, 0x01, 0x00, 0x00, 0x06, 0x68, 0x3A, 0x7F, 0x00, 0x0D, 0x00, 0x00, 0x00,
                                            0x6C, 0x34, 0x15, 0x00, 0x02, 0x00, 0x00, 0x02, 0x2E, 0x00, 0x00, 0x00, 0x54,
                                            0x00, 0x65, 0x00, 0x73, 0x00, 0x74, 0x00, 0x4E, 0x00, 0x61, 0x00, 0x6D, 0x00,
                                            0x65, 0x00, 0x73, 0x00, 0x70, 0x00, 0x61, 0x00, 0x63, 0x00, 0x65, 0x00, 0x2E,
                                            0x00, 0x54, 0x00, 0x65, 0x00, 0x73, 0x00, 0x74, 0x00, 0x43, 0x00, 0x6C, 0x00,
                                            0x61, 0x00, 0x73, 0x00, 0x73, 0x00, 0x00, 0x9C, 0x2E, 0x15, 0x00, 0x0E, 0x00,
                                            0x00, 0x00, 0x34, 0x34, 0x15, 0x00, 0x01, 0x00, 0x00, 0x06, 0x08, 0x00, 0x00,
                                            0x00, 0x4D, 0x00, 0x61, 0x00, 0x69, 0x00, 0x6E, 0x00, 0x01, 0x00, 0x00, 0x00,
                                            0x08, 0x00, 0x00, 0x00, 0x61, 0x00, 0x72, 0x00, 0x67, 0x00, 0x73, 0x00, 0x6C,
                                            0x34, 0x15, 0x00, 0x0E, 0x00, 0x00, 0x00, 0x4C, 0x34, 0x15, 0x00, 0x03, 0x00,
                                            0x00, 0x06, 0x16, 0x00, 0x00, 0x00, 0x4F, 0x00, 0x74, 0x00, 0x68, 0x00, 0x65,
                                            0x00, 0x72, 0x00, 0x4D, 0x00, 0x65, 0x00, 0x74, 0x00, 0x68, 0x00, 0x6F, 0x00,
                                            0x64, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6C, 0x34, 0x15, 0x00, 0x0E, 0x00, 0x00,
                                            0x00, 0x58, 0x34, 0x15, 0x00, 0x04, 0x00, 0x00, 0x06, 0x32, 0x00, 0x00, 0x00,
                                            0x54, 0x00, 0x65, 0x00, 0x73, 0x00, 0x74, 0x00, 0x4D, 0x00, 0x65, 0x00, 0x73,
                                            0x00, 0x73, 0x00, 0x61, 0x00, 0x67, 0x00, 0x65, 0x00, 0x57, 0x00, 0x69, 0x00,
                                            0x74, 0x00, 0x68, 0x00, 0x32, 0x00, 0x41, 0x00, 0x72, 0x00, 0x67, 0x00, 0x75,
                                            0x00, 0x6D, 0x00, 0x65, 0x00, 0x6E, 0x00, 0x74, 0x00, 0x73, 0x00, 0x02, 0x00,
                                            0x00, 0x00, 0x1A, 0x00, 0x00, 0x00, 0x74, 0x00, 0x65, 0x00, 0x73, 0x00, 0x74,
                                            0x00, 0x41, 0x00, 0x72, 0x00, 0x67, 0x00, 0x75, 0x00, 0x6D, 0x00, 0x65, 0x00,
                                            0x6E, 0x00, 0x74, 0x00, 0x41, 0x00, 0x1A, 0x00, 0x00, 0x00, 0x74, 0x00, 0x65,
                                            0x00, 0x73, 0x00, 0x74, 0x00, 0x41, 0x00, 0x72, 0x00, 0x67, 0x00, 0x75, 0x00,
                                            0x6D, 0x00, 0x65, 0x00, 0x6E, 0x00, 0x74, 0x00, 0x42, 0x00, 0x6C, 0x34, 0x15,
                                            0x00
                                        };

        private MemoryStream _memoryStream;

        [SetUp]
        public void SetUp()
        {
            AssemblyMetadata.Cache.Clear();
            ModuleMetadata.Cache.Clear();
            ClassMetadata.Cache.Clear();
            ModuleMetadata.Cache.Clear();
            _memoryStream = _metadataBytes.ConvertToMemoryStream();
            MetadataDeserializer.DeserializeAllMetadataAndCacheIt(_memoryStream);
        }

        [Test]
        public void AssemblyCacheTest()
        {
            Assert.AreEqual(1,AssemblyMetadata.Cache.Count);
        }
        
        [Test]
        public void ModuleCacheTest()
        {
            Assert.AreEqual(1,ModuleMetadata.Cache.Count);
        }
        
        [Test]
        public void ClassCacheTest()
        {
            Assert.AreEqual(1,ClassMetadata.Cache.Count);
        }
        
        [Test]
        public void MethodCacheTest()
        {
            Assert.AreEqual(3,MethodMetadata.Cache.Count);
        }

        [Test]
        public void AllDataReadToEndTest()
        {
            Assert.AreEqual(_memoryStream.Length,_memoryStream.Position);
        }
    }
}