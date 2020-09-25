using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cenope.Models
{
    public class SistemaProveedoresContextClass : DbContext
    {
        public SistemaProveedoresContextClass(DbContextOptions<SistemaProveedoresContextClass> options)
            : base(options)
        {
        }


    }
}
