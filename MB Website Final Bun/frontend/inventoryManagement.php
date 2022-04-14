<?php
require_once "../classes/product.php";
require_once "../classes/Dbh.php";
include_once "header.php";
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



<!DOCTYPE html>
<html>
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
    <div class="updateForm">
    <form action="inventoryManagement.php" method="POST">
    Show only 1 category: <input type="text" name = "categoryFilter" >
    <button type = "submit" name = "Filter">Show selected</button>
    </br>
    </br>
    </br>
    </form>
    </div>
    </br>

    <div class="updateForm">
    <form action="../classes/deleteProduct.php" method="POST">
    Id of an item you want to DELETE: <input type="text" name = "deleteId" required>
    <button type = "submit" name = "delete">Delete</button>
    </br>
    </br>
    </br>
    </form>
    </div>
    </br>


        <div class="updateForm">
            <form action="../classes/updateProduct.php" method="POST">
                
                Id of an item you want to update: <input type="text" name = "updateId" required>
                <br>
                Name: <input type="text" name = "updateName" required>
                <br>
                Category: <input type="text" name = "updateCategory" required>
                <br>
                Price: <input type="text" name = "updatePrice" required>
                <br>
                Description: <input type="text" name = "updateDescription" required>
                <br>
                Quantity: <input type="text" name = "updateQuantity" required>
                <br>
                Distributor: <input type="text" name = "updateDistributor" required>
                <br>
                Email of distributor: <input type="text" name = "updateEmailOfDistributor" required>
                <br>
                Phone number of distributor: <input type="text" name = "updatePhoneNrOfDistributor" required>
                <button type = "submit" name = "update">Update</button>
            </form>
        </div>
 </br>

 <div class="updateForm"> 
            <form action="../classes/addProduct.php" method="POST">
                Add a new item to the database(Id is automatically assigned to the next available one):
                <br><br>
                Name: <input type="text" name = "addName" required>
                <br>
                Category: <input type="text" name = "addCategory" required>
                <br>
                Price: <input type="text" name = "addPrice" required>
                <br>
                Description: <input type="text" name = "addDescription" required>
                <br>
                Quantity: <input type="text" name = "addQuantity" required>
                <br>
                Distributor: <input type="text" name = "addDistributor" required>
                <br>
                Email of distributor: <input type="text" name = "addEmailOfDistributor" required>
                <br>
                Phone number of distributor: <input type="text" name = "addPhoneNrOfDistributor" required>
                <button type = "submit" name = "add">Add</button>
            </form>
    </div>
<br><br><br>
    <div class="updateForm"> 
        <form action="inventoryManagement.php" method="POST">
        </br>
        </br>
        View products sold by date:</br>
        Date: <input type="text" name = "date" required>
        <button type = "submit" name = "view">View</button>
        </br>
        </br>
        </br>
        </form>
    </div>
    <div class="table">
<?php
    if(isset($_POST['date']) && $_POST['date'] !=NULL)
{$date = $_POST['date'];
    /*echo'Products sold for $date';*/
    $soldProducts = $dbhandler->getProductsByDate($date);
    echo'<table>';
        echo '<tr><th>Id</th><th>Name</th><th>amount</th></tr>';
        foreach ($soldProducts as $p){
            echo '<tr>';
            echo '<td>'. $p->id . '</td>';
            echo '<td>'. $p->name .'</td>';
            echo '<td>'. $p->amount .'</td>';
            echo '</tr>';
        }
        echo '</table>';
        $_POST['date'] = NULL;
}
?>
</div>


    </body>
</html>