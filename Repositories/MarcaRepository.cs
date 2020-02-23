using Crud_Produto_Marca.Database;
using Crud_Produto_Marca.Models;
using Crud_Produto_Marca.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Produto_Marca.Repositories {
    public class MarcaRepository : IMarcaRepository {

        private readonly ApplicationDbContext _dbContext;

        public MarcaRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Marca Buscar(int id) {
            return _dbContext.Set<Marca>().FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Marca obj) {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Editar(Marca obj) {
            _dbContext.Set<Marca>().Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Excluir(Marca obj) {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Marca> Listar() {
            return _dbContext.Set<Marca>().ToList();
        }

    }
}
