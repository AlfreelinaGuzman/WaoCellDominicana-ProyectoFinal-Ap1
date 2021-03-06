using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaoCellDominicana_ProyectoFinal_Ap1.Entidades{

    public class Proveedores
    {
        [Key]
        public int ProveedorId { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string EMail { get; set; }
        public DateTime FechaRegistro { get; set; }=DateTime.Now;
    }
    
}