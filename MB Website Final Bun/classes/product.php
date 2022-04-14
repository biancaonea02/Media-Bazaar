<?php
class Product{
    public $id;
    public $name;
    public $category;
    public $price;
    public $description;
    public $quantity;
    public $distributor;
    public $emailDistributor;
    public $phoneNrDistributor;

    function __construct($Id, $Name, $Category, $Price, $Description, $Quantity, $Distributor, $EmailDistributor, $PhoneNrDistributor)
    {
        $this->id = $Id;
        $this->name = $Name;
        $this->category = $Category;
        $this->price = $Price;
        $this->description = $Description;
        $this->quantity = $Quantity;
        $this->distributor = $Distributor;
        $this->emailDistributor = $EmailDistributor;
        $this->phoneNrDistributor = $PhoneNrDistributor;
    }
}


class SoldProduct{
    public $id;
    public $name;
    public $amount;

    function __construct($Id, $Name, $Amount)
    {
        $this->id = $Id;
        $this->name = $Name;
        $this->amount = $Amount;
    }
}
?>