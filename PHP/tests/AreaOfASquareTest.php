<?php
require_once __DIR__."/../vendor/bin/phpunit";
use PHPUnit\Framework\TestCase;

final class AreaOfASquareTest extends TestCase {
    private $kata;

    public function testBasicTests() {
        $this->kata = new App\AreaOfASquare();

        $this->assertSame(0.00, $this->kata->square_area(0));
        $this->assertSame(1.62, $this->kata->square_area(2));
        $this->assertSame(80.00, $this->kata->square_area(14.05));
    }
}