﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dominio
{
    public class Articulos
    {
        public int Id { get; set; }
        [DisplayName("Código")] // Configuro como se muestra el nombre de la columna, debe ir arriba del nombre que quiero modificar en la columna dgv
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
        public Marcas Marca { get; set; }
        [DisplayName("Categoría")]
        public Categorias Categoria { get; set; }
    }
}
