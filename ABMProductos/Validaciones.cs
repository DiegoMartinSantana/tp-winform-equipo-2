﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMProductos
{
    public class Validaciones
    {


        public static bool ValidarTextBoxes(List<Control> textBoxes)
        {

            foreach (Control textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    return false; // Devuelve falso si encuentra un TextBox vacío o null
                }
            }
            return true; // Devuelve true si todos los TextBox tienen contenido
        }

        public static bool decimalValido(string Precio)
        {
            decimal PrecioConvertido;
            bool Convirtio = decimal.TryParse(Precio, out PrecioConvertido); // metodo try parse devuelve true si pudo convertir ok, y el out es para hacer psajes x referencia! porque guarda ahi si pudo convertir.
            return Convirtio;

        }

        public static bool SoloNumeros(string x)
        {
            bool esNumero = true;

            foreach (char c in x)
            {
                if (char.IsDigit(c) || c == '.' || c == ',')
                {
                   
                    esNumero = false; 
                    break;
                }
            }
            return esNumero; //false si son todos numeros
        }

        public static bool SoloLetras(string x)
        {
            bool esLetra = true;
            foreach (char c in x)
            {
                if (!char.IsLetter(c))
                {
                    esLetra = false;
                    break;
                }
            }
            return esLetra;
        }


    }
}
