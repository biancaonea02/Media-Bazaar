<?php
session_start();
require_once "../classes/product.php";
require_once "../classes/Dbh.php";
$dbhandler = new Dbh;
$email = $_SESSION["email"];


function build_calendar($month, $year, $email)
{
    $mysqli = new mysqli('studmysql01.fhict.local', 'dbi452560', '12345', 'dbi452560');
    $stmt = $mysqli->prepare("select * from shifts where MONTH(date) = ? AND YEAR(date) = ? AND email = ?");
    $stmt->bind_param('sss', $month, $year, $email);
    $bookings = array();
    if ($stmt->execute()) {
        $result = $stmt->get_result();
        if ($result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                $bookings[] = $row['date'];
            }

            $stmt->close();
        }
    }

    $mysqli = new mysqli('studmysql01.fhict.local', 'dbi452560', '12345', 'dbi452560');
    $stmt = $mysqli->prepare("select * from free_days where MONTH(date) = ? AND YEAR(date) = ? AND email = ? AND status = 'ACCEPTED'");
    $stmt->bind_param('sss', $month, $year, $email);
    $free_days = array();
    if ($stmt->execute()) {
        $result = $stmt->get_result();
        if ($result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                $free_days[] = $row['date'];
            }

            $stmt->close();
        }
    }


    // Create array containing abbreviations of days of week.
    $daysOfWeek = array('Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday');

    // What is the first day of the month in question?
    $firstDayOfMonth = mktime(0, 0, 0, $month, 1, $year);

    // How many days does this month contain?
    $numberDays = date('t', $firstDayOfMonth);

    // Retrieve some information about the first day of the
    // month in question.
    $dateComponents = getdate($firstDayOfMonth);

    // What is the name of the month in question?
    $monthName = $dateComponents['month'];

    // What is the index value (0-6) of the first day of the
    // month in question.
    $dayOfWeek = $dateComponents['wday'];

    // Create the table tag opener and day headers

    $datetoday = date('Y-m-d');



    $calendar = "<table class='table table-bordered'>";
    $calendar .= "<center><h2>Your schedule for $monthName $year</h2>";
    $calendar .= "<a style='background-color: #907FA4;border-color: #907FA4; margin-right:10px; font-size:15px;' class='btn btn-xs btn-primary' href='?month=" . date('m', mktime(0, 0, 0, $month - 1, 1, $year)) . "&year=" . date('Y', mktime(0, 0, 0, $month - 1, 1, $year)) . "'>Previous Month</a> ";

    $calendar .= " <a style='background-color: #907FA4;border-color: #907FA4; margin-right:10px; font-size:15px;' class='btn btn-xs btn-primary' href='?month=" . date('m') . "&year=" . date('Y') . "'>Current Month</a> ";

    $calendar .= "<a style='background-color: #907FA4;border-color: #907FA4; margin-right:10px; font-size:15px;' class='btn btn-xs btn-primary' href='?month=" . date('m', mktime(0, 0, 0, $month + 1, 1, $year)) . "&year=" . date('Y', mktime(0, 0, 0, $month + 1, 1, $year)) . "'>Next Month</a></center><br>";



    $calendar .= "<tr>";

    // Create the calendar headers

    foreach ($daysOfWeek as $day) {
        $calendar .= "<th  class='header'>$day</th>";
    }

    // Create the rest of the calendar

    // Initiate the day counter, starting with the 1st.

    $currentDay = 1;

    $calendar .= "</tr><tr>";

    // The variable $dayOfWeek is used to
    // ensure that the calendar
    // display consists of exactly 7 columns.

    if ($dayOfWeek > 0) {
        for ($k = 0; $k < $dayOfWeek; $k++) {
            $calendar .= "<td  class='empty'></td>";
        }
    }


    $month = str_pad($month, 2, "0", STR_PAD_LEFT);

    while ($currentDay <= $numberDays) {

        // Seventh column (Saturday) reached. Start a new row.

        if ($dayOfWeek == 7) {

            $dayOfWeek = 0;
            $calendar .= "</tr><tr>";
        }

        $currentDayRel = str_pad($currentDay, 2, "0", STR_PAD_LEFT);
        $date = "$year-$month-$currentDayRel";

        $dayname = strtolower(date('l', strtotime($date)));
        $eventNum = 0;
        $today = $date == date('Y-m-d') ? "today" : "";
        if ($date < date('Y-m-d')) {
            $calendar .= "<td><h4>$currentDay</h4> <button class='btn btn-danger btn-xs'>N/A</button>";
        } else if (in_array($date, $bookings)) {
            $calendar .= "<td class='$today'><h4>$currentDay</h4> <a href='request.php?date=" . $date . "' class='btn btn-danger btn-xs'>Scheduled</a><br>";
        } else if (in_array($date, $free_days)) {
            $calendar .= "<td class='$today'><h4>$currentDay</h4> <button class='btn btn-success btn-xs' style='background-color:#FFC107; border-color:#FFC107;'>Free Day</button><br>";
        } else {
            $calendar .= "<td class='$today'><h4>$currentDay</h4> <button class='btn btn-success btn-xs'>Not Scheduled</button><br>";
        }

        $calendar .= "</td>";
        // Increment counters

        $currentDay++;
        $dayOfWeek++;
    }



    // Complete the row of the last week in month, if necessary

    if ($dayOfWeek != 7) {

        $remainingDays = 7 - $dayOfWeek;
        for ($l = 0; $l < $remainingDays; $l++) {
            $calendar .= "<td class='empty'></td>";
        }
    }

    $calendar .= "</tr>";

    $calendar .= "</table>";

    echo $calendar;
}

?>


<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/schedule.css">
</head>


<?php include('header.php'); ?>
<div class="schedule-main-content">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <?php
                $dateComponents = getdate();
                if (isset($_GET['month']) && isset($_GET['year'])) {
                    $month = $_GET['month'];
                    $year = $_GET['year'];
                } else {
                    $month = $dateComponents['mon'];
                    $year = $dateComponents['year'];
                }
                echo build_calendar($month, $year, $email);
                ?>
            </div>
        </div>
    </div>
</div>

</body>