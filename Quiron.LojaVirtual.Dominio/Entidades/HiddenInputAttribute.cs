using System;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    internal class HiddenInputAttribute : Attribute
    {
        public bool DisplayValue { get; set; }
    }
}