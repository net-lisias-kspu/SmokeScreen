using System;

namespace SmokeScreen
{
    [EffectDefinition("DEBUG_EFFECT")]
    class DebugEffect : EffectBehaviour
    {
        public override void OnEvent()
        {
            Log.info(effectName.PadRight(16) + "OnEvent single -------------------------------------------------------");
        }

        private float lastPower = -1;

        public override void OnEvent(float power)
        {
            if (Math.Abs(lastPower - power) > 0.01f)
            {
                lastPower = power;
                Log.info(effectName.PadRight(16)  + " " + instanceName + "OnEvent pow = " + power.ToString("F2"));
            }
        }

        public override void OnInitialize()
        {
            Log.info("OnInitialize");
        }

        public override void OnLoad(ConfigNode node)
        {
            Log.info("OnLoad");
        }

        public override void OnSave(ConfigNode node)
        {
            Log.info("OnSave");
        }

        private static readonly KSPe.Util.Log.Logger Log = KSPe.Util.Log.Logger.CreateForType<DebugEffect>("SmokeScreen", true);
    }
}
