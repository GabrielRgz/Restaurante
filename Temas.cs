using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Temas { 
        public static Color PanelContenedor;
        public static Color PanelBarraTitulo;
        public static Color PanelMenu;

        //Tema Oscuro
        private static readonly Color PanelContenedorD = Color.FromArgb(33, 33, 33);
        private static readonly Color PanelBarraTituloD = Color.FromArgb(0, 0, 0);
        private static readonly Color PanelMenuD = Color.FromArgb(0, 0, 0);

        //Tema Claro
        private static readonly Color PanelContenedorL = Color.FromArgb(238, 227, 216);
        private static readonly Color PanelBarraTituloL = Color.FromArgb(255, 255, 255);
        private static readonly Color PanelMenuL = Color.FromArgb(255, 255, 255);

        public static void ElegirTema(int tema)
        {
            if (tema == 1)
            {
                PanelContenedor = PanelContenedorD;
                PanelBarraTitulo = PanelBarraTituloD;
                PanelMenu = PanelMenuD;
            }
            else if (tema == 2)
            {
                PanelContenedor = PanelContenedorL;
                PanelBarraTitulo = PanelBarraTituloL;
                PanelMenu = PanelMenuL;
            }
        }
    }
}
