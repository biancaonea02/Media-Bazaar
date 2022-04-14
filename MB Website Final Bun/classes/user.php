<?php

class User
{
    //variables
    protected $name;
    protected $id;
    protected $gender;
    protected $password;
    protected $email;
    protected $address;
    protected $phoneNumber;
    protected $hourlyWage;
    protected $hoursWorked;
    protected $birthDate;
    protected $holidayDays;
    protected $sickDays;

    //constructor
    public function __construct($id, $name, $gender, $password, $email, $address, $phoneNumber, $hourlyWage, $hoursWorked, $birthDate, $holidayDays, $sickDays)
    {
        $this->id = $id;
        $this->name = $name;
        $this->gender = $gender;
        $this->password = $password;
        $this->email = $email;
        $this->address = $address;
        $this->phoneNumber = $phoneNumber;
        $this->hourlyWage = $hourlyWage;
        $this->hoursWorked = $hoursWorked;
        $this->birthDate = $birthDate;
        $this->holidayDays = $holidayDays;
        $this->sickDays = $sickDays;
    }

    //getters
    public function GetName()
    {
        return "$this->name";
    }

    public function GetId()
    {
        return "$this->id";
    }

    public function GetEmail()
    {
        return "$this->email";
    }

    public function GetPassword()
    {
        return "$this->password";
    }

    public function GetBirthDate()
    {
        return "$this->birthDate";
    }

    public function GetHolidayDays()
    {
        return "$this->holidayDays";
    }

    public function GetSickDays()
    {
        return "$this->sickDays";
    }

    public function GetGender()
    {
        return "$this->gender";
    }

    public function GetPhoneNumber()
    {
        return "$this->phoneNumber";
    }

    public function GetAddress()
    {
        return "$this->address";
    }

    public function GetHourlyWage()
    {
        return "$this->hourlyWage";
    }

    public function GetHoursWorked()
    {
        return "$this->hoursWorked";
    }

    //setters

    public function SetPassword($password)
    {
        $this->password = $password;
    }

    public function SetHolidayDays($holidayDays)
    {
        $this->holidayDays = $holidayDays;
    }

    public function SetSickDays($sickDays)
    {
        $this->sickDays = $sickDays;
    }

    public function SetPhoneNumber($phoneNumber)
    {
        $this->phoneNumber = $phoneNumber;
    }

    public function SetAddress($address)
    {
        $this->address = $address;
    }

    public function SetHourlyWage($hourlyWage)
    {
        $this->hourlyWage = $hourlyWage;
    }

    public function SetHoursWorked($hoursWorked)
    {
        $this->hoursWorked = $hoursWorked;
    }
}
