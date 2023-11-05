<?php
require_once __DIR__."/../vendor/bin/phpunit";
use PHPUnit\Framework\TestCase;

final class TwoDecimalPlacesTest extends TestCase
{
    private $kata;
    
    public function testBasicTests() {
        $this->kata = new App\TwoDecimalPlaces();

        $this->assertSame(4.66, $this->kata->twoDecimalPlaces(4.659725356));
        $this->assertSame(173735326.38, $this->kata->twoDecimalPlaces(173735326.3783732637948948));
        $this->assertSame(4.65, $this->kata->twoDecimalPlaces(4.653725356));
    }
}
