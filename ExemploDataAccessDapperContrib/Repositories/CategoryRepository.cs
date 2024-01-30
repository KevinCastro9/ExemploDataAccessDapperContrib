using Dapper.Contrib.Extensions;
using ExemploDataAccessDapperContrib.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDataAccessDapperContrib.Repositories
{
    public class CategoryRepository
    {
        private Connection.Connection conn = new Connection.Connection();
        private readonly SqlConnection _sqlConnection;

        // => serve para substituir as chaves caso o método tenha apenas uma linha
        public CategoryRepository()
         => _sqlConnection = conn.OpenConection(); //Realizando a conexão com o banco

        //Inserindo uma categoria no banco
        public long InsertCategory(Category category)
        {
            try
            {
                /* Nesse caso voce não precisa fazer a query
                    basta informar qual o objeto que vai ser inserido e depois passar o mesmo*/
                return _sqlConnection.Insert<Category>(category);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        //Alterando uma categoria no banco
        public bool UpdateCategory(Category category)
        {
            try
            {
                /* Nesse caso voce não precisa fazer a query
                      basta informar qual o objeto que vai ser alterado e depois passar o mesmo*/
                return _sqlConnection.Update<Category>(category);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Excluindo uma categoria no banco
        public bool DeleteCategory(int id)
        {
            try
            {
                /* Selecionando a categoria pelo id informado */
                var category = _sqlConnection.Get<Category>(id);

                /* Nesse caso voce não precisa fazer a query
                 basta informar qual o objeto que vai ser excluido e depois passar o mesmo*/
                return _sqlConnection.Delete<Category>(category);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Selecionando uma lista de categorias no banco
        public IEnumerable<Category> SelectListCategory()
        {
            try
            {
                /*Nesse caso voce não precisa fazer a query 
                      basta informar qual tabela deseja selecionar e ele vai trazer ela completa */
                return _sqlConnection.GetAll<Category>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //Selecionando uma categoria no banco
        public Category SelectCategory(int id)
        {
            try
            {
                /*Nesse caso voce não precisa fazer a query 
                      basta informar qual tabela deseja selecionar e ele vai trazer ela completa */
                return _sqlConnection.Get<Category>(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
