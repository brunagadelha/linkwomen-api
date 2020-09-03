using LinkWomen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkWomen.Data.Mappings
{
    public class UserConnectionMap : IEntityTypeConfiguration<UserConnection>
    {
        public void Configure(EntityTypeBuilder<UserConnection> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.UserHost)
                .WithMany(x => x.Connections)
                .HasForeignKey(x => x.UserHostId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.UserGuest)
                .WithMany()
                .HasForeignKey(x => x.UserGuestId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
