using ClasesReservaTransporte.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ClasesReservaTransporte.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AplicationDbContext _context;

        public GenericRepository()
        {
            _context = new AplicationDbContext();
            _context.Database.EnsureCreated();

        }
        public void Agregar(T entidad)
        {
            _context.Set<T>().Add(entidad);
            _context.SaveChanges();
        }
        public void Modificar(T entidad)
        {
            _context.Set<T>().Update(entidad);
            _context.SaveChanges();
        }

        public List<T> ObtenerTodos()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> ObtenerTodosCon(string PropiedadRelacionada)
        {
            return _context.Set<T>()
                           .Include(PropiedadRelacionada)
                           .AsNoTracking()
                           .ToList();
        }
        public void Eliminar(T entidad)
        {
            _context.Set<T>().Remove(entidad);
            _context.SaveChanges();
        }
    }
}
