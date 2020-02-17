using Course.Domain.Validators;
using Course.Domain.Entities;
using System;
using Xunit;

namespace Domain.Course.Tests
{
    public class SubsidiariaTest
    {
        [Fact]
        public void AO_TENTAR_CRIAR_SUB_SEMNOME_ERRO()
        {
            var validator = new SubsidiariaValidators();
            var result = validator.Validate(new Subsidiaria());
            Assert.False(result.IsValid);
        }
    }
}