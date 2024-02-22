<?php
class Car{
    public $marka;
    public $model;
    public $rokProdukcji;

    function __construct($marka, $model, $rokProdukcji)
    {
        $this->marka = $marka;
        $this->model = $model;
        $this->rokProdukcji = $rokProdukcji;
    }

    public function __toString(): string
    {
        return "Marka: $this->marka Model: $this->model Rok Produkcji: $this->rokProdukcji";
    }

}

$car = new Car("AUDI", "A4", 2012);
echo $car->__toString();