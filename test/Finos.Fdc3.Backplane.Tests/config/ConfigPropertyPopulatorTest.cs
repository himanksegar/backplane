﻿/*
	* SPDX-License-Identifier: Apache-2.0
	* Copyright 2022 FINOS FDC3 contributors - see NOTICE file
	*/

using AutoFixture;
using NUnit.Framework;

namespace Finos.Fdc3.Backplane.Tests.config
{
    internal class ConfigPropertyPopulatorTest
    {
        private Fixture _fixture;

        [SetUp]
        public void Setup()
        {
            _fixture = AutoFixtures.Create();

        }
        [Test]
        public void ShouldPopulateConfigProperties()
        {

        }
    }
}
