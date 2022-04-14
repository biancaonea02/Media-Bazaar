<?php
session_start();

if(isset($_POST["submit"]))
{
   $email = $_POST['email'];
   $password = $_POST['password'];

   require_once 'db-inc.php';
   require_once 'Administration.php';
  
   $adm->logInUser($conn, $email, $password);
}
else
{ 
  Header("Location: ../frontend/login.php?");
}
?>