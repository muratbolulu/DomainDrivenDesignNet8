namespace DomainDrivenDesignNet8.Domain.Orders;

public enum OrderStatusEnum
{
    Unknown = 0,
    AwaitingApproval=1,
    BeingPrepared=2,
    InTransit=3,
    Delivered=4
}