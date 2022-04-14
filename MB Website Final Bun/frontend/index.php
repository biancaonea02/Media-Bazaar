<?php
include('header.php');
require_once('../includes/db-inc.php');
$name = $_SESSION['name'];
$email = $_SESSION['email'];
$hourly_wage = $_SESSION['hourly_wage'];
$hours_worked = $_SESSION['hours_worked'];
$holiday_days = $_SESSION['holiday_days'];
$sick_days = $_SESSION['sick_days'];
?>

<br><br><br><br><br><br>

<!-- Main Content Section Starts -->
<div class="main-content-home">
  <div class="greeting">
    <h1>Welcome back, <?php echo $_SESSION['name']; ?>!</h1>
  </div>
  <div class="wrapper-home">
    <br><br>
    <div class="col-4-home text-center">
      <h1>$ <?php echo $hourly_wage; ?></h1>
      <br>
      Hourly Wage
    </div>

    <div class="col-4-home text-center">

      <h1><?php echo $hours_worked; ?></h1>
      <br>
      Hours Worked
    </div>

    <div class="col-4-home text-center">
      <h1><?php echo $holiday_days; ?></h1>
      <br>
      Holiday Days Left
    </div>

    <div class="col-4-home text-center">

      <h1><?php echo $sick_days ?></h1>
      <br>
      Sick Days Left
    </div>

    <div class="clearfix"></div>
  </div>
</div>
<!-- Main Content Section Ends -->

<?php
include('javascript.php');
?>
</body>

</html>