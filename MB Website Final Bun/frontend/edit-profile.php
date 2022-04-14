<?php
include('header.php');
?>

<html>

<head>
    <title>Profile - Page</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="../css/styles.css">
</head>

<?php
require_once('../includes/db-inc.php');
require_once('../includes/Administration.php');

$email = $_SESSION['email'];
$emailExists1 = $adm->emailExistsEmployee($conn, $email);
$emailExists2 = $adm->emailExistsManager($conn, $email);

if ($emailExists1 == true && $emailExists2 == false) //it's an employee
{
    $phoneNr = $emailExists1["phonenumber"];
    $address = $emailExists1["address"];
}

if ($emailExists1 == false && $emailExists2 == true) //it's a manager
{
    $phoneNr = $emailExists2["phonenumber"];
    $address = $emailExists2["address"];
}
?>


<body class="profile-page">
    <div class="container">
        <main>
            <div class="card-container">

                <div class="upper-container">
                    <div class="image-container">
                        <img src="../images/profile.jpeg">
                    </div>
                </div>

                <div class="lower-container">
                    <form action="../includes/edit-profile-user.inc.php" method="post">
                        <div>
                            <br>
                            <h4>Phone Number:</h3>
                                <br>
                                <input type="text" style='border-color: #2C003E; border-radius:6px; padding:3px;' name="currentPhoneNumber" value="<?php echo $phoneNr; ?>">
                                <br><br>
                                <h4>Address:</h3>
                                    <br>
                                    <input style='border-color: #2C003E; border-radius:6px; padding:3px;' type="text" name="currentAddress" value="<?php echo $address; ?>">
                                    <br><br>
                                    <input type="submit" name="submit" value="Update Profile" class="btn"></a>
                        </div>
                    </form>
                </div>

            </div>
        </main>
    </div>
</body>

</html>