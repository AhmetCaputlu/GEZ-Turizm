using System.Diagnostics;
using Data_Access.Configurations.Abstracts;
using Data_Access.Entities.Abstracts;
using Data_Access.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Access.Configurations
{
    internal class WebUserConfiguration : IEntityTypeConfiguration<WebUser>
    {
        public void Configure(EntityTypeBuilder<WebUser> builder)
        {
            
        }
    }
}
