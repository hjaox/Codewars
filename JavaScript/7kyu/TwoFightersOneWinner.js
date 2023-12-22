/*
https://www.codewars.com/kata/577bd8d4ae2807c64b00045b



Create a function that returns the name of the winner in a fight between two fighters.

Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.

Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.

Your function also receives a third argument, a string, with the name of the fighter that attacks first.

Example:
  declare_winner(Fighter("Lew", 10, 2), Fighter("Harry", 5, 4), "Lew") => "Lew"
  
  Lew attacks Harry; Harry now has 3 health.
  Harry attacks Lew; Lew now has 6 health.
  Lew attacks Harry; Harry now has 1 health.
  Harry attacks Lew; Lew now has 2 health.
  Lew attacks Harry: Harry now has -1 health and is dead. Lew wins.
function Fighter(name, health, damagePerAttack) {
        this.name = name;
        this.health = health;
        this.damagePerAttack = damagePerAttack;
        this.toString = function() { return this.name; }
}
*/

function declareWinner(fighter1, fighter2, firstAttacker) {
    let a = {};
    let b = {};
    let ah = 0;
    let bh = 0;
    
    if(fighter1.name === firstAttacker) {
      a = fighter1;
      b = fighter2;
    } else {
      a = fighter2;    
      b = fighter1;
    }
    
    ah = a.health;
    bh = b.health;
    
    while(ah > 0 && bh > 0) {
      bh-= a.damagePerAttack;
      if(bh <= 0) {
        return a.name;
      }
      ah-= b.damagePerAttack;
      if(ah <= 0) {
        return b.name;
      }
    }
  }