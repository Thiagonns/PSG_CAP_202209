console.log(caminho);

function excluir(){
    var codigoCorrentista = $("#txtCodigoCorrentista").val();

    var caminhoComValor = caminho + '/' + codigo;

    $.ajax({
        url : caminhoComValor,
        type: "delete",
        dataType: "json",
        contentType: "application/json",
        data: null,
        success: function(data, status, xhr){
            console.log(data)
            codigoCorrentista = data.codigoCorrentista;
            alert("Dados excluidos com sucesso! Codigo correntista:" + codigoCorrentista);
            window.location.href = "list.html";
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao excluir os dados!" + status);
            return;
        }
    })
}
