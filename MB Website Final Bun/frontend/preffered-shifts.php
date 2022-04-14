<?php
  include ('header.php');
?>

<?php
    require_once '../includes/db-inc.php';
    //Query to get active categories
    $emailEmployee = $_SESSION["email"];
    $sql = "SELECT * FROM preffered_shifts WHERE emailEmployee='$emailEmployee'";
    //Execute the query
    $res = mysqli_query($conn, $sql);
    //Count rows
    $count = mysqli_num_rows($res);

    //Check wether shifts available or not
    if($count>0)
    {
        //Shifts available
        while($row=mysqli_fetch_assoc($res))
        {
            $monday = $row['monday'];
            $tuesday = $row['tuesday'];
            $wednesday = $row['wednesday'];
            $thursday = $row['thursday'];
            $friday = $row['friday'];
            ?>
            <?php
        }
    }
    else
    {
        //Shifts not available
        ?>
        <option value="0">No Shifts Found</option>
        <?php
    }
?>
<br><br><br><br><br>
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Preffered Shifts For Each Weekday Form</title>
	<link rel="stylesheet" href="../css/styles-preffered-shifts.css">
</head>
<body>

<div class="wrapper-preffered-shifts">
  <form action="" method="POST">
    <div class="title">
      Preffered Shifts For Each Weekday Form
      </div>
      <div class="form">
        <div class="inputfield">
            <label>Monday</label>
            <div class="custom_select">
              <select name="monday">
                <?php ?>
                <option class="green_color" style="color:blue" value="<?php echo $monday?>"><?php echo $monday; ?></option>
                <option value="morning">morning</option>
                <option value="afternoon">afternoon</option>
                <option value="evening">evening</option>
                <option value="no preference">no preference</option>
              </select>
            </div>
        </div>
          <div class="inputfield">
            <label>Tuesday</label>
            <div class="custom_select">
              <select name="tuesday">
                <option class="green_color" style="color:blue" value="<?php echo $tuesday?>"><?php echo $tuesday; ?></option>
                <option value="morning">morning</option>
                <option value="afternoon">afternoon</option>
                <option value="evening">evening</option>
                <option value="no preference">no preference</option>
              </select>
            </div>
        </div>
        <div class="inputfield">
            <label>Wednesday</label>
            <div class="custom_select">
              <select name="wednesday">
                <option class="green_color" style="color:blue" value="<?php echo $wednesday?>"><?php echo $wednesday; ?></option>
                <option value="morning">morning</option>
                <option value="afternoon">afternoon</option>
                <option value="evening">evening</option>
                <option value="no preference">no preference</option>
              </select>
            </div>
        </div>
        <div class="inputfield">
            <label>Thursday</label>
            <div class="custom_select">
              <select name="thursday">
                <option class="green_color" style="color:blue" value="<?php echo $thursday?>"><?php echo $thursday; ?></option>
                <option value="morning">morning</option>
                <option value="afternoon">afternoon</option>
                <option value="evening">evening</option>
                <option value="no preference">no preference</option>
              </select>
            </div>
        </div>
          <div class="inputfield">
            <label>Friday</label>
            <div class="custom_select">
              <select name="friday">
                <option class="green_color" style="color:blue" value="<?php echo $friday?>"><?php echo $friday; ?></option>
                <option value="morning">morning</option>
                <option value="afternoon">afternoon</option>
                <option value="evening">evening</option>
                <option value="no preference">no preference</option>
              </select>
            </div>
        </div>
        <div class="inputfield">
          <input type="submit" value="Submit Preference Form" class="btn" name="submit_prefered_shifts">
        </div>
      </div>
    </form>
</div>

</body>
</html>

<?php

if(isset($_POST['submit_prefered_shifts'])){
  // $emailEmployee = $_SESSION["email"];
  $monday = $_POST['monday'];
  $tuesday = $_POST['tuesday'];
  $wednesday = $_POST['wednesday'];
  $thursday = $_POST['thursday'];
  $friday = $_POST['friday'];
  if($monday != null || $tuesday != null || $wednesday != null || $thursday != null || $friday != null){
  $mysqli = new mysqli('studmysql01.fhict.local', 'dbi452560', '12345', 'dbi452560');
  $stmt = $mysqli->prepare("UPDATE preffered_shifts SET monday='$monday', tuesday='$tuesday', wednesday='$wednesday', thursday='$thursday', friday='$friday' WHERE emailEmployee='$emailEmployee'");
  $stmt->execute();
  $msg = "<div class='alert alert-success'>Preferences for the next week set successfull</div>";
  $stmt->close();
  $mysqli->close();
  echo '<div class="bar success">Successfully Set Prefered Shifts</div>';
  }
  else{
      echo '<div class="bar error">Error: Prefered Shifts Not Set Correctly</div>';
  }
}
 
?>

<?php
  include('javascript.php');
?>