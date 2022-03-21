using PolicyMicroservice.Models;
using System.Collections.Generic;

namespace PolicyMicroservice.Repository
{
    /// <summary>
    /// </summary>
    public interface IPolicyRepo
    {
        public IEnumerable<ProviderPolicy> GetChainOfProviders(int policyNo);
        public string GetEligibleBenefits(int policyId,int memberId);
        public double GetEligibleClaimAmount(int policyId, int memberId, int benefitId);
    }
}
