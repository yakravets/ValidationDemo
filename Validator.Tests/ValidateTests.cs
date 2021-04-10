using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidationDemo;

namespace Validator.Tests
{
    [TestClass]
    public class ValidateTests
    {
        private PasswordValidator _validator;

        [TestInitialize]
        public void Setup()
        {
            _validator = new PasswordValidator();
        }

        [TestMethod]
        public void ShouldReturnFalse_WhenPasswordIsEmpty()
        {
            // Given
            var password = "";

            // When
            var result = _validator.Validate(password);

            // Then
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ShouldNotValidate_WhenPasswordIsNull()
        {
            //  When
            var result = _validator.Validate(null);
        }

        // Min Length = 6
        // min, max length зчитати з апп конфіг
        // Max Length = 20

        // white space

        // digit, upper case, lower case, special symbol
        // latin
    }
}
