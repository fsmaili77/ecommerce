using System.Runtime.Serialization;

namespace Core.Entities.OrderAgregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Panding")]
        Pending,
        [EnumMember(Value = "Payment Received")]
        PaymentReceived,
        [EnumMember(Value = "Payment Failed")]
        PaymentFailed
    }
}