#pragma once

#include "ModuleManager.h"

class DragonBonesPLUGIN_API DragonBonesPlugin : public IModuleInterface {

public:
	
	static inline DragonBonesPlugin& Get() {
		return FModuleManager::LoadModuleChecked< DragonBonesPlugin >( "DragonBonesPlugin" );
	}
	
	static inline bool IsAvailable() {
		return FModuleManager::Get().IsModuleLoaded( "DragonBonesPlugin" );
	}
};

