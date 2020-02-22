using Course.Domain.Validators;
using Course.Domain.Entities;
using System;
using Xunit;

namespace Domain.Course.Tests
{
    public class SubsidiariaTest
    {
       
        
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AO_TENTAR_CRIAR_SUB_SEMNOME_ERRO(string nome)
        {
            var validator = new SubsidiariaValidators();
            var result = validator.Validate(new Subsidiaria(nome));
            Assert.False(result.IsValid);
        }
    }
}