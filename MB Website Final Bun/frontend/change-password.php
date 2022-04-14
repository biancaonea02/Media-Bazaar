<?php
include('header.php');
?>

<html>

<head>
    <title>Profile - Page</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="../css/styles.css">
</head>


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
                    <form action="../includes/change-password-inc.php" method="post">
                        <div>
                            <br>
                            <h4>New Password:</h4>
                            <br>
                            <input type="password" style='border-color: #2C003E; border-radius:6px; padding:3px;' name="newPassword">
                            <br><br>
                            <h4>Repeat Password:</h4>
                            <br>
                            <input type="password" style='border-color: #2C003E; border-radius:6px; padding:3px;' name="repeatNewPassword">
                            <br><br>
                            <input type="submit" name="submit" value="Change Password" class="btn"></a>
                        </div>
                    </form>
                </div>
            </div>
        </main>
    </div>
</body>

</html>