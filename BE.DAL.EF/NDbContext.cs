using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BE.DAL.EF
{
    public partial class NDbContext: DbContext
    {
        public NDbContext()
        {

        }
        public NDbContext(DbContextOptions<NDbContext> options)
: base(options)
        {
        }
    }
}
