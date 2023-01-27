$(function(){
  carregar();
});

function carregar(){
  $.get(caminho, function(data, status){
      if (data == 0){
        alert("Erro ao obter os dados.")
        return;
      }
      else{
        for (let index = 0; index < data.length; index++) {
          const instituicao = data[index];
          
          console.log(instituicao);

          var codigo = instituicao.codigoInstituicaoBancaria;
          var descricao = instituicao.descricao;
          var siteWWW = instituicao.siteWWW;


          var linha = '';
          linha += "<tr>";
          linha += "<td class='table-active text-center'><button id='btnExibirAtual' class='border-light border-0' onclick='exibirAtual("+ codigo +");'> <img src='/img/att.png''width=35 height=35'></button></td>";
          linha += "<td class='table-active text-center'>" + codigo + "</td>";
          linha += "<td class='table-active text-center'>" + descricao + "</td>";
          linha += "<td class='table-active text-center'>" + siteWWW + "</td>";
          linha += "<td class='table-active text-center'><button id='btnAlterar' class='btn-warning' onclick='alterarAtual("+ codigo +");'> Alterar</button></td>";
          linha += "<td class='table-active text-center'><button id='btnExcluir' class='btn-danger' onclick='excluirAtual("+ codigo +");'> Excluir </button></td>";
          linha += "</tr>";
          
          $("#tblDados tbody").append(linha);
        }
      }

  });
}

function exibirAtual(codigo){
  localStorage.setItem("instituicaoAcao", JSON.stringify(0));
  localStorage.setItem("CodigoInstituicaoBancariaSelecionado",JSON.stringify(codigo));
  window.location.href = "detail.html";
}

function cadastrarNovo(){
localStorage.setItem("instituicaoAcao", JSON.stringify(1));
window.location.href = "detail.html"
}

function alterarAtual(codigo){
localStorage.setItem("instituicaoAcao", JSON.stringify(2));
localStorage.setItem("CodigoInstituicaoBancariaSelecionado",JSON.stringify(codigo));
window.location.href = "detail.html";
}

function excluirAtual(codigo){
localStorage.setItem("instituicaoAcao", JSON.stringify(3));
localStorage.setItem("CodigoInstituicaoBancariaSelecionado",JSON.stringify(codigo));
window.location.href = "detail.html";
}

