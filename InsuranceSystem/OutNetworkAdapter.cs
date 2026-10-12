namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {
        private readonly OutNetworkPatient patient;

        public OutNetworkAdapter(string newName, int newPolicyNumber)
        {
            patient = new OutNetworkPatient(newName, newPolicyNumber);
        }

        public string getPatientName()
        {
            return patient.getPatientName();
        }

        public string getPolicyNumber()
        {
            return patient.PolicyNumber.ToString();
        }

        public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            return patient.CoveragePercent(ProcedureCost) * ProcedureCost;
        }

        public bool IsCovered(string patientName, string policyNumber)
        {
            return patient.IsCovered(patientName, int.Parse(policyNumber)) == "yes";
        }
    }
}
