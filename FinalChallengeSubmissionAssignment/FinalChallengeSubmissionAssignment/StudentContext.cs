using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace FinalChallengeSubmissionAssignment
{
    class StudentContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
    }
}
