// RELAÇÃO DE ASSOCIAÇÂO

using System.Net;

Console.WriteLine("Relação de Associação");

Paciente p1 = new Paciente("Joao");
Medico m1 = new Medico("Roberto");

m1.AtenderPaciente(p1);
Console.WriteLine(p1.Nome);


//RELAÇÃO DE AGREGAÇÃO

Console.WriteLine("Relação de Agregação");

Aluno aluno1 = new Aluno("Jose");
Aluno aluno2 = new Aluno("Maria");

Universidade universidade = new Universidade();
universidade.AdicionarAluno(aluno1);
universidade.AdicionarAluno(aluno2);

universidade.MostrarAlunos();

//RELAÇÃO DE COMPOSIÇÃO

Console.WriteLine("Relação de Composição");


Casa c1 = new Casa();
c1.AdicionarComodo(new Comodo("Sala"));
c1.AdicionarComodo(new Comodo("Cozinha"));
c1.AdicionarComodo(new Comodo("Quarto"));
c1.MostrarComodos();

c1 = new Casa();
c1.MostrarComodos();


