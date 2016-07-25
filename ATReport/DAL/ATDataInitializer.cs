using ATReport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ATReport.DAL
{
    public class ATDataInitializer : DropCreateDatabaseIfModelChanges<ATDataContext>
    {
        protected override void Seed(ATDataContext context)
        {
            // add new data to context

            context.SaveChanges();
        }
    }
}