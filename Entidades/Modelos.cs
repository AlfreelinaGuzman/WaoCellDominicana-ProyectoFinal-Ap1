using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaoCellDominicana_ProyectoFinal_Ap1.Entidades
{

    public class Modelos
    {
        [Key]
        public int ModeloId { get; set; }
        public string Modelo { get; set; }
    }

}