using System;

namespace CrudPessoas.Models
{
    /// <summary>
    /// Representa uma pessoa com um identificador único e um nome.
    /// </summary>
    public class Pessoa
    {
        /// <summary>
        /// Identificador único para a pessoa.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Nome da pessoa.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Cria uma nova instância de <see cref="Pessoa"/> com o identificador e o nome especificados.
        /// </summary>
        /// <param name="id">O identificador único para a pessoa.</param>
        /// <param name="nome">O nome da pessoa.</param>
        /// <exception cref="ArgumentNullException">Lançada se o nome for nulo.</exception>
        public Pessoa(Guid id, string nome)
        {
            Id = id;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), "Nome não pode ser nulo.");
        }

        /// <summary>
        /// Cria uma nova instância padrão de <see cref="Pessoa"/> com um identificador único e um nome padrão.
        /// </summary>
        public Pessoa()
        {
            Id = Guid.NewGuid();  // Cria um novo identificador único
            Nome = "Nome Padrão";  // Define um nome padrão
        }
    }
}
