<?php
require_once "../classes/freeDays.php";
class Dbh
{
    public $host = "localhost";
    private $username = "root";
    private $password = "";
    private $dbName = "media_bazaar";
    public $result = "";

    public function connection()
    {
        $dsn = 'mysql:dbname=' . $this->dbName . ';host=' . $this->host;
        $conn = new PDO($dsn, $this->username, $this->password);
        return $conn;
    }


    public function getAllProducts()
    {
        $sql = "SELECT * FROM products ORDER BY category;";
        try {
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute();
            $result = $stmt->fetchAll();
            $products = array();
            foreach ($result as $p) {
                $product = new Product($p['id'], $p['name'], $p['category'], $p['price'], $p['description'], $p['quantity'], $p['distributor'], $p['emailDistributor'], $p['phoneNrDistributor']);
                array_push($products, $product);
            }
            $conn = null;
            return $products;
        } catch (PDOException $e) {
            echo "Something went wrong.";
            $conn = null;
        }
    }

    public function deleteProduct($productId)
    {
        $sql = "DELETE FROM products WHERE id = $productId";
        try {
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute();
            $conn = null;
        } catch (PDOException $e) {
            echo "Something went wrong";
            $conn = null;
        }
    }


    public function updateProduct($productId, $name, $category, $price, $description, $quantity, $distributor, $emailDistributor, $phoneNrDistributor)
    {
        $sql = "UPDATE products SET id='$productId', name='$name', category='$category', price='$price', description='$description', quantity='$quantity', distributor='$distributor', emailDistributor='$emailDistributor', phoneNrDistributor='$phoneNrDistributor' WHERE id = $productId";
        try {
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute();
            $conn = null;
        } catch (PDOException $e) {
            echo "Something went wrong. Message: \"" . $e->getMessage() . "\", Code: \"" . $e->getCode() . "\"";
            $conn = null;
        }
    }


    public function getProductsByCategory($category)
    {
        $sql = "SELECT * FROM products WHERE category = '$category';";
        try {
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute();
            $result = $stmt->fetchAll();
            $products = array();
            foreach ($result as $p) {
                $product = new Product($p['id'], $p['name'], $p['category'], $p['price'], $p['description'], $p['quantity'], $p['distributor'], $p['emailDistributor'], $p['phoneNrDistributor']);
                array_push($products, $product);
            }
            $conn = null;
            return $products;
        } catch (PDOException $e) {
            echo "Something went wrong. Message: \"" . $e->getMessage() . "\", Code: \"" . $e->getCode() . "\"";
            $conn = null;
        }
    }


    public function getProductsByDate($date)
    {
        $sql = "SELECT products.id, name, amount FROM salehistory INNER JOIN products on salehistory.id = products.id WHERE date = '$date';";
        try {
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute();
            $result = $stmt->fetchAll();
            $soldProducts = array();
            foreach ($result as $p) {
                $soldProduct = new SoldProduct($p['id'], $p['name'], $p['amount']);
                array_push($soldProducts, $soldProduct);
            }
            $conn = null;
            return $soldProducts;
        } catch (PDOException $e) {
            echo "Something went wrong. Message: \"" . $e->getMessage() . "\", Code: \"" . $e->getCode() . "\"";
            $conn = null;
        }
    }

    public function addProduct($name, $category, $price, $description, $quantity, $distributor, $emailDistributor, $phoneNrDistributor)
    {
        $sql = "INSERT INTO products (name, category, price, description, quantity, distributor, emailDistributor, phoneNrDistributor) VALUES ('$name','$category','$price','$description','$quantity','$distributor','$emailDistributor','$phoneNrDistributor')";
        try {
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute();
            $conn = null;
        } catch (PDOException $e) {
            echo "Something went wrong. Message: \"" . $e->getMessage() . "\", Code: \"" . $e->getCode() . "\"";
            $conn = null;
        }
    }

    public function GetFreeDayOfEmployeeByDate($email, $date)
    {
        $sql = "SELECT * FROM free_days WHERE email='$email' AND date='$date'";
        try {
            $conn = $this->connection();
            $stmt = $conn->prepare($sql);
            $stmt->execute();
            $result = $stmt->fetchAll();
            $free_days = array();
            foreach ($result as $f) {
                $free_day = new FreeDays($f['id'], $f['name'], $f['email'], $f['date'], $f['shift'], $f['reason'], $f['sick_day'], $f['status']);
                array_push($free_days, $free_day);
            }
            $conn = null;
            return $free_days;
        } catch (PDOException $e) {
            echo "Something went wrong.";
            $conn = null;
        }
    }
}
