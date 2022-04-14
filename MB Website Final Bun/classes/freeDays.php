<?php

class FreeDays
{

    //variables
    private $id;
    private $name;
    private $email;
    private $date;
    private $shift;
    private $reason;
    private $sick_day;
    private $status;

    //constructor
    public function __construct($id, $name, $email, $date, $shift, $reason, $sick_day, $status)
    {
        $this->id = $id;
        $this->name = $name;
        $this->email = $email;
        $this->date = $date;
        $this->shift = $shift;
        $this->reason = $reason;
        $this->sick_day = $sick_day;
        $this->status = $status;
    }
}
