using DDD.Domain.Universidade.PicManagementContext;
using DDD.Infra.SqlServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServer.Repositories
{
    public class PosGraduacaoRepositorySqlServer : IPosGraduacaoRepository
    {
        private readonly SqlContext _context;

        public PosGraduacaoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public PosGraduacao GetPosGraduacaoById(int idProjeto)
        {
            return _context.PosGraduacoes.Find(idProjeto);
        }

        public PosGraduacao InsertPosGraduacao(int ProjetoId, int idPesquisador)
        {

            var posGraduacao = new PosGraduacao
            {
                pesquisadorID = idPesquisador,
                ProjetoId = ProjetoId
            };

            try
            {

                _context.PosGraduacoes.Add(posGraduacao);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                var msg = ex.InnerException;
                throw;
            }

            return posGraduacao;
        }
    }
}