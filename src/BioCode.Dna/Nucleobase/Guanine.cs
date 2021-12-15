
namespace BioCode.Molecular
{
    public class Guanine : Nucleobase
    {
        public override char Symbol => 'G';
        public static string Symbol3 => "Gua";
        public static string Name => "Guanine";

        public override Nucleobase Complimentary => new Cytosine();
    }
}
