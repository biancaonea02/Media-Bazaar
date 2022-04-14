<?php

$serverName = "studmysql01.fhict.local";
$dbUsername = "dbi452560";
$dbPassword = "12345";
$dbName = "dbi452560";

$conn = mysqli_connect($serverName, $dbUsername, $dbPassword, $dbName);

if(!$conn)
{
  die("Connection failed: " . mysqli_connect_error());
}
