using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Interfaces;

namespace Business
{
    public class Buser
    {

        //private Duser objData = new Duser();
        //public List<User> ListUser()
        //{
        //    return objData.ListUser();
        //}

        public List<User> ListUser() => new Duser().ListUser();

        public int Create(User obj, out string Message)
        {
            Message = string.Empty;

            // Validaciones básicas
            if (string.IsNullOrEmpty(obj.Uname) || string.IsNullOrWhiteSpace(obj.Uname))
            {
                Message = "El nombre no debe estar vacío.";
                return 0;
            }
            if (string.IsNullOrEmpty(obj.Ulastname) || string.IsNullOrWhiteSpace(obj.Ulastname))
            {
                Message = "El apellido no debe estar vacío.";
                return 0;
            }
            if (string.IsNullOrEmpty(obj.Uemail) || string.IsNullOrWhiteSpace(obj.Uemail))
            {
                Message = "El email no debe estar vacío.";
                return 0;
            }
            if (string.IsNullOrEmpty(obj.Uphone) || string.IsNullOrWhiteSpace(obj.Uphone))
            {
                Message = "El teléfono no debe estar vacío.";
                return 0;
            }
            if (string.IsNullOrEmpty(obj.Upassword) || string.IsNullOrWhiteSpace(obj.Upassword))
            {
                Message = "La contraseña no debe estar vacía.";
                return 0;
            }
        

            if (obj.Ustatus.ToString() == null || obj.Ustatus.ToString() == "")
            {
                Message = "El estado no debe estar vacío.";
                return 0;
            }




            // Llamar al método en la capa de datos para guardar en la base de datos
            return new Duser().Create(obj, out Message);
        }





    }
}
