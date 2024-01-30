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
    public class RoleRepository
    {
        private Connection.Connection conn = new Connection.Connection();
        private readonly SqlConnection _sqlConnection;

        // => serve para substituir as chaves caso o método tenha apenas uma linha
        public RoleRepository()
         => _sqlConnection = conn.OpenConection(); //Realizando a conexão com o banco

        //Inserindo uma role no banco
        public long InsertRole(Role role)
        {
            try
            {
                /* Nesse caso voce não precisa fazer a query
                    basta informar qual o objeto que vai ser inserido e depois passar o mesmo*/
                return _sqlConnection.Insert<Role>(role);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        //Alterando uma role no banco
        public bool UpdateRole(Role role)
        {
            try
            {
                /* Nesse caso voce não precisa fazer a query
                      basta informar qual o objeto que vai ser alterado e depois passar o mesmo*/
                return _sqlConnection.Update<Role>(role);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Excluindo uma role no banco
        public bool DeleteRole(int id)
        {
            try
            {
                /* Selecionando a role pelo id informado */
                var role = _sqlConnection.Get<Role>(id);

                /* Nesse caso voce não precisa fazer a query
                 basta informar qual o objeto que vai ser excluido e depois passar o mesmo*/
                return _sqlConnection.Delete<Role>(role);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Selecionando uma lista de roles no banco
        public IEnumerable<Role> SelectListRole()
        {
            try
            {
                /*Nesse caso voce não precisa fazer a query 
                      basta informar qual tabela deseja selecionar e ele vai trazer ela completa */
                return _sqlConnection.GetAll<Role>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //Selecionando uma role no banco
        public Role SelectRole(int id)
        {
            try
            {
                /*Nesse caso voce não precisa fazer a query 
                      basta informar qual tabela deseja selecionar e ele vai trazer ela completa */
                return _sqlConnection.Get<Role>(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
