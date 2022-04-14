<?php
class Dbh {
public $host = "studmysql01.fhict.local";
private $username = "dbi452560";
private $password = "12345";
private $dbName = "dbi452560";
public $result = "";

 public function connection(){
    $dsn = 'mysql:dbname='.$this->dbName.';host='.$this->host;
    $conn = new PDO($dsn, $this->username, $this->password);
    return $conn;
 }

//  public function RestockRequest($id, $quantity){
//     $sql = "INSERT INTO restock_requests(idProduct, quantity, date, status) VALUES ($id, $quantity, '2021-05-11', 'PENDING' )";
//     try{
//         $conn = $this->connection();
//         $stmt = $conn->prepare($sql);
//         $stmt->execute();
//         }
//         $conn = null;
        
//         catch(PDOException $e){
//             echo "Something went wrong. Message: \"".$e->getMessage()."\", Code: \"".$e->getCode()."\"";
//             $conn = null;
//         }
// }

    public function getAllProducts(){
        $sql = "SELECT * FROM products ORDER BY category;";  
        try{
        $conn = $this->connection();
        $stmt = $conn->prepare($sql);
        $stmt->execute();
        $result = $stmt->fetchAll();
        $products = array();
        foreach($result as $p){
        $product = new Product($p['id'],$p['name'],$p['category'],$p['price'],$p['description'],$p['quantity'],$p['distributor'],$p['emailDistributor'],$p['phoneNrDistributor']);
        array_push($products, $product);
        }
        $conn = null;
        return $products;
        }
        catch(PDOException $e){
            echo "Something went wrong. Message: \"".$e->getMessage()."\", Code: \"".$e->getCode()."\"";
            $conn = null;
        }
        
    }

    public function deleteProduct($productId){
        $sql = "DELETE FROM products WHERE id = $productId";
        try{
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute();
            $conn = null;
            }        
        catch(PDOException $e){
                echo "Something went wrong. Message: \"".$e->getMessage()."\", Code: \"".$e->getCode()."\"";
                $conn = null;
            }
    }


    public function updateProduct($productId, $name, $category, $price, $description, $quantity, $distributor, $emailDistributor, $phoneNrDistributor){
        $sql = "UPDATE products SET id='$productId', name='$name', category='$category', price='$price', description='$description', quantity='$quantity', distributor='$distributor', emailDistributor='$emailDistributor', phoneNrDistributor='$phoneNrDistributor' WHERE id = $productId";
        try{
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute();
            $conn = null;
            }        
        catch(PDOException $e){
                echo "Something went wrong. Message: \"".$e->getMessage()."\", Code: \"".$e->getCode()."\"";
                $conn = null;
            }
    }


    public function getProductsByCategory($category){
        $sql = "SELECT * FROM products WHERE category = '$category';";  
        try{
        $conn = $this->connection();
        $stmt = $conn->prepare($sql);
        $stmt->execute();
        $result = $stmt->fetchAll();
        $products = array();
        foreach($result as $p){
        $product = new Product($p['id'],$p['name'],$p['category'],$p['price'],$p['description'],$p['quantity'],$p['distributor'],$p['emailDistributor'],$p['phoneNrDistributor']);
        array_push($products, $product);
        }
        $conn = null;
        return $products;
        }
        catch(PDOException $e){
            echo "Something went wrong. Message: \"".$e->getMessage()."\", Code: \"".$e->getCode()."\"";
            $conn = null;
        }
    }
        

   
}