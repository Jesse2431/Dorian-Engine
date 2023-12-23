using Microsoft.Xna.Framework;
using System.Security.Cryptography.X509Certificates;

namespace DorianEngine.Core
{
    // TODO: Possibly implement Driver-based mood files.
    //       Perhaps even use their format?

    public class Lighting
    {
        // Sun related values, float's are 0-1. SunScale is size of sun
        public Vector3 SunPosition;
        public Vector3 SunColor;
        public float SunScale;
        public float SunBrightness;

        // Image lens flare, simple yes or no
        public bool LensFlareEnabled;

        // Sun and ambient related values, AmbientBrightness is 0-1 scale
        public Vector3 AmbientColor;
        public float AmbientBrightness;

        // Shadow related values, intensity is 0-1 scale
        public Vector3 ShadowColor;
        public float ShadowIntensity;

        // Fog related variables, pretty self explanatory
        public bool FogEnabled;
        public Vector3 FogColor;
        public float FogNearDistance;
        public float FogFarDistance;

        // Time related variables, TimeOfDay is stored in HHMM format
        public float TimeOfDay;
        public bool DayNightCycleEnabled;

        // Make a new Lighting with default values
        public Lighting()
        {
            SunPosition = new Vector3(225, 225, 225);
            SunBrightness = 0.95f;

            LensFlareEnabled = false;

            AmbientColor = new Vector3(220, 220, 220);
            SunColor = new Vector3(255, 232, 93);

            ShadowColor = new Vector3(0, 0, 0);
            ShadowIntensity = 0.25f;

            FogEnabled = false;
            FogColor = new Vector3(255, 255, 255);
            FogNearDistance = 25;
            FogFarDistance = 100;

            TimeOfDay = 1400;
            DayNightCycleEnabled = false;
        }
    }
}
