var caminhoEnvelope = '';
$(function(){
  carregarInstituicao();
  $("#ddlInstituicao").change(function(){
    var codigoInstituicaoBancaria = $(this).children("option:selected").val();
    var limite = $("#ddlTakeSkip").children("option:selected").val();
    var salto = 0;
    if(limite != 0 ){
      caminhoEnvelope = caminho + "/envelope/PorInstituicao/" + codigoInstituicaoBancaria + "?limite=" + limite + "&salto=" + salto ;
      carregar(caminhoEnvelope);
    }
    else{
      limite = 2;
      caminhoEnvelope = caminho + "/envelope/PorInstituicao/" + codigoInstituicaoBancaria + "?limite=" + limite + "&salto=" + salto ;
      carregar(caminhoEnvelope);
    }
  });

  $("#ddlTakeSkip").change(function(){
    var limite = $(this).children("option:selected").val();
    var codigoInstituicaoBancaria = $("#ddlInstituicao").children("option:selected").val();
    var salto = 0;
    if (codigoInstituicaoBancaria != 0){
      caminhoEnvelope = caminho + "/envelope/PorInstituicao/" + codigoInstituicaoBancaria + "?limite=" + limite + "&salto=" + salto ;
      carregar(caminhoEnvelope);
    }
    else{
      alert("Informe uma instituicao para pesquisa.")
    }
  });
});

function carregar(caminhoEnvelope){
    $.ajax({
      url: caminhoEnvelope,
      type: "get",
      dataType: "json",
      contentType: "application/json",
      data: null,
      async: false,
      success: function(data, status, xhr){
        var codigoStatus = data.status.codigo;
        var mensagemStatus = data.status.mensagem;
                
        if (codigoStatus == 404){
          $("#liPagina").hide();
          $("#liPosterior").hide();          
          alert(mensagemStatus);
          return;
        }
        
        $("#tblDados tbody").empty();        

        for (let index = 0; index < data.dados.length; index++) {
          const correntista = data.dados[index];

          console.log(correntista);


          var codigoCorrentista = correntista.codigoCorrentista;
          var nome = correntista.nome;
          var sobrenome = correntista.sobrenome;
          var email = correntista.email;
          var ativo = correntista.ativo;
          var hasPrev = data.paginacao.hasPrev;
          var hasNext = data.paginacao.hasNext;
          var pageNumber = data.paginacao.pageNumber;                    

          var linha = '';
          linha += "<tr>";
          linha += "    <td class='table-active text-center'>";
          linha += "      <button id='btnExibir' class='border-light border-0' onclick='exibirAtual("+ codigoCorrentista +");'> ";
          linha += "        <img src='/img/att.png''width=35 height=35'>";
          linha += "      </button>";
          linha += "    </td>";
          linha += "  <td class='table-active text-center'>" + codigoCorrentista + "</td>";
          linha += "  <td class='table-active text-center'>" + nome + "</td>";
          linha += "  <td class='table-active text-center'>" + sobrenome + "</td>";
          linha += "  <td class='table-active text-center'>" + email + "</td>";
          linha += "  <td class='table-active text-center'>" + ativo + "</td>";
          linha += "  <td class='table-active text-center'>";
          linha += "    <button id='btnAlterar' class='btn-warning' onclick='alterarAtual("+ codigoCorrentista +");'> Alterar</button>";
          linha += "  </td>";
          linha += "  <td class='table-active text-center'>";
          linha += "  <button id='btnExcluir' class='btn-danger' onclick='excluirAtual("+ codigoCorrentista +");'> Excluir </button>";
          linha += "  </td>";
          linha += "</tr>";
            $("#tblDados tbody").append(linha);
        }        
        carregarLinkPaginacao(pageNumber, hasPrev, hasNext);
      },
      error: function(xhr, status, errorThrown){
          alert("Erro ao obter os dados. " + status + caminhoEnvelope);
          return;
      }
    });
}

function exibirAtual(codigo){
  localStorage.setItem("correntistaAcao", JSON.stringify(0));
  localStorage.setItem("codigoCorrentistaSelecionado",JSON.stringify(codigo));
  window.location.href = "detail.html";
}

function cadastrarNovo(){
localStorage.setItem("correntistaAcao", JSON.stringify(1));
window.location.href = "detail.html"
}

function alterarAtual(codigo){
localStorage.setItem("correntistaAcao", JSON.stringify(2));
localStorage.setItem("codigoCorrentistaSelecionado",JSON.stringify(codigo));
window.location.href = "detail.html";
}

function excluirAtual(codigo){
localStorage.setItem("correntistaAcao", JSON.stringify(3));
localStorage.setItem("codigoCorrentistaSelecionado",JSON.stringify(codigo));
window.location.href = "detail.html";
}

var instituicoes = [];

function carregarInstituicao(){
  var caminhoInstituicao  = servidor + "/" + "InstituicaoBancaria";
  $.get(caminhoInstituicao, function(data){

        for (let index = 0; index < data.length; index++) {
          const inst = data[index];
          
          console.log(inst);

          $("#ddlInstituicao").append(
            $('<option></option>').val(inst.codigoInstituicaoBancaria).html(inst.descricao)
        );
        }     
  });
}

function carregarLinkPaginacao(numeroPagina, anterior, posterior){
  $("#navPaginacao ul").empty();


    var linha = '';
    linha += "<li class='page-item'>";
    linha +=  "<a class='page-link' id='liAnterior' onclick='carregar(\""+ anterior +"\")' tabindex='-1'>Anterior</a>";
    linha += "</li>";
    linha += "<li class='page-item'>";
    linha +=  "<a class='page-link' id='liPagina'> "+ numeroPagina +"</a>";
    linha += "</li>";
    linha += "<li class='page-item'>";
    linha +=  "<a class='page-link' id='liPosterior' onclick='carregar(\""+ posterior +"\")'>Próximo</a>";
    linha += "</li>";
    $("#navPaginacao ul").html(linha);

    if(numeroPagina == 1){
      $("#liAnterior").hide();
    }
  }






  



  
