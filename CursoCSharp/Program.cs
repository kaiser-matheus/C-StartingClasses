﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados Console - Fundamentos", DadosConsole.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Relacionais - Fundamentos", Operadores_Relacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}