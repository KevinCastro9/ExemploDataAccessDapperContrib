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
    public class TagRepository
    {
        private Connection.Connection conn = new Connection.Connection();
        private readonly SqlConnection _sqlConnection;

        // => serve para substituir as chaves caso o método tenha apenas uma linha
        public TagRepository()
         => _sqlConnection = conn.OpenConection(); //Realizando a conexão com o banco

        //Inserindo uma tag no banco
        public long InsertTag(Tag tag)
        {
            try
            {
                /* Nesse caso voce não precisa fazer a query
                    basta informar qual o objeto que vai ser inserido e depois passar o mesmo*/
                return _sqlConnection.Insert<Tag>(tag);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        //Alterando uma tag no banco
        public bool UpdateTag(Tag tag)
        {
            try
            {
                /* Nesse caso voce não precisa fazer a query
                      basta informar qual o objeto que vai ser alterado e depois passar o mesmo*/
                return _sqlConnection.Update<Tag>(tag);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Excluindo uma tag no banco
        public bool DeleteTag(int id)
        {
            try
            {
                /* Selecionando a tag pelo id informado */
                var tag = _sqlConnection.Get<Tag>(id);

                /* Nesse caso voce não precisa fazer a query
                 basta informar qual o objeto que vai ser excluido e depois passar o mesmo*/
                return _sqlConnection.Delete<Tag>(tag);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Selecionando uma lista de tags no banco
        public IEnumerable<Tag> SelectListTag()
        {
            try
            {
                /*Nesse caso voce não precisa fazer a query 
                      basta informar qual tabela deseja selecionar e ele vai trazer ela completa */
                return _sqlConnection.GetAll<Tag>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //Selecionando uma tag no banco
        public Tag SelectTag(int id)
        {
            try
            {
                /*Nesse caso voce não precisa fazer a query 
                      basta informar qual tabela deseja selecionar e ele vai trazer ela completa */
                return _sqlConnection.Get<Tag>(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
