using Novo.Dao.Interfaces;
using Novo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Novo.Dao {

    public class ContratoDaoImpl : IContratoDao {

        public List<Contrato> BuscarContratos() {
            using(var model = new EnterpriseDatabaseEntities()) {
                return model.Contratos.ToList();
            }
        }

        public List<Contrato> BuscarContratos(long cpf) {
            using(var model = new EnterpriseDatabaseEntities()) {
                return model.Contratos.Where(Contrato => Contrato.CpfCliente == cpf).ToList();
            }
        }

        public List<Contrato> BuscarContratos(int id) {
            using(var model = new EnterpriseDatabaseEntities()) {
                return model.Contratos.Where(Contrato => Contrato.Id == id).ToList();
            }
        }

        public Contrato CriarContrato(Contrato Contrato) {
            using(var model = new EnterpriseDatabaseEntities()) {
                model.Contratos.Add(Contrato);
                model.SaveChanges();
                return BuscarContratos(Contrato.Id).FirstOrDefault();
            }
        }

        public Contrato AtualizarContrato(Contrato contratoAlterado,int id) {
            Contrato contrato = BuscarContratos(id).FirstOrDefault();
            using(var model = new EnterpriseDatabaseEntities()) {
                if(contrato == null)
                    return null;
                else {
                    contrato.CpfCliente = contratoAlterado.CpfCliente;
                    contrato.DataFim = contratoAlterado.DataFim;
                    contrato.DataInicio = contratoAlterado.DataInicio;
                    contrato.IdVeiculo = contratoAlterado.IdVeiculo;
                    contrato.Valor = contratoAlterado.Valor;
                    model.Entry(contrato).State = System.Data.Entity.EntityState.Modified;
                    model.SaveChanges();
                }
            }
            return contrato;
        }
    }
}