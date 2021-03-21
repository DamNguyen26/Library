<?php
$host = 'localhost';
$user = 'root';
$pass = '';
$db   = 'DB_ Library';
$conn =  mysqli_connect($host, $user, $pass, $db);
if (!$conn) {
    die("Failed to connect" . mysqli_connect_error());
}
