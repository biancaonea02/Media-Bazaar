<?php
session_start();
$name = $_SESSION["name"];
$email = $_SESSION["email"];
$status = "PENDING";
$message_sick = "";
$message_shift = "";
?>
<?php
if (isset($_GET['date'])) {
    $date = $_GET['date'];
}

if (isset($_POST['submit_shiftoff'])) {
    $name = $_POST['name'];
    $shift = $_POST['shift'];
    $email = $_POST['email'];
    $reason = $_POST['reason'];
    $status = "PENDING";
    $sickday = 0;
    if ($reason != "" || $reason != null) {
        $mysqli = new mysqli("studmysql01.fhict.local", "dbi452560", "12345", "dbi452560");
        $stmt = $mysqli->prepare("INSERT INTO free_days (name, email, date, shift, reason, sick_day, status) VALUES (?,?,?,?,?,?,?)");
        $stmt->bind_param('sssssss', $name, $email, $date, $shift, $reason, $sickday, $status);
        $stmt->execute();
        $msg = "<div class='alert alert-success'>Shift Requested Successfull</div>";
        $stmt->close();
        $mysqli->close();
    } else {
        $message_shift = "<p style=color:red;>Please provide a reason for your shift request.<p>";
    }
} else if (isset($_POST['submit_sickday'])) {
    $name = $_POST['name'];
    $shift = null;
    $email = $_POST['email'];
    $reason = $_POST['reason'];
    $status = "PENDING";
    $sickday = true;
    if ($reason != "" || $reason != null) {
        $mysqli = new mysqli('studmysql01.fhict.local', 'dbi452560', '12345', 'dbi452560');
        $stmt = $mysqli->prepare("INSERT INTO free_days (name, email, date, shift, reason, sick_day, status) VALUES (?,?,?,?,?,?,?)");
        $stmt->bind_param('sssssss', $name, $email, $date, $shift, $reason, $sickday, $status);
        $stmt->execute();
        $msg = "<div class='alert alert-success'>Sickday Requested Successfull</div>";
        $stmt->close();
        $mysqli->close();
    } else {
        $message_sick = "<p style=color:red;>Please provide a reason for your sickday request.<p>";
    }
}

?>


<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../css/styles.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
</head>

<body style="background-color:#907FA4;">
    <div class="container">
        <button style="margin-top:120px; background-color:#301b3f; border-color:#301b3f;" class="btn btn-secondary"><a href="calendar.php">Back to schedule</a></button>
        <h1 class="text-center">Request Leave for Date: <?php echo date('m/d/Y', strtotime($date)); ?></h1>
        <hr>
        <h2 class="text-center" style="color:purple" ;>Request a shift off</h2>
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                <?php echo isset($msg) ? $msg : ''; ?>
                <form action="" method="post" autocomplete="off">
                    <div class="form-group">
                        <label for="">Name</label>
                        <input type="text" class="form-control" name="name" value="<?php echo $name; ?>" readonly>
                    </div>
                    <div class="form-group">
                        <label for="">Email</label>
                        <input type="email" class="form-control" name="email" value="<?php echo $email; ?>" readonly>
                    </div>
                    <div class="form-group">
                        <label for="">Select which shift you want free: </label>

                        <select name="shift">

                            <?php
                            require_once '../includes/db-inc.php';
                            //Query to get active categories
                            $sql = "SELECT * FROM shifts WHERE email='$email' AND date='$date'";
                            //Execute the query
                            $res = mysqli_query($conn, $sql);
                            //Count rows
                            $count = mysqli_num_rows($res);

                            //Check wether shifts available or not
                            if ($count > 0) {
                                //Shifts available
                                while ($row = mysqli_fetch_assoc($res)) {
                                    $shift_type = $row['shift'];
                                    $shift_id = $row['id'];
                            ?>
                                    <option value="<?php echo $shift_type; ?>"><?php echo $shift_type; ?></option>
                                <?php
                                }
                            } else {
                                //Shifts not available
                                ?>
                                <option value="0">No Shifts Found</option>
                            <?php
                            }
                            ?>

                        </select>
                    </div>
                    <div class="form-group">
                        <label for="">Reason for shift off: </label>
                        <input type="textarea" class="form-control" name="reason" rows="5" cols="50">
                    </div>
                    <?php echo $message_shift; ?>
                    <button class="btn btn-primary" style="background-color:#301b3f; border-color:#301b3f;" type="submit" name="submit_shiftoff">Request Shift Off</button>

                </form>
                <br><br><br><br>
                <h2 class="text-center" style="color:purple" ;>Request a sick day</h2>


                <form action="" method="post" autocomplete="off">
                    <input type="hidden" class="form-control" name="name" value="<?php echo $name; ?>">
                    <input type="hidden" class="form-control" name="email" value="<?php echo $email; ?>">
                    <div class="form-group">
                        <label for="">Reason for sick day: </label>
                        <input type="textarea" class="form-control" name="reason" rows="5" cols="50">
                    </div>
                    <?php echo $message_sick; ?>
                    <button class="btn btn-primary" style="background-color:#301b3f; border-color:#301b3f;" type="submit" name="submit_sickday">Request this day as a SICKDAY</button>
                    <br><br><br><br>
                </form>
            </div>
        </div>
    </div>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</body>

</html>