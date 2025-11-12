# 📝 Exercícios - Referências vs Valores

## 🎯 Objetivo

Praticar value types, reference types, structs, records, ref/out/in parameters e boxing/unboxing.

---

## ✏️ Exercício 1: Comparando Value vs References

**Dificuldade**: ⭐ Iniciante

Crie e teste o comportamento de cópia:

**Struct** (value type):
```csharp
public struct PontoStruct
{
    public int X { get; set; }
    public int Y { get; set; }
}
```

**Class** (reference type):
```csharp
public class PontoClass
{
    public int X { get; set; }
    public int Y { get; set; }
}
```

**Teste**: Crie dois pontos de cada tipo, copie um para o outro, modifique a cópia e veja o resultado!

---

## ✏️ Exercício 2: Métodos com ref e out

**Dificuldade**: ⭐⭐ Intermediário

Crie uma classe `Calculadora` com métodos:

**Com ref**:
- `Dobrar(ref int numero)` - dobra o valor
- `Trocar(ref int a, ref int b)` - troca valores

**Com out**:
- `Dividir(int a, int b, out int quociente, out int resto)`
- `ConverterParaInt(string texto, out int resultado)` - retorna bool

**Com retorno de tupla** (alternativa ao out):
- `DividirComTupla(int a, int b)` - retorna `(int quociente, int resto)`

Teste todos e compare as abordagens!

---

## ✏️ Exercício 3: Struct para Coordenadas

**Dificuldade**: ⭐⭐ Intermediário

Crie um `struct Coordenada`:

**Properties**:
- `Latitude` (double)
- `Longitude` (double)

**Construtores**:
- `Coordenada(double lat, double lon)`

**Métodos**:
- `DistanciaPara(Coordenada outra)` - fórmula de Haversine simplificada
- `EstaNoHemisferioNorte()` - latitude > 0
- `EstaNoHemisferioSul()` - latitude < 0
- `ToString()` override - formato "Lat: X, Lon: Y"

**Por que usar struct?**: É pequeno (16 bytes), representa valor único, imutável idealmente.

---

## ✏️ Exercício 4: Record para Dados Imutáveis

**Dificuldade**: ⭐⭐ Intermediário

Crie um `record Pessoa`:

```csharp
public record Pessoa(string Nome, string CPF, DateTime DataNascimento);
```

**Adicione**:
- Property calculada: `Idade` (anos)
- Método: `ComNome(string novoNome)` - retorna nova pessoa com nome alterado

**Teste**:
- Crie duas pessoas
- Compare com `==` (comparação por valor)
- Use `with` para criar variações
- Teste a deconstrução: `var (nome, cpf, data) = pessoa;`

---

## ✏️ Exercício 5: Boxing e Unboxing

**Dificuldade**: ⭐ Iniciante

Demonstre boxing e unboxing:

```csharp
// Boxing
int numero = 42;
object obj = numero;  // Boxing

// Unboxing
int numeroNovamente = (int)obj;  // Unboxing

// Problema de performance
ArrayList lista = new ArrayList();
for (int i = 0; i < 1000; i++)
    lista.Add(i);  // Boxing 1000 vezes!

// Solução
List<int> listaGenerica = new List<int>();
for (int i = 0; i < 1000; i++)
    listaGenerica.Add(i);  // Sem boxing!
```

**Tarefa**: Crie exemplos e meça performance (use `Stopwatch`).

---

## ✏️ Exercício 6: Struct vs Class - Performance

**Dificuldade**: ⭐⭐⭐ Avançado

Compare performance entre struct e class:

**Struct**:
```csharp
public struct PontoStruct
{
    public double X { get; init; }
    public double Y { get; init; }
    public double Z { get; init; }
}
```

**Class**:
```csharp
public class PontoClass
{
    public double X { get; init; }
    public double Y { get; init; }
    public double Z { get; init; }
}
```

**Teste**:
1. Crie array de 1.000.000 de pontos (struct e class)
2. Meça tempo de criação
3. Meça tempo de acesso
4. Meça uso de memória (aproximado)

