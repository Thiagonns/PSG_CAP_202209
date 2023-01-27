console.log(caminho);

function alterar(){
    
    var codigoCorrentista = $("#txtCodigoCorrentista").val();
    var codigoInstituicaoBancaria = $("#txtCodigoInstituicaoBancaria").val();
    var nome = $("#txtNome").val();
    var sobrenome = $("#txtSobrenome").val();
    var email = $("#txtEmail").val();
    var dataInclusao = $("#txtDataInclusao").val();
    var ativo = $("#chbAtivo").prop('checked');

    var novo = {
        codigoCorrentista,
        codigoInstituicaoBancaria,
        nome,
        sobrenome,
        email,
        dataInclusao,
        ativo
    };

    $.ajax({
        url : caminho,
        type: "put",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(novo),
        success: function(data, status, xhr){
            console.log(data)
            codigoCorrentista = data.codigoCorrentista;
            alert("Dados alterados com sucesso! Codigo:" + codigoCorrentista);
            window.location.href = "list.html";
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao alterar os dados! " + status);
            return;
        }
    })
}
