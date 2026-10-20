namespace ClasesReservaTransporte.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Agregar(T entidad);
        List<T> ObtenerTodos();
    }
}
