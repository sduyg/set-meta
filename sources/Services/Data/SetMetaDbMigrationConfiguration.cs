﻿using System;
using System.Data.Entity.Migrations;
using System.Linq;

using SetMeta.Web.Helpers;
using SetMeta.Web.Data.Entities;

namespace SetMeta.Web.Services.Data
{
    public class SetMetaDbMigrationConfiguration : DbMigrationsConfiguration<SetMetaDbContext>
    {
        public SetMetaDbMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SetMetaDbContext context)
        {
            if (context.Users.Any()) return;

            #region Users

            AddUser(context, ConstHelper.Admin, "admin@test.com", ConstHelper.Admin);
            AddUser(context, ConstHelper.Developer, "dev@test.com", ConstHelper.Developer);
            AddUser(context, ConstHelper.User, "user@test.com", ConstHelper.User);

            #endregion

            #region Quarters

            var quarterPublicId = AddMetaDataType(context, "Quarters");
            AddMetaData(context, "Quarters", quarterPublicId, "First Quarter", "1");
            AddMetaData(context, "Quarters", quarterPublicId, "Second Quarter", "2");
            AddMetaData(context, "Quarters", quarterPublicId, "Third Quarter", "3");
            AddMetaData(context, "Quarters", quarterPublicId, "Fourth Quarter", "4");

            #endregion

            #region Months

            var monthPublicId = AddMetaDataType(context, "Months");
            AddMetaData(context, "Months", monthPublicId, "January", "1");
            AddMetaData(context, "Months", monthPublicId, "February", "2");
            AddMetaData(context, "Months", monthPublicId, "March", "3");
            AddMetaData(context, "Months", monthPublicId, "April", "4");
            AddMetaData(context, "Months", monthPublicId, "May", "5");
            AddMetaData(context, "Months", monthPublicId, "June", "6");
            AddMetaData(context, "Months", monthPublicId, "July", "7");
            AddMetaData(context, "Months", monthPublicId, "August", "8");
            AddMetaData(context, "Months", monthPublicId, "September", "9");
            AddMetaData(context, "Months", monthPublicId, "October", "10");
            AddMetaData(context, "Months", monthPublicId, "November", "11");
            AddMetaData(context, "Months", monthPublicId, "December", "12");

            #endregion

            #region Days

            var dayPublicId = AddMetaDataType(context, "Days");
            AddMetaData(context, "Days", dayPublicId, "Monday", "1");
            AddMetaData(context, "Days", dayPublicId, "Tuesday", "2");
            AddMetaData(context, "Days", dayPublicId, "Wednesday", "3");
            AddMetaData(context, "Days", dayPublicId, "Thursday", "4");
            AddMetaData(context, "Days", dayPublicId, "Friday", "5");
            AddMetaData(context, "Days", dayPublicId, "Saturday", "6");
            AddMetaData(context, "Days", dayPublicId, "Sunday", "7");

            #endregion

            #region Timezones

            var tiemZonesPublicId = AddMetaDataType(context, "Time Zones");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−12:00", "utc_minus_twelve");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−11:00", "utc_minus_eleven");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−10:00", "utc_minus_ten");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−09:30", "utc_minus_half_past_nine");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−09:00", "utc_minus_nine");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−08:00", "utc_minus_eight");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−07:00", "utc_minus_seven");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−06:00", "utc_minus_six");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−05:00", "utc_minus_five");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−04:30", "utc_minus_half_past_four");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−04:00", "utc_minus_four");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−03:30", "utc_minus_half_past_three");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−03:00", "utc_minus_three");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−02:00", "utc_minus_two");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC−01:00", "utc_minus_one");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC±00:00", "utc_zero");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+01:00", "utc_plus_one");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+02:00", "utc_plus_two");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+03:00", "utc_plus_three");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+03:30", "utc_plus_half_past_three");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+04:00", "utc_plus_four");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+04:30", "utc_plus_half_past_four");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+05:00", "utc_plus_five");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+05:30", "utc_plus_half_past_five");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+05:45", "utc_plus_a_quarter_to_five");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+06:00", "utc_plus_six");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+06:30", "utc_plus_half_past_six");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+07:00", "utc_plus_seven");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+08:00", "utc_plus_eight");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+08:45", "utc_plus_a_quarter_to_nine");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+09:00", "utc_plus_nine");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+09:30", "utc_plus_half_past_nine");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+10:00", "utc_plus_ten");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+10:30", "utc_plus_half_past_ten");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+11:00", "utc_plus_eleven");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+11:30", "utc_plus_half_past_eleven");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+12:00", "utc_plus_twelve");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+12:45", "utc_plus_a_quarter_to_thirteen");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+13:00", "utc_plus_thirteen");
            AddMetaData(context, "Time Zones", tiemZonesPublicId, "UTC+14:00", "utc_plus_fourteen");

            #endregion

            #region Horoscopes

            var horoscopesPublicId = AddMetaDataType(context, "Horoscopes");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Aquarius", "1");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Aries", "2");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Cancer", "3");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Capricorn", "4");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Gemini", "5");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Leo", "6");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Libra", "7");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Pisces", "8");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Sagittarius", "9");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Scorpio", "10");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Taurus", "11");
            AddMetaData(context, "Horoscopes", horoscopesPublicId, "Virgo", "12");

            #endregion

            #region Vehicle Types

            var vehicleTypesPublicId = AddMetaDataType(context, "Vehicle Types");
            AddMetaData(context, "Vehicle Types", vehicleTypesPublicId, "Automobile", "1");
            AddMetaData(context, "Vehicle Types", vehicleTypesPublicId, "SUVs & Pick-Up Trucks", "2");
            AddMetaData(context, "Vehicle Types", vehicleTypesPublicId, "Motorcyles", "3");
            AddMetaData(context, "Vehicle Types", vehicleTypesPublicId, "Minivans, Vans & Panelvans", "4");
            AddMetaData(context, "Vehicle Types", vehicleTypesPublicId, "ATV", "5");
            AddMetaData(context, "Vehicle Types", vehicleTypesPublicId, "UTV", "6");
            AddMetaData(context, "Vehicle Types", vehicleTypesPublicId, "Electric Vehicles", "7");
            AddMetaData(context, "Vehicle Types", vehicleTypesPublicId, "RVs & Campers", "8");

            #endregion

            #region Car Brands

            var carBrandsPublicId = AddMetaDataType(context, "Car Brands");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Acura", "www.acura.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Alfa Romeo", "www.alfaromeo.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Aston Martin", "www.astonmartin.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Audi", "www.audi.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Bentley", "www.bentleymotors.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "BMW", "www.bmw.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Bugatti", "www.bugatti.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Buick", "www.buick.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Cadillac", "www.cadillac.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Chery", "www.chery.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Chevrolet", "www.chevrolet.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Chrysler", "www.chrysler.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Citroën", "www.citroen.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Dacia", "www.dacia.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Daewoo", "www.daewoous.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Daihatsu", "www.daihatsu.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Dodge", "www.dodge.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Eagle", "www.eagleautonz.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Ferrari", "www.ferrari.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Fiat", "www.fiat.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Ford", "www.ford.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "GAZ", "eng.gazgroup.ru");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Geely", "www.geely.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Gumpert", "www.gumpert.de");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Hennessey", "www.hennesseyperformance.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Honda", "honda.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Hyundai", "www.hyundai.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Ikco", "www.ikco.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Infiniti", "www.infiniti.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Isuzu", "www.isuzu.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Jaguar", "www.jaguar.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Kia", "www.kia.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Lada", "www.lada.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Lamborghini", "www.lamborghini.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Lancia", "www.lancia.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Lexus", "www.lexus.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Lincoln", "www.lincoln.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Lotus", "www.lotuscars.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Maserati", "www.maserati.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Mazda", "www.mazda.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "McLaren", "www.mclaren.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Mercedes - Benz", "www.mercedes-benz.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Mercury", "www.mercuryvehicles.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "MG", "mg.co.uk");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Mini", "www.mini.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Mitsubishi", "www.mitsubishi-motors.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Nissan", "www.nissan-global.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Oldsmobile", "www.oldsmobile.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Opel", "www.opel.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Peugeot", "www.peugeot.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Pontiac", "www.pontiac.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Porsche", "www.porsche.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Proton", "www.proton.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Renault", "www.renault.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Rolls-Royce", "www.rolls-roycemotorcars.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Saab", "www.saab.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Seat", "www.seat.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Skoda", "www.skoda-auto.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Smart", "www.smart.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Subaru", "www.subaru-global.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Suzuki", "www.suzuki.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Şamil", "www.samil.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Tata", "www.tatamotors.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Toyota", "www.toyota.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Volkswagen", "www.vw.com");
            AddMetaDataUrl(context, "Car Brands", carBrandsPublicId, "Volvo", "www.volvo.com");

            #endregion

            #region Payment Type

            var paymentTypePublicId = AddMetaDataType(context, "Payment Type");
            AddMetaData(context, "Payment Type", paymentTypePublicId, "Cash", "1");
            AddMetaData(context, "Payment Type", paymentTypePublicId, "Credit Card", "2");
            AddMetaData(context, "Payment Type", paymentTypePublicId, "Paypal", "3");

            #endregion

            #region Credit Card

            var creditCardPublicId = AddMetaDataType(context, "Credit Card");
            AddMetaData(context, "Credit Card", creditCardPublicId, "American Express", "american_express");
            AddMetaData(context, "Credit Card", creditCardPublicId, "Diners Club", "diners_club");
            AddMetaData(context, "Credit Card", creditCardPublicId, "MasterCard", "master_card");
            AddMetaData(context, "Credit Card", creditCardPublicId, "Visa", "visa");

            #endregion

            #region JobTitles
            var jobTitlesPublicId = AddMetaDataType(context, "JobTitles");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "General Manager", "general_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Software Developer", "software_developer");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Logo Support", "logo_support");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Department Chief", "department_chief");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Secretary", "secretary");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Administrative Manager", "administrative_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Service Manager", "service_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "IT Manager", "it_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Technical Service", "technical_service");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "It Specialist", "it_specialist");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Customer Representative", "customer_representative");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Accounting Personnel", "accounting_personnel");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Customer Services", "customer_services");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Project Manager", "project_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Sales Representative", "sales_representative");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Chief Executive Officer", "chief_executive_officer");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Call Center Operator", "call_center_operator");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Business Development Project Manager", "business_development_project_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Vice General Manager", "vice_general_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Purchasing Manager", "purchasing_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Manager", "manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Assistant Manager", "assistant_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Quality Management Specialist", "quality_management_specialist");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "System Manager", "system_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Accounting Manager", "accounting_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Quality Assurance Manager", "quality_assurance_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "IT Personnel", "it_personnel");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Quality System manager", "quality_system_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "General Secretary", "general_secretary");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Vice President Corporate Affairs", "vice_president_corporate_affairs");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "President Corporate Affairs", "president_corporate_affairs");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Rector", "rector");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Coordinator", "coordinator");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Operation Manager", "operation_manager");
            AddMetaData(context, "JobTitles", jobTitlesPublicId, "Administrator", "administrator");

            #endregion

            #region Sectors

            var sectorPublicId = AddMetaDataType(context, "Sectors");

            AddMetaData(context, "Sectors", sectorPublicId, "Fuel Oil", "fuel_oil");
            AddMetaData(context, "Sectors", sectorPublicId, "Packing", "Packing");
            AddMetaData(context, "Sectors", sectorPublicId, "Banking", "banking");
            AddMetaData(context, "Sectors", sectorPublicId, "Informatics", "informatics");
            AddMetaData(context, "Sectors", sectorPublicId, "Cement", "cement");
            AddMetaData(context, "Sectors", sectorPublicId, "Iron And Steel", "iron_and_steel");
            AddMetaData(context, "Sectors", sectorPublicId, "Pharmacy", "pharmacy");
            AddMetaData(context, "Sectors", sectorPublicId, "Electronics", "electronics");
            AddMetaData(context, "Sectors", sectorPublicId, "Electricity", "electricity");
            AddMetaData(context, "Sectors", sectorPublicId, "Food", "food");
            AddMetaData(context, "Sectors", sectorPublicId, "General", "general");
            AddMetaData(context, "Sectors", sectorPublicId, "Customs", "customs");
            AddMetaData(context, "Sectors", sectorPublicId, "Service", "service");
            AddMetaData(context, "Sectors", sectorPublicId, "Medicine", "medicine");
            AddMetaData(context, "Sectors", sectorPublicId, "Construction", "construction");
            AddMetaData(context, "Sectors", sectorPublicId, "Importation", "importation");
            AddMetaData(context, "Sectors", sectorPublicId, "Chemistry", "chemistry");
            AddMetaData(context, "Sectors", sectorPublicId, "Jeweler", "jeweler");
            AddMetaData(context, "Sectors", sectorPublicId, "Machine", "machine");
            AddMetaData(context, "Sectors", sectorPublicId, "Metal", "metal");
            AddMetaData(context, "Sectors", sectorPublicId, "Transportation", "transportation");
            AddMetaData(context, "Sectors", sectorPublicId, "Chambers", "chamber");
            AddMetaData(context, "Sectors", sectorPublicId, "Automotive", "automotive");
            AddMetaData(context, "Sectors", sectorPublicId, "Plastic", "plastic");
            AddMetaData(context, "Sectors", sectorPublicId, "Health", "health");
            AddMetaData(context, "Sectors", sectorPublicId, "Insurance", "insurance");
            AddMetaData(context, "Sectors", sectorPublicId, "Indepentet Accountent", "indepentet_accountent");
            AddMetaData(context, "Sectors", sectorPublicId, "Tourism", "tourism");
            AddMetaData(context, "Sectors", sectorPublicId, "Shipping", "shipping");
            AddMetaData(context, "Sectors", sectorPublicId, "Structure", "structure");

            #endregion

            #region Departments

            var departmentPublicId = AddMetaDataType(context, "Deparments");

            AddMetaData(context, "Departments", departmentPublicId, "General", "general");
            AddMetaData(context, "Departments", departmentPublicId, "Management", "management");
            AddMetaData(context, "Departments", departmentPublicId, "Technical Service", "technical_service");
            AddMetaData(context, "Departments", departmentPublicId, "Accounting", "accounting");
            AddMetaData(context, "Departments", departmentPublicId, "Software", "software");
            AddMetaData(context, "Departments", departmentPublicId, "Hardware", "hardware");
            AddMetaData(context, "Departments", departmentPublicId, "Logo Support", "logo_support");
            AddMetaData(context, "Departments", departmentPublicId, "Consultant", "consultant");
            AddMetaData(context, "Departments", departmentPublicId, "Sale", "sale");
            AddMetaData(context, "Departments", departmentPublicId, "Purchase", "purchase");
            AddMetaData(context, "Departments", departmentPublicId, "Information Technology", "information_technology");
            AddMetaData(context, "Departments", departmentPublicId, "Personnel Directorate", "personnel_directorate");
            AddMetaData(context, "Departments", departmentPublicId, "Account Executive", "account_executive");
            AddMetaData(context, "Departments", departmentPublicId, "Organization Management", "organization_management");
            AddMetaData(context, "Departments", departmentPublicId, "Shipment", "shipment");
            AddMetaData(context, "Departments", departmentPublicId, "Customer Services", "customer_services");
            AddMetaData(context, "Departments", departmentPublicId, "Insurance", "insurance");
            AddMetaData(context, "Departments", departmentPublicId, "Chancellery", "chancellery");
            AddMetaData(context, "Departments", departmentPublicId, "Marketing", "marketing");
            AddMetaData(context, "Departments", departmentPublicId, "Transportation", "transportation");
            AddMetaData(context, "Departments", departmentPublicId, "Human Resources", "human_resources");

            #endregion

            #region Currency

            var currencyPublicId = AddMetaDataType(context, "Currencies");

            AddMetaData(context, "Currency", currencyPublicId, "Afghan Afghani", "AFN");
            AddMetaData(context, "Currency", currencyPublicId, "Albanian Lek", "ALL");
            AddMetaData(context, "Currency", currencyPublicId, "Armenian Dram", "AMD");
            AddMetaData(context, "Currency", currencyPublicId, "Dutch Guilder", "ANG");
            AddMetaData(context, "Currency", currencyPublicId, "Angolan Kwanza", "AOA");
            AddMetaData(context, "Currency", currencyPublicId, "Argentine Peso", "ARS");
            AddMetaData(context, "Currency", currencyPublicId, "Australian Dollar", "AUD");
            AddMetaData(context, "Currency", currencyPublicId, "Aruban or Dutch Guilder", "AWG");
            AddMetaData(context, "Currency", currencyPublicId, "Azerbaijani New Manat", "AZN");
            AddMetaData(context, "Currency", currencyPublicId, "Bosnian Convertible Marka", "BAM");
            AddMetaData(context, "Currency", currencyPublicId, "Barbadian or Bajan Dollar", "BBD");
            AddMetaData(context, "Currency", currencyPublicId, "Bangladeshi Taka", "BDT");
            AddMetaData(context, "Currency", currencyPublicId, "Bulgarian Lev", "BGN");
            AddMetaData(context, "Currency", currencyPublicId, "Bahraini Dinar", "BHD");
            AddMetaData(context, "Currency", currencyPublicId, "Burundian Franc", "BIF");
            AddMetaData(context, "Currency", currencyPublicId, "Bermudian Dollar", "BMD");
            AddMetaData(context, "Currency", currencyPublicId, "Bruneian Dollar", "BND");
            AddMetaData(context, "Currency", currencyPublicId, "Bolivian Boliviano", "BOB");
            AddMetaData(context, "Currency", currencyPublicId, "Brazilian Real", "BRL");
            AddMetaData(context, "Currency", currencyPublicId, "Bahamian Dollar", "BSD");
            AddMetaData(context, "Currency", currencyPublicId, "Bhutanese Ngultrum", "BTN");
            AddMetaData(context, "Currency", currencyPublicId, "Botswana Pula", "BWP");
            AddMetaData(context, "Currency", currencyPublicId, "Belarusian Ruble", "BYR");
            AddMetaData(context, "Currency", currencyPublicId, "Belizean Dollar", "BZD");
            AddMetaData(context, "Currency", currencyPublicId, "Canadian Dollar", "CAD");
            AddMetaData(context, "Currency", currencyPublicId, "Congolese Franc", "CDF");
            AddMetaData(context, "Currency", currencyPublicId, "Swiss Franc", "CHF");
            AddMetaData(context, "Currency", currencyPublicId, "Chilean Peso", "CLP");
            AddMetaData(context, "Currency", currencyPublicId, "Chinese Yuan Renminbi", "CNY");
            AddMetaData(context, "Currency", currencyPublicId, "Colombian Peso", "COP");
            AddMetaData(context, "Currency", currencyPublicId, "Costa Rican Colon", "CRC");
            AddMetaData(context, "Currency", currencyPublicId, "Cuban Convertible Peso", "CUC");
            AddMetaData(context, "Currency", currencyPublicId, "Cuban Peso", "CUP");
            AddMetaData(context, "Currency", currencyPublicId, "Cape Verdean Escudo", "CVE");
            AddMetaData(context, "Currency", currencyPublicId, "Czech Koruna", "CZK");
            AddMetaData(context, "Currency", currencyPublicId, "Djiboutian Franc", "DJF");
            AddMetaData(context, "Currency", currencyPublicId, "Danish Krone", "DKK");
            AddMetaData(context, "Currency", currencyPublicId, "Dominican Peso", "DOP");
            AddMetaData(context, "Currency", currencyPublicId, "Algerian Dinar", "DZD");
            AddMetaData(context, "Currency", currencyPublicId, "Egyptian Pound", "EGP");
            AddMetaData(context, "Currency", currencyPublicId, "Eritrean Nakfa", "ERN");
            AddMetaData(context, "Currency", currencyPublicId, "Ethiopian Birr", "ETB");
            AddMetaData(context, "Currency", currencyPublicId, "Euro", "EUR ");
            AddMetaData(context, "Currency", currencyPublicId, "Fijian Dollar", "FJD");
            AddMetaData(context, "Currency", currencyPublicId, "Falkland Island Pound", "FKP");
            AddMetaData(context, "Currency", currencyPublicId, "British Pound", "GBP");
            AddMetaData(context, "Currency", currencyPublicId, "Georgian Lari", "GEL");
            AddMetaData(context, "Currency", currencyPublicId, "Guernsey Pound", "GGP");
            AddMetaData(context, "Currency", currencyPublicId, "Ghanaian Cedi", "GHS");
            AddMetaData(context, "Currency", currencyPublicId, "Gibraltar Pound", "GIP");
            AddMetaData(context, "Currency", currencyPublicId, "Gambian Dalasi", "GMD");
            AddMetaData(context, "Currency", currencyPublicId, "Guinean Franc", "GNF");
            AddMetaData(context, "Currency", currencyPublicId, "Guatemalan Quetzal", "GTQ");
            AddMetaData(context, "Currency", currencyPublicId, "Guyanese Dollar", "GYD");
            AddMetaData(context, "Currency", currencyPublicId, "Hong Kong Dollar", "HKD");
            AddMetaData(context, "Currency", currencyPublicId, "Honduran Lempira", "HNL");
            AddMetaData(context, "Currency", currencyPublicId, "Croatian Kuna", "HRK");
            AddMetaData(context, "Currency", currencyPublicId, "Haitian Gourde", "HTG");
            AddMetaData(context, "Currency", currencyPublicId, "Hungarian Forint", "HUF");
            AddMetaData(context, "Currency", currencyPublicId, "Indonesian Rupiah", "IDR");
            AddMetaData(context, "Currency", currencyPublicId, "Israeli Shekel", "ILS");
            AddMetaData(context, "Currency", currencyPublicId, "Isle of Man Pound", "IMP");
            AddMetaData(context, "Currency", currencyPublicId, "Indian Rupee", "INR");
            AddMetaData(context, "Currency", currencyPublicId, "Iraqi Dinar", "IQD");
            AddMetaData(context, "Currency", currencyPublicId, "Iranian Rial", "IRR");
            AddMetaData(context, "Currency", currencyPublicId, "Icelandic Krona", "ISK");
            AddMetaData(context, "Currency", currencyPublicId, "Jersey Pound", "JEP");
            AddMetaData(context, "Currency", currencyPublicId, "Jamaican Dollar", "JMD");
            AddMetaData(context, "Currency", currencyPublicId, "Jordanian Dinar", "JOD");
            AddMetaData(context, "Currency", currencyPublicId, "Japanese Yen", "JPY");
            AddMetaData(context, "Currency", currencyPublicId, "Kenyan Shilling", "KES");
            AddMetaData(context, "Currency", currencyPublicId, "Kyrgyzstani Som", "KGS");
            AddMetaData(context, "Currency", currencyPublicId, "Cambodian Riel", "KHR");
            AddMetaData(context, "Currency", currencyPublicId, "Comoran Franc", "KMF");
            AddMetaData(context, "Currency", currencyPublicId, "North Korean Won", "KPW");
            AddMetaData(context, "Currency", currencyPublicId, "South Korean Won", "KRW");
            AddMetaData(context, "Currency", currencyPublicId, "Kuwaiti Dinar", "KWD");
            AddMetaData(context, "Currency", currencyPublicId, "Caymanian Dollar", "KYD");
            AddMetaData(context, "Currency", currencyPublicId, "Kazakhstani Tenge", "KZT");
            AddMetaData(context, "Currency", currencyPublicId, "Lao or Laotian Kip", "LAK");
            AddMetaData(context, "Currency", currencyPublicId, "Lebanese Pound", "LBP");
            AddMetaData(context, "Currency", currencyPublicId, "Sri Lankan Rupee", "LKR");
            AddMetaData(context, "Currency", currencyPublicId, "Liberian Dollar", "LRD");
            AddMetaData(context, "Currency", currencyPublicId, "Basotho Loti", "LSL");
            AddMetaData(context, "Currency", currencyPublicId, "Lithuanian Litas", "LTL");
            AddMetaData(context, "Currency", currencyPublicId, "Latvian Lat", "LVL");
            AddMetaData(context, "Currency", currencyPublicId, "Libyan Dinar", "LYD");
            AddMetaData(context, "Currency", currencyPublicId, "Moroccan Dirham", "MAD");
            AddMetaData(context, "Currency", currencyPublicId, "Moldovan Leu", "MDL");
            AddMetaData(context, "Currency", currencyPublicId, "Malagasy Ariary", "MGA");
            AddMetaData(context, "Currency", currencyPublicId, "Macedonian Denar", "MKD");
            AddMetaData(context, "Currency", currencyPublicId, "Burmese Kyat", "MMK");
            AddMetaData(context, "Currency", currencyPublicId, "Mongolian Tughrik", "MNT");
            AddMetaData(context, "Currency", currencyPublicId, "Macau Pataca", "MOP");
            AddMetaData(context, "Currency", currencyPublicId, "Mauritanian Ouguiya", "MRO");
            AddMetaData(context, "Currency", currencyPublicId, "Mauritian Rupee", "MUR");
            AddMetaData(context, "Currency", currencyPublicId, "Maldivian Rufiyaa", "MVR");
            AddMetaData(context, "Currency", currencyPublicId, "Malawian Kwacha", "MWK");
            AddMetaData(context, "Currency", currencyPublicId, "Mexican Peso", "MXN");
            AddMetaData(context, "Currency", currencyPublicId, "Malaysian Ringgit", "MYR");
            AddMetaData(context, "Currency", currencyPublicId, "Mozambican Metical", "MZN");
            AddMetaData(context, "Currency", currencyPublicId, "Namibian Dollar", "NAD");
            AddMetaData(context, "Currency", currencyPublicId, "Nigerian Naira", "NGN");
            AddMetaData(context, "Currency", currencyPublicId, "Nicaraguan Cordoba", "NIO");
            AddMetaData(context, "Currency", currencyPublicId, "Norwegian Krone", "NOK");
            AddMetaData(context, "Currency", currencyPublicId, "Nepalese Rupee", "NPR");
            AddMetaData(context, "Currency", currencyPublicId, "New Zealand Dollar", "NZD");
            AddMetaData(context, "Currency", currencyPublicId, "Omani Rial", "OMR");
            AddMetaData(context, "Currency", currencyPublicId, "Panamanian Balboa", "PAB");
            AddMetaData(context, "Currency", currencyPublicId, "Peruvian Nuevo Sol", "PEN");
            AddMetaData(context, "Currency", currencyPublicId, "Papua New Guinean Kina", "PGK");
            AddMetaData(context, "Currency", currencyPublicId, "Philippine Peso", "PHP");
            AddMetaData(context, "Currency", currencyPublicId, "Pakistani Rupee", "PKR");
            AddMetaData(context, "Currency", currencyPublicId, "Polish Zloty", "PLN");
            AddMetaData(context, "Currency", currencyPublicId, "Paraguayan Guarani", "PYG");
            AddMetaData(context, "Currency", currencyPublicId, "Qatari Riyal", "QAR");
            AddMetaData(context, "Currency", currencyPublicId, "Romanian New Leu", "RON");
            AddMetaData(context, "Currency", currencyPublicId, "Serbian Dinar", "RSD");
            AddMetaData(context, "Currency", currencyPublicId, "Russian Ruble", "RUB");
            AddMetaData(context, "Currency", currencyPublicId, "Rwandan Franc", "RWF");
            AddMetaData(context, "Currency", currencyPublicId, "Saudi Arabian Riyal", "SAR");
            AddMetaData(context, "Currency", currencyPublicId, "Solomon Islander Dollar", "SBD");
            AddMetaData(context, "Currency", currencyPublicId, "Seychellois Rupee", "SCR");
            AddMetaData(context, "Currency", currencyPublicId, "Sudanese Pound", "SDG");
            AddMetaData(context, "Currency", currencyPublicId, "Swedish Krona", "SEK");
            AddMetaData(context, "Currency", currencyPublicId, "Singapore Dollar", "SGD");
            AddMetaData(context, "Currency", currencyPublicId, "Saint Helenian Pound", "SHP");
            AddMetaData(context, "Currency", currencyPublicId, "Sierra Leonean Leone", "SLL");
            AddMetaData(context, "Currency", currencyPublicId, "Somali Shilling", "SOS");
            AddMetaData(context, "Currency", currencyPublicId, "Seborgan Luigino", "SPL");
            AddMetaData(context, "Currency", currencyPublicId, "Surinamese Dollar", "SRD");
            AddMetaData(context, "Currency", currencyPublicId, "Sao Tomean Dobra", "STD");
            AddMetaData(context, "Currency", currencyPublicId, "Salvadoran Colon", "SVC");
            AddMetaData(context, "Currency", currencyPublicId, "Syrian Pound", "SYP");
            AddMetaData(context, "Currency", currencyPublicId, "Swazi Lilangeni", "SZL");
            AddMetaData(context, "Currency", currencyPublicId, "Thai Baht", "THB");
            AddMetaData(context, "Currency", currencyPublicId, "Tajikistani Somoni", "TJS");
            AddMetaData(context, "Currency", currencyPublicId, "Turkmenistani Manat", "TMT");
            AddMetaData(context, "Currency", currencyPublicId, "Tunisian Dinar", "TND");
            AddMetaData(context, "Currency", currencyPublicId, "Tongan Pa'anga", "TOP");
            AddMetaData(context, "Currency", currencyPublicId, "Turkish Lira", "TRY");
            AddMetaData(context, "Currency", currencyPublicId, "Trinidadian Dollar", "TTD");
            AddMetaData(context, "Currency", currencyPublicId, "Tuvaluan Dollar", "TVD");
            AddMetaData(context, "Currency", currencyPublicId, "Taiwan New Dollar", "TWD");
            AddMetaData(context, "Currency", currencyPublicId, "Tanzanian Shilling", "TZS");
            AddMetaData(context, "Currency", currencyPublicId, "Ukrainian Hryvna", "UAH");
            AddMetaData(context, "Currency", currencyPublicId, "Ugandan Shilling", "UGX");
            AddMetaData(context, "Currency", currencyPublicId, "US Dollar", "USD");
            AddMetaData(context, "Currency", currencyPublicId, "Uruguayan Peso", "UYU");
            AddMetaData(context, "Currency", currencyPublicId, "Uzbekistani Som", "UZS");
            AddMetaData(context, "Currency", currencyPublicId, "Venezuelan Bolivar", "VEF");
            AddMetaData(context, "Currency", currencyPublicId, "Vietnamese Dong", "VND");
            AddMetaData(context, "Currency", currencyPublicId, "Ni-Vanuatu Vatu", "VUV");
            AddMetaData(context, "Currency", currencyPublicId, "Samoan Tala", "WST");
            AddMetaData(context, "Currency", currencyPublicId, "Central African CFA Franc BEAC", "XAF");
            AddMetaData(context, "Currency", currencyPublicId, "Silver Ounce", "XAG");
            AddMetaData(context, "Currency", currencyPublicId, "Gold Ounce", "XAU");
            AddMetaData(context, "Currency", currencyPublicId, "Bitcoin", "XBT");
            AddMetaData(context, "Currency", currencyPublicId, "East Caribbean Dollar", "XCD");
            AddMetaData(context, "Currency", currencyPublicId, "IMF Special Drawing Rights", "XDR");
            AddMetaData(context, "Currency", currencyPublicId, "CFA Franc", "XOF");
            AddMetaData(context, "Currency", currencyPublicId, "Palladium Ounce", "XPD");
            AddMetaData(context, "Currency", currencyPublicId, "CFP Franc", "XPF");
            AddMetaData(context, "Currency", currencyPublicId, "Platinum Ounce", "XPT");
            AddMetaData(context, "Currency", currencyPublicId, "Yemeni Rial", "YER");
            AddMetaData(context, "Currency", currencyPublicId, "South African Rand", "ZAR");
            AddMetaData(context, "Currency", currencyPublicId, "Zambian Kwacha", "ZMW");
            AddMetaData(context, "Currency", currencyPublicId, "Zimbabwean Dollar", "ZWD ");

            #endregion

            #region Measurement Units

            #region Stress and Pressure

            var stressAndPressurePublicId = AddMetaDataType(context, "Stress and Pressure");

            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Hectopascal", "hPa");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Kilonewton per square meter", "kN/m²");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Kilopascal", "kPa");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Kilogram per square centimeter", "kgf/cm²");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Kilogram per square meter", "kgf/m²");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "physical atmosphere", "atm");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Planck pressure", "L¯¹MT¯²");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Meganewton per square meter", "MN/m²");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Megapascal", "Mpa");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Newton per square centimeter", "N/cm²");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Newton per square meter", "N/m²");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Newton per square millimeter", "N/mm²");
            AddMetaData(context, "Stress and Pressure", stressAndPressurePublicId, "Pascal", "Pa");

            #endregion

            #region Acceleration

            var accelerationPublicId = AddMetaDataType(context, "Acceleration");

            AddMetaData(context, "Acceleration", accelerationPublicId, "Foot per second squared", "ft/s²");
            AddMetaData(context, "Acceleration", accelerationPublicId, "Galileo", "Gal");
            AddMetaData(context, "Acceleration", accelerationPublicId, "meter per second squared", "m/s²");
            AddMetaData(context, "Acceleration", accelerationPublicId, "Millimeter per second squared", "mm/s²");
            AddMetaData(context, "Acceleration", accelerationPublicId, "Kilometer per second squared", "km/s²");
            AddMetaData(context, "Acceleration", accelerationPublicId, "Standard acceleration of free fall on Earth", "gn index");
            AddMetaData(context, "Acceleration", accelerationPublicId, "Inch per second squared", "in/s²");

            #endregion

            #region Area

            var areaPublicId = AddMetaDataType(context, "Area");

            AddMetaData(context, "Area", areaPublicId, "Are", "a");
            AddMetaData(context, "Area", areaPublicId, "Barn", "b");
            AddMetaData(context, "Area", areaPublicId, "Square centimeter", "cm²");
            AddMetaData(context, "Area", areaPublicId, "Square decimeter", "dm²");
            AddMetaData(context, "Area", areaPublicId, "Square foot", "ft²");
            AddMetaData(context, "Area", areaPublicId, "Square inch", "in²");
            AddMetaData(context, "Area", areaPublicId, "Square kilometer", "km²");
            AddMetaData(context, "Area", areaPublicId, "Planck area", "L²");
            AddMetaData(context, "Area", areaPublicId, "Square meter", "m²");
            AddMetaData(context, "Area", areaPublicId, "Square millimeter", "mm²");

            #endregion

            #region Capacity and volume

            var capacityAndVolumePublicId = AddMetaDataType(context, "Capacity and volume");

            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Barrel", "bbl");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Bushel", "bu");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Cubic centimeter", "cc");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "centiliter", "cl");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Cubic decimeter", "dm³");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Cubic foot", "ft³");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Cubic inch ", "in³");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Cubic kilometer", "km³");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Cubic meter ", "m³");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Cubic millimeter", "mm³");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Cubic yard", "yd³");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Deciliter", "dl");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Fluid ounce", "oz");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Gallon", "gal");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Hectoliter", "hl");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Planck volume", "L³");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Liter", "l");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Microliter ", "µl");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Milliliter", "ml");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Peck", "pk");
            AddMetaData(context, "Capacity and volume", capacityAndVolumePublicId, "Quart", "qt");

            #endregion

            #region Circular measure

            var circularMeasurePublicId = AddMetaDataType(context, "Circular measure");

            AddMetaData(context, "Circular measure", circularMeasurePublicId, "circumference", "circle");
            AddMetaData(context, "Circular measure", circularMeasurePublicId, "Degree", "deg");
            AddMetaData(context, "Circular measure", circularMeasurePublicId, "Grade", "grad");
            AddMetaData(context, "Circular measure", circularMeasurePublicId, "Radian", "rad");

            #endregion

            #region Computer Storage

            var computerStoragePublicId = AddMetaDataType(context, "Computer Storage");

            AddMetaData(context, "Computer Storage", computerStoragePublicId, "Exbibyte [exabyte]", "Eb [EiB]");
            AddMetaData(context, "Computer Storage", computerStoragePublicId, "Exabit [exbibit]", "Ebit [Eibit]");
            AddMetaData(context, "Computer storage", computerStoragePublicId, "Gigabyte [gibibyte]", "Gb [GiB]");
            AddMetaData(context, "Computer storage", computerStoragePublicId, " Gigabit [gibibit]", "Gbit [Gibit]");
            AddMetaData(context, "Computer Storage", computerStoragePublicId, "megabyte [mebibyte]", "Mb [MiB] ");
            AddMetaData(context, "Computer Storage", computerStoragePublicId, "megabit [mebibit]", "Mbit [Mibit]");
            AddMetaData(context, "Computer Storage", computerStoragePublicId, "Storage length in meters", "m");
            AddMetaData(context, "computer Storage", computerStoragePublicId, "Terabit [tebibit] ", "Tbit [Tibit]");
            AddMetaData(context, "Computer Storage", computerStoragePublicId, "Terabyte [tebibyte] ", "Tb [TiB]");
            AddMetaData(context, "Computer storage", computerStoragePublicId, "Kilobyte [kibybyte]", "Kb [KiB]");
            AddMetaData(context, "Computer storage", computerStoragePublicId, "Kilobit [kibibit]", "Kbit [Kibit]");

            #endregion

            #region Data transfer rate

            var dataTransferRatePublicId = AddMetaDataType(context, "Data transfer rate");

            AddMetaData(context, "Data transfer rate", dataTransferRatePublicId, "byte per second", "B/s ");
            AddMetaData(context, "Data transfer rate", dataTransferRatePublicId, "Gigabyte per second", "GB/s");
            AddMetaData(context, "Data transfer rate", dataTransferRatePublicId, "Gigabit per second", "Gbps");
            AddMetaData(context, "Data transfer rate", dataTransferRatePublicId, "Kilobyte per second", "KB/s");
            AddMetaData(context, "Data transfer rate", dataTransferRatePublicId, "Megabyte per second", "MB/s");
            AddMetaData(context, "Data transfer rate", dataTransferRatePublicId, "megabit per second", "Mbps");
            AddMetaData(context, "Data transfer rate", dataTransferRatePublicId, "Terabyte per second", "TB/s");
            AddMetaData(context, "Data transfer rate", dataTransferRatePublicId, "Terabit per second (Tbps)", "Tbps");
            AddMetaData(context, "Data transfer rate", dataTransferRatePublicId, "bit per second", "bps");
            AddMetaData(context, "Data transfer rate", dataTransferRatePublicId, "Kilobit per second", "kbps");

            #endregion

            #region Density

            var densityPublicId = AddMetaDataType(context, "Density");

            AddMetaData(context, "Density", densityPublicId, "Planck density", "L¯³M ");
            AddMetaData(context, "Density", densityPublicId, "Pound per cubic foot", "lb/ft³");
            AddMetaData(context, "Density", densityPublicId, "Pound per U.S. gallon", "lb/gal");
            AddMetaData(context, "Density", densityPublicId, "Pound per cubic inch", "lb/in³");
            AddMetaData(context, "Density", densityPublicId, "Pound per cubic yard", "lb/yd³");
            AddMetaData(context, "Density", densityPublicId, "Milligram per cubic meter", "mg/m³");
            AddMetaData(context, "Density", densityPublicId, "Ounce per cubic foot ", "oz/ft³");
            AddMetaData(context, "Density", densityPublicId, "Ounce per cubic inch ", "oz/in³");
            AddMetaData(context, "Density", densityPublicId, "Ounce per cubic yard ", "oz/yd³");
            AddMetaData(context, "Density", densityPublicId, "Gram per litre", "g/L");
            AddMetaData(context, "Density", densityPublicId, " Gram per cubic meter", "g/m³");
            AddMetaData(context, "Density", densityPublicId, "Kilogram per litre", "kg/L");
            AddMetaData(context, "Density", densityPublicId, "Kilogram per cubic meter", "kg/m³");
            AddMetaData(context, "Density", densityPublicId, " Gram per millilitre", "g/mL");

            #endregion

            #region Distance and Length

            var distanceAndLenghtPublicId = AddMetaDataType(context, "Distance and Length");

            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "astronomical unit", "au");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Cable length", "cbl");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Gunter's (surveyors') chain", "ch");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Ramsden's (engineers') chain", "ch");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Centimeter", "cm");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Cubit", "cu");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Decimeter", "dm");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Fathom", "fath");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Foot", "ft");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Horizontal pitch", "HP");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Hand", "hd");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Horizontal pitch", "HP");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Inch", "in");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Kilometer", "km");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Planck length", "L");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "meter", "m");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Mile", "mi");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Millimeter", "mm");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Nanometer", "nm");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Palm", "plm");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Parsec", "pc");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Point", "pt");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Pixel", "px");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Rod", "rd");
            AddMetaData(context, "Distance and Length", distanceAndLenghtPublicId, "Yard", "yd");

            #endregion

            #region Energy and Work

            var energyAndWorkPublicId = AddMetaDataType(context, "Energy and Work");

            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "billion barrel of oil equivalent", "BBOE");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "barrel of oil equivalent", "BOE");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "British Thermal Unit", "BTU");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Calorie", "cal");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Electronvolt", "eV");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Foot-Pound", "ft*lbs");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Gigatonne of oil equivalent", "Gtoe");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Joule", "J");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Kilobarrel of oil equivalent", "kBOE");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Kilojoule", "kJ");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Kilowatt hour", "kW*h");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Kilocalorie", "kcal");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Planck energy", "L²MT¯²");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Megajoule", "MJ");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Million BTU", "MMBTU");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "megacalorie", "Mcal");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "megatonne of oil equivalent", "Mtoe");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Metre-kilogram", "mkg");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Watt hour", "W*h");
            AddMetaData(context, "Energy and Work", energyAndWorkPublicId, "Watt second", "W*s");

            #endregion

            #region Flow rate by mass

            var flowRateByMassPublicId = AddMetaDataType(context, "Flow rate by mass");

            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Gram per day", "g/day");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Gram per hour", "g/hour");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Kilogram per day", "kg/day");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Kilogram per hour", "kg/hour");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Kilogram per minute", "kg/min");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Kilogram per second", "kg/s");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Kilogram per year", "kg/year");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Pound per day", "lb/day");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Pound per second", "lb/s");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Pound per minute", "lb/min");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Pound per hour", "lb/hour");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, " Gram per minute", "g/min");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Gram per second", "g/s");
            AddMetaData(context, "Flow rate by mass", flowRateByMassPublicId, "Gram per year", "g/year");

            #endregion

            #region Flow rate by volume

            var flowRateByVolumePublicId = AddMetaDataType(context, "Flow rate by volume");

            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic foot per second", "ft³/s");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic foot per minute", "ft³/min");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic foot per hour", "ft³/hour");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic foot per day", "ft³/day");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic foot per year", "ft³/year");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic inch per second", "in³/s");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic inch per minute", "in³/min");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic inch per hour", "in³/hour");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic inch per day", "in³/day");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic inch per year", "in³/year");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic meter per second", "m³/s");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic meter per minute", "m³/min");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic meter per hour", "m³/hour");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic meter per day", "m³/day");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Cubic meter per year", "m³/year");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "U.S. gallon per day", "gal/day");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "U.S. gallon per year", "gal/year");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "U.S. gallon per hour", "gph");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "U.S. gallon per minute", "gpm");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "U.S. gallon per second", "gps");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Liter per day", "l/day");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Liter per hour", "l/hour");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Liter per minute", "l/min");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Liter per second", "l/s");
            AddMetaData(context, "Flow rate by volume", flowRateByVolumePublicId, "Liter per year", "l/year");

            #endregion

            #region Force

            var forcePublicId = AddMetaDataType(context, "Force");

            AddMetaData(context, "Force", forcePublicId, "Dyne", "dyn");
            AddMetaData(context, "Force", forcePublicId, "Grave-force", "Gf");
            AddMetaData(context, "Force", forcePublicId, "Kilonewton", "kN");
            AddMetaData(context, "Force", forcePublicId, "Kilogram-force", "kgf");
            AddMetaData(context, "Force", forcePublicId, "Kilopond", "kp");
            AddMetaData(context, "Force", forcePublicId, "Planck force", "LMT²");
            AddMetaData(context, "Force", forcePublicId, "Pound-force", "lbf");
            AddMetaData(context, "Force", forcePublicId, "Meganewton", "MN");
            AddMetaData(context, "Force", forcePublicId, "Milligrave-force", "mGf");
            AddMetaData(context, "Force", forcePublicId, "Millinewton", "mN");
            AddMetaData(context, "Force", forcePublicId, "Micronewton ", "µN");
            AddMetaData(context, "Force", forcePublicId, "Newton", "N");

            #endregion

            #region Franctions and Percent

            var franctionsAndPercentPublicId = AddMetaDataType(context, "Franctions and Percent");

            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Atto", "a");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Centil", "c");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Deci", "d");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Deka", "da");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Exa", "E");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Femto", "f");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Hecto", "h");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Half", "½");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Kilo", "k");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Mega", "M");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "milli", "m");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Micro", "µ; mc");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Micromole ", "µmol");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Millimole", "mmol");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Mole", "mol");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Nano", "n");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Tera", "T");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Permille", "‰");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Yotta", "Y");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Zetta", "Z");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Percent", "%");
            AddMetaData(context, "Franctions and Percent", franctionsAndPercentPublicId, "Giga", "g");

            #endregion

            #region Mass and weight

            var massAndWeightPublicId = AddMetaDataType(context, "Mass and weight");

            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Carat", "ct");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Dram", "dr");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Pennyweight", "dwt");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Gram", "g");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Grain", "gr");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Kilogram", "kg");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Pound", "lb");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Planck mass", "M");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Microgram", "mcg");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Milligram", "mg");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "Ounce ", "oz");
            AddMetaData(context, "Mass and weight", massAndWeightPublicId, "atomic mass unit", "amu");

            #endregion

            #region Power

            var powerPublicId = AddMetaDataType(context, "Power");

            AddMetaData(context, "Power", powerPublicId, "Foot pound-force per second", "ft*lbf/s");
            AddMetaData(context, "Power", powerPublicId, "Horsepower, electric", "hp(E)");
            AddMetaData(context, "Power", powerPublicId, "Horsepower, mechanical (imperial)", "hp(I) ");
            AddMetaData(context, "Power", powerPublicId, "Horsepower, metric", "hp(M)");
            AddMetaData(context, "Power", powerPublicId, "Horsepower, boiler", "hp(S)");
            AddMetaData(context, "Power", powerPublicId, "Kilowatt", "kW");
            AddMetaData(context, "Power", powerPublicId, "Planck power", "L²MT¯³");
            AddMetaData(context, "Power", powerPublicId, "Megawatt", "MW");
            AddMetaData(context, "Power", powerPublicId, "Volt-ampere", "VA");
            AddMetaData(context, "Power", powerPublicId, "Watt", "W");

            #endregion

            #region Radiation

            var radiationPublicId = AddMetaDataType(context, "Radiation");

            AddMetaData(context, "Radiation", radiationPublicId, "Centigrey", "cGy");
            AddMetaData(context, "Radiation", radiationPublicId, "Gray", "Gy");
            AddMetaData(context, "Radiation", radiationPublicId, "Milligray", "mGy");
            AddMetaData(context, "Radiation", radiationPublicId, "Milliroentgen", "mR");
            AddMetaData(context, "Radiation", radiationPublicId, "Millisievert", "mSv");
            AddMetaData(context, "Radiation", radiationPublicId, "Microgray ", "µGy");
            AddMetaData(context, "Radiation", radiationPublicId, "Microroentgen ", "µR");
            AddMetaData(context, "Radiation", radiationPublicId, "Microsievert ", "µSv");

            #endregion

            #region Radioactivity

            var radioActivityPublicId = AddMetaDataType(context, "Radioactivity");

            AddMetaData(context, "Radioactivity", radioActivityPublicId, "Becquerel ", "Bq");
            AddMetaData(context, "Radioactivity", radioActivityPublicId, "Curie", "Ci");
            AddMetaData(context, "Radioactivity", radioActivityPublicId, "Disintegrations per minute", "dpm");
            AddMetaData(context, "Radioactivity", radioActivityPublicId, "Gigabecquerel", "GBq");
            AddMetaData(context, "Radioactivity", radioActivityPublicId, "Kilobecquerel", "kBq");
            AddMetaData(context, "Radioactivity", radioActivityPublicId, "Megabecquerel", "MBq");
            AddMetaData(context, "Radioactivity", radioActivityPublicId, "Millicurie", "mCi");
            AddMetaData(context, "Radioactivity", radioActivityPublicId, "Microcurie", "µCi");

            #endregion

            #region Speed

            var speedPublicId = AddMetaDataType(context, "Speed");

            AddMetaData(context, "Speed", speedPublicId, "Kilometer per second", "km/s");
            AddMetaData(context, "Speed", speedPublicId, "meter per second", "m/s");
            AddMetaData(context, "Speed", speedPublicId, "Mile per hour ", "mph");
            AddMetaData(context, "Speed", speedPublicId, "Mile per hour ", "mph");

            #endregion

            #region Temperature

            var temperaturePublicId = AddMetaDataType(context, "Temperature");

            AddMetaData(context, "Temperature", temperaturePublicId, "degrees Celsius ", "°C ");
            AddMetaData(context, "Temperature", temperaturePublicId, "degrees Delisle ", "°D ");
            AddMetaData(context, "Temperature", temperaturePublicId, "degrees Fahrenheit ", "°F ");
            AddMetaData(context, "Temperature", temperaturePublicId, "degrees Newton ", "°N ");
            AddMetaData(context, "Temperature", temperaturePublicId, "degrees Rømer ", "°R ");
            AddMetaData(context, "Temperature", temperaturePublicId, "degrees Rankine ", "°RØ");
            AddMetaData(context, "Temperature", temperaturePublicId, "degrees Reaumur", "°Re ");
            AddMetaData(context, "Temperature", temperaturePublicId, "Kelvin", "K");

            #endregion

            #region Time

            var timePublicId = AddMetaDataType(context, "Time");

            AddMetaData(context, "Time", timePublicId, "Minute", "min");
            AddMetaData(context, "Time", timePublicId, "Second", "s");
            AddMetaData(context, "Time", timePublicId, "Planck time", "T");

            #endregion

            #endregion

            #region Continents

            var continentsPublicId = AddMetaDataType(context, "Continents");
            var asiaPublicId = AddMetaData(context, "Continents", continentsPublicId, "Asia", "1");
            var africaPublicId = AddMetaData(context, "Continents", continentsPublicId, "Africa", "2");
            var antarcticaPublicId = AddMetaData(context, "Continents", continentsPublicId, "Antarctica", "3");
            var europePublicId = AddMetaData(context, "Continents", continentsPublicId, "Europe", "4");
            var oceaniaPublicId = AddMetaData(context, "Continents", continentsPublicId, "Oceania", "5");
            var northAmericaPublicId = AddMetaData(context, "Continents", continentsPublicId, "North America", "6");
            var southAmericaPublicId = AddMetaData(context, "Continents", continentsPublicId, "South America", "7");

            #endregion

            #region Countries

            var countryPublicId = AddMetaDataType(context, "Countries");
            AddMetaData(context, "Countries", countryPublicId, "Afghanistan", "AF", "+93", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Afghanistan", "AF", "+93", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Albania", "AL", "+355", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Algeria", "DZ", "+213", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "American Samoa", "AS", "+1684", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Andorra", "AD", "+376", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Angola", "AO", "+244", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Anguilla", "AI", "+1264", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Antigua and Barbuda", "AG", "+1268", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Argentina", "AR", "+54", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Armenia", "AM", "+374", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Aruba", "AW", "+297", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Australia", "AU", "+61", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Austria", "AT", "+43", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Azerbaijan", "AZ", "+994", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Bahamas", "BS", "+1242", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Bahrain", "BH", "+973", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Bangladesh", "BD", "+880", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Barbados", "BB", "+1246", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Belarus", "BY", "+375", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Belgium", "BE", "+32", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Belize", "BZ", "+501", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Benin", "BJ", "+229", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Bermuda", "BM", "+1 441", "North America", northAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Bhutan", "BT", " +975", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Bolivia", "BO", "+591", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Bosnia and Herzegovina", "BA", "+387", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Botswana", "BW", "+267", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Brazil", "BR", "+55", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Brunei", "BN", "+673", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Bulgaria", "BG", "+359", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Burkina Faso", "BF", "+226", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Burundi", "BI", "+257", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Cambodia", "KH", "+855", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Cameroon", "CM", "+237", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Canada", "CA", "+1", "North America", northAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Cape Verde", "CV", "+238", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Cayman Islands", "CJ", "+1345", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Central African Republic", "CF", "+236", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Chad", "TD", "+235", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Chile", "CL", "+56", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "China", "CN", "+86", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Colombia", "CO", "+57", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Comoros", "KM", "+269", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Democratic Republic of the Congo", "CD", "+243", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Republic of the Congo", "CG", "+242", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Costa Rica", "CR", "+506", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Ivory Coast", "CI", "+225", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Croatia", "HR", "+385", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Cuba", "CU", "+53", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Cyprus", "CY", "+357", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Czech Republic ", "CZ", "+420", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Denmark", "DK", "+45", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Djibouti", "DJ", "+253", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Dominica", "DM", "+1 767", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Dominican Republic", "DO", "+1 809, or 829, 849", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "East Timor", "TL", "+670", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Ecuador", "EC", "+593", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Egypt", "EG", "+20", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "El Salvador", "SV", "+503", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Equatorial Guinea", "GQ", "+240", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Eritrea", "ER", "+291", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Estonia", "EE", "+372", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Ethiopia", "ET", "+251", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Faroe Islands", "FO", "+298", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Fiji", "FJ", "+679", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Finland", "FI", "+358", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "France", "FR", "+33", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "French Guiana", "GF", "+594", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "French Polynesia", "PF", "+689", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Gabon", "GA", "+241", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Gambia", "GM", "+220", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Georgia", "GE", "+995", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Germany", "DE", "+49", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Ghana", "GH", "+233", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Great Britain", "GB", "+44", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Greece", "GR", "+30", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Greenland", "GL", "+299", "North America", northAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Grenada", "GD", "+1 473", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Guadeloupe", "GP", "+590", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Guam", "GU", "+1 671", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Guatemala", "GT", "+502", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Guinea", "GN", "+224", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Guinea-Bissau", "GW", "+245", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Guyana", "GY", "+592", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Haiti", "HT", "+509", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Vatican City State", "VA", "+379", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Honduras", "HN", " +504", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Hong Kong", "HK", "+852", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Hungary", "HU", "+36", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Iceland", "IS", "+354", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "India", "IN", "+91", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Indonesia", "ID", "+62", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Iran", "IR", "+98", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Iraq", "IQ", "+964", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Ireland", "IE", "+353", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Israel", "IL", "+972", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Italy", "IT", "+39", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Jamaica", "JM", "+1 876", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Japan", "JP", "+81", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Jordan", "JO", "+962", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Kazakhstan", "KZ", "+7", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Kenya", "KE", "+254", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Kiribati", "KI", "+686", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "North Korea", "KP", "+850", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "South Korea", "KR", "+82", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Kosovo", "KV", "+381", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Kuwait", "KW", "+965", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Kyrgyzstan", "KG", "+996", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Lao", "LS", "+856", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Latvia", "LV", "+371", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Lebanon", "LB", "+961", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Lesotho", "LS", "+266", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Liberia", "LR", "+231", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Libya", "LY", "+218", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Liechtenstein", "LI", "+423", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Lithuania", "LT", "+370", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Luxembourg", "LU", "+352", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Macau", "MO", "+853", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Republic of Macedonia", "MK", "+389", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Madagascar", "MG", "+261", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Malawi", "MW", "+265", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Malaysia", "MY", "+60", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Maldives", "MV", " +960", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Mali", "ML", "+223", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Malta", "MT", "+356", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Marshall Islands", "MH", "+692", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Martinique", "MQ", "+596", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Mauritania", "MR", "+222", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Mauritius", "MU", "+230", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Mexico", "MX", "+52", "North America", northAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Federated States of Micronesia", "FM", "+691", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Moldova", "MD", "+373", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Monaco", "MC", "+377", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Mongolia", "MN", "+976", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Montenegro", "ME", "+382", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Montserrat", "MS", " +1 664", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Morocco", "MA", "+212", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Mozambique", "MZ", "+258", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Myanmar - Burma", "MM", "+95", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Namibia", "NA", "+264", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Nauru", "NR", "+674", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Nepal", "NP", "+977", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Netherlands", "NL", "+31", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Netherlands Antilles", "AN", "+599", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "New Caledonia", "NC", "+687", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "New Zealand", "NZ", "+64", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Nicaragua", "NI", "+505", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Niger", "NE", "+227", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Nigeria", "NG", "+234", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Northern Mariana Islands", "MP", "+1 670", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Norway", "NO", "+47", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Oman", "OM", "+968", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Pakistan", "PK", "+92", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Palau", "PW", "+680", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Palestinian territories", "PS", "+970", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Panama", "PA", "+507", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Papua New Guinea", "PG", "+675", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Paraguay", "PY", "+595", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Peru", "PE", "+51", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Philippines", "PH", "+63", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Pitcairn Islands", "PN", "+870", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Poland", "PL", "+48", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Portugal", "PT", "+351", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Puerto Rico", "PR", "+1 787 or +1 939", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Qatar", "QA", "+974", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Reunion Island", "RE", "+262", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Romania", "RO", "+40", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Russian Federation", "RU", "+7", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Rwanda", "RW", "+250", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Saint Kitts and Nevis", "KN", "+1 869", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Saint Lucia", "LC", "+1 758", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Saint Vincent and the Grenadines", "VC", "+1 784", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Samoa", "WS", "+685", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "San Marino", "SM", " +378", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Sao Tome and Principe", "ST", "+239", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Saudi Arabia", "SA", "+966", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Senegal", "SN", "+221", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Serbia", "RS", "+381", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Seychelles", "SC", "+248", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Sierra Leone", "SL", "+232", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Singapore", "SG", "+65", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Slovakia", "SK", "+421", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Slovenia", "SI", "+386", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Solomon Islands", "SB", "+677", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Somalia", "SO", "+252", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "South Africa", "ZA", "+27", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "South Sudan", "SS", "+211", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Spain", "ES", "+34", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Sri Lanka", "LK", "+94", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Sudan", "SD", "+249", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Suriname", "SR", " +597", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Swaziland", "SZ", " +268", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Sweden", "SE", "+46", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Switzerland", "CH", "+41", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Taiwan", "TW", "+886", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Tajikistan", "TJ", "+922", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "United Republic of Tanzania", "TZ", "+255", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Thailand", "TH", " +66", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Tibet", "TI", "+0086", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Timor-Leste", "TL", "+670", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Togo", "TG", "+228", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Tokelau", "TK", "+690", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Tonga", "TO", "+676", " Oceania");
            AddMetaData(context, "Countries", countryPublicId, "Trinidad and Tobago", "TT", "+1 868", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Tunisia", "TN", "+216", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Turkey", "TR", "+90", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "Turkmenistan", "TM", "+993", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Tuvalu", "TV", "+688", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Uganda", "UG", "+256", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Ukraine", "UA", "+380", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "United Arab Emirates", "AE", "+971", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "United Kingdom", "GB", "+44", "Europe", europePublicId);
            AddMetaData(context, "Countries", countryPublicId, "United States", "US", "+1", "North America", northAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Uruguay", "UY", "+598", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Uzbekistan", "UZ", "+998", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Vanuatu", "VU", "+678", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Venezuela", "VE", "+58", "South America", southAmericaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Vietnam", "VN", "+84", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "British Virgin Islands", "VG", "+1 284", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "US Virgin Islands", "VI", "+1 340", "Oceania", oceaniaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Yemen", "YE", "+967", "Asia", asiaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Zambia", "ZM", "+260", "Africa", africaPublicId);
            AddMetaData(context, "Countries", countryPublicId, "Zimbabwe", "ZW", "+263", "Africa", africaPublicId);

            #endregion

            #region Universities

            var universityPublicId = AddMetaDataType(context, "Universities");

            AddMetaData(context, "Universities", universityPublicId, "Abant İzzet Baysal Üniversitesi", "ibu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Abdullah Gül Üniversitesi", "agu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Adana Bilim ve Teknoloji Üniversitesi", "adanabtu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Adnan Menderes Üniversitesi", "adu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Adıyaman Üniversitesi", "adiyaman.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Afyon Kocatepe Üniversitesi", "aku.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Ahi Evran Üniversitesi", "ahievran.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Akdeniz Üniversitesi", "akdeniz.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Aksaray Üniversitesi", "aksaray.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Amasya Üniversitesi", "amasya.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Anadolu Üniversitesi", "anadolu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Ankara Sosyal Bilimler Üniversitesi", "asbu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Ankara Üniversitesi", "ankara.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Ardahan Üniversitesi", "ardahan.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Artvin Çoruh Üniversitesi", "artvin.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Atatürk Üniversitesi", "atauni.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Ağrı İbrahim Çeçen Üniversitesi", "agri.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Balıkesir Üniversitesi", "balikesir.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bartın Üniversitesi", "bartin.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Batman Üniversitesi", "batman.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bayburt Üniversitesi", "bayburt.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bilecik Şeyh Edebali Üniversitesi", "bilecik.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bingöl Üniversitesi", "bingol.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bitlis Eren Üniversitesi", "beu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bozok Üniversitesi", "bozok.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Boğaziçi Üniversitesi", "boun.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bursa Teknik Üniversitesi", "btu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bülent Ecevit Üniversitesi", "beun.edu.tr/");
            AddMetaData(context, "Universities", universityPublicId, "Celal Bayar Üniversitesi", "bayar.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Cumhuriyet Üniversitesi", "cumhuriyet.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Deniz Harp Okulu", "dho.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Dicle Üniversitesi", "dicle.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Dokuz Eylül Üniversitesi", "deu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Dumlupınar Üniversitesi", "dpu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Düzce Üniversitesi", "duzce.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Ege Üniversitesi", "ege.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Erciyes Üniversitesi", "erciyes.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Erzincan Üniversitesi", "erzincan.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Erzurum Teknik Üniversitesi", "erzurum.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Eskişehir Osmangazi Üniversitesi", "ogu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Fırat Üniversitesi", "firat.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Galatasaray Üniversitesi", "gsu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Gazi Üniversitesi", "gazi.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Gaziantep Üniversitesi", "gantep.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Gaziosmanpaşa Üniversitesi", "gop.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Gebze Yüksek Teknoloji Enstitüsü", "gyte.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Giresun Üniversitesi", "giresun.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Gülhane Askeri Tıp Akademisi", "gata.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Gümüşhane Üniversitesi", "gumushane.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Hacettepe Üniversitesi", "hacettepe.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Hakkari Üniversitesi", "hakkari.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Harran Üniversitesi", "harran.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Hitit Üniversitesi", "hitit.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İnönü Üniversitesi", "inonu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Medeniyet Üniversitesi", "medeniyet.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Teknik Üniversitesi", "itu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Üniversitesi", "istanbul.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İzmir Kâtip Çelebi Üniversitesi", "ikc.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İzmir Yüksek Teknoloji Enstitüsü", "iyte.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Iğdır Üniversitesi", "igdir.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Kafkas Üniversitesi", "kafkas.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Kahramanmaraş Sütçü İmam Üniversitesi", "ksu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Kara Harp Okulu", "www.kho.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Karabük Üniversitesi", "karabuk.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Karadeniz Teknik Üniversitesi", "ktu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Karamanoğlu Mehmetbey Üniversitesi", "kmu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Kastamonu Üniversitesi", "kastamonu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Kilis 7 Aralık Üniversitesi", "kilis.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Kocaeli Üniversitesi", "kocaeli.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Kırklareli Üniversitesi", "kirklareli.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Kırıkkale Üniversitesi", "kku.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Mardin Artuklu Üniversitesi", "artuklu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Marmara Üniversitesi", "marmara.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Mehmet Akif Ersoy Üniversitesi", "mehmetakif.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Mersin Üniversitesi", "mersin.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Mimar Sinan Güzel Sanatlar Üniversitesi", "msgsu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Mustafa Kemal Üniversitesi", "mku.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Muğla Üniversitesi", "mugla.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Muş Alparslan Üniversitesi", "alparslan.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Namık Kemal Üniversitesi", "nku.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Necmettin Erbakan Üniversitesi", "konya.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Nevşehir Üniversitesi", "nevsehir.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Niğde Üniversitesi", "nigde.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Ondokuz Mayıs Üniversitesi", "omu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Ordu Üniversitesi", "odu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Orta Doğu Teknik Üniversitesi", "odtu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Osmaniye Korkut Ata Üniversitesi", "osmaniye.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Pamukkale Üniversitesi", "pamukkale.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Polis Akademisi", "pa.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Recep Tayyip Erdoğan Üniversitesi", "rize.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Sakarya Üniversitesi", "sakarya.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Selçuk Üniversitesi", "selcuk.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Siirt Üniversitesi", "siirt.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Sinop Üniversitesi", "sinop.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Süleyman Demirel Üniversitesi", "sdu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Trakya Üniversitesi", "trakya.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Tunceli Üniversitesi", "tunceli.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Türk Alman Üniversitesi", "tau.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Uludağ Üniversitesi", "uludag.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Uşak Üniversitesi", "usak.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Yalova Üniversitesi", "yalova.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Yüzüncü Yıl Üniversitesi", "yyu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Yıldırım Beyazıt Üniversitesi", "ybu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Yıldız Teknik Üniversitesi", "yildiz.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Çanakkale Onsekiz Mart Üniversitesi", "comu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Çankırı Karatekin Üniversitesi", "karatekin.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Çukurova Üniversitesi", "cu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Şırnak Üniversitesi", "sirnak.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Acıbadem Üniversitesi", "acibadem.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Alanya Hamdullah Emin Paşa Üniversitesi", "");
            AddMetaData(context, "Universities", universityPublicId, "Ankara Bilge Üniversitesi", "bilge.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Atılım Üniversitesi", "atilim.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Avrasya Üniversitesi", "avrasya.edu.tr/");
            AddMetaData(context, "Universities", universityPublicId, "Bahçeşehir Üniversitesi", "bahcesehir.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Başkent Üniversitesi", "baskent.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Beykent Üniversitesi", "beykent.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bezmiâlem Vakıf Üniversitesi", "bezmialem.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bilkent Üniversitesi", "bilkent.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Bursa Orhangazi Üniversitesi", "bou.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Canik Başarı Üniversitesi", "basari.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Çankaya Üniversitesi", "cankaya.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Çağ Üniversitesi", "cag.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Doğuş Üniversitesi", "dogus.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Fatih Sultan Mehmet Üniversitesi", "fatihsultan.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Fatih Üniversitesi", "fatihun.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Gedik Üniversitesi", "gedik.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Gediz Üniversitesi", "gediz.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Haliç Üniversitesi", "halic.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Hasan Kalyoncu Üniversitesi", "hku.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Işık Üniversitesi", "isikun.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İpek Üniversitesi**", "altinkoza.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul 29 Mayıs Üniversitesi", "29mayis.edu.tr/");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Arel Üniversitesi", "arel.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Aydın Üniversitesi", "aydin.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Bilgi Üniversitesi", "bilgi.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Bilim Üniversitesi", "istanbulbilim.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Esenyurt Üniversitesi", "www.esenyurt.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Gelişim Üniversitesi", "gelisim.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Kemerburgaz Üniversitesi", "kemerburgaz.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Kültür Üniversitesi", "iku.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Medipol Üniversitesi", "medipol.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Mef Üniversitesi", "mef.k12.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Sabahattin Zaim Üniversitesi", "iszu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Şehir Üniversitesi", "sehir.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İstanbul Ticaret Üniversitesi", "iticu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İzmir Ekonomi Üniversitesi", "ieu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "İzmir Üniversitesi", "izmir.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Kadir Has Üniversitesi", "khas.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Karatay Üniversitesi", "karatay.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Koç Üniversitesi", "ku.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Konya Gıda Tarım Üniversitesi", "");
            AddMetaData(context, "Universities", universityPublicId, "Maltepe Üniversitesi", "maltepe.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Melikşah Üniversitesi", "meliksah.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Mevlana Üniversitesi", "mevlana.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Murat Hüdavendigar Üniversitesi", "");
            AddMetaData(context, "Universities", universityPublicId, "Nişantaşı Üniversitesi", "nisantasi.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Nuh Naci Yazgan Üniversitesi", "nny.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Okan Üniversitesi", "okan.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Özyeğin Üniversitesi", "ozyegin.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Piri Reis Üniversitesi", "pirireis.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Sabancı Üniversitesi", "sabanciuniv.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Sanko Üniversitesi", "www.facebook.com/sankouni");
            AddMetaData(context, "Universities", universityPublicId, "Selahattin Eyyubi Üniversitesi", "tr.wikipedia.org/wiki/Selahattin_Eyyubi_%C3%9Cniversitesi");
            AddMetaData(context, "Universities", universityPublicId, "Süleyman Şah Üniversitesi", "ssu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Şifa Üniversitesi", "sifa.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "TED Üniversitesi", "tedu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "TOBB Ekonomi ve Teknoloji Üniversitesi", "etu.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Toros Üniversitesi", "toros.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Turgut Özal Üniversitesi", "turgutozal.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Türk Hava Kurumu Üniversitesi", "thk.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Ufuk Üniversitesi", "ufuk.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Uluslararası Antalya Üniversitesi", "antalya.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Üsküdar Üniversitesi", "uskudar.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Yaşar Üniversitesi", "yasar.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Yeditepe Üniversitesi", "yeditepe.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Yeni Yüzyıl Üniversitesi", "yeniyuzyil.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Zirve Üniversitesi", "zirve.edu.tr");
            AddMetaData(context, "Universities", universityPublicId, "Kanuni Üniversitesi", "tr.wikipedia.org/wiki/Kanuni_%C3%9Cniversitesi");
            AddMetaData(context, "Universities", universityPublicId, "MEF Üniversitesi", "mef.edu.tr");
            #endregion

            #region Languages

            var languagePublicId = AddMetaDataType(context, "Languages");

            AddMetaData(context, "Languages", languagePublicId, "Abkhaz", "ab");
            AddMetaData(context, "Languages", languagePublicId, "Abkhaz", "ab");
            AddMetaData(context, "Languages", languagePublicId, "Afar", "aa");
            AddMetaData(context, "Languages", languagePublicId, "Afrikaans", "af");
            AddMetaData(context, "Languages", languagePublicId, "Akan", "ak");
            AddMetaData(context, "Languages", languagePublicId, "Albanian", "sq");
            AddMetaData(context, "Languages", languagePublicId, "Amharic", "am");
            AddMetaData(context, "Languages", languagePublicId, "Arabic", "ar");
            AddMetaData(context, "Languages", languagePublicId, "Aragonese", "an");
            AddMetaData(context, "Languages", languagePublicId, "Armenian", "hy");
            AddMetaData(context, "Languages", languagePublicId, "Assamese", "as");
            AddMetaData(context, "Languages", languagePublicId, "Avaric", "av");
            AddMetaData(context, "Languages", languagePublicId, "Avestan", "ae");
            AddMetaData(context, "Languages", languagePublicId, "Aymara", "ay");
            AddMetaData(context, "Languages", languagePublicId, "Azerbaijani", "az");
            AddMetaData(context, "Languages", languagePublicId, "Bambara", "bm");
            AddMetaData(context, "Languages", languagePublicId, "Bashkir", "ba");
            AddMetaData(context, "Languages", languagePublicId, "Basque", "eu");
            AddMetaData(context, "Languages", languagePublicId, "Belarusian", "be");
            AddMetaData(context, "Languages", languagePublicId, "Bihari", "bh");
            AddMetaData(context, "Languages", languagePublicId, "Bislama", "bi");
            AddMetaData(context, "Languages", languagePublicId, "Bosnian", "bs");
            AddMetaData(context, "Languages", languagePublicId, "Breton", "br");
            AddMetaData(context, "Languages", languagePublicId, "Bulgarian", "bg");
            AddMetaData(context, "Languages", languagePublicId, "Burmese", "my");
            AddMetaData(context, "Languages", languagePublicId, "Chamorro", "ch");
            AddMetaData(context, "Languages", languagePublicId, "Chechen", "ce");
            AddMetaData(context, "Languages", languagePublicId, "Chinese", "zh");
            AddMetaData(context, "Languages", languagePublicId, "Chuvash", "cv");
            AddMetaData(context, "Languages", languagePublicId, "Cornish", "kw");
            AddMetaData(context, "Languages", languagePublicId, "Corsican", "co");
            AddMetaData(context, "Languages", languagePublicId, "Cree", "cr");
            AddMetaData(context, "Languages", languagePublicId, "Croatian", "hr");
            AddMetaData(context, "Languages", languagePublicId, "Czech", "cs");
            AddMetaData(context, "Languages", languagePublicId, "Danish", "da");
            AddMetaData(context, "Languages", languagePublicId, "Dutch", "nl");
            AddMetaData(context, "Languages", languagePublicId, "Dzongkha", "dz");
            AddMetaData(context, "Languages", languagePublicId, "English", "en");
            AddMetaData(context, "Languages", languagePublicId, "Esperanto", "eo");
            AddMetaData(context, "Languages", languagePublicId, "Estonian", "et");
            AddMetaData(context, "Languages", languagePublicId, "Ewe", "ee");
            AddMetaData(context, "Languages", languagePublicId, "Faroese", "fo");
            AddMetaData(context, "Languages", languagePublicId, "Fijian", "fj");
            AddMetaData(context, "Languages", languagePublicId, "Finnish", "fi");
            AddMetaData(context, "Languages", languagePublicId, "French", "fr");
            AddMetaData(context, "Languages", languagePublicId, "Galician", "gl");
            AddMetaData(context, "Languages", languagePublicId, "Georgian", "ka");
            AddMetaData(context, "Languages", languagePublicId, "German", "de");
            AddMetaData(context, "Languages", languagePublicId, "Greek, Modern", "el");
            AddMetaData(context, "Languages", languagePublicId, "Guaraní", "gn");
            AddMetaData(context, "Languages", languagePublicId, "Gujarati", "gu");
            AddMetaData(context, "Languages", languagePublicId, "Hausa", "ha");
            AddMetaData(context, "Languages", languagePublicId, "Herero", "hz");
            AddMetaData(context, "Languages", languagePublicId, "Hindi", "hi");
            AddMetaData(context, "Languages", languagePublicId, "Hiri Motu", "ho");
            AddMetaData(context, "Languages", languagePublicId, "Hungarian", "hu");
            AddMetaData(context, "Languages", languagePublicId, "Interlingua", "ia");
            AddMetaData(context, "Languages", languagePublicId, "Indonesian", "id");
            AddMetaData(context, "Languages", languagePublicId, "Interlingue", "ie");
            AddMetaData(context, "Languages", languagePublicId, "Irish", "ga");
            AddMetaData(context, "Languages", languagePublicId, "Igbo", "ig");
            AddMetaData(context, "Languages", languagePublicId, "Inupiaq", "ik");
            AddMetaData(context, "Languages", languagePublicId, "Ido", "io");
            AddMetaData(context, "Languages", languagePublicId, "Icelandic", "is");
            AddMetaData(context, "Languages", languagePublicId, "Italian", "it");
            AddMetaData(context, "Languages", languagePublicId, "Inuktitut", "iu");
            AddMetaData(context, "Languages", languagePublicId, "Japanese", "ja");
            AddMetaData(context, "Languages", languagePublicId, "Javanese", "jv");
            AddMetaData(context, "Languages", languagePublicId, "Kannada", "kn");
            AddMetaData(context, "Languages", languagePublicId, "Kanuri", "kr");
            AddMetaData(context, "Languages", languagePublicId, "Kashmiri", "ks");
            AddMetaData(context, "Languages", languagePublicId, "Kazakh", "kk");
            AddMetaData(context, "Languages", languagePublicId, "Khmer", "km");
            AddMetaData(context, "Languages", languagePublicId, "Kinyarwanda", "rw");
            AddMetaData(context, "Languages", languagePublicId, "Kyrgyz", "ky");
            AddMetaData(context, "Languages", languagePublicId, "Komi", "kv");
            AddMetaData(context, "Languages", languagePublicId, "Kongo", "kg");
            AddMetaData(context, "Languages", languagePublicId, "Korean", "ko");
            AddMetaData(context, "Languages", languagePublicId, "Kurdish", "ku");
            AddMetaData(context, "Languages", languagePublicId, "Latin", "la");
            AddMetaData(context, "Languages", languagePublicId, "Ganda", "lg");
            AddMetaData(context, "Languages", languagePublicId, "Lingala", "ln");
            AddMetaData(context, "Languages", languagePublicId, "Lao", "lo");
            AddMetaData(context, "Languages", languagePublicId, "Lithuanian", "lt");
            AddMetaData(context, "Languages", languagePublicId, "Luba-Katanga", "lu");
            AddMetaData(context, "Languages", languagePublicId, "Latvian", "lv");
            AddMetaData(context, "Languages", languagePublicId, "Manx", "gv");
            AddMetaData(context, "Languages", languagePublicId, "Macedonian", "mk");
            AddMetaData(context, "Languages", languagePublicId, "Malagasy", "mg");
            AddMetaData(context, "Languages", languagePublicId, "Malay", "ms");
            AddMetaData(context, "Languages", languagePublicId, "Malayalam", "ml");
            AddMetaData(context, "Languages", languagePublicId, "Maltese", "mt");
            AddMetaData(context, "Languages", languagePublicId, "Māori", "mi");
            AddMetaData(context, "Languages", languagePublicId, "Marshallese", "mh");
            AddMetaData(context, "Languages", languagePublicId, "Mongolian", "mn");
            AddMetaData(context, "Languages", languagePublicId, "Nauru", "na");
            AddMetaData(context, "Languages", languagePublicId, "Norwegian Bokmål", "nb");
            AddMetaData(context, "Languages", languagePublicId, "North Ndebele", "nd");
            AddMetaData(context, "Languages", languagePublicId, "Nepali", "ne");
            AddMetaData(context, "Languages", languagePublicId, "Ndonga", "ng");
            AddMetaData(context, "Languages", languagePublicId, "Norwegian Nynorsk", "nn");
            AddMetaData(context, "Languages", languagePublicId, "Norwegian", "no");
            AddMetaData(context, "Languages", languagePublicId, "Nuosu", "ii");
            AddMetaData(context, "Languages", languagePublicId, "South Ndebele", "nr");
            AddMetaData(context, "Languages", languagePublicId, "Occitan", "oc");
            AddMetaData(context, "Languages", languagePublicId, "Ojibwe, Ojibwa", "oj");
            AddMetaData(context, "Languages", languagePublicId, "Oromo", "om");
            AddMetaData(context, "Languages", languagePublicId, "Oriya", "or");
            AddMetaData(context, "Languages", languagePublicId, "Pāli", "pi");
            AddMetaData(context, "Languages", languagePublicId, "Persian (Farsi)", "fa");
            AddMetaData(context, "Languages", languagePublicId, "Polish", "pl");
            AddMetaData(context, "Languages", languagePublicId, "Portuguese", "pt");
            AddMetaData(context, "Languages", languagePublicId, "Quechua", "qu");
            AddMetaData(context, "Languages", languagePublicId, "Romansh", "rm");
            AddMetaData(context, "Languages", languagePublicId, "Kirundi", "rn");
            AddMetaData(context, "Languages", languagePublicId, "Romanian", "ro");
            AddMetaData(context, "Languages", languagePublicId, "Russian", "ru");
            AddMetaData(context, "Languages", languagePublicId, "Sardinian", "sc");
            AddMetaData(context, "Languages", languagePublicId, "Sindhi", "sd");
            AddMetaData(context, "Languages", languagePublicId, "Northern Sami", "se");
            AddMetaData(context, "Languages", languagePublicId, "Samoan", "sm");
            AddMetaData(context, "Languages", languagePublicId, "Sango", "sg");
            AddMetaData(context, "Languages", languagePublicId, "Serbian", "sr");
            AddMetaData(context, "Languages", languagePublicId, "Shona", "sn");
            AddMetaData(context, "Languages", languagePublicId, "Slovak", "sk");
            AddMetaData(context, "Languages", languagePublicId, "Slovene", "sl");
            AddMetaData(context, "Languages", languagePublicId, "Somali", "so");
            AddMetaData(context, "Languages", languagePublicId, "Southern Sotho", "st");
            AddMetaData(context, "Languages", languagePublicId, "South Azerbaijani", "az");
            AddMetaData(context, "Languages", languagePublicId, "Sundanese", "su");
            AddMetaData(context, "Languages", languagePublicId, "Swahili", "sw");
            AddMetaData(context, "Languages", languagePublicId, "Swati", "ss");
            AddMetaData(context, "Languages", languagePublicId, "Swedish", "sv");
            AddMetaData(context, "Languages", languagePublicId, "Tamil", "ta");
            AddMetaData(context, "Languages", languagePublicId, "Telugu", "te");
            AddMetaData(context, "Languages", languagePublicId, "Tajik", "tg");
            AddMetaData(context, "Languages", languagePublicId, "Thai", "th");
            AddMetaData(context, "Languages", languagePublicId, "Tigrinya", "ti");
            AddMetaData(context, "Languages", languagePublicId, "Turkmen", "tk");
            AddMetaData(context, "Languages", languagePublicId, "Tagalog", "tl");
            AddMetaData(context, "Languages", languagePublicId, "Tswana", "tn");
            AddMetaData(context, "Languages", languagePublicId, "Turkish", "tr");
            AddMetaData(context, "Languages", languagePublicId, "Tsonga", "ts");
            AddMetaData(context, "Languages", languagePublicId, "Tatar", "tt");
            AddMetaData(context, "Languages", languagePublicId, "Twi", "tw");
            AddMetaData(context, "Languages", languagePublicId, "Tahitian", "ty");
            AddMetaData(context, "Languages", languagePublicId, "Ukrainian", "uk");
            AddMetaData(context, "Languages", languagePublicId, "Urdu", "ur");
            AddMetaData(context, "Languages", languagePublicId, "Uzbek", "uz");
            AddMetaData(context, "Languages", languagePublicId, "Venda", "ve");
            AddMetaData(context, "Languages", languagePublicId, "Volapük", "vo");
            AddMetaData(context, "Languages", languagePublicId, "Walloon", "wa");
            AddMetaData(context, "Languages", languagePublicId, "Welsh", "cy");
            AddMetaData(context, "Languages", languagePublicId, "Wolof", "wo");
            AddMetaData(context, "Languages", languagePublicId, "Xhosa", "xh");
            AddMetaData(context, "Languages", languagePublicId, "Yiddish", "yi");
            AddMetaData(context, "Languages", languagePublicId, "Yoruba", "yo");
            AddMetaData(context, "Languages", languagePublicId, "Zulu", "zu");

            AddMetaData(context, "Languages", languagePublicId, "Bengali; Bangla", "bn");
            AddMetaData(context, "Languages", languagePublicId, "Catalan; Valencian", "ca");
            AddMetaData(context, "Languages", languagePublicId, "Zhuang, Chuang", "za");
            AddMetaData(context, "Languages", languagePublicId, "Western Frisian", "fy");
            AddMetaData(context, "Languages", languagePublicId, "Vietnamese", "vi");
            AddMetaData(context, "Languages", languagePublicId, "Uyghur, Uighur", "ug");
            AddMetaData(context, "Languages", languagePublicId, "Tonga (Tonga Islands)", "to");
            AddMetaData(context, "Languages", languagePublicId, "Tibetan Standard, Tibetan, Central", "bo");
            AddMetaData(context, "Languages", languagePublicId, "Spanish; Castilian", "es");
            AddMetaData(context, "Languages", languagePublicId, "Sinhala, Sinhalese", "si");
            AddMetaData(context, "Languages", languagePublicId, "Scottish Gaelic; Gaelic", "gd");
            AddMetaData(context, "Languages", languagePublicId, "Ossetian, Ossetic", "os");
            AddMetaData(context, "Languages", languagePublicId, "Panjabi, Punjabi", "pa");
            AddMetaData(context, "Languages", languagePublicId, "Sanskrit (Saṁskṛta)", "sa");
            AddMetaData(context, "Languages", languagePublicId, "Old Church Slavonic, Church Slavonic, Old Bulgarian", "cu");
            AddMetaData(context, "Languages", languagePublicId, "Limburgish, Limburgan, Limburger", "li");
            AddMetaData(context, "Languages", languagePublicId, "Luxembourgish, Letzeburgesch", "lb");
            AddMetaData(context, "Languages", languagePublicId, "Marathi (Marāṭhī)", "mr");
            AddMetaData(context, "Languages", languagePublicId, "Kwanyama, Kuanyama", "kj");
            AddMetaData(context, "Languages", languagePublicId, "Pashto, Pushto", "ps");
            AddMetaData(context, "Languages", languagePublicId, "Navajo, Navaho", "nv");
            AddMetaData(context, "Languages", languagePublicId, "Kikuyu, Gikuyu", "ki");
            AddMetaData(context, "Languages", languagePublicId, "Kalaallisut, Greenlandic", "kl");
            AddMetaData(context, "Languages", languagePublicId, "Hebrew (modern)", "he");
            AddMetaData(context, "Languages", languagePublicId, "Haitian; Haitian Creole", "ht");
            AddMetaData(context, "Languages", languagePublicId, "Fula; Fulah; Pulaar; Pular", "ff");
            AddMetaData(context, "Languages", languagePublicId, "Divehi; Dhivehi; Maldivian;", "dv");
            AddMetaData(context, "Languages", languagePublicId, "Chichewa; Chewa; Nyanja", "ny");

            #endregion

            context.SaveChanges();
        }

        private void AddMetaData(SetMetaDbContext context, string type, string typePublicId, string name, string code, string value, string parentName, string parentPublicId = "")
        {
            var metaData = new MetaData
            {
                PublicId = Guid.NewGuid().ToNoDashString(),
                IsActive = true,
                Name = name,
                Code = code,
                TypeName = type,
                TypeCode = type.ToUrlSlug(),
                TypePublicId = typePublicId,
                Value = value,
                ParentName = parentName,
                ParentCode = parentName.ToUrlSlug(),
                ParentPublicId = parentPublicId
            };

            context.MetaDatas.Add(metaData);
        }

        private string AddMetaData(SetMetaDbContext context, string type, string typePublicId, string name, string value)
        {
            var publicId = Guid.NewGuid().ToNoDashString();
            var metaData = new MetaData
            {
                PublicId = publicId,
                IsActive = true,
                Name = name,
                Code = name.ToUrlSlug(),
                TypeName = type,
                TypeCode = type.ToUrlSlug(),
                TypePublicId = typePublicId,
                Value = value
            };

            context.MetaDatas.Add(metaData);

            return publicId;
        }
        private string AddMetaDataUrl(SetMetaDbContext context, string type, string typePublicId, string name, string url)
        {
            var publicId = Guid.NewGuid().ToNoDashString();
            var metaData = new MetaData
            {
                PublicId = publicId,
                IsActive = true,
                Name = name,
                Code = name.ToUrlSlug(),
                TypeName = type,
                TypeCode = type.ToUrlSlug(),
                TypePublicId = typePublicId,
                Url = url
            };

            context.MetaDatas.Add(metaData);

            return publicId;
        }

        private string AddMetaDataType(SetMetaDbContext context, string name)
        {
            var publicId = Guid.NewGuid().ToNoDashString();
            var metaDataType = new MetaDataType
            {
                PublicId = publicId,
                IsActive = true,
                Name = name,
                Code = name.ToUrlSlug()
            };

            context.MetaDataTypes.Add(metaDataType);

            return publicId;
        }

        private static void AddUser(SetMetaDbContext context, string name, string email, string role)
        {
            var user = new User
            {
                Email = email,
                PublicId = Guid.NewGuid().ToNoDashString(),
                Name = name,
                RoleId = ConstHelper.BasicRoles[role],
                RoleName = role,
                ImageUrl = GravatarHelper.GetGravatarURL(email),
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("password"),
                LastLoginAt = DateTime.Now,
                IsActive = true,
                Language = ConstHelper.CultureNameEN
            };
            context.Users.Add(user);
        }
    }
}