using Unit5_AdapterPatternPatient_Blazor.InsuranceSystem;

namespace Unit5_AdapterPatternPatient_Blazor.Tests;

[TestClass]
public class InNetworkPatientTests
{
    [TestMethod]
    public void CoverageAmount_GoldPlanBrokenArm_Covers80Percent()
    {
        // Arrange
        InsuranceInterface patient = new InNetworkPatient("Alex Patient", "A100", PolicyLevels.Gold);

        // Act
        decimal amountCovered = patient.CoverageAmount(0, 100m);

        // Assert
        Assert.AreEqual(80m, amountCovered);
    }

    [TestMethod]
    public void CoverageAmount_GoldPlanBrokenLeg_Covers90Percent()
    {
        // Arrange
        InsuranceInterface patient = new InNetworkPatient("Alex Patient", "A100", PolicyLevels.Gold);

        // Act
        decimal amountCovered = patient.CoverageAmount(3, 100m);

        // Assert
        Assert.AreEqual(90m, amountCovered);
    }

    [TestMethod]
    public void CoverageAmount_SilverPlanBrokenArm_Covers60Percent()
    {
        // Arrange
        InsuranceInterface patient = new InNetworkPatient("Sam Patient", "A200", PolicyLevels.Silver);

        // Act
        decimal amountCovered = patient.CoverageAmount(0, 100m);

        // Assert
        Assert.AreEqual(60m, amountCovered);
    }

    [TestMethod]
    public void CoverageAmount_SilverPlanBrokenLeg_Covers75Percent()
    {
        // Arrange
        InsuranceInterface patient = new InNetworkPatient("Sam Patient", "A200", PolicyLevels.Silver);

        // Act
        decimal amountCovered = patient.CoverageAmount(3, 100m);

        // Assert
        Assert.AreEqual(75m, amountCovered);
    }

    [TestMethod]
    public void IsCovered_MatchingNameAndPolicy_ReturnsTrue()
    {
        // Arrange
        var patient = new InNetworkPatient("Alex Patient", "A100", PolicyLevels.Gold);

        // Act
        bool isCovered = patient.IsCovered("Alex Patient", "A100");

        // Assert
        Assert.IsTrue(isCovered);
    }

    [TestMethod]
    public void IsCovered_MismatchedPolicy_ReturnsFalse()
    {
        // Arrange
        var patient = new InNetworkPatient("Alex Patient", "A100", PolicyLevels.Gold);

        // Act
        bool isCovered = patient.IsCovered("Alex Patient", "WRONG");

        // Assert
        Assert.IsFalse(isCovered);
    }

    [TestMethod]
    public void GetPatientName_ReturnsPatientName()
    {
        // Arrange
        var patient = new InNetworkPatient("Alex Patient", "A100", PolicyLevels.Gold);

        // Act
        string name = patient.getPatientName();

        // Assert
        Assert.AreEqual("Alex Patient", name);
    }

    [TestMethod]
    public void GetPolicyNumber_ReturnsPolicyNumber()
    {
        // Arrange
        var patient = new InNetworkPatient("Alex Patient", "A100", PolicyLevels.Gold);

        // Act
        string policyNumber = patient.getPolicyNumber();

        // Assert
        Assert.AreEqual("A100", policyNumber);
    }
}
