<?php
include_once "Dbh.php";

$dbhandler = new Dbh;
$id = $_POST['deleteId'];
$dbhandler->deleteProduct($id);

header("Location: ../frontend/inventoryManagement.php");