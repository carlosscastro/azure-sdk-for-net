﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Azure.Tests;
using Fluent.Tests.Common;
using Xunit;
using Xunit.Abstractions;

namespace Samples.Tests
{
    public class KeyVault
    {
        public KeyVault(ITestOutputHelper output)
        {
            Microsoft.Azure.Management.Samples.Common.Utilities.LoggerMethod = output.WriteLine;
            Microsoft.Azure.Management.Samples.Common.Utilities.PauseMethod = TestHelper.ReadLine;
        }

        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "KeyVault")]
        public void ManageKeyVaultTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ManageKeyVault.Program.RunSample(rollUpClient);
            }
        }
    }
}