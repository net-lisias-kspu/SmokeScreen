# SmokeScreen /L Unofficial

A plugin for Kerbal Space Program that adds an improved version of the MODEL_MULTI_PARTICLE effect.

Unofficial fork by Lisias.


## Installation Instructions

To install, place the GameData folder inside your Kerbal Space Program folder. Optionally, you can also do the same for the PluginData (be careful to do not overwrite your custom settings):

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
	+ Delete `<KSP_ROOT>/GameData/SmokeScreen` if existent
	+ Delete `<KSP_ROOT>/GameData/net-lisias-ksp/SmokeScreen`
* Extract the package's `GameData` folder into your KSP's root:
	+ `<PACKAGE>/GameData` --> `<KSP_ROOT>/`
* Extract the package's `PluginData` folder (if available) into your KSP's root, taking precautions to do not overwrite your custom settings if this is not what you want to.
	+ `<PACKAGE>/PluginData` --> `<KSP_ROOT>/`
	+ You can safely ignore this step if you already had installed it previously and didn't deleted your custom configurable files.

The following file layout must be present after installation:

```
<KSP_ROOT>
	[GameData]
		[net-lisias-ksp]
			[SmokeScreen]
				CHANGE_LOG.md
				LICENSE
				NOTICE
				README.md
				...
		000_KSPe.dll
		ModuleManager.dll
		...
	[PluginData]
		[net-lisias-ksp]
			[SmokeScreen]
				...
	KSP.log
	PartDatabase.cfg
	...
```


### Dependencies

* [KSP API Extensions/L](https://github.com/net-lisias-ksp/KSPAPIExtensions)
	+ **Not Included** 
