using Xunit;

namespace BioCode.Molecular.Test
{
    public class DnaTests
    {
        [Fact]
        public void Create_Dna_From_String()
        {
            //assert
            var dnaChain = "TACTGAA";
            //"ATGACTT"

            //act
            var dna = new Dna(dnaChain);

            //arrange
            Assert.Equal(dnaChain, dna.ToString());
        }

        [Fact]
        public void GetReverse_Dna()
        {
            //assert
            var dnaChain = "TACTGAA";
            var dna = new Dna(dnaChain);

            //act
            var reverseDna = dna.Reverse();

            //arrange
            Assert.Equal("ATGACTT", reverseDna);
        }
    }
}