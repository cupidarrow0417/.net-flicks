﻿using Xunit;

namespace CoreTemplate.Tests.ManagerTests.Config
{
    [CollectionDefinition("Managers")]
    public class ManagerCollection : ICollectionFixture<ManagerHelper>
    {
        // This class has no code, and is never created. Its purpose is simply to be the
        //place to apply [CollectionDefinition] and all the ICollectionFixture<> interfaces.
    }
}