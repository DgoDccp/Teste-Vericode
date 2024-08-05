
using VeriCode.PageObjects;

namespace VeriCode.Teste
{
    class TesteTricentis : PageTricentis
    {
        [Test]
        public void Tricentis()
        {
            // Enter Vehicle Data
            PreencherVehicleData();
            ClicarNext();

            // Enter Insurant Data
            PreencherInsurantData();
            ClicarNextInsurantData();
        }

        private void PreencherVehicleData()
        {
            ValidaVehicleData();
            PreencherMake();
            PreencherModel();
            PreencherCylinderCapacity();
            PreencherEnginePerformance();
            PreencherDataOfManunfacture();
            PreencherNumberOfSeats();
            ClicarRightHandDrive();
            PreencherNumberOfSeatsMotorcycle();
            PreencherFuelType();
            PreencherPayload();
            PreencherTotalWeight();
            PreencherListPrice();
            PreencherLicensePlataNumber();
            PreencherAnnualMileage();
        }

        private void PreencherInsurantData()
        {
            ValidarEnterInsurantData();
            PreencherFirstName();
            PreencherLastName();
            PreencherDataNascimento();
            ClicarGender();
            PreencherStreetAddres();
            PreencherCountry();
            PreencherZipCode();
            PreencherCity();
            PreencherOccupation();
            ClicarHobbies();
            PreencherWebSite();
            ClicarOpen();
        }
    }
}
