namespace BioCode.Molecular
{
    public abstract class Nucleobase
    {
        public virtual char Symbol { get; }
        public string Symbol3 { get; }
        public string Name { get; }
        public virtual Nucleobase Complimentary { get; }

        public static Adenine Adenine = new ();
        public static Cytosine Cytosine = new ();
        public static Guanine Guanine = new ();
        public static Thymine Thymine = new ();
    }
}