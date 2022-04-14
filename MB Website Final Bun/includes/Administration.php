<?php
require_once('../classes/user.php');
require_once('../classes/employee.php');
class Administration{

    private $employees;

    public function __construct(){
      $this->employees = array();
    }

    function AddEmployeesFromDatabase($conn)
    {
      $sql = "SELECT * FROM users";
      $stmt = mysqli_stmt_init($conn);

      mysqli_stmt_prepare($stmt, $sql);
      mysqli_stmt_execute($stmt);

      $result = mysqli_stmt_get_result($stmt);

      if ($result->num_rows > 0)
      {
      while($row = $result->fetch_assoc())
        {
          $id = $row["id"];
          $name = $row["username"];
          $email = $row["email"];
          $gender = $row["gender"];
          $hourlyWage = $row["hourlyWage"];
          $address = $row["address"];
          $phoneNumber = $row["phonenumber"];
          $hoursWorked = $row["hoursWorked"];
          $password = $row["password"];
          $holidayDays = $row["holidayDays"];
          $sickDays = $row["sickDays"];
          $birthDate = $row["birthDate"];

          array_push($this->employees, new Employee($id, $name, $gender, $password, $email, $address, $phoneNumber, $hourlyWage, $hoursWorked, $birthDate, $holidayDays, $sickDays));
        }
      }
    }

    function GetAllEmployees(){
      return $this->employees; 
    }

