using Microsoft.AspNetCore.Mvc;
using CrudPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudPessoas.Controllers
{
    /// <summary>
    /// Controlador responsável por gerenciar operações CRUD (Create, Read, Update, Delete) sobre o objeto Pessoa.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        /// <summary>
        /// Lista de pessoas simulada. Em uma aplicação real, você pode usar um serviço ou repositório para gerenciar os dados.
        /// </summary>
        private static readonly List<Pessoa> Pessoas = new()
        {
            new Pessoa { Id = Guid.NewGuid(), Nome = "Laís" },
            new Pessoa { Id = Guid.NewGuid(), Nome = "Daiane" },
            new Pessoa { Id = Guid.NewGuid(), Nome = "Jorge" }
        };

        /// <summary>
        /// Obtém a lista de todas as pessoas.
        /// </summary>
        /// <returns>Uma lista contendo todas as pessoas.</returns>
        [HttpGet]
        public IActionResult GetPessoas()
        {
            return Ok(Pessoas);
        }

        /// <summary>
        /// Obtém uma pessoa pelo ID especificado.
        /// </summary>
        /// <param name="id">ID da pessoa a ser encontrada.</param>
        /// <returns>Uma ação HTTP contendo a pessoa correspondente ao ID ou um código de status HTTP 404 se não encontrada.</returns>
        [HttpGet("{id:guid}")]
        public IActionResult GetPessoa(Guid id)
        {
            var pessoa = Pessoas.FirstOrDefault(p => p.Id == id);
            if (pessoa == null)
            {
                return NotFound(); // Retorna 404 se a pessoa não for encontrada.
            }

            return Ok(pessoa); // Retorna a pessoa encontrada com código HTTP 200.
        }

        /// <summary>
        /// Cria uma nova pessoa com os dados fornecidos.
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa contendo os dados a serem criados.</param>
        /// <returns>Ação HTTP com código 201 e a nova pessoa criada, ou código 400 para dados inválidos.</returns>
        [HttpPost]
        public IActionResult CreatePessoa([FromBody] Pessoa pessoa)
        {
            if (pessoa == null || string.IsNullOrEmpty(pessoa.Nome))
            {
                return BadRequest("Dados da pessoa são inválidos."); // Retorna 400 para dados inválidos.
            }

            pessoa.Id = Guid.NewGuid();
            Pessoas.Add(pessoa);
            return CreatedAtAction(nameof(GetPessoa), new { id = pessoa.Id }, pessoa); // Retorna 201 com a nova pessoa.
        }

        /// <summary>
        /// Atualiza uma pessoa existente com um ID específico.
        /// </summary>
        /// <param name="id">ID da pessoa a ser atualizada.</param>
        /// <param name="pessoa">Objeto Pessoa com os dados atualizados.</param>
        /// <returns>Ação HTTP com código 200 e a pessoa atualizada, ou código 404 se não encontrada.</returns>
        [HttpPut("{id:guid}")]
        public IActionResult UpdatePessoa(Guid id, [FromBody] Pessoa pessoa)
        {
            var pessoaExistente = Pessoas.FirstOrDefault(p => p.Id == id);
            if (pessoaExistente == null)
            {
                return NotFound(); // Retorna 404 se a pessoa não for encontrada.
            }

            if (string.IsNullOrEmpty(pessoa.Nome))
            {
                return BadRequest("O nome da pessoa é inválido."); // Retorna 400 para dados inválidos.
            }

            pessoaExistente.Nome = pessoa.Nome;
            return Ok(pessoaExistente); // Retorna 200 com a pessoa atualizada.
        }

        /// <summary>
        /// Remove uma pessoa pelo ID especificado.
        /// </summary>
        /// <param name="id">ID da pessoa a ser removida.</param>
        /// <returns>Ação HTTP com código 204 se a pessoa foi removida com sucesso, ou código 404 se não encontrada.</returns>
        [HttpDelete("{id:guid}")]
        public IActionResult DeletePessoa(Guid id)
        {
            var pessoa = Pessoas.FirstOrDefault(p => p.Id == id);
            if (pessoa == null)
            {
                return NotFound(); // Retorna 404 se a pessoa não for encontrada.
            }

            Pessoas.Remove(pessoa);
            return NoContent(); // Retorna 204 ao remover com sucesso.
        }
    }
}
