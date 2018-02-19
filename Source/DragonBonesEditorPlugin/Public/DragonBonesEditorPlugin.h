#pragma once

#include "ModuleManager.h"

class IDragonBonesEditorPlugin : public IModuleInterface {

public:
	static inline IDragonBonesEditorPlugin& Get() {
		return FModuleManager::LoadModuleChecked< IDragonBonesEditorPlugin >( "DragonBonesEditorPlugin" );
	}

	static inline bool IsAvailable() {
		return FModuleManager::Get().IsModuleLoaded( "DragonBonesEditorPlugin" );
	}
};

