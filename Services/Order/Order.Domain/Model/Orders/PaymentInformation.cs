namespace Order.Domain.Model.Orders
{
    public record PaymentInformation
    {
        public PaymentInformation(string paymentToken)
        {
            PaymentToken = paymentToken;
        }

        public string PaymentToken { get; init; }
    }
}
