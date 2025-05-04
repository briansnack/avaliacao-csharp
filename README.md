# Trabalho de Programação C# - ADS

## 🧑‍🤝‍🧑 Integrantes do Grupo
- Brian Lucas Snack Martins
- Vinicius Travenssoli de Souza

## 📋 Exercícios Resolvidos

1. Validador de Senhas Fortes  
2. Tabuada Completa com Laço  
3. Cálculo de Fatorial com while  
4. Conversor de Temperaturas com Menu  
5. Verificador de Palíndromos  
6. Cadastro Simples de Produtos  
7. Soma de Números Pares de um Array  
8. Cálculo de IMC com Classificação  
9. Jogo da Adivinhação  
10. Lista de Tarefas (To-Do List)

---

## 📌 Descrição dos Exercícios

### 1. Validador de Senhas Fortes
Valida uma senha com base em critérios de segurança (mínimo de 8 caracteres, letra maiúscula, número e caractere especial).

### 2. Tabuada Completa com Laço
Imprime a tabuada (1 a 10) de um número fornecido pelo usuário, usando `for`.

### 3. Contador de Números Pares
Exibe todos os números pares de 1 a 100.

### 4. Soma de Números
Solicita uma quantidade de números ao usuário e mostra a soma total.

### 5. Verificador de Números Primos
Verifica se um número informado é primo ou não.

### 6. Conversor de Temperatura
Converte uma temperatura de Celsius para Fahrenheit e Kelvin.

### 7. Calculadora Simples
Permite ao usuário escolher uma operação (soma, subtração, multiplicação ou divisão) entre dois números.

### 8. Contador de Vogais
Conta quantas vogais existem em uma frase digitada pelo usuário.

### 9. Jogo da Adivinhação
Gera um número aleatório entre 1 e 100 e desafia o usuário a adivinhar, informando se está acima ou abaixo.

### 10. Lista de Tarefas (To-Do List)
Permite ao usuário inserir tarefas até digitar “fim” e depois exibe todas as tarefas registradas.

---

## 📚 Documentação Detalhada

### Exercício 1 - Validador de Senhas Fortes

**Lógica passo a passo:**
1. Solicitar a senha ao usuário.
2. Verificar:
   - Se tem pelo menos 8 caracteres.
   - Se contém letra maiúscula.
   - Se contém número.
   - Se contém caractere especial (como !@#$%^&*).
3. Informar se a senha é válida ou não com base nos critérios.

**Comandos usados:**
- `Console.ReadLine()` para entrada.
- `Regex` para verificar padrões.
- `if`, `else` e `bool`.

**Justificativas:**
Usamos expressões regulares para facilitar a verificação dos critérios em uma única linha, com alto desempenho e clareza.

---

### Exercício 5 - Verificador de Palíndromos

**Lógica passo a passo:**
1. Solicitar uma palavra ou frase ao usuário.
2. Converter o texto para minúsculo.
3. Remover caracteres que não são letras ou números.
4. Inverter a string.
5. Comparar o texto original tratado com o invertido.
6. Informar se é ou não um palíndromo.

**Comandos usados:**
- `Console.ReadLine()` para entrada.
- `Regex.Replace()` para limpar os caracteres indesejados.
- `ToLower()` para padronizar.
- `Array.Reverse()` para inverter a string.
- `if` e `else` para verificação.

**Justificativas:**
A limpeza da entrada com Regex garante que espaços, acentos e pontuações não interfiram na verificação. Isso torna o algoritmo mais robusto para diferentes frases e entradas do usuário.

---

## 📅 Entrega

- Data de entrega: **04/05 até 23h59**
- E-mail enviado para: `tpedra@up.edu.br`
- Assunto do e-mail: `SEXTA_BRIAN_VINICIUS_ADS`

---

## 💡 Observações

- Código original e funcional.
- Cada exercício está em um arquivo separado `.cs`.
- Sem uso de bibliotecas externas além da base da linguagem.