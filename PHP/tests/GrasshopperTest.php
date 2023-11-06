<?php
require_once __DIR__."/../vendor/bin/phpunit";
use PHPUnit\Framework\TestCase;

final class GrasshopperTest extends TestCase {
    private $kata;

    public function testBasicTests() {
        $this->kata = new App\Grasshopper();

        $this->assertSame(8, $this->kata->move(0, 4));
        $this->assertSame(15, $this->kata->move(3, 6));
        $this->assertSame(12, $this->kata->move(2, 5));
    }
}