using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            
                builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2d27eb3-be37-4cfa-bc39-e38594b0f5ee",
                    UserId = "1d27eb3-be47-4cfa-ec39-e37594b0f5ee"
                },

                 new IdentityUserRole<string>
                 {
                     RoleId = "2d28eb3-ce37-4bfa-bc39-e37594b0f5ee",
                     UserId = "1d28eb3-be47-4cfa-ec39-e39594b0f5ee"
                 }

                );
        }
    }
}