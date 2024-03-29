﻿using BuildingBlocks.Domain.Entities;

namespace Dinners.Domain.Reservations.Refunds;

public sealed record RefundId : EntityId<Guid>
{
    public override Guid Value { get; protected set; }

    public static RefundId Create(Guid id) => new RefundId(id);

    public static RefundId CreateUnique() => new RefundId(Guid.NewGuid());

    private RefundId(Guid value)
    {
        Value = value;
    }

    private RefundId() { }
}
