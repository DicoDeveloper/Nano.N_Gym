using N_Base.Data.Infra;
using N_Base.Data.Interfaces;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Entity.Objects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace N_Base.Data.Repository
{
    public class CargoRepository : ICargoRepository
    {
        private IContext _context { get; set; }

        public CargoRepository(IContext context) => _context = context;

        public bool Insert(Cargo cargo)
        {
            try
            {
                return _context.Insert(cargo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Cargo.\nMensagem:{ex.Message}");
            }
        }        
        public async Task<IEnumerable<Cargo>> GetAll()
        {
            try
            {
                return await _context.GetCargos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Cargos.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Cargo> Get(long id)
        {
            try
            {
                return await _context.GetCargo(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Cargo.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}