using System.Collections.Generic;

namespace Proyecto
{
    public static class funcionesUtilitarias
    {
        public static List<Area> funcionMostrar(int piso, string descripcionArea)
        {
            List<Area> area = AreaDAO.FiltrarPorPiso(piso, descripcionArea);
            return area;
        }
    }
}