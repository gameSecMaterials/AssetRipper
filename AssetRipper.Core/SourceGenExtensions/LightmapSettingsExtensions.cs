﻿using AssetRipper.SourceGenerated.Classes.ClassID_157;
using GIWorkflowMode = AssetRipper.SourceGenerated.Enums.GIWorkflowMode_0;

namespace AssetRipper.Core.SourceGenExtensions
{
	public static class LightmapSettingsExtensions
	{
		public static void ConvertToEditorFormat(this ILightmapSettings settings)
		{
			settings.GIWorkflowMode_C157 = (int)GIWorkflowMode.OnDemand;
			settings.LightmapEditorSettings_C157.SetToDefault();
		}

		public static GIWorkflowMode GetGIWorkflowMode(this ILightmapSettings settings)
		{
			return (GIWorkflowMode)settings.GIWorkflowMode_C157;
		}
	}
}
