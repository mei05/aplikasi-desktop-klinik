using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;


namespace Project_UAS
{
    public partial class puskesmasEntities : DbContext
    {
        public object Form_output_test { get; internal set; }

        // Override base SaveChanges to expand out validation errors so client gets an actually helpful message
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.InnerException;

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbUpdateException(exceptionMessage, ex.InnerException);
            }
        }
    }
}


