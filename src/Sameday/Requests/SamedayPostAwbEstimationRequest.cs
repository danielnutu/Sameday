using Sameday.Http;
using Sameday.Objects;
using Sameday.Objects.PostAwb.Request;
using Sameday.Objects.Types;
using System;

namespace Sameday.Requests
{
    public class SamedayPostAwbEstimationRequest : ISamedayRequest
    {
        public SamedayPostAwbEstimationRequest(int pickupPointId, int contactPersonId,
            PackageType packageType, ParcelDimensionsObject[] parcelsDimensions, int serviceId,
            AwbPaymentType awbPayment, AwbRecipientEntityObject awbRecipient,
            float insuredValue, float cashOnDeliveryAmount = 0,
            ThirdPartyPickupEntityObject thirdPartyPickup = null, int[] serviceTaxIds = default)
        {
            PickupPointId = pickupPointId;
            ContactPersonId = contactPersonId;
            PackageType = packageType;
            ParcelsDimensions = parcelsDimensions;
            ServiceId = serviceId;
            AwbPayment = awbPayment;
            AwbRecipient = awbRecipient;
            InsuredValue = insuredValue;
            CashOnDeliveryAmount = cashOnDeliveryAmount;
            ThirdPartyPickup = thirdPartyPickup;
            ServiceTaxIds = serviceTaxIds;
        }

        public int PickupPointId { get; }
        public int ContactPersonId { get; }
        public PackageType PackageType { get; }
        public ParcelDimensionsObject[] ParcelsDimensions { get; }
        public int ServiceId { get; }
        public AwbPaymentType AwbPayment { get; }
        public AwbRecipientEntityObject AwbRecipient { get; }
        public float InsuredValue { get; }
        public float CashOnDeliveryAmount { get; }
        public ThirdPartyPickupEntityObject ThirdPartyPickup { get; }
        public int[] ServiceTaxIds { get; }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
