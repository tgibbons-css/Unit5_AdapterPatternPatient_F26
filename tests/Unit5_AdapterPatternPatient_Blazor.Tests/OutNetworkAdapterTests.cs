// using Unit5_AdapterPatternPatient_Blazor.InsuranceSystem;

// namespace Unit5_AdapterPatternPatient_Blazor.Tests;

// // Future TDD exercise:
// // Uncomment these tests after the class OutNetworkAdapter is created.
// // The examples assume that the adapter wraps an OutNetworkPatient.

// [TestClass]
// public class OutNetworkAdapterTests
// {
//     [TestMethod]
//     public void CoverageAmount_CostBelow1000_Uses50PercentRate()
//     {
//         // Arrange
//         var adaptee = new OutNetworkPatient("Kathy Modin", 112233);
//         InsuranceInterface patient = new OutNetworkAdapter(adaptee);

//         // Act
//         decimal amountCovered = patient.CoverageAmount(0, 100m);

//         // Assert
//         Assert.AreEqual(50m, amountCovered);
//     }

//     [TestMethod]
//     public void CoverageAmount_CostJustBelow1000_Uses50PercentRate()
//     {
//         // Arrange
//         var adaptee = new OutNetworkPatient("Kathy Modin", 112233);
//         InsuranceInterface patient = new OutNetworkAdapter(adaptee);

//         // Act
//         decimal amountCovered = patient.CoverageAmount(0, 999.99m);

//         // Assert
//         Assert.AreEqual(499.995m, amountCovered);
//     }

//     [TestMethod]
//     public void CoverageAmount_CostOf1000_Uses25PercentRate()
//     {
//         // Arrange
//         var adaptee = new OutNetworkPatient("Kathy Modin", 112233);
//         InsuranceInterface patient = new OutNetworkAdapter(adaptee);

//         // Act
//         decimal amountCovered = patient.CoverageAmount(0, 1000m);

//         // Assert
//         Assert.AreEqual(250m, amountCovered);
//     }

//     [TestMethod]
//     public void CoverageAmount_AnyProcedureId_UsesOutOfNetworkRate()
//     {
//         // Arrange
//         var adaptee = new OutNetworkPatient("Kathy Modin", 112233);
//         InsuranceInterface patient = new OutNetworkAdapter(adaptee);

//         // Act
//         decimal amountCovered = patient.CoverageAmount(999, 100m);

//         // Assert
//         Assert.AreEqual(50m, amountCovered);
//     }

//     [TestMethod]
//     public void IsCovered_WhenAdapteeReportsYes_ReturnsTrue()
//     {
//         // Arrange
//         var adaptee = new OutNetworkPatient("Kathy Modin", 112233);
//         InsuranceInterface patient = new OutNetworkAdapter(adaptee);

//         // Act
//         bool isCovered = patient.IsCovered("Kathy Modin", "112233");

//         // Assert
//         Assert.IsTrue(isCovered);
//     }

//     [TestMethod]
//     public void IsCovered_WhenAdapteeReportsNo_ReturnsFalse()
//     {
//         // Arrange
//         var adaptee = new OutNetworkPatient("Kathy Modin", 112233);
//         InsuranceInterface patient = new OutNetworkAdapter(adaptee);

//         // Act
//         bool isCovered = patient.IsCovered("Kathy Modin", "999999");

//         // Assert
//         Assert.IsFalse(isCovered);
//     }

//     [TestMethod]
//     public void GetPatientName_ReturnsWrappedPatientName()
//     {
//         // Arrange
//         var adaptee = new OutNetworkPatient("Kathy Modin", 112233);
//         InsuranceInterface patient = new OutNetworkAdapter(adaptee);

//         // Act
//         string patientName = patient.getPatientName();

//         // Assert
//         Assert.AreEqual("Kathy Modin", patientName);
//     }

//     [TestMethod]
//     public void GetPolicyNumber_ReturnsPolicyNumberAsString()
//     {
//         // Arrange
//         var adaptee = new OutNetworkPatient("Kathy Modin", 112233);
//         InsuranceInterface patient = new OutNetworkAdapter(adaptee);

//         // Act
//         string policyNumber = patient.getPolicyNumber();

//         // Assert
//         Assert.AreEqual("112233", policyNumber);
//     }
// }
