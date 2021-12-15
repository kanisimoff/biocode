
namespace BioCode.Molecular
{
    public class Cytosine : Nucleobase
    {
        public override char Symbol => 'C';
        public static string Symbol3 => "Cyt";
        public static string Name => nameof(Cytosine);
        public override Nucleobase Complimentary => new Guanine();
    }
}
