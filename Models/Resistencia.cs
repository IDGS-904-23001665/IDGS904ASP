using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904ASP.Models
{
    public class Resistencia
    {
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Color3 { get; set; }
        public string Tolerancia { get; set; }

        public double Valor { get; set; }
        public double ValorMaximo { get; set; }
        public double ValorMinimo { get; set; }

        public string ObtenerCssColor(string colorName)
        {
            switch (colorName)
            {
                case "Negro": return "black";
                case "Café": return "saddlebrown";
                case "Rojo": return "red";
                case "Naranja": return "orange";
                case "Amarillo": return "yellow";
                case "Verde": return "green";
                case "Azul": return "blue";
                case "Violeta": return "purple";
                case "Gris": return "gray";
                case "Blanco": return "white";
                default: return "transparent";
            }
        }
    }
}