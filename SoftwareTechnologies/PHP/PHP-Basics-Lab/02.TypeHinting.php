<?php

function sum(int $a, int $b) : int
{
    return $a + $b;
}

echo sum(2, 3) . "<br>\n"; // 5
echo sum(2.8, 2) . "<br>\n";
echo sum(3, 3) . "<br>\n";
echo sum(3.3, 3.3) . "<br>\n";