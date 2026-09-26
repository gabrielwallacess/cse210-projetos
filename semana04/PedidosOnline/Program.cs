List<Pedido> pedidos = new List<Pedido>();


// Pedido 1 - Cliente EUA

Endereco endereco1 = new Endereco(
    "123 Main Street",
    "New York",
    "NY",
    "USA"
);


Cliente cliente1 = new Cliente(
    "John Smith",
    endereco1
);


Pedido pedido1 = new Pedido(cliente1);


pedido1.AdicionarProduto(
    new Produto("Notebook", "N001", 1200, 1)
);

pedido1.AdicionarProduto(
    new Produto("Mouse", "M001", 25, 2)
);


pedidos.Add(pedido1);



// Pedido 2 - Cliente Brasil

Endereco endereco2 = new Endereco(
    "Rua Paulista, 100",
    "São Paulo",
    "SP",
    "Brasil"
);


Cliente cliente2 = new Cliente(
    "Gabriel Wallace",
    endereco2
);


Pedido pedido2 = new Pedido(cliente2);


pedido2.AdicionarProduto(
    new Produto("Teclado Mecânico", "T001", 300, 1)
);

pedido2.AdicionarProduto(
    new Produto("Monitor", "MO001", 900, 2)
);


pedidos.Add(pedido2);



// Exibir resultados

foreach (Pedido pedido in pedidos)
{
    Console.WriteLine("==============================");

    Console.WriteLine(pedido.EtiquetaEmbalagem());

    Console.WriteLine(pedido.EtiquetaEnvio());

    Console.WriteLine();

    Console.WriteLine($"Total do pedido: ${pedido.CalcularTotal()}");

    Console.WriteLine("==============================\n");
}