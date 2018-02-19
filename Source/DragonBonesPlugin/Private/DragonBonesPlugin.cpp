#include "DragonBonesPluginPrivatePCH.h"

class FDragonBonesPlugin : public DragonBonesPlugin {
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};

IMPLEMENT_MODULE( FDragonBonesPlugin, DragonBonesPlugin )

void FDragonBonesPlugin::StartupModule() { }


void FDragonBonesPlugin::ShutdownModule() { }



