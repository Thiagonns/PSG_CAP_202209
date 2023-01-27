var codigo = 0;

$(function(){
    avaliarAcao("correntistaAcao")
    if(acao == 0){
        carregarDetalhe();
        somenteLeitura();
        $("#btnNovo").hide();
        $("#btnAlterar").hide();
        $("#btnExcluir").hide();
        $("#DtAtivo").hide();
        $("#chbAtivo").attr('disabled', true);
    }

    if(acao == 1){
        $("#txtCodigoCorrentista").attr('readonly', true);
        $("#txtAtivo").attr('readonly', true);
        $("#txtDataInclusao").attr('readonly', true);
        $("#btnAlterar").hide();
        $("#btnExcluir").hide();
        $("#DtAtivo").hide();
        $("#DtInclusao").hide();
        $("#chbAtivo").attr('checked', true);
        $("#chbAtivo").attr('disabled', true);
    }

    if(acao == 2){
        carregarDetalhe();
        $("#txtCodigoCorrentista").attr('readonly', true);
        $("#txtDataInclusao").attr('readonly', true);
        $("#DtAtivo").hide();
        $("#DtInclusao").hide();
        $("#btnNovo").hide();
        $("#btnExcluir").hide();
    }

    if(acao == 3){
        carregarDetalhe();
        somenteLeitura();
        $("#btnNovo").hide();
        $("#btnAlterar").hide();
        $("#chbAtivo").attr('disabled', true);
        $("#DtAtivo").hide();
    }
});

function somenteLeitura(){
    $("#txtCodigoCorrentista").attr('readonly', true);
    $("#txtCodigoInstituicaoBancaria").attr('readonly', true)
    $("#txtNome").attr('readonly', true);
    $("#txtSobrenome").attr('readonly', true);
    $("#txtEmail").attr('readonly', true);
    $("#txtDataInclusao").attr('readonly', true);
    $("#txtAtivo").attr('readonly', true);
}

function carregarDetalhe(){
    var tmp = localStorage.getItem("codigoCorrentistaSelecionado");
    codigo = JSON.parse(tmp)

    if ((codigo == undefined) || (codigo == 0)){
        alert("código inválido!!");
        window.location.href = "list.html";
    }
    else{
        localStorage.removeItem("codigoCorrentistaSelecionado");
    }
    
    var caminhoComValor = caminho + '/' + codigo;
    
    $.get(caminhoComValor, function(data, status){
        if (data.length == 0){
            alert("Erro ao obter os dados.")
            return;
        }
        else{
            console.log(data);
            $("#txtCodigoCorrentista").val(data.codigoCorrentista);
            $("#txtCodigoInstituicaoBancaria").val(data.codigoInstituicaoBancaria);
            $("#txtNome").val(data.nome);
            $("#txtSobrenome").val(data.sobrenome);
            $("#txtEmail").val(data.email);
            $("#txtDataInclusao").val(data.dataInclusao);
            $("#txtAtivo").val(data.ativo);
            $("#chbAtivo").prop('checked', data.ativo);
        }
    });
}
function stringToBoolean(value){
    return (String(value) === '1' || String(value).toLowerCase() === 'true');
}