using System;
namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem;
public class OutNetworkAdapter : InsuranceInterface
{

OutNetworkPatient outnetworkpatient;

public OutNetworkAdapter(string newName, int newPolicyNumber)
{
    outnetworkpatient = new OutNetworkPatient(newName, newPolicyNumber);
}

public bool IsCovered(string patientName, string policyNumber)
{
    int policynumber = int.Parse(policyNumber);
    string covered = outnetworkpatient.IsCovered(patientName, policynumber);
    if (covered == "yes")
        {
            return true;
        }
    return false;
}

public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
{
    decimal coveragePercent = outnetworkpatient.CoveragePercent(ProcedureCost);
    return (coveragePercent * ProcedureCost);
}

public string getPatientName()
{
    return outnetworkpatient.getPatientName();
}

public string getPolicyNumber()
{
    return outnetworkpatient.PolicyNumber.ToString();
}

}