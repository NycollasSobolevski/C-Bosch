Individuo pessoa = new Individuo("13303655936");
pessoa.addDespesa(new DespesaMes(05, 200.90f));
pessoa.addDespesa(new DespesaMes(05, 55.10f));
pessoa.addDespesa(new DespesaMes(05, 20f));
pessoa.addDespesa(new DespesaDia(05, 05, 20f));
int mes = 5;
Console.WriteLine($"Total gasto no mes {mes} é {pessoa.totalizaMes(mes)}");