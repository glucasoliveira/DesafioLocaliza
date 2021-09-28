using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Novo.Dao.Interfaces;
using Novo.Models;
using Novo.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace Novo.Tests.Services {

    [TestClass]
    public class ClienteBOTest {

        [TestMethod]
        public void BuscaClientes() {
            Mock<IClienteDao> mockDao = new Mock<IClienteDao>();

            List<Cliente> clientes = new List<Cliente>() {
                new Cliente() {
                    Cpf = 12346579810,
                    Nome = "João"
                },
                new Cliente() {
                    Cpf = 12346579811,
                    Nome = "Pedro"
                },
            };

            mockDao.Setup(dao => dao.BuscarClientes()).Returns(clientes);

            ClienteBOImpl bo = new ClienteBOImpl(mockDao.Object);

            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.SetConfiguration(new HttpConfiguration());
            HttpResponseMessage expectedResult = httpRequest.CreateResponse(System.Net.HttpStatusCode.OK,clientes);

            HttpResponseMessage resultBo = bo.BuscarClientes(httpRequest);

            Assert.IsTrue(resultBo.StatusCode == expectedResult.StatusCode);
            Assert.IsTrue(resultBo.Content.ReadAsStringAsync().Result == expectedResult.Content.ReadAsStringAsync().Result);
        }
    }
}