using Crud_Produto_Marca.Database;
using Crud_Produto_Marca.Models;
using Crud_Produto_Marca.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Produto_Marca.Repositories {
    public class ProdutoRepository : IProdutoRepository {
        private readonly ApplicationDbContext _dbContext;

        public ProdutoRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Produto Buscar(int id) {
            return _dbContext.Set<Produto>().FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Produto obj) {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Editar(Produto obj) {
            _dbContext.Set<Produto>().Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Excluir(Produto obj) {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Produto> Listar() {
            return _dbContext.Set<Produto>().ToList();
        }

    }
}