**Use**: `Stopwatch` para tempo, `GC.GetTotalMemory()` para memória.

---

## ✏️ Exercício 7: Passagem por Referência com in

**Dificuldade**: ⭐⭐ Intermediário

Crie um struct grande:

```csharp
public struct DadosComplexos
{
    public long Valor1, Valor2, Valor3, Valor4;
    public double Data1, Data2, Data3, Data4;
    public decimal Money1, Money2, Money3, Money4;
}
```

**Métodos**:
1. Sem modificador (copia struct):
```csharp
double Calcular(DadosComplexos dados)
```

2. Com `in` (passa por referência readonly):
```csharp
double Calcular(in DadosComplexos dados)
```

**Compare**: Performance e comportamento.

---

## ✏️ Exercício 8: Record Struct (C# 10)

**Dificuldade**: ⭐⭐ Intermediário

Crie um `record struct Dimensoes`:

```csharp
public record struct Dimensoes(double Largura, double Altura, double Profundidade)
{
    public double Volume => Largura * Altura * Profundidade;
}
```

**Teste**:
- Criação e cópia (value type)
- Comparação por valor
- `with` expressions
- ToString() automático
- Deconstrução

**Compare com**: struct normal e record class.

---

## ✏️ Exercício 9: Tuplas para Múltiplos Retornos

**Dificuldade**: ⭐⭐ Intermediário

Crie uma classe `Estatisticas` com métodos que retornam tuplas:

```csharp
public class Estatisticas
{
    // Retorna (media, minimo, maximo)
    public (double Media, int Minimo, int Maximo) Analisar(int[] numeros)
    
    // Retorna (aprovados, reprovados, recuperacao)
    public (int Aprovados, int Reprovados, int Recuperacao) 
        AnalisarNotas(double[] notas)
    
    // Retorna dados completos
    public (double Media, double Mediana, double Moda, double DesvioPadrao) 
        EstatisticasCompletas(int[] valores)
}
```

**Teste**: Use deconstrução para pegar os valores:
```csharp
var (media, min, max) = stats.Analisar(numeros);
```

---

## ✏️ Exercício 10: Sistema de Geometria (PROJETO FINAL)

**Dificuldade**: ⭐⭐⭐ Avançado

Crie um sistema completo usando structs, records e classes adequadamente:

### Struct `Ponto2D`
```csharp
public struct Ponto2D
{
    public double X { get; init; }
    public double Y { get; init; }
    
    public double DistanciaPara(in Ponto2D outro)
    public Ponto2D Mover(double deltaX, double deltaY)
}
```

### Struct `Ponto3D`
```csharp
public struct Ponto3D
{
    public double X { get; init; }
    public double Y { get; init; }
    public double Z { get; init; }
    
    public double DistanciaPara(in Ponto3D outro)
    public Ponto3D Mover(double deltaX, double deltaY, double deltaZ)
}
```

### Record `Cor`
```csharp
public record Cor(byte R, byte G, byte B)
{
    public string ToHex() => $"#{R:X2}{G:X2}{B:X2}";
    
    // Cores pré-definidas
    public static Cor Vermelho => new(255, 0, 0);
    public static Cor Verde => new(0, 255, 0);
    public static Cor Azul => new(0, 0, 255);
}
```

### Class `FormaGeometrica`
```csharp
public class FormaGeometrica
{
    public string Nome { get; set; }
    public Cor CorPreenchimento { get; set; }
    public Ponto2D Centro { get; set; }
    
    public virtual double CalcularArea();
    public virtual double CalcularPerimetro();
    
    public void Mover(double deltaX, double deltaY)
    {
        Centro = Centro.Mover(deltaX, deltaY);
    }
}
```

### Class `Circulo` : FormaGeometrica
```csharp
public class Circulo : FormaGeometrica
{
    public double Raio { get; set; }
    
    public override double CalcularArea() => Math.PI * Raio * Raio;
    public override double CalcularPerimetro() => 2 * Math.PI * Raio;
    
    public bool ContemPonto(in Ponto2D ponto)
    {
        return Centro.DistanciaPara(ponto) <= Raio;
    }
}
```

