using Novo.Dao;
using Novo.Dao.Interfaces;
using Novo.Services;
using Novo.Services.Interface;

namespace Novo {

    public static class FactoryManager {
        private static IVeiculoDao veiculoDao;
        private static IVeiculoBO veiculoBo;

        private static IContratoDao contratoDao;
        private static IContratoBO contratoBo;

        private static IClienteDao clienteDao;
        private static IClienteBO clienteBo;

        public static IClienteDao GetClienteDao() {
            if(clienteDao != null)
                return clienteDao;
            else
                clienteDao = new ClienteDaoImpl();

            return clienteDao;
        }

        public static IClienteBO GetClienteBO() {
            if(clienteBo != null)
                return clienteBo;
            else
                clienteBo = new ClienteBOImpl();

            return clienteBo;
        }

        public static IContratoDao GetContratoDao() {
            if(contratoDao != null)
                return contratoDao;
            else
                contratoDao = new ContratoDaoImpl();

            return contratoDao;
        }

        public static IContratoBO GetContratoBO() {
            if(contratoBo != null)
                return contratoBo;
            else
                contratoBo = new ContratoBOImpl();

            return contratoBo;
        }

        public static IVeiculoDao GetVeiculoDao() {
            if(veiculoDao != null)
                return veiculoDao;
            else
                veiculoDao = new VeiculoDaoImpl();

            return veiculoDao;
        }

        public static IVeiculoBO GetVeiculoBO() {
            if(veiculoBo != null)
                return veiculoBo;
            else
                veiculoBo = new VeiculoBOImpl();

            return veiculoBo;
        }
    }
}