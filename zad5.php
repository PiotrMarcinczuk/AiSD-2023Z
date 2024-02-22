<?php
$tab = array();
echo "Podaj liczbe 1: ";
array_push($tab, readline());
echo "Podaj liczbe 2: ";
array_push($tab, readline());
echo "Podaj liczbe 3: ";
array_push($tab, readline());
echo "Podaj liczbe 4: ";
array_push($tab, readline());
$max = $tab[0];
for($i=0; $i<count($tab); $i++){
    if($tab[$i] > $max){
        $max = $tab[$i];
    }
}
echo "Maksymalna: ", $max;
