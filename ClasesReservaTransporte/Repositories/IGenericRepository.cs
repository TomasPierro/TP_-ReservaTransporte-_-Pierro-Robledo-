namespace ClasesReservaTransporte.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Agregar(T entidad);

        void Modificar(T entidad);

        void Eliminar(T entidad);

        List<T> ObtenerTodos();

        List<T> ObtenerTodosCon(string PropiedadRelacionada);
    }
}
