<?php

class Shift
{
    //instance variables
    private $startHour;
    private $finishHour;
    private $weedDay;
    private $date;

    //constructor
    public function __construct($startHour, $finishHour, $weekDay, $date)
    {
        $this->startHour = $startHour;
        $this->finishHour = $finishHour;
        $this->weekDay = $weedDay;
        $this->date = $date;
    }

    //getters
    public function GetStartHour()
    {
        return "$this->startHour";
    }

    public function GetFinishHour()
    {
        return "$this->finishHour";
    }

    public function GetWeekDay()
    {
        return "$this->weekDay";
    }

    public function GetDate()
    {
        return "$this->date";
    }
    //setters

    public function SetStartHour($startHour)
    {
        $this->startHour = $startHour;
    }

    public function SetFinishHour($finishHour)
    {
        $this->finishHour = $finishHour;
    }

    public function SetWeekDay($weekDay)
    {
        $this->weekDay = $weekDay;
    }

    public function SetDate($date)
    {
        $this->date = $date;
    }
}
