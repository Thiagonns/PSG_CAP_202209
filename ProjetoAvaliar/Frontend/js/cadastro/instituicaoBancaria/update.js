console.log(caminho);

function alterar(){
    
    var codigoinstituicaoBancaria = $("#txtCodigoInstituicaoBancaria").val();
    var codigoBanco = $("#txtCodigoBanco").val();
    var descricao = $("#txtDescricao").val();
    var siteWWW = $("#txtSiteWWW").val();
    var dataInsercao = $("#txtDataInclusao").val();
    var ativo = $("#chbAtivo").prop('checked');

    var novo = {
        codigoinstituicaoBancaria,
        codigoBanco,
        descricao,
        siteWWW,
        dataInsercao,
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
            codigoinstituicaoBancaria = data.codigoinstituicaoBancaria;
            alert("Dados alterados com sucesso! Codigo:" + codigoinstituicaoBancaria);
            window.location.href = "list.html";
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao alterar os dados! " + status);
            return;
        }
    })
}
