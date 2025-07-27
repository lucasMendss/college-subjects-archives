<html>
<?php 
if (empty($_POST['Nome'])) {
    echo ("Por favor, preencha os campos obrigatórios (marcados com *)."); 
} 
else {
    var_dump($_POST);
}

//echo($_POST['Nome'])
?>
    <form action="exercicio3.html">
        <input type="submit" value="Retornar ao formulário">
    </form>
</html>


