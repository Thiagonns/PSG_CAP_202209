console.log(caminho);

function cadastrar(){
    var codigoinstituicaoBancaria = 0;
    var codgoBanco = $("#txtCodigoBanco").val();
    var descricao = $("#txtDescricao").val();
    var siteWWW = $("#txtSiteWWW").val();
    var dataInclusao = null;
    var ativo = null;


    var novo = {
        codigoinstituicaoBancaria,
        codgoBanco,
        descricao,
        siteWWW,
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
            codigoinstituicaoBancaria = data.codigoinstituicaoBancaria;
            alert("Dados gravados com sucesso! Codigo:" + codigoinstituicaoBancaria);
            window.location.href = "list.html";
        },
        error: function(xhr, status, errorThrown){
            alert("Erro ao gravar os dados!" + status);
            return;
        }
    })
}
