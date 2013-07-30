using Kormetal.Bll.SpecificationBase;

namespace Kormetal.Bll.BusinessSpesifications.Sifre
{
    public class Min6KarakterSpesification:Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
           return candidate.Length >= 6;
        }
    }
}
