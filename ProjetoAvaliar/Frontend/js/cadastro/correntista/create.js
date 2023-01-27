console.log(caminho);

function cadastrar(){
    var codigoCorrentista = 0;
    var codigoInstituicaoBancaria = $("#txtCodigoInstituicaoBancaria").val();
    var nome = $("#txtNome").val();
    var sobrenome = $("#txtSobrenome").val();
    var email = $("#txtEmail").val();
    var dataInclusao = null;
    var ativo = null;

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
        type: "post",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(novo),
        success: function(data, status, xhr){
            console.log(data)
            codigoCorrentista = data.codigoCorrentista;
            alert("Dados gravados com sucesso! Codigo:" + codigoCorrentista);
            window.location.href = "list.html";
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao gravar os dados!" + status);
            return;
        }
    })
}
