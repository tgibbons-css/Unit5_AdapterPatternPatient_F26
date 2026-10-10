namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {
        private OutNetworkPatient patient;

        // Create an out-of-network patient
        public OutNetworkAdapter(string name, int policyNumber)
        {
            patient = new OutNetworkPatient(name, policyNumber);
        }

        // Get the patient's name
        public string getPatientName()
        {
            return patient.getPatientName();
        }

        // Convert the policy number from int to string
        public string getPolicyNumber()
        {
            return patient.PolicyNumber.ToString();
        }

        // Calculate the amount insurance will cover
        public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            decimal percent = patient.CoveragePercent(ProcedureCost);
            return percent * ProcedureCost;
        }

        // Check whether the patient is covered
        public bool IsCovered(string patientName, string policyNumber)
        {
            int number = int.Parse(policyNumber);

            string result = patient.IsCovered(patientName, number);

            return result == "yes";
        }
    }
}