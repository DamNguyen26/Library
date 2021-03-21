<?php
if (isset($_POST["login"])) {
    $Email = $_POST["Email"];
    $Password = $_POST["Password"];

    $Email = strip_tags($Email);
    $Email = addslashes($Email);
    $Password = strip_tags($Password);
    $Password = addslashes($Password);
    include("func/connec.php");
    $sql = "SELECT * FROM `login` WHERE Email = '$Email' and Password = '$Password'";
    $result = mysqli_query($conn, $sql);
    $num_rows = mysqli_num_rows($result);
    if ($num_rows == 0) {
        echo "Email or password is incorrect !";
        ?>
        <br>
        <button><a href="../signin.php">Back to login</a></button>
        <?php
    } else {
        session_start();
        $_SESSION['Email'] = $Email;
        header('Location: ../index.php');
    }
}
