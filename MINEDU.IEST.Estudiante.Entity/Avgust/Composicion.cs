﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

namespace IDCL.AVGUST.SIP.Contexto.IDCL.AVGUST.SIP.Entity.Avgust
{
    public partial class Composicion
    {
        public int IdArticulo { get; set; }
        public int Iditem { get; set; }
        public int? IngredienteActivo { get; set; }
        public string FormuladorMolecular { get; set; }
        public int idGrupoQuimico { get; set; }
        public string ContracionIA { get; set; }

        public GrupoQuimico GrupoQuimicoNavegation { get; set; }
        public Articulo IdArticuloNavigation { get; set; }
        public IngredienteActivo IngredienteActivoNavigation { get; set; }
    }
}