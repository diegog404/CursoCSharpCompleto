/* membros estáticos
 
- São membros de classe, podem ser usados indenpendente de objetos. Servem em classes utilitárias e
declaração de constantes.

Console.Write("Entre o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = Calculadora.Circunferencia(raio);
double volume = Calculadora.Volume(raio);

Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


tipos referência e tipos valor

- variáveis do tipo classe são ponteiros que apontam para objetos na memória
- tipos referência podem ser null, não apontam para ninguém

- structs são tipos valor, são caixas que armazenam os valores
- uma variável que recebe outra, gera simplesmente uma cópia do valor da variável alvo.

- utilizar new em qualquer tipo estruturado gera um valor padrão aos elementos.


desalocação por garbage collector e desalocação por escopo

- O garbage collector desaloca automaticamente objetos que não estão sendo mais usados.
- a desalocação por escopo exclui todas as variáveis e objetos de um escopo local que não está sendo mais usado.


nullable

- Nullable permite que dados do tipo struct possam receber null. Utilizável onde vc quer colocar 
dados que possam valer nulo(data de nascimento, algum valor numérico).
*/