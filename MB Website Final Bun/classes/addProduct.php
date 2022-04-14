<?php
include_once "Dbh.php";

$dbhandler = new Dbh;
$name = $_POST['addName'];
$category = $_POST['addCategory'];
$price = $_POST['addPrice'];
$description = $_POST['addDescription'];
$quantity = $_POST['addQuantity'];
$distributor = $_POST['addDistributor'];
$emailDistributor = $_POST['addEmailOfDistributor'];
$phoneNrDistributor = $_POST['addPhoneNrOfDistributor'];
$dbhandler->addProduct($name, $category, $price, $description, $quantity, $distributor, $emailDistributor, $phoneNrDistributor);

header("Location: ../frontend/inventoryManagement.php");