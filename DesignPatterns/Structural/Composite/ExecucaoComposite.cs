namespace DesignPatterns.Structural.Composite
{
    public class ExecucaoComposite
    {
        public static void Executar()
        {
            var validaCadastro = new Mensagem("O cadastro não foi realizado!");

            var userFormErro = new Mensagem("O usuário informou um nome inválido!");

            var tamanhoNomeForm = new InputFormMessage("O nome precisa possuir mais do que 2 caracteres!");
            var nomeVazioForm = new InputFormMessage("O nome não pode possuir números");

            userFormErro.AdicionarFilha(tamanhoNomeForm);
            userFormErro.AdicionarFilha(nomeVazioForm);

            validaCadastro.AdicionarFilha(userFormErro);

            var domainUsuarioErro = new Mensagem("Problemas ao processar o cadastro de usuário!");

            var cpfUsuarioDomain = new DomainMessage("O Cpf informado está em uso!");
            var emailUsuarioDomain = new DomainMessage("O Email informado está em uso!");

            domainUsuarioErro.AdicionarFilha(cpfUsuarioDomain);
            domainUsuarioErro.AdicionarFilha(emailUsuarioDomain);

            validaCadastro.AdicionarFilha(domainUsuarioErro);
            validaCadastro.ExibirMensagens(2);
        }
    }
}
