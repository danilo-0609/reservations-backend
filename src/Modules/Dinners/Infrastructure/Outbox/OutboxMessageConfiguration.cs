﻿using Dinners.Domain.Restaurants;
using Domain.Restaurants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Dinners.Infrastructure.Outbox;

internal sealed class OutboxMessageConfiguration : IEntityTypeConfiguration<OutboxMessage>
{
    public void Configure(EntityTypeBuilder<OutboxMessage> builder)
    {
        builder.ToTable("DinnersOutboxMessages", "dinners");
    
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("Id");

        builder.Property(x => x.Type)
            .HasColumnName("Type");

        builder.Property(x => x.Content)
            .HasColumnName("Content");

        builder.Property(x => x.OcurredOnUtc)
            .HasColumnName("OcurredOn");

        builder.Property(x => x.ProcessedOnUtc)
            .IsRequired(false)
            .HasColumnName("ProcessedOn");

        builder.Property(x => x.Error)
        .IsRequired(false)
             .HasColumnName("Error");
    }
}
