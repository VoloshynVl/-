using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace RPGCharacterPrototype
{
    // Перелічення для класу персонажа


    public enum CharacterClass
    {
        Warrior,
        Mage,
        Archer,
        Priest,
        Rogue
    }

    // Перелічення для типу зброї
    public enum WeaponType
    {
        Sword,
        Staff,
        Bow,
        Wand,
        Dagger,
        Axe,
        Mace
    }

    // Перелічення для типу броні
    public enum ArmorType
    {
        Light,
        Medium,
        Heavy,
        Cloth,
        Leather,
        Plate
    }

    // Клас для здібності персонажа
    [Serializable]
    public class Ability
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ManaCost { get; set; }
        public int Cooldown { get; set; }

        public Ability() { }

        public Ability(string name, string description, int manaCost, int cooldown)
        {
            Name = name;
            Description = description;
            ManaCost = manaCost;
            Cooldown = cooldown;
        }

        // Метод для клонування здібності
        public Ability Clone()
        {
            return new Ability(Name, Description, ManaCost, Cooldown);
        }

        public override string ToString()
        {
            return Name;
        }
    }

    // Головний клас персонажа, що реалізує інтерфейс ICloneable
    [Serializable]
    public class Character : ICloneable
    {
        // Базові характеристики
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public List<Ability> Abilities { get; set; }

        // Специфічні властивості
        public WeaponType Weapon { get; set; }
        public CharacterClass Class { get; set; }
        public ArmorType Armor { get; set; }

        // Конструктор за замовчуванням (необхідний для серіалізації)
        public Character()
        {
            Abilities = new List<Ability>();
        }

        // Повний конструктор
        public Character(string name, int level, int health, int mana,
                        WeaponType weapon, CharacterClass characterClass, ArmorType armor)
        {
            Name = name;
            Level = level;
            Health = health;
            Mana = mana;
            Abilities = new List<Ability>();
            Weapon = weapon;
            Class = characterClass;
            Armor = armor;
        }

        // Метод для додавання здібності
        public void AddAbility(Ability ability)
        {
            Abilities.Add(ability);
        }

        // Метод для видалення здібності
        public void RemoveAbility(Ability ability)
        {
            Abilities.Remove(ability);
        }

        // Реалізація методу Clone з інтерфейсу ICloneable
        public object Clone()
        {
            // Створюємо нову копію персонажа
            Character clone = new Character
            {
                Name = this.Name + " (Clone)",
                Level = this.Level,
                Health = this.Health,
                Mana = this.Mana,
                Weapon = this.Weapon,
                Class = this.Class,
                Armor = this.Armor,
                Abilities = new List<Ability>()
            };

            // Клонуємо всі здібності
            foreach (var ability in this.Abilities)
            {
                clone.Abilities.Add(ability.Clone());
            }

            return clone;
        }

        // Перевизначаємо метод ToString для кращого відображення персонажа у списку
        public override string ToString()
        {
            return $"{Name} - Lvl.{Level} {Class} ({Weapon}, {Armor})";
        }
    }
}