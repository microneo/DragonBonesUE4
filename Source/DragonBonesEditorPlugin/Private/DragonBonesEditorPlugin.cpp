#include "DragonBonesEditorPluginPrivatePCH.h"

class FDragonBonesEditorPlugin: public IDragonBonesEditorPlugin {
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};

IMPLEMENT_MODULE(FDragonBonesEditorPlugin, IDragonBonesEditorPlugin)



void FDragonBonesEditorPlugin::StartupModule () { }

void FDragonBonesEditorPlugin::ShutdownModule () { }



