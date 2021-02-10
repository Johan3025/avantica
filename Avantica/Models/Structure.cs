using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avantica.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace WebApplication3.Models
    {
        public class Address
        {
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string county { get; set; }
            public string district { get; set; }
            public string state { get; set; }
            public string zip { get; set; }
            public string zipPlus4 { get; set; }

        }
        public class Financial
        {
            public string capRate { get; set; }
            public string occupancy { get; set; }
            public bool isSection8 { get; set; }
            public DateTime? leaseStartDate { get; set; }
            public DateTime? leaseEndDate { get; set; }
            public string listPrice { get; set; }
            public int? salePrice { get; set; }
            public int? marketValue { get; set; }
            public DateTime? monthlyHoa { get; set; }
            public int? monthlyManagementFees { get; set; }
            public string monthlyRent { get; set; }
            public string netYield { get; set; }
            public string turnOverFee { get; set; }
            public string rehabCosts { get; set; }
            public string rehabDate { get; set; }
            public string yearlyInsuranceCost { get; set; }
            public string yearlyPropertyTaxes { get; set; }
            public bool? isCashOnly { get; set; }

        }
        public class Physical
        {
            public string bathRooms { get; set; }
            public string bedRooms { get; set; }
            public string parcelNumber { get; set; }
            public bool isPool { get; set; }
            public int? lotSize { get; set; }
            public int squareFeet { get; set; }
            public string stories { get; set; }
            public int? units { get; set; }
            public int yearBuilt { get; set; }
            public string zipYearBuilt { get; set; }

        }
        public class Score
        {
            public string conditionScore { get; set; }
            public string crimeScore { get; set; }
            public int neighborhoodScore { get; set; }
            public string overallScore { get; set; }
            public string qualityScore { get; set; }
            public string schoolScore { get; set; }
            public string charterSchoolScore { get; set; }
            public string floodRiskScore { get; set; }
            public string walkabilityScore { get; set; }

        }
        public class Valuation
        {
            public string avmBpoValue { get; set; }
            public string avmBpoAdjValue { get; set; }
            public string avmBpoDate { get; set; }
            public string rsAvmValue { get; set; }
            public string rsAvmDate { get; set; }
            public string rsBpoMergeValue { get; set; }

        }
        public class Photos
        {
            public int id { get; set; }
            public string guid { get; set; }
            public string resourceType { get; set; }
            public bool isPublic { get; set; }
            public string description { get; set; }
            public string filename { get; set; }
            public string sizeInByte { get; set; }
            public string contentType { get; set; }
            public string url { get; set; }
            public string urlMedium { get; set; }
            public string urlSmall { get; set; }
            public string textContent { get; set; }

        }
        public class FloorPlans
        {
            public int id { get; set; }
            public string guid { get; set; }
            public string resourceType { get; set; }
            public bool isPublic { get; set; }
            public string description { get; set; }
            public string filename { get; set; }
            public string sizeInByte { get; set; }
            public string contentType { get; set; }
            public string url { get; set; }
            public string urlMedium { get; set; }
            public string urlSmall { get; set; }
            public string textContent { get; set; }

        }
        public class Resources
        {
            public IList<Photos> photos { get; set; }
            public IList<FloorPlans> floorPlans { get; set; }
            public IList<threeDRenderings> threeDRenderings { get; set; }
            public IList<string> audios { get; set; }

        }


        public class threeDRenderings
        {
            public int id { get; set; }
            public Guid guid { get; set; }
            public string resourceType { get; set; }
            public bool isPublic { get; set; }
            public string description { get; set; }
            public string filename { get; set; }
            public string sizeInByte { get; set; }
            public string contentType { get; set; }
            public string url { get; set; }
            public string urlMedium { get; set; }
            public string urlSmall { get; set; }
            public string textContent { get; set; }
        }

        public class LeaseSummary
        {
            public string occupancy { get; set; }
            public string leasingStatus { get; set; }
            public string marketedRent { get; set; }
            public string paymentStatus { get; set; }
            public DateTime leaseStartDate { get; set; }
            public DateTime leaseEndDate { get; set; }
            public string monthlyRent { get; set; }
            public string securityDepositAmount { get; set; }
            public string hasPet { get; set; }
            public string petFeeAmount { get; set; }
            public bool isPetsDeposit { get; set; }
            public string petsDepositAmount { get; set; }
            public bool? isLeaseConcessions { get; set; }
            public bool isRentersInsuranceRequired { get; set; }
            public bool isSection8 { get; set; }
            public bool isTenantBackgroundChecked { get; set; }
            public bool isTenantIncomeAbove3x { get; set; }
            public string isTenantMayTerminateEarly { get; set; }
            public string isTenantPurchaseOption { get; set; }

        }
        public class UtilitiesOwnership
        {
            public string electric { get; set; }
            public string gas { get; set; }
            public string water { get; set; }
            public string garbage { get; set; }
            public string pool { get; set; }
            public string landscaping { get; set; }
            public string pestControl { get; set; }

        }
        public class ApplianceOwnership
        {
            public string refrigerator { get; set; }
            public string dishwasher { get; set; }
            public string washer { get; set; }
            public string dryer { get; set; }
            public string microwave { get; set; }
            public string stove { get; set; }

        }
        public class Lease
        {
            public LeaseSummary leaseSummary { get; set; }
            public UtilitiesOwnership utilitiesOwnership { get; set; }
            public ApplianceOwnership applianceOwnership { get; set; }

        }
        public class GoogleMapOption
        {
            public bool hasStreetView { get; set; }
            public int povHeading { get; set; }
            public int povPitch { get; set; }
            public double povLatitude { get; set; }
            public double povLongitude { get; set; }

        }
        public class Properties
        {
            public int id { get; set; }
            public int accountId { get; set; }
            public string buyerAccountId { get; set; }
            public string buyerUserId { get; set; }
            public string externalId { get; set; }
            public string programId { get; set; }
            public bool isDwellCertified { get; set; }
            public bool isAllowOffer { get; set; }
            public bool isAllowPreview { get; set; }
            public bool isFeatured { get; set; }
            public bool isRentGuaranteed { get; set; }
            public bool allowRentGuaranteedOptout { get; set; }
            public bool isSecuritized { get; set; }
            public bool isHot { get; set; }
            public bool isNew { get; set; }
            public bool? isBargain { get; set; }
            public bool isDiligenceVaultUnlocked { get; set; }
            public bool? isPropertyManagerOfferRetain { get; set; }
            public bool? isHoa { get; set; }
            public bool hasAudio { get; set; }
            public bool hasDiligenceVaultDocuments { get; set; }
            public int market { get; set; }
            public int? daysOnMarket { get; set; }
            public double? latitude { get; set; }
            public double? longitude { get; set; }
            public string propertyName { get; set; }
            public string description { get; set; }
            public string highlights { get; set; }
            public string mainImageUrl { get; set; }
            public string personalProperties { get; set; }
            public string diligenceVaultSummary { get; set; }
            public string featuredReason { get; set; }
            public string status { get; set; }
            public string allowedFundingTypes { get; set; }
            public string allowableSaleTypes { get; set; }
            public string visibility { get; set; }
            public string priceVisibility { get; set; }
            public string propertyType { get; set; }
            public string certificationLevel { get; set; }
            public string escrowClosingDate { get; set; }
            public Address address { get; set; }
            public Financial financial { get; set; }
            public Physical physical { get; set; }
            public Score score { get; set; }
            public Valuation valuation { get; set; }
            public Resources resources { get; set; }
            public string manager { get; set; }
            public string seller { get; set; }
            public string sellerBroker { get; set; }
            public string hoa { get; set; }
            public Lease lease { get; set; }
            public List<string> diligences { get; set; }
            public GoogleMapOption googleMapOption { get; set; }
            public string inspectionType { get; set; }

        }
        public class Application
        {
            public IList<Properties> properties { get; set; }

        }

    }

}
