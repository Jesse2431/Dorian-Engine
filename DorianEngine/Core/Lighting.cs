using Microsoft.Xna.Framework;
using System.Security.Cryptography.X509Certificates;

namespace DorianEngine.Core
{
    public class Lighting
    {
        // TODO: Possibly implement Driver-based mood files.
        //       Perhaps even use their format?

        // Sun related values, float's are 0-1. SunScale is size of sun
        public Vector3 SunPosition = new Vector3(225, 225, 225);
        public Vector3 SunColor = new Vector3(255, 232, 93);
        public float SunScale = 0.25f;
        public float SunBrightness = 0.95f;

        // Image lens flare, simple yes or no
        public bool LensFlareEnabled = true;

        // Sun and ambient related values, AmbientBrightness is 0-1 scale
        public Vector3 AmbientColor = new Vector3(220, 220, 220);
        public float AmbientBrightness = 1.0f;

        // Shadow related values, intensity is 0-1 scale
        public Vector3 ShadowColor = new Vector3(0, 0, 0);
        public float ShadowIntensity = 0.25f;

        // Fog related variables, pretty self explanatory
        public bool FogEnabled = false;
        public Vector3 FogColor = new Vector3(255, 255, 255);
        public float FogNearDistance = 25;
        public float FogFarDistance = 75;

        // Time related variables, TimeOfDay is stored in HHMM format, DayNightCycleSpeed is in how many irl minutes it takes for 1 ingame minute to pass
        public float TimeOfDay = 1400;
        public bool DayNightCycleEnabled = false;
        public float DayNightCycleSpeed = 1f;

        // Resets all values back to their standard
        public void Reset()
        {
            SunPosition = new Vector3(225, 225, 225);
            SunColor = new Vector3(255, 232, 93);
            SunScale = 0.25f;
            SunBrightness = 0.95f;

            LensFlareEnabled = true;

            AmbientColor = new Vector3(220, 220, 220);
            AmbientBrightness = 1.0f;

            ShadowColor = new Vector3(0, 0, 0);
            ShadowIntensity = 0.25f;

            FogEnabled = false;
            FogColor = new Vector3(255, 255, 255);;
            FogNearDistance = 25;
            FogFarDistance = 75;

            TimeOfDay = 1400;
            DayNightCycleEnabled = false;
            DayNightCycleSpeed = 1f;
        }

        public string LightingInfo()
        {
            string lightingInfo = "SUN SETTINGS \n" +
                                  " - Sun position: " + "X: " + SunPosition.X + "Y: " + SunPosition.Y + "Z: " + SunPosition.Y + "\n" +
                                  " - Sun color: " + "R: " + SunColor.X + "G: " + SunColor.Y + "B: " + SunColor.Y + "\n" +
                                  " - Sun scale: " + SunScale.ToString() + "\n" +
                                  " - Sun brightness: " + SunBrightness.ToString() + "\n" +
                                  "\n" +
                                  "LENS FLARE SETTINGS \n" +
                                  " - Lens Flare Enabled: " + LensFlareEnabled.ToString() + "\n" +
                                  "\n" +
                                  "AMBIENT SETTINGS \n" +
                                  " - Ambient color: " + "R: " + AmbientColor.X + "G: " + AmbientColor.Y + "B: " + AmbientColor.Y + "\n" +
                                  " - Ambient brightness: " + AmbientBrightness.ToString() + "\n" +
                                  "\n" +
                                  "SHADOW SETTINGS \n" +
                                  " - Shadow color: " + "R: " + ShadowColor.X + "G: " + ShadowColor.Y + "B: " + ShadowColor.Y + "\n" +
                                  " - Shadow intensity: " + ShadowIntensity.ToString() + "\n" +
                                  "\n" +
                                  "FOG SETTINGS \n" +
                                  " - Fog enabled" + FogEnabled.ToString() + "\n" +
                                  " - Fog color: " + "R: " + FogColor.X + "G: " + FogColor.Y + "B: " + FogColor.Y + "\n" +
                                  " - Fog near distance: " + FogNearDistance.ToString() + "\n" +
                                  " - Fog far distance: " + FogFarDistance.ToString() + "\n" +
                                  "\n" +
                                  "TIME SETTINGS \n" +
                                  " - Time of day: " + TimeOfDay.ToString() + "\n" +
                                  " - Day-night cycle enabled" + DayNightCycleEnabled.ToString() + "\n" +
                                  " - Day-night speed" + DayNightCycleSpeed.ToString();

            return lightingInfo;
        }
    }
}
