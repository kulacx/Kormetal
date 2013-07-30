using Kormetal.Bll.SpecificationBase;

namespace Kormetal.Bll.BusinessSpesifications.Sifre
{
    class Min12KarakterSpesification:Specification<string>
    {
        public override bool IsSatisfiedBy(string candidate)
        {
            return candidate.Length >= 12;
        }
    }
}
