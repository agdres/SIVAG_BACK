using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System;

namespace SIVAG_BACKEND.Utilities.Execptions
{
    public static class ExceptionEntityModel
    {
        public static string HandleException(Exception ex, string Accion)
        {
            string Res = "";
            if (ex is DbUpdateConcurrencyException concurrencyEx)
            {
                // A custom exception of yours for concurrency issues
                throw ex;
            }
            else if (ex is DbUpdateException dbUpdateEx)
            {
                if (dbUpdateEx.InnerException != null)
                {
                    if (dbUpdateEx.InnerException is SqlException sqlException)
                    {
                        switch (sqlException.Number)
                        {
                            case 2627:  // Unique constraint error
                                Res = "Este " +Accion + " no se encuentra disponible";
                                break;
                            case 547:   // Constraint check violation
                            case 2601:  // Duplicated key row error
                                        // Constraint violation exception
                                        // A custom exception of yours for concurrency issues
                            default:
                                   Res = dbUpdateEx.Message;
                                break;
                        }
                    }
                    
                }
            }
            return Res;

        }
    }
}
