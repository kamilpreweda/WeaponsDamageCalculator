using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WeaponsDamageCalculator;

namespace SwordDamageHermeticPrototype
{
    public class SwordDamageHermetic : WeaponDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        /// <summary>
        /// Konstruktor oblicza obrażenia na podstawie domyślnych wartości właściwości
        /// Magic i Flaming oraz początkowego rzutu 3d6.
        /// </summary>
        /// <param name="startingRoll">Początkowy rzut 3d6</param>
       public SwordDamageHermetic(int startingRoll) : base(startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();            
        }
        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
            Debug.WriteLine($"Po wykonaniu CalculateDamage: {Damage} (rzut: {Roll})");
        }

        

        

    }
}
