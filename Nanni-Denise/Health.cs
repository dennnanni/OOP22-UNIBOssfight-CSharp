using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanni_Denise
{
    /// <summary>
    /// This class implements the Health.
    /// </summary>
    public class Health : IHealth
    {
        private const int DefaultHp = 100;

        /// <summary>
        /// Property to get and set the health value.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Property to get the max health value.
        /// </summary>
        public int MaxValue { get; private set; }

        /// <summary>
        /// Creates a new instance of the class Health.
        /// </summary>
        public Health() : this(DefaultHp) { }

        /// <summary>
        /// Creates a new instance of the class Health given a initial healh value.
        /// </summary>
        /// <param name="value">initial health points</param>
        public Health(int value)
        {
            Value = value;
            MaxValue = value;
        }

        ///
        /// <inheritdoc/>
        /// 
        public void Damage(int damage) => Value -= damage;

        ///
        /// <inheritdoc/>
        /// 
        public void Destroy() => Value = 0;

        ///
        /// <inheritdoc/>
        /// 
        public bool IsDead() => Value <= 0;
    }
}
