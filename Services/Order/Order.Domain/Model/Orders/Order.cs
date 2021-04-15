using System;

namespace Order.Domain.Model.Orders
{
    public class Order
    {
        public Order(
            Guid consumerId,
            Guid restaurantId,
            DeliveryInformation deliveryInformation,
            PaymentInformation paymentInformation,
            OrderLineItems lineItems)
        {
            OrderId = Guid.NewGuid();
            ConsumerId = consumerId;
            RestaurantId = restaurantId;
            DeliveryInformation = deliveryInformation;
            PaymentInformation = paymentInformation;
            LineItems = lineItems;
            Status = OrderStatus.ApprovalPending;
        }

        public Guid OrderId { get; }
        public Guid ConsumerId { get; }
        public Guid RestaurantId { get; }
        public DeliveryInformation DeliveryInformation { get; private set; }
        public PaymentInformation PaymentInformation { get; private set; }
        public OrderLineItems LineItems { get; private set; }
        public OrderStatus Status { get; private set; }
        public long Version { get; private set; }

        public void PendCancel()
        {
            if (Status.IsApproved)
            {
                Status = OrderStatus.CancelPending;
                return;
            }
            throw new UnsupportedOrderStatusTransitionException();
        }

        public void UndoPendCancel()
        {
            if (Status.IsCancelPending)
            {
                Status = OrderStatus.Approved;
                return;
            }
            throw new UnsupportedOrderStatusTransitionException();
        }

        public void Cancel()
        {
            if (Status.IsCancelPending)
            {
                Status = OrderStatus.Cancelled;
                return;
            }
            throw new UnsupportedOrderStatusTransitionException();
        }

        public void Approve()
        {
            if (Status.IsApprovalPending)
            {
                Status = OrderStatus.Approved;
                return;
            }
            throw new UnsupportedOrderStatusTransitionException();
        }

        public void Reject()
        {
            if (Status.IsApprovalPending)
            {
                Status = OrderStatus.Rejected;
                return;
            }
            throw new UnsupportedOrderStatusTransitionException();
        }

        public void Revise()
        {
            if (Status.IsApproved)
            {
                Status = OrderStatus.RevisionPending;
                return;
            }
            throw new UnsupportedOrderStatusTransitionException();
        }

        public void ConfirmRevision(OrderRevision orderRevision)
        {
            if (Status.IsRevisionPending)
            {
                DeliveryInformation = orderRevision.DeliveryInformation;
                LineItems.Update(orderRevision);
                Status = OrderStatus.Rejected;
                return;
            }
            throw new UnsupportedOrderStatusTransitionException();
        }

        public void RejectRevision()
        {
            if (Status.IsRevisionPending)
            {
                Status = OrderStatus.Approved;
                return;
            }
            throw new UnsupportedOrderStatusTransitionException();
        }
    }
}
