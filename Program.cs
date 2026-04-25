const double TaxaIOFMes = 0.0038;
const double TaxaIOFDiario = 0.000082;

decimal valorTotalFatura;
double percentualPagamentoMinimo, taxaJurosMensais;

decimal valorPagamentoMinimo, valorNaoPago, valorJuros,
        valorIOFmes, valorIOFDiario, valorProximaFatura, custoCreditoRotativo;

Console.WriteLine ("--- Crédito Rotativo de Cartão de Crédito ---\n");

Console.Write("Valor total da fatura (R$)...: \n");
valorTotalFatura =  Convert.ToDecimal(Console.ReadLine());
Console.Write("Pagamento mínimo (%).........: \n");
percentualPagamentoMinimo = Convert.ToDouble(Console.ReadLine()) / 100;
Console.Write("Taxa de juros mensais (%)....: \n");
taxaJurosMensais = Convert.ToDouble(Console.ReadLine()) / 100;

valorPagamentoMinimo = valorTotalFatura * Convert.ToDecimal(percentualPagamentoMinimo);
valorNaoPago = valorTotalFatura - valorPagamentoMinimo;
valorJuros = valorNaoPago * Convert.ToDecimal(taxaJurosMensais);
valorIOFmes = valorNaoPago *  Convert.ToDecimal(TaxaIOFMes);
valorIOFDiario = valorNaoPago * Convert.ToDecimal(TaxaIOFDiario * 30);

valorProximaFatura = valorNaoPago + valorJuros + valorIOFmes + valorIOFDiario;
custoCreditoRotativo = valorProximaFatura - valorNaoPago;

Console.WriteLine($"\nPagamento mínimo..................:  {valorPagamentoMinimo:C2}");

Console.WriteLine("\nCaso seja pago o valor mínimo:");

Console.WriteLine($"Valor não pago....................: {valorNaoPago:C}");
Console.WriteLine($"Juros.............................: {valorJuros:C}");
Console.WriteLine($"IOF mensal........................: {valorIOFmes:C}");
Console.WriteLine($"IOF diário........................: {valorIOFDiario:C}");
Console.WriteLine($"");
Console.WriteLine($"Valor a pagar na próxima fatura...: {valorProximaFatura:C}");
Console.WriteLine($"Custo do crédito rotativo.........: {custoCreditoRotativo:C}");