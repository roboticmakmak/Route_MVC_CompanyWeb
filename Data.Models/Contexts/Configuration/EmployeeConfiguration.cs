﻿using Company.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Contexts.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
       public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(50);
        }
    }
}
