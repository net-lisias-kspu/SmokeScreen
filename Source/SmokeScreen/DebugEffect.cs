/*
	This file is part of SmokeScreen /L Unleashed
		© 2021 Lisias T : http://lisias.net <support@lisias.net>
		© 2014-2020 Sébastien GAGGINI AKA Sarbian

	SmokeScreen /L is double licensed, as follows:

		* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
		* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

	And you are allowed to choose the License that better suit your needs.

	SmokeScreen /L Unleashed is distributed in the hope that it will be
	useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with FShangarExtender /L Unleashed.
	If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with FShangarExtender /L Unleashed.
	If not, see <https://www.gnu.org/licenses/>.

 The following is meant to satisfy the original 2 Clause BSD License:
 
 * Copyright (c) 2019, Sébastien GAGGINI AKA Sarbian, France
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 *
 * 1. Redistributions of source code must retain the above copyright notice, this
 *    list of conditions and the following disclaimer.
 *
 * 2. Redistributions in binary form must reproduce the above copyright notice,
 *    this list of conditions and the following disclaimer in the documentation
 *    and/or other materials provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 */
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

        private static readonly KSPe.Util.Log.Logger Log = KSPe.Util.Log.Logger.CreateForType<SmokeScreen.Startup>("SmokeScreen", typeof(DebugEffect).Name);
    }
}
