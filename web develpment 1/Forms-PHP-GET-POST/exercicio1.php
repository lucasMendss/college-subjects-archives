<html>
<head>
    <title>Exercicio 1</title>
</head>
<body>

<h1>Exercicio 1 - Aula de formularios</h1>

<h2>O parametro "Ex" enviado com o metodo GET possui o seguinte valor: <?php echo $_GET['Ex'] ?></h2>

<h2>Abaixo estao os parametros enviados com o metodo GET</h2>
<!-- 
<div style="font-size: 10px">
<p> exemplo: http://youtube.com/watch.php?tr=ffh7f74748&t=3m55s</p>
<p>Parametros:</p>
<ul>
    <li>tr=ffh7f7474</li>
    <li>t=3m55s</li>
</ul>
</div>
-->

<?php
 var_dump($_GET);
?>
</body>
</html>