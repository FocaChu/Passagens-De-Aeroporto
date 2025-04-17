using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    internal class Program
    {
        #region Listas
        static string menuOp;
        static List<Aviao> frota = new List<Aviao>();
        static List<Piloto> listaPilotos = new List<Piloto>();
        static List<Aeroporto> listaAeroportos = new List<Aeroporto>();
        static List<Voo> listaVoos = new List<Voo>();
        static List<Passagem> listaPassagens = new List<Passagem>();

        #endregion

        #region Listas de Usuarios

        static List<Pessoa> userCliente = new List<Pessoa>();
        static List<Adm> adms = new List<Adm>();

        #endregion

        static void Banner()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"__________       .__  .______   ____            ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"\______   \ ____ |  | |  \   \ /   /___   ____  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@" |       _//  _ \|  | |  |\   Y   /  _ \ /  _ \ ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@" |    |   (  <_> )  |_|  |_\     (  <_> |  <_> )");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@" |____|_  /\____/|____/____/\___/ \____/ \____/ ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"        \/                                      ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            Adm adm1 = new Adm("Jorge");
            adms.Add(adm1);

            Adm adm2 = new Adm("Vitor");
            adms.Add(adm2);

            MenuOp();

        }

        static void MenuOp()
        {
            int option = 1;
            bool selecionado = false;

            Console.CursorVisible = false;

            while (!selecionado)
            {
                Console.Clear();
                Banner();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n*** Bem vindo! ***\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                string[] opcoes = new string[]
                {
                "Login como usuário",
                "Login como administrador"
                };

                for (int i = 0; i < opcoes.Length; i++)
                {
                    Console.ForegroundColor = (i + 1 == option) ? ConsoleColor.DarkCyan : ConsoleColor.White;
                    Console.WriteLine($"{(i + 1 == option ? ">>" : "  ")} {opcoes[i]}");
                }

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (option > 1) option--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (option < opcoes.Length) option++;
                        break;

                    case ConsoleKey.Enter:
                        selecionado = true;
                        break;
                }
            }

            Console.Clear();
            switch (option)
            {
                case 1:
                    MenuUser();
                    break;

                case 2:
                    LoginAdmin();
                    break;
            }

            MenuOp();
        }

        static void LoginAdmin()
        {
            while (true)
            {
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Digite abaixo seu nome de usuario: \nInsira 0 para sair.");
                string procuraAdm = Console.ReadLine();

                if (procuraAdm == "0") break;

                bool isAdmin = adms.Exists(a => a.Nick.Equals(procuraAdm, StringComparison.OrdinalIgnoreCase));

                if (isAdmin)
                {
                    Console.WriteLine("Login bem-sucedido! Bem-vindo, administrador.");
                    Console.ReadKey();
                    MenuAdm();
                    break;
                }
                else
                {
                    Console.WriteLine("Acesso negado. Você não é um administrador.");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }


        }

        static void MenuUser()
        {
            int option = 1;
            bool selecionado = false;

            Console.CursorVisible = false;

            while (!selecionado)
            {
                Console.Clear();

                string[] opcoes = new string[]
                {
            "Comprar Passagem",
            "Ver Passagens",
            "Sair"
                };

                for (int i = 0; i < opcoes.Length; i++)
                {
                    Console.ForegroundColor = (i + 1 == option) ? ConsoleColor.DarkCyan : ConsoleColor.White;
                    Console.WriteLine($"{(i + 1 == option ? ">>" : "  ")} {opcoes[i]}");
                }

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (option > 1) option--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (option < opcoes.Length) option++;
                        break;

                    case ConsoleKey.Enter:
                        selecionado = true;
                        break;
                }
            }

            Console.Clear();
            switch (option)
            {
                case 1: ComprarPassagem(); break;
                case 2: MostrarPassagens(); break;
                case 3: return;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            MenuUser();
        }

        static void MenuAdm()
        {
            int option = 1;
            bool selecionado = false;

            Console.CursorVisible = false;

            while (!selecionado)
            {
                Console.Clear();

                string[] opcoes = new string[]
                {
            "Cadastrar novo avião",
            "Ver aviões cadastrados",
            "Cadastrar novo piloto",
            "Ver Pilotos cadastrados",
            "Cadastrar novo voo",
            "Ver voos cadastrados",
            "Cadastrar novo Aeroporto",
            "Ver aeroportos cadastrados",
            "Entrar no menu de delet",
            "Sair"
                };

                for (int i = 0; i < opcoes.Length; i++)
                {
                    Console.ForegroundColor = (i + 1 == option) ? ConsoleColor.DarkCyan : ConsoleColor.White;
                    Console.WriteLine($"{(i + 1 == option ? ">>" : "  ")} {opcoes[i]}");
                }

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (option > 1) option--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (option < opcoes.Length) option++;
                        break;

                    case ConsoleKey.Enter:
                        selecionado = true;
                        break;
                }
            }

            Console.Clear();
            switch (option)
            {
                case 1: CadastrarAviao(); break;
                case 2: VerAvioes(); break;
                case 3: CadastrarPiloto(); break;
                case 4: VerPilotos(); break;
                case 5: CadastrarVoo(); break;
                case 6: VerVoos(); break;
                case 7: CadastrarAeroporto(); break;
                case 8: VerAeroportos(); break;
                case 9: MenuDeletar(); break;
                case 10: return;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            MenuAdm();
        }

        static void CadastrarAviao()
        {
            string nome;
            do
            {
                Console.Write("Digite o nome do avião: ");
                nome = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nome));

            string modelo;
            do
            {
                Console.Write("Digite o modelo do avião: ");
                modelo = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(modelo));

            List<Assento> assentos = CriarAssentos();

            Aviao novoAviao = new Aviao(nome, modelo, assentos);
            frota.Add(novoAviao);

            Console.WriteLine($"Avião {nome} cadastrado com sucesso!\n");
        }

        static List<Assento> CriarAssentos()
        {
            var assentos = new List<Assento>();

            // Enfia 5 assentos executivos (Fileira C)
            for (int i = 1; i <= 5; i++)
            {
                assentos.Add(new Assento("C", i.ToString(), ClasseAssento.Executiva));
            }

            // Enfia 5 assentos econômicos (Fileira A e B)
            for (int i = 1; i <= 3; i++)
            {
                assentos.Add(new Assento("A", i.ToString(), ClasseAssento.Economica));
            }
            for (int i = 4; i <= 5; i++)
            {
                assentos.Add(new Assento("B", i.ToString(), ClasseAssento.Economica));
            }

            return assentos;
        }

        static void CadastrarPiloto()
        {
            string nome;
            do
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nome));

            DateTime dataNascimento;
            while (true)
            {
                try
                {
                    Console.Write("Data de nascimento (dd/mm/yyyy): ");
                    dataNascimento = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato de data inválido. Por favor, insira a data no formato dd/mm/yyyy.");
                }
            }

            Console.WriteLine("Gênero:");
            foreach (var valor in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{(int)valor} - {valor}");
            }

            Genero genero;
            while (true)
            {
                Console.Write("Digite o número correspondente: ");
                if (int.TryParse(Console.ReadLine(), out int generoInt) && Enum.IsDefined(typeof(Genero), generoInt))
                {
                    genero = (Genero)generoInt;
                    break;
                }
                else
                {
                    Console.WriteLine("Gênero inválido. Tente novamente.");
                }
            }

            string cpf;
            do
            {
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(cpf));

            string telefone;
            do
            {
                Console.Write("Telefone: ");
                telefone = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(telefone));

            string email;
            do
            {
                Console.Write("Email: ");
                email = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(email));

            string especializacao;
            do
            {
                Console.Write("Especialização do piloto: ");
                especializacao = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(especializacao));

            Piloto piloto = new Piloto(especializacao, nome, dataNascimento, genero, cpf, telefone, email);
            listaPilotos.Add(piloto);

            Console.WriteLine($"Piloto {piloto.Nome} cadastrado com sucesso!\n");
        }

        static void VerAvioes()
        {
            foreach (var aviao in frota)
            {
                aviao.ExibirDadosAviao();
            }
        }

        static void VerPilotos()
        {
            foreach (var piloto in listaPilotos)
            {
                piloto.ExibirDadosPiloto();
            }
        }

        static void CadastrarAeroporto()
        {
            Console.WriteLine("=== Cadastro de Aeroporto ===");

            string nome;
            do
            {
                Console.Write("Nome do Aeroporto: ");
                nome = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nome));

            string pais;
            do
            {
                Console.Write("País: ");
                pais = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(pais));

            string estado;
            do
            {
                Console.Write("Estado: ");
                estado = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(estado));

            string cidade;
            do
            {
                Console.Write("Cidade: ");
                cidade = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(cidade));

            string bairro;
            do
            {
                Console.Write("Bairro: ");
                bairro = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(bairro));

            string rua;
            do
            {
                Console.Write("Rua: ");
                rua = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(rua));

            string cep;
            do
            {
                Console.Write("CEP: ");
                cep = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(cep));

            int numero;
            while (true)
            {
                Console.Write("Número: ");
                try
                {
                    numero = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                }
            }

            Endereco endereco = new Endereco(pais, estado, cidade, bairro, rua, cep, numero);
            Aeroporto aeroporto = new Aeroporto(nome, endereco);

            listaAeroportos.Add(aeroporto);

            Console.WriteLine($"\nAeroporto \"{nome}\" cadastrado com sucesso!\n");
        }

        static void VerAeroportos()
        {
            if (listaAeroportos.Count == 0)
            {
                Console.WriteLine("Nenhum aeroporto cadastrado.\n");
                return;
            }

            Console.WriteLine("=== Lista de Aeroportos ===\n");
            foreach (var aeroporto in listaAeroportos)
            {
                aeroporto.ExibirDados();
            }

        }

        static void CadastrarVoo()
        {
            Console.WriteLine("=== Cadastro de Voo ===");

            if (frota.Count == 0 || listaPilotos.Count == 0 || listaAeroportos.Count < 2)
            {
                Console.WriteLine("Cadastro de voo indisponível. Verifique se há aviões, pilotos e aeroportos suficientes.\n");
                return;
            }

            // Escolha do avião
            Console.WriteLine("Escolha um avião:");
            for (int i = 0; i < frota.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {frota[i].Nome} - {frota[i].Modelo}");
            }

            int indexAviao;
            while (true)
            {
                Console.Write("Número do avião: ");
                if (int.TryParse(Console.ReadLine(), out indexAviao) &&
                    indexAviao > 0 && indexAviao <= frota.Count)
                {
                    indexAviao -= 1;
                    break;
                }
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }

            // Escolha do piloto
            Console.WriteLine("Escolha um piloto:");
            for (int i = 0; i < listaPilotos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaPilotos[i].Nome} - {listaPilotos[i].Especializacao}");
            }

            int indexPiloto;
            while (true)
            {
                Console.Write("Número do piloto: ");
                if (int.TryParse(Console.ReadLine(), out indexPiloto) &&
                    indexPiloto > 0 && indexPiloto <= listaPilotos.Count)
                {
                    indexPiloto -= 1;
                    break;
                }
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }

            // Escolha do aeroporto de origem
            Console.WriteLine("Escolha o aeroporto de origem:");
            for (int i = 0; i < listaAeroportos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaAeroportos[i].Nome} - {listaAeroportos[i].Endereco.Cidade}");
            }

            int indexOrigem;
            while (true)
            {
                Console.Write("Número do aeroporto de origem: ");
                if (int.TryParse(Console.ReadLine(), out indexOrigem) &&
                    indexOrigem > 0 && indexOrigem <= listaAeroportos.Count)
                {
                    indexOrigem -= 1;
                    break;
                }
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }

            // Escolha do aeroporto de destino (não pode ser o mesmo)
            Console.WriteLine("Escolha o aeroporto de destino:");
            for (int i = 0; i < listaAeroportos.Count; i++)
            {
                if (i == indexOrigem) continue;
                Console.WriteLine($"{i + 1}. {listaAeroportos[i].Nome} - {listaAeroportos[i].Endereco.Cidade}");
            }

            int indexDestino;
            while (true)
            {
                Console.Write("Número do aeroporto de destino: ");
                if (int.TryParse(Console.ReadLine(), out indexDestino) &&
                    indexDestino > 0 && indexDestino <= listaAeroportos.Count &&
                    indexDestino - 1 != indexOrigem)
                {
                    indexDestino -= 1;
                    break;
                }
                Console.WriteLine("Entrada inválida ou aeroporto igual à origem. Tente novamente.");
            }

            // Data de partida
            DateTime partida;
            while (true)
            {
                Console.Write("Data e hora de partida (ex: 2025-04-05 14:30): ");
                if (DateTime.TryParse(Console.ReadLine(), out partida))
                    break;

                Console.WriteLine("Formato de data e hora inválido. Tente novamente.");
            }

            // Data de chegada
            DateTime chegada;
            while (true)
            {
                Console.Write("Data e hora de chegada (ex: 2025-04-05 18:45): ");
                if (DateTime.TryParse(Console.ReadLine(), out chegada))
                    break;

                Console.WriteLine("Formato de data e hora inválido. Tente novamente.");
            }

            Voo voo = new Voo(
                frota[indexAviao],
                listaPilotos[indexPiloto],
                partida,
                chegada,
                listaAeroportos[indexOrigem],
                listaAeroportos[indexDestino]
            );

            listaVoos.Add(voo);
            Console.WriteLine("\nVoo cadastrado com sucesso!\n");
        }

        static void VerVoos()
        {
            if (listaVoos.Count == 0)
            {
                Console.WriteLine("Nenhum voo cadastrado.\n");
                return;
            }

            Console.WriteLine("=== Lista de Voos ===\n");
            foreach (var voo in listaVoos)
            {
                voo.ExibirDados();
            }
        }

        static void ComprarPassagem()
        {
            if (listaVoos.Count == 0)
            {
                Console.WriteLine("Nenhum voo disponível para compra.");
                return;
            }

            Console.WriteLine("=== Lista de Voos ===");
            for (int i = 0; i < listaVoos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Voo {listaVoos[i].ID} de {listaVoos[i].Origem.Nome} para {listaVoos[i].Destino.Nome}");
            }

            int indexVoo;
            while (true)
            {
                Console.Write("Escolha um voo: ");
                if (int.TryParse(Console.ReadLine(), out indexVoo) && indexVoo > 0 && indexVoo <= listaVoos.Count)
                    break;

                Console.WriteLine("Entrada inválida. Escolha um número de voo válido.");
            }
            var vooSelecionado = listaVoos[indexVoo - 1];
            var aviao = vooSelecionado.Aviao;

            var assentosDisponiveis = aviao.Assentos
                .Where(a => !listaPassagens.Any(g => g.Voo == vooSelecionado && g.Assento == a)).ToList();

            if (assentosDisponiveis.Count == 0)
            {
                Console.WriteLine("Não há assentos disponíveis neste voo.");
                return;
            }

            Console.WriteLine("=== Assentos disponíveis ===");
            for (int i = 0; i < assentosDisponiveis.Count; i++)
            {
                var a = assentosDisponiveis[i];
                Console.WriteLine($"{i + 1}. Fileira {a.Fileira}, Número {a.Numero} - Classe: {a.Classe}");
            }

            int indexAssento;
            while (true)
            {
                Console.Write("Escolha um assento: ");
                if (int.TryParse(Console.ReadLine(), out indexAssento) && indexAssento > 0 && indexAssento <= assentosDisponiveis.Count)
                    break;

                Console.WriteLine("Entrada inválida. Escolha um número de assento válido.");
            }
            var assentoEscolhido = assentosDisponiveis[indexAssento - 1];

            Console.WriteLine("=== Cadastro de Passageiro ===");

            string nome;
            do
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nome));

            DateTime dataNasc;
            while (true)
            {
                Console.Write("Data de nascimento (yyyy-mm-dd): ");
                try
                {
                    dataNasc = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Data inválida. Por favor, use o formato yyyy-mm-dd.");
                }
            }

            Genero genero;
            while (true)
            {
                Console.Write("Gênero (0 - Feminino, 1 - Masculino, 2 - Não Binário, 3 - Não Informado, 4 - Outro): ");
                if (Enum.TryParse(Console.ReadLine(), out genero) && Enum.IsDefined(typeof(Genero), genero))
                    break;

                Console.WriteLine("Gênero inválido.");
            }

            string cpf;
            do
            {
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(cpf));

            string tel;
            do
            {
                Console.Write("Telefone: ");
                tel = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(tel));

            string email;
            do
            {
                Console.Write("Email: ");
                email = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(email));


            Passageiro passageiro = new Passageiro(new List<Bagagem>(), nome, dataNasc, genero, cpf, tel, email);

            Console.Write("Deseja adicionar bagagem? (s/n): ");
            if (Console.ReadLine().ToLower() == "s")
            {
                while (true)
                {
                    TipoBagagem tipo;
                    while (true)
                    {
                        Console.Write("Tipo (0 - Mão, 1 - Despachada): ");
                        if (Enum.TryParse(Console.ReadLine(), out tipo) && Enum.IsDefined(typeof(TipoBagagem), tipo))
                            break;

                        Console.WriteLine("Tipo de bagagem inválido.");
                    }

                    double peso;
                    while (true)
                    {
                        Console.Write("Peso: ");
                        if (double.TryParse(Console.ReadLine(), out peso) && peso > 0)
                            break;

                        Console.WriteLine("Peso inválido.");
                    }

                    Bagagem bagagem = new Bagagem { Tipo = tipo, Peso = peso };
                    passageiro.Bagagens.Add(bagagem);

                    Console.Write("Adicionar mais bagagens? (s/n): ");
                    if (Console.ReadLine().ToLower() != "s")
                        break;
                }
            }

            Passagem passagem = new Passagem
            {
                Passageiro = passageiro,
                Voo = vooSelecionado,
                Assento = assentoEscolhido,
                Preco = (decimal)new Passagem
                {
                    Passageiro = passageiro,
                    Assento = assentoEscolhido
                }.CalcularPreco()
            };

            listaPassagens.Add(passagem);
            vooSelecionado.Passageiros.Add(passageiro);

            Console.WriteLine($"\nPassagem comprada com sucesso! Preço total: R${passagem.Preco:F2}\n");
        }

        static void MostrarPassagens()
        {
            if (listaPassagens.Count == 0)
            {
                Console.WriteLine("Nenhuma passagem foi comprada ainda.");
                return;
            }

            Console.WriteLine("\n=== PASSAGENS COMPRADAS ===\n");

            foreach (var passagem in listaPassagens)
            {
                var passageiro = passagem.Passageiro;
                var voo = passagem.Voo;
                var assento = passagem.Assento;

                Console.WriteLine($"Passagem ID: {passagem.ID}");
                Console.WriteLine($"Voo: {voo.Origem.Nome} -> {voo.Destino.Nome}");
                Console.WriteLine($"Data/Hora de Partida: {voo.DataHoraPartida}");
                Console.WriteLine($"Data/Hora de Chegada: {voo.DataHoraChegada}");
                Console.WriteLine($"Assento: Fileira {assento.Fileira}, Número {assento.Numero} ({assento.Classe})");
                Console.WriteLine($"Passageiro: {passageiro.Nome} | CPF: {passageiro.CPF} | Email: {passageiro.Email}");
                Console.WriteLine($"Bagagens:");

                if (passagem.Passageiro.Bagagens.Count == 0)
                {
                    Console.WriteLine("Nenhuma bagagem registrada.");
                }
                else
                {
                    foreach (var bagagem in passagem.Passageiro.Bagagens)
                    {
                        Console.WriteLine($"  - Tipo: {bagagem.Tipo}, Peso: {bagagem.Peso}kg, Preço: R${bagagem.CalcularPreco():F2}");
                    }
                }

                Console.WriteLine($"Preço total: R${passagem.Preco:F2}");
                Console.WriteLine(new string('-', 40));
            }
        }

        static void MenuDeletar()
        {
            int option = 1;
            bool selecionado = false;

            Console.CursorVisible = false;

            while (!selecionado)
            {
                Console.Clear();
                Console.WriteLine("*** Menu Deletar ***\n");

                string[] opcoes = new string[]
                {
            "Deletar avião",
            "Deletar piloto",
            "Deletar voo",
            "Deletar aeroporto",
            "Sair"
                };

                for (int i = 0; i < opcoes.Length; i++)
                {
                    Console.ForegroundColor = (i + 1 == option) ? ConsoleColor.Red : ConsoleColor.White;
                    Console.WriteLine($"{(i + 1 == option ? ">>" : "  ")} {opcoes[i]}");
                }

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (option > 1) option--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (option < opcoes.Length) option++;
                        break;

                    case ConsoleKey.Enter:
                        selecionado = true;
                        break;
                }
            }

            Console.Clear();
            switch (option)
            {
                case 1: DeletarAviao(); break;
                case 2: DeletarPiloto(); break;
                case 3: DeletarVoo(); break;
                case 4: DeletarAeroporto(); break;
                case 5: return;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            MenuDeletar(); 
        }

        static void DeletarAviao()
        {
            if (frota.Count == 0)
            {
                Console.WriteLine("Nenhum avião disponível para deletar.");
                return;
            }

            Console.WriteLine("=== Lista de Aviões ===");
            for (int i = 0; i < frota.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {frota[i].Nome} - {frota[i].Modelo}");
            }

            Console.Write("Escolha o número do avião que deseja deletar: ");
            int indexAviao = int.Parse(Console.ReadLine()) - 1;

            if (indexAviao >= 0 && indexAviao < frota.Count)
            {
                frota.RemoveAt(indexAviao);
                Console.WriteLine("Avião deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }

        static void DeletarPiloto()
        {
            if (listaPilotos.Count == 0)
            {
                Console.WriteLine("Nenhum piloto disponível para deletar.");
                return;
            }

            Console.WriteLine("=== Lista de Pilotos ===");
            for (int i = 0; i < listaPilotos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaPilotos[i].Nome} - {listaPilotos[i].Especializacao}");
            }

            Console.Write("Escolha o número do piloto que deseja deletar: ");
            int indexPiloto = int.Parse(Console.ReadLine()) - 1;

            if (indexPiloto >= 0 && indexPiloto < listaPilotos.Count)
            {
                listaPilotos.RemoveAt(indexPiloto);
                Console.WriteLine("Piloto deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }

        static void DeletarVoo()
        {
            if (listaVoos.Count == 0)
            {
                Console.WriteLine("Nenhum voo disponível para deletar.");
                return;
            }

            Console.WriteLine("=== Lista de Voos ===");
            for (int i = 0; i < listaVoos.Count; i++)
            {
                var voo = listaVoos[i];
                Console.WriteLine($"{i + 1}. Voo {voo.ID} de {voo.Origem.Nome} para {voo.Destino.Nome} - Partida: {voo.DataHoraPartida} - Chegada: {voo.DataHoraChegada}");
            }

            Console.Write("Escolha o número do voo que deseja deletar: ");
            int indexVoo = int.Parse(Console.ReadLine()) - 1;

            if (indexVoo >= 0 && indexVoo < listaVoos.Count)
            {
                listaVoos.RemoveAt(indexVoo);
                Console.WriteLine("Voo deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }

        static void DeletarAeroporto()
        {
            if (listaAeroportos.Count == 0)
            {
                Console.WriteLine("Nenhum aeroporto disponível para deletar.");
                return;
            }

            Console.WriteLine("=== Lista de Aeroportos ===");
            for (int i = 0; i < listaAeroportos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaAeroportos[i].Nome} - {listaAeroportos[i].Endereco.Cidade}");
            }

            Console.Write("Escolha o número do aeroporto que deseja deletar: ");
            int indexAeroporto = int.Parse(Console.ReadLine()) - 1;

            if (indexAeroporto >= 0 && indexAeroporto < listaAeroportos.Count)
            {
                listaAeroportos.RemoveAt(indexAeroporto);
                Console.WriteLine("Aeroporto deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }

    }
}