    function invalidEmail($email)
    {
      if(!filter_var($email, FILTER_VALIDATE_EMAIL))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    function emailExistsEmployee($conn, $email)
    {
      $sql = "SELECT * FROM users WHERE email = ?;";
      $stmt = mysqli_stmt_init($conn);
      if(!mysqli_stmt_prepare($stmt, $sql))
      {
        exit();
      }

      mysqli_stmt_bind_param($stmt, "s", $email);
      mysqli_stmt_execute($stmt);

      $resultData = mysqli_stmt_get_result($stmt);

      if($row = mysqli_fetch_assoc($resultData))
      {
        return $row;
      }
      else
      {
        $result = false;
        return $result;
      }
      mysqli_stmt_close($stmt);

    }

    function emailExistsManager($conn, $email)
    {
      $sql = "SELECT * FROM managers WHERE email = ?;";
      $stmt = mysqli_stmt_init($conn);
      if(!mysqli_stmt_prepare($stmt, $sql))
      {
        exit();
      }

      mysqli_stmt_bind_param($stmt, "s", $email);
      mysqli_stmt_execute($stmt);

      $resultData = mysqli_stmt_get_result($stmt);

      if($row = mysqli_fetch_assoc($resultData))
      {
        return $row;
      }
      else
      {
        $result = false;
        return $result;
      }
      mysqli_stmt_close($stmt);

    }

    function passwordsMatch($password, $repeatpassword)
    {
      $result;
      if($password == $repeatpassword)
      {
        $result = true;
      }
      else
      {
        $result = false;
      }

      return $result;
    }

    function getUserByEmail($email)
    {
        for($i = 0; $i < count($this->employees); $i++)
        {
          if($this->employees[$i]->GetEmail() == "$email")
          {
            return $this->employees[$i];
          }
        return null;
        }
    }

    function UpdatePassword($conn, $email, $new_password)
    {
        //get the user that we want to update
        $emailExists1 = $this->emailExistsEmployee($conn, $email);
        $emailExists2= $this->emailExistsManager($conn, $email);
        // $employeeToBeUpdated = $this->emailExists($conn, $email);

        //check if the current one is the same as in the database
        if($emailExists1 == false && $emailExists2 == true) //it's a manager
        {
          $sql1 = "UPDATE managers SET password='$new_password' WHERE email = '$email'";

          if ($conn->query($sql1) === TRUE)
              {
                  echo "Password successfully updated!";
                 // $employeeToBeUpdated->SetPassword($new_password);
                  return true;
              }
              else
              {
                  echo "Error updating password. Try again!";
                  return false;
              }
        }

        if($emailExists2 == false && $emailExists1 == true) //it's an employee
        {
          $sql1 = "UPDATE users SET password='$new_password' WHERE email = '$email'";
          if ($conn->query($sql1) === TRUE)
              {
                  echo "Password successfully updated!";
                 // $employeeToBeUpdated->SetPassword($new_password);
                  return true;
              }
              else
              {
                  echo "Error updating password. Try again!";
                  return false;
              }
        }

    }



      function logInUser($conn, $email, $password)
    {
      $emailExists1 = $this->emailExistsEmployee($conn, $email);
      $emailExists2 = $this->emailExistsManager($conn, $email);

      if($emailExists1 == false && $emailExists2 == false)
      {
        Header("Location: ../frontend/login.php?error=emailnotexists");
        exit();
      }

      if($emailExists1 == false && $emailExists2 == true)
      {
        $userLogged = $emailExists2; //it's a manager
        $_SESSION["name"] = $userLogged["name"];
        $passwordDB = $userLogged["password"];
        $phoneNrDB =  $userLogged["phonenumber"];
      }

      if($emailExists1 == true && $emailExists2 == false)
     {
        $userLogged = $emailExists1; //it's an employee
        $_SESSION["name"] = $userLogged["username"];
        $passwordDB = $userLogged["password"];
        $phoneNrDB =  $userLogged["phonenumber"];
        $_SESSION["department"] = $userLogged["department"];
     }


      if($this->passwordsMatch($password, $passwordDB) == false)
      {
        Header("Location: ../frontend/login.php?error=passwordsnotmatch");
        exit();
      }
      else if($this->passwordsMatch($password, $passwordDB) == true)
      {
        session_start();
        $_SESSION["email"] = $userLogged["email"];
        $_SESSION["position"] = $userLogged["position"];
        $_SESSION["address"] = $userLogged["address"];
        $_SESSION["holiday_days"] = $userLogged["holidayDays"];
        $_SESSION["sick_days"] = $userLogged["sickDays"];
        $_SESSION["hours_worked"] = $userLogged["hoursWorked"];
        $_SESSION["hourly_wage"] = $userLogged["hourlyWage"];
        $_SESSION["phoneNumber"] = $phoneNrDB;

        Header("Location: ../frontend/");
        exit();
      }
    }

  function EditProfile($conn, $email, $phoneNr, $address)
  {
    //get the user that we want to update
    $emailExists1 = $this->emailExistsEmployee($conn, $email);
    $emailExists2= $this->emailExistsManager($conn, $email);


    if($emailExists1 == false && $emailExists2 == true) //it's a manager
    {
      $sql1 = "UPDATE managers SET phoneNumber='$phoneNr' WHERE email = '$email'";
      $sql2 = "UPDATE managers SET address='$address' WHERE email = '$email'";

      if ($conn->query($sql1) === TRUE && $conn->query($sql2) === TRUE)
          {
              echo "Profile successfully updated!";
             // $employeeToBeUpdated->SetPassword($new_password);
              return true;
          }
          else
          {
              echo "Error updating profile. Try again!";
              return false;
          }
    }

    if($emailExists2 == false && $emailExists1 == true) //it's an employee
    {
      $sql1 = "UPDATE users SET phonenumber='$phoneNr' WHERE email = '$email'";
      $sql2 = "UPDATE users SET address='$address' WHERE email = '$email'";
      if ($conn->query($sql1) === TRUE && $conn->query($sql2) === TRUE)
          {
              echo "Profile successfully updated!";
             // $employeeToBeUpdated->SetPassword($new_password);
              return true;
          }
          else
          {
              echo "Error updating profile. Try again!";
              return false;
          }
    }
  }

  function NrOfProductsForEachCategory($conn, $category)
  {
      $quantity = 0;
      $sql = "SELECT * FROM products WHERE category = '$category'";
      $stmt = mysqli_stmt_init($conn);

      mysqli_stmt_prepare($stmt, $sql);
      mysqli_stmt_execute($stmt);

      $result = mysqli_stmt_get_result($stmt);

      if ($result->num_rows > 0)
      {
      while($row = $result->fetch_assoc())
        {
          $quantity = $quantity + $row["quantity"];
        }
      }

      return $quantity;
  }
  public function RestockRequest($conn, $id, $quantity){
    $sql = "INSERT INTO restock_requests(idProduct, quantity, date, status) VALUES ($id, $quantity, '2021-05-11', 'PENDING' )";
    $res = mysqli_query($conn, $sql);
}
  // function GetShiftsForEmployee($conn, $email){
  //   $sql = "SELECT shift FROM shifts WHERE email = '$email'";
  // }

}


 //<!-- // CREATE AN ADMINISTRATION OBJECT AND LOAD IT WITH DATA FROM THE DATABASE -->

require_once 'db-inc.php';
$adm = new Administration();
$adm->AddEmployeesFromDatabase($conn);
