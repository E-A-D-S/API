using PrimeiraApi.Models;

namespace PrimeiraApi.Rotas;

public static class PessoaRotas
{
    public static List<Pessoa> Pessoas = new() 
    
    {
    new (id: Guid.NewGuid(), nome: "Laís"),
    new (id: Guid.NewGuid(), nome: "Daiane"),
    new (id: Guid.NewGuid(), nome: "Jorge")

    };

    public static void MapPessoaRotas(this WebApplication app)

{
    app.MapGet(pattern:"/pessoas", handler: () => Pessoas);

        app.MapGet(pattern: "/pessoas/{nome}", handler: (string nome) =>
{
    var pessoa = Pessoas.Find(x => x.Nome == nome);
    if (pessoa == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(pessoa);
});


 }

}