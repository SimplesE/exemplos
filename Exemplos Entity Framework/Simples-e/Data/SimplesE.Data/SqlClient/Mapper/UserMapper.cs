using SimplesE.Model.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplesE.Data.SqlClient.Mapper
{
    public class UserMapper : EntityTypeConfiguration<User>
    {
        public UserMapper()
        {
            Property(u => u.Name).HasMaxLength(50);
            ComplexType<Address>().Property(u => u.Address).IsOptional();
        }
    }
}
