using System;
using Xunit;

namespace RDub.Utility.Tests
{
    public class EnsureTests
    {
        [Fact]
        public void ArgumentNotNull_NullObject_Throws()
        {
            object argument = null;

            Assert.Throws<ArgumentNullException>(() => Ensure.ArgumentNotNull(argument, "arg"));
        }

        [Fact]
        public void ArgumentNotNull_NonNullObject_DoesNotThrow()
        {
            string value = "This is a test.";

            Assert.DoesNotThrow(() => Ensure.ArgumentNotNull(value, "value"));
        }
    }
}