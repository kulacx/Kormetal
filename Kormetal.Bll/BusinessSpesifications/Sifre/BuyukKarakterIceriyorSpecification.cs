using System.Text.RegularExpressions;
using Kormetal.Bll.SpecificationBase;

namespace Kormetal.Bll.BusinessSpesifications.Sifre
{
    class BuyukKarakterIceriyorSpecification:Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return Regex.IsMatch(candidate, @"[A-Z]");
        }
    }
}
