using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwordDamageHermeticPrototype;

namespace WeaponsDamageCalculator
{
    public class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        private int roll;
        private bool flaming;
        private bool magic;

        /// <summary>
        /// Konstruktor oblicza obrażenia na podstawie domyślnych wartości właściwości
        /// Magic i Flaming oraz początkowego rzutu 3d6.
        /// </summary>
        /// <param name="startingRoll">Początkowy rzut 3d6</param>
        public ArrowDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

        /// <summary>
        /// Ustawia lub pobiera wartość rzutu 3d6.
        /// </summary>
        public int Roll { get { return roll; } set { roll = value; CalculateDamage(); } }

        /// <summary>
        /// Zwraca true, jeśli miecz jest płonący, w przeciwnym razie zwraca false.
        /// </summary>
        public bool Flaming { get { return flaming; } set { flaming = value; CalculateDamage(); } }

        /// <summary>
        /// Zwraca true, jeśli miecz jest magiczny, w przeciwnym razie zwraca false.
        /// </summary>
        public bool Magic { get { return magic; } set { magic = value; CalculateDamage(); } }

        /// <summary>
        /// Zawiera obliczone obrażenia.
        /// </summary>
        public int Damage { get; private set; }

        /// <summary>
        /// Oblicza obrażenia na podstawie aktualnych wartości właściwości.
        /// </summary>
        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
            
        }





    }

}
