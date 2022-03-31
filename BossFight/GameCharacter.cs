using System;
using System.Data;
using System.Reflection;

namespace BossFight
{
    public class GameCharacter
    {
        public string _name;
        public int _health;
        public int _maxStrength;
        public int _minStrength;
        public int _stamina;
        public int _maxStamina;

        private Random _random = new Random();


        public GameCharacter() : this("???", 50, 10, 10)
        {
        }

        public GameCharacter(string name, int health, int strength, int stamina) :
            this(name, health, strength, strength, stamina)
        {
        }

        public GameCharacter(string name, int health, int minStrength, int maxStrength, int stamina)
        {
            _name = name;
            _health = health;
            _minStrength = minStrength;
            _maxStrength = maxStrength;
            _stamina = stamina;
            _maxStamina = stamina;

            Console.WriteLine($"{_name} has {_health} health, {_minStrength} minimum strength, {_maxStrength} maximum strength, and {_stamina} stamina");
        }

        public void Fight(GameCharacter target)
        {
            if (_health <= 0) return;
            int damage = _random.Next(_minStrength, _maxStrength + 1);

            if (_stamina <= 0)
            {
                Recharge();
            }
            else
            {
                target.TakeDamage(damage);
                _stamina -= 10;
            }
            Console.WriteLine($"{_name} hit {target._name} with {damage} damage, {target._name} now has {target._health} health left");
        }

        public void Recharge()
        {
            _stamina = _maxStamina;
            Console.WriteLine($"{_name} took a rest.");
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
        }
    }
}