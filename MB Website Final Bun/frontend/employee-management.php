<?php
  include ('header.php');
  require_once('../includes/Administration.php');
  require_once('../includes/db-inc.php');
?>

  <table class="table-emp">
    <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Email</th>
        <th>Address</th>
        <th>Phonenumber</th>
        <th>Hourly Wage</th>
        <th>Hourd Worked</th>
        <th>Holiday Days</th>
        <th>Sick Days</th>
    </tr>
    <?php
        $employees;
        //$adm->AddEmployeesFromDatabase($conn);
        $employees = $adm->GetAllEmployees();
        foreach($employees as &$value){
            echo "<tr><td>". $value->GetId() ."</td><td>". $value->GetName() ."</td><td>". $value->GetEmail() ."</td><td>". $value->GetAddress() ."</td><td>". $value->GetPhoneNumber() ."</td><td>". $value->GetHourlyWage() ."$</td><td>". $value->GetHoursWorked() ."</td><td>". $value->GetHolidayDays() ."</td><td>". $value->GetSickDays() ."</td>";
        }
        
    ?>
  </table>
<?php
  include('javascript.php');
?>
</body>
</html>