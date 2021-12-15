using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioCode.Molecular
{
    public class Dna
    {
        public Collection<Nucleobase> NucleoBases { get; set; }

        public Dna(string chain)
        {
            NucleoBases = new Collection<Nucleobase>();
            foreach (var nucleotide in chain.ToUpperInvariant().ToCharArray())
            {
                if (nucleotide == Nucleobase.Adenine.Symbol)
                {
                    NucleoBases.Add(new Adenine());
                }
                else if (nucleotide == Nucleobase.Cytosine.Symbol)
                {
                    NucleoBases.Add(new Cytosine());
                }
                else if (nucleotide == Nucleobase.Guanine.Symbol)
                {
                    NucleoBases.Add(new Guanine());
                }
                else if (nucleotide == Nucleobase.Thymine.Symbol)
                {
                    NucleoBases.Add(new Thymine());
                }
            }
        }

        public string Reverse()
        {
            var cmp = NucleoBases.Select(x => x.Complimentary).ToList();
            return string.Concat(NucleoBases.Select(n => n.Complimentary.Symbol));
        }

        public override string ToString()
        {
            return string.Concat(NucleoBases.Select(n => n.Symbol));
        }
    }
}
