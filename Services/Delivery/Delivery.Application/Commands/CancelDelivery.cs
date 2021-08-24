//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using MediatR;

//namespace Delivery.Application.Commands
//{
//    using Common.Application.Commands;
//    using Common.Application.Validation;
//    using Domain.Model.Couriers;
//    using Domain.Model.Deliveries;
//    using System.Net;

//    public static class CancelDelivery
//    {
//        public record Command(Guid OrderId) : ICommand<Result>;

//        public record Result(int Id)
//        {
//            public HttpStatusCode StatusCode { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
//        }

//        public class Validator : IValidable
//        {
//            public async Task<ValidationResult> Validate(Command request)
//            {
//                //if (repository.Todos.Any(x => x.Name.Equals(request.Name, StringComparison.OrdinalIgnoreCase)))
//                //    return ValidationResult.Fail("Todo already exists.");

//                return ValidationResult.Success();
//            }
//        }

//        public class Handler : ICommandHandler<Command, Result>
//        {
//            private readonly IDeliveryRepository _deliveryRepository;
//            private readonly ICourierRepository _courierRepository;

//            public Handler(IDeliveryRepository deliveryRepository, ICourierRepository courierRepository)
//            {
//                _deliveryRepository = deliveryRepository;
//                _courierRepository = courierRepository;
//            }

//            public async Task<Result> Handle(Command command, CancellationToken cancellationToken)
//            {
//                var delivery = await _deliveryRepository.FindByOrderIdAsync(command.OrderId);
//                delivery.Cancel();
//                await _deliveryRepository.UpdateAsync(delivery);
//                if (delivery.HasAssignedCourier)
//                {
//                    var courier = await _courierRepository.FindByIdAsync(delivery.CourierId.Value);
//                    courier.RemoveDelivery(delivery.DeliveryId);
//                    await _courierRepository.UpdateAsync(courier);
//                }
//                return new Result(5);
//            }
//        }
//    }
//}
