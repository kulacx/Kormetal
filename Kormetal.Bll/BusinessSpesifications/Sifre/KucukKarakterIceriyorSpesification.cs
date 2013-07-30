using System.Text.RegularExpressions;
using Kormetal.Bll.SpecificationBase;

namespace Kormetal.Bll.BusinessSpesifications.Sifre
{
    class KucukKarakterIceriyorSpesification:Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return Regex.IsMatch(candidate, @"[a-z]");
        }
    }
}
