using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WaoCellDominicana_ProyectoFinal_Ap1.Entidades
{
    public class ComprasDetalles
    {
        [Key]
        public int Id { get; set; }
        public int CompraId { get; set; }
        public int ArticuloId { get; set; }
        //public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public int Cantidad { get; set; }
        public decimal ITBIS { get; set; }
       // public decimal Importe { get; set; }
        public decimal Monto { get; set; }
        

    }
}