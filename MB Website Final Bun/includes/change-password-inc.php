<?php
    session_start();
    require_once 'db-inc.php';
    require_once 'Administration.php';

    $email =  $_SESSION['email'];
    $newPassword = $_POST['repeatNewPassword'];

    if($adm->UpdatePassword($conn, $email, $newPassword) == true)
    {
        header("Location: ../frontend/profile-page.php");
    }
    else
    {
        header("Location: ../frontend/profile-page.php");
    }
?>