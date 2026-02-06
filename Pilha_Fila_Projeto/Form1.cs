namespace Pilha_Fila_Projeto
{
    public partial class Form1 : Form
    {
        Queue<string> fila = new Queue<string>();
        Stack<string> pilha = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddPilha_Click(object sender, EventArgs e)
        {
            pilha.Push(txtPilha.Text); //Atualizacao lógica
            AtualizarPilha();//atualização visual
        }

        private void btnAddFila_Click(object sender, EventArgs e)
        {
            fila.Enqueue(txtFila.Text);
            AtualizarFila();
        }

        private void btnRemovePilha_Click(object sender, EventArgs e)
        {
            if (pilha.Count > 0)
                pilha.Pop();

            AtualizarPilha();
        }

        private void btnRemoveFila_Click(object sender, EventArgs e)
        {
            if (fila.Count > 0)
                fila.Dequeue();

            AtualizarFila();
        }

        private void AtualizarPilha()
        {
            lbxPilha.Items.Clear(); //limpando o listbox de pilha
            foreach (string item in pilha)//percorrendo a minha pilha
            {
                lbxPilha.Items.Add(item);// para cada item na minha pilha
                //adiciono eles visualmente no meu listbox
            }
        }

        void AtualizarFila()
        {
            lbxFila.Items.Clear();
            foreach (var item in fila)
                lbxFila.Items.Add(item);
        }

       
    }
}
