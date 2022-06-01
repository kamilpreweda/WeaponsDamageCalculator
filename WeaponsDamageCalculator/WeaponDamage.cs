using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsDamageCalculator
{
    public abstract class WeaponDamage
    {
        public int roll;
        public bool flaming;
        public bool magic;

        /// <summary>
        /// Zawiera obliczone obrażenia.
        /// </summar
        public int Damage { get; protected set; }

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
        /// Oblicza obrażenia na podstawie aktualnych wartości właściwości.
        /// </summary>
        protected abstract void CalculateDamage();
       

        /// <summary>
        /// Konstruktor oblicza obrażenia na podstawie domyślnych wartości właściwości
        /// Magic i Flaming oraz początkowego rzutu 3d6.
        /// </summary>
        /// <param name="startingRoll">Początkowy rzut 3d6</param>
        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
    }
}
