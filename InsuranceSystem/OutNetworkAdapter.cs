
namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {
        OutNetworkPatient patient;

        public OutNetworkAdapter(string name, int policyNumber)
        {
            patient = new OutNetworkPatient(name, policyNumber);
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
            decimal percent = patient.CoveragePercent(ProcedureCost);
            return percent * ProcedureCost;
        }

        public bool IsCovered(string patientName, string policyNumber)
        {
            int number = int.Parse(policyNumber);
            return patient.IsCovered(patientName, number) == "yes";
        }
    }
}
