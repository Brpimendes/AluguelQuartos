
namespace AluguelDeQuartos {
    class Quarto {
        public string Nome { get; set; }
        public string Email { get; set; }        

        public Quarto() {
        }

        public Quarto(string name, string email) {
            Nome = name;
            Email = email;
        }

        public override string ToString() {
            return "Nome: " + Nome
                   + ", e-mail: " + Email;
        }
    }
}
