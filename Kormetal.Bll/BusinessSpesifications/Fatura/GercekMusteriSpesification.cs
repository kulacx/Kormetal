using Kormetal.Bll.SpecificationBase;

namespace Kormetal.Bll.BusinessSpesifications.Fatura
{
    public class GercekMusteriSpesification:Specification<int>
    {
        public override bool IsSatisfiedBy(int candidate)
        {
            return candidate == 1 ? true:false;
        }
    }
}
