<?php
include_once "Dbh.php";

$dbhandler = new Dbh;
$id = $_POST['updateId'];
$name = $_POST['updateName'];
$category = $_POST['updateCategory'];
$price = $_POST['updatePrice'];
$description = $_POST['updateDescription'];
$quantity = $_POST['updateQuantity'];
$distributor = $_POST['updateDistributor'];
$emailDistributor = $_POST['updateEmailOfDistributor'];
$phoneNrDistributor = $_POST['updatePhoneNrOfDistributor'];
$dbhandler->updateProduct($id, $name, $category, $price, $description, $quantity, $distributor, $emailDistributor, $phoneNrDistributor);

header("Location: ../frontend/inventoryManagement.php");