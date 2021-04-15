namespace Order.Domain.Model.Orders
{
    public record OrderStatus
    {
        public static OrderStatus ApprovalPending = new OrderStatus(1, "Approval Pending");
        public static OrderStatus Approved = new OrderStatus(2, "Approved");
        public static OrderStatus Rejected = new OrderStatus(3, "Rejected");
        public static OrderStatus CancelPending = new OrderStatus(4, "Cancel Pending");
        public static OrderStatus Cancelled = new OrderStatus(5, "Cancelled");
        public static OrderStatus RevisionPending = new OrderStatus(6, "Revision Pending");

        public bool IsApprovalPending => Id == ApprovalPending.Id;
        public bool IsApproved => Id == Approved.Id;
        public bool IsRejected => Id == Rejected.Id;
        public bool IsCancelPending => Id == CancelPending.Id;
        public bool IsCancelled => Id == Cancelled.Id;
        public bool IsRevisionPending => Id == RevisionPending.Id;

        public OrderStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; init; }
        public string Name { get; init; }
    }
}