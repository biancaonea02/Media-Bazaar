<?php

class Announcement
{
    //instance variables
    private $announcementText;


    //constructor
    public function __construct($announcementText)
    {
        $this->announcementText = $announcementText;
    }

    //getters
    public function GetAnnouncementText()
    {
        return "$this->announcementText";
    }
    //setters

    public function SetAnnouncementText($announcementText)
    {
        $this->announcementText = $announcementText;
    }
}