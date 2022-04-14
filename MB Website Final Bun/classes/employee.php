<?php

require_once "shift.php";
require_once "user.php";

class Employee extends User
{
    //variables
    protected $shifts;

    //constructor
    public function __construct($id, $name, $gender, $password, $email, $address, $phoneNumber, $hourlyWage, $hoursWorked, $birthDate, $holidayDays, $sickDays)
    {
        $this->shifts = array();
        parent::__construct($id, $name, $gender, $password, $email, $address, $phoneNumber, $hourlyWage, $hoursWorked, $birthDate, $holidayDays, $sickDays);
    }

    //properties
    public function GetShifts(){
        return "$this->shifts";
    }

    // public function GetEmail()
    // {
    //     parent::GetEmail();
    // }

    //methods
    public function GetShiftByStartHourAndEndHourAndDate($start, $end, $date)
    {
        $unixTimestamp = strtotime($date);
        $day = date("l", $unixTimestamp);

        foreach($shifts as &$value){
            if($value->GetStartHour() == $start && $value->GetFinishHour() == $end && $value->GetDateDay() == $day){
                return $value;
            }
        }
        return null;
    }

    public function AddShift($shift){
        array_push($this->shifts, $shift);
    }

    public function RemoveShift($shift){
        if(in_array($shift, $this->shifts)){
            unset($this->shifts[$shift]);
            return true;
        }
        else{
            return false;
        }
    }

}