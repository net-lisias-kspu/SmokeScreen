# SmokeScreen :: Change Log

* 2021-0413: 2.8.14.2 (LisiasT) for KSP >= 1.4
	+ Making the thing compatible downto KSP 1.4
	+ Adding KSPe facilities:
		- Logging
		- File System
	+ Moving the whole shebang into `net.lisias.ksp` file system hierarchy.
		- User serviceable configuration files moved to `<KSP_ROOT>/PluginData` 
* 2021-0407: 2.8.14.1 (LisiasT) for KSP >= 1.4
	+ ***DITCHED*** due wrongly compilation against a beta release of KSPe.
* 2020-0418: 2.8.14 (sarbian) for KSP >= 1.8
	+ Add partTransform support and manual input sharing
* 2020-0213: 2.8.13 (sarbian) for KSP >= 1.8
	+ Fix effect using multiple MODEL_MULTI_SHURIKEN_PERSIST in their configs
* 2020-0210: 2.8.12 (sarbian) for KSP [1.4 <= KSP < 1.8]
	+ Comment typo and spare space
	+ 2.8.11 - Potential for for raidernick scale troubles
	+ Fix the NRE / Effect not working on config that uses the same name
	+ multiple time
* 2019-1221: 2.8.9 (sarbian) for [1.4 <= KSP < 1.8]
	+ No changelog provided
* 2019-1221: 2.8.8 (sarbian) for [1.4 <= KSP < 1.8]
	+ Fix the root part effect and remove the backup node hack
* 2019-1221: 2.8.7.0 (sarbian) for [1.4 <= KSP < 1.8]
	+ No changelog provided
* 2019-0925: 2.8.6 (sarbian) for [1.4 <= KSP < 1.8]
	+ Decluster now adds size & removes lifetime from new particles
	+ Allow particle animation while in High Warp
* 2019-0724: 2.8.5 (sarbian) for [1.4 <= KSP < 1.8]
	+ No changelog provided
* 2019-0723: 2.8.4 (sarbian) for [1.4 <= KSP < 1.8]
	+ Just say no to Linq. And say yes to null check
	+ UpdateParticlesCount order and once per frame
	+ Krakensbane scale mandate the use of a double
	+ 31 - Add saturationMult, brightnessMult and alphaMult curves
* 2019-0712: 2.8.3 (sarbian) for [1.4 <= KSP < 1.8]
	+ Fix for #35
	+ UI to force emitOnUpdate and decluster
	+ Handle emitOnUpdate for detached emitter
* 2019-0707: 2.8.2.0 (sarbian) for [1.4 <= KSP < 1.8]
	+ No changelog provided
* 2018-1103: 2.8.1 (sarbian) for [1.4 <= KSP < 1.8]
	+ No changelog provided
* 2018-0310: 2.8.0 (sarbian) for [1.4 <= KSP < 1.8]
	+ Goodbye old emitter
	+ More old code cleanup
	+ Update for KSP 1.4 use of Shuriken
	+ Add support for single transform fx
* 2018-0129: 2.7.6.1 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2018-0128: 2.7.6 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2017-0703: 2.7.5 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2017-0310: 2.7.4 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2017-0310: 2.7.3.0 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2017-0207: 2.7.2 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2017-0121: 2.7.1 (sarbian) for KSP 0.7.3
	+ Fix Effect init related to a vicious API change in Stock made by a
	+ stupid dev (smack myself on head). Fix KSP-RO/RealismOverhaul#1492
	+ Fix the Animation Color for converted Shiruken particle system
* 2016-1218: 2.7.0 (sarbian) for KSP 0.7.3
	+ Lets go to the future
	+ 6 != 7
* 2016-1120: 2.6.21 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2016-1119: 2.6.20 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2016-1024: 2.6.19.0 (sarbian) for KSP 0.7.3
	+ Update the ToolbarWrapper to the last version
* 2016-1015: 2.6.18 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2016-0724: 2.6.17 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2016-0409: 2.6.15 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2016-0405: 2.6.14 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2016-0215: 2.6.13 (sarbian) for KSP 0.7.3
	+ Fix smoke running away from vehicle when Krakensbane activates
* 2016-0201: 2.6.12.0 (sarbian) for KSP 0.7.3
	+ 2.6.12 - Fix the NRE spam when adding a digit in the live editor
* 2016-0131: 2.6.11.0 (sarbian) for KSP 0.7.3
	+ 2.6.11 - Open the UI with Mod+P
* 2015-1222: 2.6.10 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2015-1027: 2.6.9.0 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2015-0816: 2.6.8 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2015-0707: 2.6.5 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2015-0630: 2.6.4 (sarbian) for KSP 0.7.3
	+ New sizeClamp Curve that adds itself to the sizeClamp value
* 2015-0721: 2.6.3.0 (sarbian) for KSP 0.7.3
	+ Fix an NRE spam when an active engine go out of physic range
	+ V2.6.7
* 2015-0603: 2.6.2 (sarbian) for KSP 0.7.3
	+ Don't set the rendermode each frame
	+ Add curves for lengthScale and velocityScale
	+ Use the 1.0 provided values
* 2015-0526: 2.6.1 (sarbian) for KSP 0.7.3
	+ Fix the singleEmitTimer and add workaround for the stock effect init
	+ problem
	+ Add a logging effect to debug
* 2015-0428: 2.6.0 (sarbian) for KSP 0.7.3
	+ No changelog provided
* 2014-1215: 2.4.2.0 (sarbian) for KSP 0.7.3
	+ 2.5.3 : rebuild for 0.90
* 2014-0810: 0.9.0.0 (sarbian) for KSP 0.7.3
	+ added alpha, linAlphaDecay and logAlphaDecay options.
	+ Changed the code to use colorAnimation, now it actually works.
	+ Now applying changes when just the base Alpha is changed as well.
	+ 2.4.2
