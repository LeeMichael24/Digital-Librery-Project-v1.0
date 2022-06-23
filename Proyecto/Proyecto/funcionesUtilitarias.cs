namespace Proyecto
{
    public static class funcionesUtilitarias
    {
        public static Area funcionMostrar(int busqueda)
        {
            Area area = AreaDAO.FiltrarPorPiso(busqueda);
            return area;
        }
    }
}