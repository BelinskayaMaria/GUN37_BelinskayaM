using System;

namespace RPGGame
{
    // Класс Unit для RPG игры
    public class Unit
    {
        // Поле для здоровья (приватное)
        private float health;

        // Свойство для имени (только для чтения)
        public string Name { get; }

        // Свойство для здоровья (только для чтения)
        public float Health
        {
            get { return health; }
        }

        // Свойство урона (только для чтения)
        public int Damage { get; }

        // Свойство брони (только для чтения)
        public float Armor { get; }

        // Конструктор без аргументов
        public Unit() : this("Unknown Unit")
        {
            // Вызов другого конструктора
        }

        // Конструктор с аргументом (имя)
        public Unit(string name)
        {
            Name = name;
            health = 100f;    // Начальное здоровье
            Damage = 5;        // Урон по умолчанию
            Armor = 0.6f;      // Броня по умолчанию
        }

        // Метод для расчета реального здоровья
        public float GetRealHealth()
        {
            return health * (1f + Armor);
        }

        // Метод получения урона
        public bool SetDamage(float value)
        {
            health -= value * Armor;

            // Проверка, мертв ли юнит
            if (health <= 0f)
            {
                health = 0f;
                return true; // Юнит погиб
            }
            else
            {
                return false; // Юнит жив
            }
        }
    }
}