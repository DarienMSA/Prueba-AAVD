using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;

namespace testForms
{
    class EnlaceCassandraDarien
    {
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; } /// /// /// ///


        static private Cluster _cluster;
        static private ISession _session;

        private static void conectarDarien()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString(); /// /// /// ///
          


            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _session = _cluster.Connect(_dbKeySpace);
        }

        private static void desconectarDarien()
        {
            _cluster.Dispose();
        }

        public void InsertaDatosDarien(TimeUuid idNota, string nomCliente, string nomEmpresa, List<string> objetos, List<decimal> costo, decimal montoFinal, LocalDate fechaGenerada)
        {
            try
            {
                conectarDarien();
                string qry;
                string query = "BEGIN BATCH\nINSERT INTO nota_compra(idNota, nomCliente, nomEmpresa, fechaGenerada, montoFinal) VALUES({0},'{1}', '{2}', '{3}', {4});\n";
                qry = string.Format(query, idNota, nomCliente, nomEmpresa, fechaGenerada, montoFinal);

                foreach(var data in objetos)
                {
                    qry += "UPDATE nota_compra SET objetos = objetos + ['{0}'] WHERE idNota = {1};\n";
                    qry = string.Format(qry, data, idNota);
                    //_session.Execute(qry);
                }

                

                foreach (var data in costo)
                {
                    qry += "UPDATE nota_compra SET costo = costo + [{0}] WHERE idNota = {1};\n";
                    qry = string.Format(qry, data, idNota);
                    //_session.Execute(qry);
                }
                qry += "APPLY BATCH";
                _session.Execute(qry);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
            }
        }

        public void ActualizarDatosDarien(TimeUuid idNota, string nomCliente, string nomEmpresa, List<string> objetos, List<decimal> costo, decimal montoFinal, LocalDate fechaGenerada)
        {
            try
            {
                conectarDarien();

                /*string qry = "insert into ejemplo(campo1, campo2) values(";
                qry = qry + id.ToString();
                qry = qry + ",'";
                qry = qry + dato;
                qry = qry + "');";*/
                string qry;
                //string query = "insert into ejemplo(campo1, campo2) values({0}, '{1}');";
                string query = "UPDATE nota_compra SET nomCliente = '{0}', nomEmpresa = '{1}', fechaGenerada = '{2}', montoFinal = {3} WHERE idNota = {4};";
                qry = string.Format(query, nomCliente, nomEmpresa, fechaGenerada, montoFinal, idNota);

                _session.Execute(qry);

                query = "UPDATE nota_compra SET objetos = NULL, costo = NULL WHERE idNota = {0};";
                qry = string.Format(query, idNota);
                _session.Execute(qry);

                query = "UPDATE nota_compra SET objetos = objetos + ['{0}'] WHERE idNota = {1};";

                foreach (var data in objetos)
                {
                    qry = string.Format(query, data, idNota);
                    _session.Execute(qry);
                }

                query = "UPDATE nota_compra SET costo = costo + [{0}] WHERE idNota = {1};";

                foreach (var data in costo)
                {
                    qry = string.Format(query, data, idNota);
                    _session.Execute(qry);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
            }
        }

        public void EliminaProdPrecDarien(TimeUuid idNota, int pos, decimal montoTotal)
        {
            try
            {
                conectarDarien();
                string qry;

                string query = "DELETE objetos[{0}] FROM nota_compra WHERE idNota = {1};";
                qry = string.Format(query, pos, idNota);
                _session.Execute(qry);
                qry = "DELETE costo[{0}] FROM nota_compra WHERE idNota = {1};";
                qry = string.Format(qry, pos, idNota);
                _session.Execute(qry);
                qry = "UPDATE nota_compra SET montoFinal = {0} WHERE idNota = {1};";
                qry = string.Format(qry, montoTotal, idNota);
                _session.Execute(qry);


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
            }
        }

        public void EliminarClienteDarien(TimeUuid idNota)
        {
            try
            {
                conectarDarien();

                string qry;
                string query = "DELETE FROM nota_compra WHERE idNota = {0};";
                qry = string.Format(query,  idNota);

                _session.Execute(qry);


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
            }
        }

        public IEnumerable<notaCompra> Get_OneDarien(TimeUuid dato)
        {
            string query = "SELECT * FROM nota_compra WHERE idNota = ?;";
            conectarDarien();
            IMapper mapper = new Mapper(_session);
            IEnumerable<notaCompra> notas = mapper.Fetch<notaCompra>(query, dato);

            desconectarDarien();
            return notas.ToList();
        }

        public IEnumerable<notaCompra> Get_ProductoPrecioDarien(TimeUuid idNota)
        {
            string query = "SELECT objetos, costo FROM nota_compra WHERE idNota = ?;";
            conectarDarien();
            IMapper mapper = new Mapper(_session);
            IEnumerable<notaCompra> notas = mapper.Fetch<notaCompra>(query, idNota);

            desconectarDarien();
            return notas.ToList();
        }

        public List<notaCompra> Get_AllDarien()
        {
            string query = "SELECT * FROM nota_compra;";
            conectarDarien();

            IMapper mapper = new Mapper(_session);
            IEnumerable<notaCompra> notas = mapper.Fetch<notaCompra>(query);

            desconectarDarien();
            return notas.ToList();

        }

    }
}
