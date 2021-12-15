
namespace BioCode.Molecular
{
    public class Adenine : Nucleobase
    {
        public override char Symbol => 'A';
        public static string Symbol3 => "Ade";
        public static string Name => "Adenine";

        public override Nucleobase Complimentary => new Thymine();
    }
}
