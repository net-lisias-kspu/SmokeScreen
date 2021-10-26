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
using UnityEngine;

namespace SmokeScreen
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    internal class SmokeScreenUI : MonoBehaviour
    {
        private readonly string icon = KSPe.IO.File<Startup>.Asset.Solve("SmokeScreen");

        private readonly IButton button;

        private bool showUI = false;

        private Rect winPos = new Rect(450, 50, 400, 100);

        private const int winID = 512099;

        private SmokeScreenUI()
        {
            if (!ToolbarManager.ToolbarAvailable)
            {
                return;
            }

            button = ToolbarManager.Instance.add("SmokeScreen", "main");
            button.TexturePath = icon;
            button.ToolTip = "SmokeScreen";
            button.OnClick += e => { showUI = !showUI; };
        }

        internal void Update()
        {
            if (GameSettings.MODIFIER_KEY.GetKey() && Input.GetKeyDown(KeyCode.P))
                showUI = !showUI;
        }

        private void OnDestroy()
        {
            if (button != null)
            {
                button.Destroy();
            }
        }

        private void OnGUI()
        {
            if (showUI)
            {
                winPos = GUILayout.Window(winID, winPos, windowGUI, "SmokeScreen", GUILayout.MinWidth(300));
            }
        }

        private void windowGUI(int ID)
        {
            GUILayout.BeginVertical();

            SmokeScreenConfig.Instance.globalCollideDisable =
                GUILayout.Toggle(SmokeScreenConfig.Instance.globalCollideDisable, "Globally disable Collide");
            SmokeScreenConfig.Instance.globalPhysicalDisable =
                GUILayout.Toggle(SmokeScreenConfig.Instance.globalPhysicalDisable, "Globally disable Physical");

            SmokeScreenConfig.Instance.forceEmitOnUpdate =
                GUILayout.Toggle(SmokeScreenConfig.Instance.forceEmitOnUpdate, "Globally force emitOnUpdate");

            SmokeScreenConfig.Instance.forceDecluster =
                GUILayout.Toggle(SmokeScreenConfig.Instance.forceDecluster, "Globally force decluster");

            SmokeScreenConfig.Instance.shareManualInput =
                GUILayout.Toggle(SmokeScreenConfig.Instance.shareManualInput, "Share manual input values across effects");

            GUILayout.Space(10);

            GUILayout.BeginHorizontal();
            GUILayout.Label("maximumActiveParticles", GUILayout.ExpandWidth(true));
            int.TryParse(
                GUILayout.TextField(
                    SmokeScreenConfig.Instance.maximumActiveParticles.ToString(),
                    GUILayout.ExpandWidth(true),
                    GUILayout.Width(100)),
                out SmokeScreenConfig.Instance.maximumActiveParticles);
            GUILayout.EndHorizontal();

            // 'SmokeScreenConfig.activeParticles' isn't accurate anymore
            int activeParticles = 0;
            ModelMultiShurikenPersistFX.List.ForEach (x => activeParticles += x.CurrentlyActiveParticles);
            GUILayout.Label ($"Active particles: {activeParticles}");

            GUILayout.Space(10);

            GUILayout.Label("Open ModelMultiShurikenPersistFX UI :");
            
            foreach (var mmFX in ModelMultiShurikenPersistFX.List)
            {
                if (mmFX.hostPart != null)
                {
                    // Changed to string interpolation, and added current particle count alongside max particle count per plume
                    mmFX.showUI = GUILayout.Toggle(
                        mmFX.showUI,
                        $"{mmFX.hostPart.name}: {mmFX.effectName}, {mmFX.instanceName}: {mmFX.CurrentlyActiveParticles} ({mmFX.MaxActiveParticles} max)"
                    );
                }
            }

            GUILayout.EndVertical();

            GUI.DragWindow();
        }
    }
}