### Class `Retangulo` : FormaGeometrica
```csharp
public class Retangulo : FormaGeometrica
{
    public double Largura { get; set; }
    public double Altura { get; set; }
    
    public override double CalcularArea() => Largura * Altura;
    public override double CalcularPerimetro() => 2 * (Largura + Altura);
    
    // Retorna os 4 cantos
    public (Ponto2D SuperiorEsquerdo, Ponto2D SuperiorDireito, 
            Ponto2D InferiorEsquerdo, Ponto2D InferiorDireito) ObterCantos()
}
```

### Class `GerenciadorFormas`
```csharp
public class GerenciadorFormas
{
    private List<FormaGeometrica> formas = new();
    
    public void Adicionar(FormaGeometrica forma)
    public void Remover(FormaGeometrica forma)
    
    // Retorna estatísticas
    public (double AreaTotal, double PerimetroTotal, int Quantidade) 
        ObterEstatisticas()
    
    public void MoverTodas(double deltaX, double deltaY)
    public List<FormaGeometrica> BuscarPorCor(Cor cor)
    
    public void ExibirResumo()
}
```

**Teste Completo**:
```csharp
var gerenciador = new GerenciadorFormas();

// Criar formas
var circulo = new Circulo
{
    Nome = "Círculo 1",
    Centro = new Ponto2D { X = 0, Y = 0 },
    Raio = 10,
    CorPreenchimento = Cor.Vermelho
};

var retangulo = new Retangulo
{
    Nome = "Retângulo 1",
    Centro = new Ponto2D { X = 20, Y = 20 },
    Largura = 30,
    Altura = 20,
    CorPreenchimento = Cor.Azul
};

gerenciador.Adicionar(circulo);
gerenciador.Adicionar(retangulo);

// Mover todas as formas
gerenciador.MoverTodas(10, 10);

// Estatísticas
var (areaTotal, perimetroTotal, qtd) = gerenciador.ObterEstatisticas();
Console.WriteLine($"Total: {qtd} formas, Área: {areaTotal:F2}, Perímetro: {perimetroTotal:F2}");

// Buscar por cor
var formasVermelhas = gerenciador.BuscarPorCor(Cor.Vermelho);

gerenciador.ExibirResumo();
```

**Conceitos Demonstrados**:
- ✅ Structs para pontos (value types pequenos)
- ✅ Records para cores (dados imutáveis)
- ✅ Classes para formas (reference types complexos)
- ✅ Tuplas para múltiplos retornos
- ✅ `in` modifier para performance
- ✅ Herança (preview do Dia 03!)

---

## 📊 Critérios de Avaliação

✅ **Value vs Reference**: Entende a diferença?  
✅ **Struct**: Usado corretamente (pequeno, valor único)?  
✅ **Class**: Usado para objetos complexos?  
✅ **Record**: Usado para dados imutáveis?  
✅ **ref/out/in**: Aplicado adequadamente?  
✅ **Performance**: Considera impacto das escolhas?  

---

## 🎯 Dicas

1. **Struct**: Use para tipos pequenos (≤16 bytes), imutáveis
2. **Class**: Use para objetos maiores, mutáveis
3. **Record**: Use para DTOs, dados imutáveis
4. **ref**: Quando precisa modificar original
5. **out**: Para múltiplos retornos (ou use tuplas)
6. **in**: Para structs grandes (performance)
7. **Tuplas**: Para retornos temporários

---

## 🚀 Desafios Extras

### Iniciante
1. Compare memória usada por struct vs class
2. Implemente ToString() em todos os tipos
3. Adicione mais operações matemáticas

### Intermediário
4. Implemente operadores (+, -, *, /) para Ponto2D
5. Crie conversões implícitas entre Ponto2D e Ponto3D
6. Adicione suporte a transformações (rotação, escala)

### Avançado
7. Implemente Span<T> para arrays de structs
8. Use stackalloc para alta performance
9. Compare ref struct com struct normal

---

**Boa sorte! 💪**

*Escolher o tipo certo (struct/class/record) é crucial para performance e design!*

