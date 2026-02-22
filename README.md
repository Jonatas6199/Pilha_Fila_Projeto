# 📚 Projeto: Estruturas de Dados - Pilha e Fila (Stack & Queue)
**Unidade Curricular 12 (UC 12) - Desenvolvimento Desktop**

Olá de novo! Neste segundo projeto, vamos dar um passo além. Em vez de apenas guardar um número ou texto solto em uma variável, vamos aprender como organizar **vários dados** na memória do computador. 

Para isso, exploraremos duas coleções genéricas fundamentais na programação: a **Pilha** e a **Fila**.

---

## 🧠 A Teoria: Como organizar nossos dados?

Imagine que você tem vários dados chegando e precisa decidir em qual ordem vai processá-los. Existem duas regras clássicas para isso:

### 1. A Fila (Queue) - A regra do "Primeiro a chegar, Primeiro a sair"
* **Conceito:** Chamamos de **FIFO** (*First In, First Out*).
* **Exemplo do cotidiano:** Pense em uma fila de banco. A primeira pessoa que entra na fila é a primeira a ser atendida e sair dela.
* **No C#:** Usamos os comandos `Enqueue` (para entrar na fila) e `Dequeue` (para sair da fila).

### 2. A Pilha (Stack) - A regra do "Último a chegar, Primeiro a sair"
* **Conceito:** Chamamos de **LIFO** (*Last In, First Out*).
* **Exemplo do cotidiano:** Pense em uma pilha de pratos na pia. O último prato que você coloca no topo da pilha é o primeiro que você vai pegar para lavar.
* **No C#:** Usamos os comandos `Push` (para empurrar para o topo da pilha) e `Pop` (para tirar do topo).



---

## 🎨 Passo 1: Desenhando a Interface (UI)
Para visualizar o código rodando, precisamos montar nossa tela no Windows Forms com os seguintes componentes:

**Para a Pilha:**
* 1 `TextBox` nomeado como `txtPilha` (para digitar o item).
* 1 `Button` nomeado como `btnAddPilha` (para adicionar).
* 1 `Button` nomeado como `btnRemovePilha` (para remover).
* 1 `ListBox` nomeado como `lbxPilha` (para mostrar visualmente a pilha crescendo/diminuindo).

**Para a Fila:**
* 1 `TextBox` nomeado como `txtFila`.
* 1 `Button` nomeado como `btnAddFila`.
* 1 `Button` nomeado como `btnRemoveFila`.
* 1 `ListBox` nomeado como `lbxFila`.

---

## ⚙️ Passo 2: Entendendo o Código

### 1. Criando as Coleções na Memória
Logo no topo do código, declaramos nossas estruturas de dados. O `<string>` indica que elas vão guardar textos.
```csharp
Queue<string> fila = new Queue<string>(); // Cria a Fila
Stack<string> pilha = new Stack<string>(); // Cria a Pilha
```

### 2. Adicionando Dados (Push e Enqueue)
Quando clicamos no botão de adicionar, pegamos o texto que o usuário digitou e colocamos na coleção correspondente. Depois, chamamos um método para atualizar a tela.

```C#
private void btnAddPilha_Click(object sender, EventArgs e)
{
    pilha.Push(txtPilha.Text); // Adiciona no TOPO da pilha
    AtualizarPilha();          // Atualiza o visual
}
```
```csharp
private void btnAddFila_Click(object sender, EventArgs e)
{
    fila.Enqueue(txtFila.Text); // Adiciona no FINAL da fila
    AtualizarFila();
}
```
### 3. Removendo Dados (Pop e Dequeue)
Aqui temos um detalhe muito importante de segurança! Antes de mandar remover um item, verificamos se a coleção não está vazia usando o Count > 0. Se tentarmos remover algo de uma lista vazia, o programa quebra (dá erro)!

```C#
private void btnRemovePilha_Click(object sender, EventArgs e)
{
    if (pilha.Count > 0) // Tem alguém na pilha?
        pilha.Pop();     // Tira o do TOPO

    AtualizarPilha();
}
```
```csharp
private void btnRemoveFila_Click(object sender, EventArgs e)
{
    if (fila.Count > 0) // Tem alguém na fila?
        fila.Dequeue(); // Tira o PRIMEIRO da fila

    AtualizarFila();
}
```
### 4. Conectando a Memória com a Tela (ListBox)
Como o usuário não consegue ver a memória do computador, precisamos desenhar o que está na coleção dentro do nosso ListBox. Fazemos isso limpando a lista visual e repovoando ela do zero toda vez que ocorre uma mudança.

```csharp
private void AtualizarPilha()
{
    lbxPilha.Items.Clear(); // Limpa a tela
    
    // O comando 'foreach' significa "Para cada..."
    // Ele vai percorrer toda a nossa pilha na memória.
    foreach (string item in pilha)
    {
        lbxPilha.Items.Add(item); // Adiciona o item visualmente no ListBox
    }
}
```
(O método AtualizarFila() faz exatamente a mesma coisa, mas varrendo a fila em vez da pilha).

## 🎉 Conclusão
Execute o projeto e brinque com os botões! Observe como a Pilha sempre remove o último nome que você digitou (como os pratos), enquanto a Fila respeita a ordem de chegada (como no banco).
