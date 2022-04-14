<?php
require_once('user.php');
class Manager extends User
{
    //variables
    protected $position;

    //constructor
    public function __construct($id, $name, $gender, $password, $email, $address, $phoneNumber, $hourlyWage, $hoursWorked, $birthDate, $holidayDays, $sickDays)
    {
        $this->position = $position;
        parent::__construct($id, $name, $gender, $password, $email, $address, $phoneNumber, $hourlyWage, $hoursWorked, $birthDate, $holidayDays, $sickDays);
    }

    //getters
    public function GetPosition()
    {
        return "$this->position";
    }

    //setters

    public function SetPosition($position)
    {
        $this->position = $position;
    }

}