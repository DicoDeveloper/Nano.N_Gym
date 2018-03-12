using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Infra;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Entity.Objects;
using N_Base.Data.Interfaces;

namespace N_Base.Data.Repository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private IContext _context { get; set; }
        public bool Insert(Endereco endereco)
        {
            try
            {
                return _context.Insert(endereco);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Endereço.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<Endereco>> GetAll()
        {
            try
            {
                return await _context.GetEnderecos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Endereços.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Endereco> Get(long id)
        {
            try
            {
                return await _context.GetEndereco(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Endereço.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}