using H1Store.Catalogo.Data.EntityFramework;
using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Data.Repository
{
	public class CartaRepository : ICriancaRepository
	{
		private readonly Contexto _context;

		#region - Construtores
		public CartaRepository(Contexto context)
        {
            _context = context;
        }



        #endregion

        #region - Funções

        public async Task Adicionar(Crianca carta)
        {
            try
            {
                await _context.Carta.AddAsync(carta);
                await _context.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a carta: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Crianca>> ObterTodos()
        {
            try
            {
                return await _context.Carta.ToListAsync();
            }

            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a carta: {ex.Message}");
            }
        }

        #endregion





    }
}
