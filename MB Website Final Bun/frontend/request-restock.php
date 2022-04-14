<?php
require_once "../classes/product.php";
require_once "../classes/Dbh.php";
include_once "header.php";
require_once '../includes/db-inc.php';
require_once '../includes/Administration.php';

?>
<?php
$dbhandler = new Dbh;
$allProdcuts = array();
$soldProducts = array();
if(isset($_POST['categoryFilter']) && $_POST['categoryFilter'] != NULL)
{
    $filter = $_POST['categoryFilter'];
    $allProducts = $dbhandler->getProductsByCategory($filter);
    $_POST['categoryFIlter'] = NULL;
}
else{
    $allProducts = $dbhandler->getAllProducts();
}
?>
    <link rel = "stylesheet" type = "text/css" href = "../css/inventoryManagement.css" />

    <head>
        <title>Products table</title>
    </head>
    <body>

    <div class="table">
    <?php
        echo'<table class="table-emp">';
        echo '<tr><th>Id</th><th>Name</th><th>Category</th><th>Price</th><th>Description</th><th>Quantity</th><th>Distributor</th><th>EmailOfDistributor</th><th>PhoneNumberDistributor</th></tr>';
        foreach ($allProducts as $p){
            echo '<tr>';
            echo '<td>'. $p->id . '</td>';
            echo '<td>'. $p->name .'</td>';
            echo '<td>'. $p->category .'</td>';
            echo '<td>'. $p->price .'</td>';
            echo '<td>'. $p->description.'</td>';
            echo '<td>'. $p->quantity.'</td>';
            echo '<td>'. $p->distributor .'</td>';
            echo '<td>'. $p->emailDistributor .'</td>';
            echo '<td>'. $p->phoneNrDistributor.'</td>';
            echo '</tr>';
        }
        echo '</table>';
    ?>
</div>
<div class="updateForm">
    <form action="request-restock.php" method="POST">
    Request restock:
    Id: <input type="text" name = "id" >
    Quantity: <input type="text" name = "quantity" >
    <button type = "submit" name = "requestRestock">Request</button>
    </br>
    </br>
    </form>
    <br><br>

<?php
    if(isset($_POST['id']) && $_POST['id'] !=NULL && isset($_POST['quantity']) && $_POST['quantity'] !=NULL)
    {
        $id = $_POST['id'];
        $quantity = $_POST['quantity'];
    /*echo'Products sold for $date';*/
    $adm->RestockRequest($conn,$id, $quantity);
    $_POST['id'] = NULL;
    $_POST['quantity'] = NULL;
}
?>
    </div>
    </body>
</html>