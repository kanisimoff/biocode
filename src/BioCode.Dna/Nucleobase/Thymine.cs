namespace BioCode.Molecular
{
    public class Thymine : Nucleobase
    {
        public override char Symbol => 'T';
        public static string Symbol3 => "Thy";
        public static string Name => nameof(Thymine);
        public override Nucleobase Complimentary => new Adenine();

    }
}
