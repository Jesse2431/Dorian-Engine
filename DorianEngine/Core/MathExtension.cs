using System;

namespace DorianEngine.Core
{
    public static class MathExtension
    {
        // TODO: Implement math extensions

        /// <summary>
        /// Returns given value to radians
        /// </summary>
        /// <param name="degreesInput"></param>
        /// <returns>Degrees to be converted to radians</returns>
        public static float ToRadians(float degreesInput)
        {
            return degreesInput * (((float)Math.PI) / 180);
        }
    }
}