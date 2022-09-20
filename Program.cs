Console.Write("Digite o valor total de vendas: ");

double valor = Convert.ToDouble(Console.ReadLine());

if(valor >= 3000){
    Console.WriteLine("Premio de R$ 300,00");  
}else if(valor >= 1000){
    Console.WriteLine("Premio de R$ 150,00");   
}else{
    Console.WriteLine("Sem comissão a receber.");
}

Console.ReadKey();