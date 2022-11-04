// parte 1...
// var teste = "teste";
// let valor = 1;
// if(valor > 0)
// {
//     let teste = "testeeee";
//     alert(teste);
// }

// alert(teste);

// parte 2...
// var numero = 1;

// if (numero == "1") {
//   alert("== compara apenas os valores");
// }

// var mensagem;
// if (numero === "1") {
//   mensagem = "Nunca executa";
// } else {
//   mensagem = "Number é diferente de String com o ===";
// }

// if ternario...
// var x =
//   numero === "1" ? "Nunca executa" : "Number é diferente de String com o ===";

// parte 3...
// var laranja = 6;
// switch (laranja) {
//   case 3:
//     alert("Fazer um copo de suco");
//     break;
//   case 6:
//     alert("Fazer dois copo de suco");
//     break;
//   case 9:
//     alert("Fazer uma jarra de suco");
//     break;
//   default:
//     alert("Fazer quanto suco for possível");
// }

//parte 4...
// var pessoas = ["João", "José", "Maria", "Sebastião", "Antonio"];

// //for "comum"
// for (var i = 0; i < pessoas.length; i++) {
//     alert(pessoas[i]);
// }

// var nome = "";
// var pessoa = {
//     nome: "Iara",
// sobrenome: "Almeida" 
// };

// //for "foreach"
// for (x in pessoa) {
//     nome += pessoa[x] + " ";
// }
// alert(nome);

//exercicio 1
// var impares = 1 + " ";

// for (let i = 2; i <= 10; i++) {
//     if (i % 2 !== 0)
//     {
//         impares += i + " ";
//     }
// }
// console.log(impares);

// console.log("--------");

// //exercicio 2
// var soma=0;
// for(let i = 1; i <= 100; i++) {
//     soma += i;
// }
// console.log(soma);

// funcoes
function funcao() {
    var teste = "teste";
    var valor = 1;

    if (valor > 0) {
        var teste = "testeeee";
    }
    alert(teste);
}

function minhaFuncao() {
    var x = document.getElementById("nome");
    x.value = x.value.toUpperCase();
}