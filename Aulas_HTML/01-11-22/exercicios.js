function nomeIdade() {
  const nome = document.getElementById("nome").value;
  const idade = document.getElementById("idade").value;
  alert(nome + " tem " + idade + " anos.");
}

function maiorIdade() {
  const nome = document.getElementById("nome").value;
  const idade = document.getElementById("idade").value;
  if (idade > 17) {
    alert(nome + " é maior de idade.");
  } else {
    alert(nome + " é menor de idade.");
  }
}

function soma() {
  const val1 = parseInt(document.getElementById("val1").value);
  const val2 = parseInt(document.getElementById("val2").value);

  var soma = val1 + val2;
  alert("A soma dos valores é igual a " + soma);
}

function parOuImpar() {
  const val1 = parseInt(document.getElementById("val1").value);
  const val2 = parseInt(document.getElementById("val2").value);
  const botao = document.getElementById("botao");

  let soma = parseInt(val1) + parseInt(val2);

  if (soma % 2 === 0) {
    botao.style.backgroundColor = "blue";
    botao.value = "é par";
} else {
    botao.style.backgroundColor = "green";
    botao.value = "é ímpar";
  }
}