using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    // Adapter so an OutNetworkPatient can be used as an InsuranceInterface
    public class OutNetworkAdapter : InsuranceInterface
    {
        OutNetworkPatient patient;

        public OutNetworkAdapter(string newName, int newPolicyNumber)
        {
            patient = new OutNetworkPatient(newName, newPolicyNumber);
        }

        public OutNetworkAdapter(OutNetworkPatient existingPatient)
        {
            patient = existingPatient;
        }

        // required for Insurance Interface
        public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            return patient.CoveragePercent(ProcedureCost) * ProcedureCost;
        }

        // required for Insurance Interface
        public bool IsCovered(string patientName, string policyNumber)
        {
            if (!int.TryParse(policyNumber, out int policy))
            {
                return false;
            }
            return patient.IsCovered(patientName, policy) == "yes";
        }

        public string getPatientName()
        {
            return patient.getPatientName();
        }

        public string getPolicyNumber()
        {
            return patient.PolicyNumber.ToString();
        }
    }
}
