<?php
    session_start();
    require_once 'db-inc.php';
    require_once 'Administration.php';

    $email =  $_SESSION['email'];
    $newPhoneNr = $_POST['currentPhoneNumber'];
    $newAddress = $_POST['currentAddress'];

    if($adm->EditProfile($conn, $email, $newPhoneNr, $newAddress) == true)
    {
      header("Location: ../frontend/profile-page.php");
    }
    else
    {
      header("Location: ../frontend/index.php");
    }

?>
