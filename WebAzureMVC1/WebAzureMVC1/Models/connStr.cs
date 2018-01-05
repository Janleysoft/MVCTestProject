using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAzureMVC1.Models
{
    public class connStr:DbContext
    {
        public connStr() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}