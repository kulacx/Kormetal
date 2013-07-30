using System.Text.RegularExpressions;
using Kormetal.Bll.SpecificationBase;

namespace Kormetal.Bll.BusinessSpesifications.Sifre
{
    public class GucluKarakterlerIceriyorSpecification:Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return Regex.IsMatch(candidate, @"[!@#\$%\^&\*\?_~\-\(\);\.\+:]+");
        }
    }
}
