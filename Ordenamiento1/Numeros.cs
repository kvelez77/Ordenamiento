using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento1
{
    class Numeros
    {

        private int longitud;
        private int[] arreglo = new int[1];
        private Button[] arreglo_botones = new Button[1];


        public Numeros()
        {
            int a = 0;
            arreglo[0] = a;
            arreglo_botones[0] = new Button();
            arreglo_botones[0].Width = 40;
            arreglo_botones[0].Height = 40;
            arreglo_botones[0].BackColor = Color.GreenYellow;
            arreglo_botones[0].Text = a.ToString();
            Calcular_Longitud();
            

        }


        public void Calcular_Longitud()
        {
            longitud = arreglo.Length;
        }


        public int Obtener_Longitud()
        {
            return longitud;
        }


        public int[] Obtener_Arreglo()
        {
            return arreglo;
        }


     
    }







}
