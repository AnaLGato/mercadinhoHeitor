namespace mercadinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void linha()
            {
                for (int i = 0; i == 100; i++)
                {
                       Console.Write("-");

                }

                Console.WriteLine();
            
            }
            
            static void Imprimir(string codigo, string descricao, float preco, float qntestoque, string coisa)
            {
                Console.WriteLine("| {0,-13} | {1} | {2} | R$ {3}  {4} |",codigo, descricao, preco, qntestoque, coisa);
            }
             
            
            

            Produto[] carrinho = new Produto[12];

            carrinho[0] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[1] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[2] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[3] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[4] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[5] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[6] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[7] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[8] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[9] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[10] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            carrinho[11] = new Produto("7891025101604", "Leite", 3.0f, 15.0f, "l");
            linha();
            foreach(var produto in carrinho)
            {
                Imprimir(produto.Codigo, produto.Descricao, produto.Preco, produto.Qntestoque, produto.Coisa);
            }

            linha();

        }
    }
}