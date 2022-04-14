<?php
session_start();
 if(!isset($_SESSION['email'])){
   header("Location: login.php");
 }
?>
<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>MediaBazaar</title>
  <link rel="stylesheet" href="../css/styles.css">
  <link rel="preconnect" href="https://fonts.gstatic.com">
  <link href="https://fonts.googleapis.com/css2?family=Lora:wght@500&family=Roboto+Slab&family=Sacramento&display=swap" rel="stylesheet">
</head>

<body>
  <header>
    <a href="#aboutUs" class="logo"><span>M</span>edia<span>B</span>azaar</a>
    <div class="menuToggle" onclick="toggleMenu();">

    </div>
    <ul class="navigation">
      <li>
        <a href="index.php" onclick="toggleMenu();">Home</a>
      </li>
      <?php
          if($_SESSION["position"] == "inventory manager"){
            echo "<li><a href='inventoryManagement.php' onclick='toggleMenu();'>Inventory</a></li>";
          }
          else if($_SESSION["position"] == "employee manager"){
            echo "<li><a href='employee-management.php' onclick='toggleMenu();'>Employees</a></li>";
          }
          else if($_SESSION["department"] == "WAREHOUSE"){
            echo "<li><a href='request-restock.php' onclick='toggleMenu();'>Request Restock</a></li>";
          }
        ?>
      <li>
        <a href="calendar.php" onclick="toggleMenu();">Schedule</a>
      </li>
      <li>
        <a href="preffered-shifts.php" onclick="toggleMenu();">Shift Prefferance</a>
      </li>
      <li>
        <a href="profile-page.php" onclick="toggleMenu();">My Profile</a>
      </li>
      <li>
        <a class="logout" href="../includes/logout-inc.php" onclick="toggleMenu();">Logout</a>
      </li>
    </ul>
  </header>