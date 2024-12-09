using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Balert
    {
        public static string GenerateAlert(string message, string type)
        {
            return $@"
            <div class='alert alert-{type} alert-dismissible fade show' role='alert'>
                <strong>{(type == "success" ? "Éxito!" : type == "warning" ? "Advertencia!" : "Error!")}</strong> {message}
                <button type='button' class='btn-close' data-bs-dismiss='alert' aria-label='Close'></button>
            </div>";
        }        
    }
}
