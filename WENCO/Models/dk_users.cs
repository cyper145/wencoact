//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WENCO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dk_users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dk_users()
        {
            this.dk_rol_users = new HashSet<dk_rol_users>();
        }
    
        public string id { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string date_of_birth { get; set; }
        public string photo { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string token { get; set; }
        public Nullable<int> isactive { get; set; }
        public Nullable<System.DateTime> last_login { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dk_rol_users> dk_rol_users { get; set; }
    }
}