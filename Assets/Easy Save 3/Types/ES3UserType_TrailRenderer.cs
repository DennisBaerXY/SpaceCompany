using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("time", "startWidth", "endWidth", "widthMultiplier", "autodestruct", "emitting", "numCornerVertices", "numCapVertices", "minVertexDistance", "startColor", "endColor", "shadowBias", "generateLightingData", "textureMode", "alignment", "widthCurve", "colorGradient", "enabled", "shadowCastingMode", "receiveShadows", "forceRenderingOff", "motionVectorGenerationMode", "lightProbeUsage", "reflectionProbeUsage", "renderingLayerMask", "rendererPriority", "rayTracingMode", "sortingLayerName", "sortingLayerID", "sortingOrder", "sortingGroupID", "sortingGroupOrder", "allowOcclusionWhenDynamic", "staticBatchRootTransform", "lightProbeProxyVolumeOverride", "probeAnchor", "lightmapIndex", "realtimeLightmapIndex", "lightmapScaleOffset", "realtimeLightmapScaleOffset", "materials", "material", "sharedMaterial", "sharedMaterials", "name")]
	public class ES3UserType_TrailRenderer : ES3ComponentType
	{
		public static ES3Type Instance = null;

		public ES3UserType_TrailRenderer() : base(typeof(UnityEngine.TrailRenderer)){ Instance = this; priority = 1;}


		protected override void WriteComponent(object obj, ES3Writer writer)
		{
			var instance = (UnityEngine.TrailRenderer)obj;
			
			writer.WriteProperty("time", instance.time, ES3Type_float.Instance);
			writer.WriteProperty("startWidth", instance.startWidth, ES3Type_float.Instance);
			writer.WriteProperty("endWidth", instance.endWidth, ES3Type_float.Instance);
			writer.WriteProperty("widthMultiplier", instance.widthMultiplier, ES3Type_float.Instance);
			writer.WriteProperty("autodestruct", instance.autodestruct, ES3Type_bool.Instance);
			writer.WriteProperty("emitting", instance.emitting, ES3Type_bool.Instance);
			writer.WriteProperty("numCornerVertices", instance.numCornerVertices, ES3Type_int.Instance);
			writer.WriteProperty("numCapVertices", instance.numCapVertices, ES3Type_int.Instance);
			writer.WriteProperty("minVertexDistance", instance.minVertexDistance, ES3Type_float.Instance);
			writer.WriteProperty("startColor", instance.startColor, ES3Type_Color.Instance);
			writer.WriteProperty("endColor", instance.endColor, ES3Type_Color.Instance);
			writer.WriteProperty("shadowBias", instance.shadowBias, ES3Type_float.Instance);
			writer.WriteProperty("generateLightingData", instance.generateLightingData, ES3Type_bool.Instance);
			writer.WriteProperty("textureMode", instance.textureMode, ES3Type_enum.Instance);
			writer.WriteProperty("alignment", instance.alignment, ES3Type_enum.Instance);
			writer.WriteProperty("widthCurve", instance.widthCurve, ES3Type_AnimationCurve.Instance);
			writer.WriteProperty("colorGradient", instance.colorGradient, ES3Type_Gradient.Instance);
			writer.WriteProperty("enabled", instance.enabled, ES3Type_bool.Instance);
			writer.WriteProperty("shadowCastingMode", instance.shadowCastingMode, ES3Type_enum.Instance);
			writer.WriteProperty("receiveShadows", instance.receiveShadows, ES3Type_bool.Instance);
			writer.WriteProperty("forceRenderingOff", instance.forceRenderingOff, ES3Type_bool.Instance);
			writer.WriteProperty("motionVectorGenerationMode", instance.motionVectorGenerationMode, ES3Type_enum.Instance);
			writer.WriteProperty("lightProbeUsage", instance.lightProbeUsage, ES3Type_enum.Instance);
			writer.WriteProperty("reflectionProbeUsage", instance.reflectionProbeUsage, ES3Type_enum.Instance);
			writer.WriteProperty("renderingLayerMask", instance.renderingLayerMask, ES3Type_uint.Instance);
			writer.WriteProperty("rendererPriority", instance.rendererPriority, ES3Type_int.Instance);
			writer.WriteProperty("rayTracingMode", instance.rayTracingMode, ES3Type_enum.Instance);
			writer.WriteProperty("sortingLayerName", instance.sortingLayerName, ES3Type_string.Instance);
			writer.WriteProperty("sortingLayerID", instance.sortingLayerID, ES3Type_int.Instance);
			writer.WriteProperty("sortingOrder", instance.sortingOrder, ES3Type_int.Instance);
			writer.WritePrivateProperty("sortingGroupID", instance);
			writer.WritePrivateProperty("sortingGroupOrder", instance);
			writer.WriteProperty("allowOcclusionWhenDynamic", instance.allowOcclusionWhenDynamic, ES3Type_bool.Instance);
			writer.WritePrivatePropertyByRef("staticBatchRootTransform", instance);
			writer.WritePropertyByRef("lightProbeProxyVolumeOverride", instance.lightProbeProxyVolumeOverride);
			writer.WritePropertyByRef("probeAnchor", instance.probeAnchor);
			writer.WriteProperty("lightmapIndex", instance.lightmapIndex, ES3Type_int.Instance);
			writer.WriteProperty("realtimeLightmapIndex", instance.realtimeLightmapIndex, ES3Type_int.Instance);
			writer.WriteProperty("lightmapScaleOffset", instance.lightmapScaleOffset, ES3Type_Vector4.Instance);
			writer.WriteProperty("realtimeLightmapScaleOffset", instance.realtimeLightmapScaleOffset, ES3Type_Vector4.Instance);
			writer.WriteProperty("materials", instance.materials, ES3Type_MaterialArray.Instance);
			writer.WritePropertyByRef("material", instance.material);
			writer.WritePropertyByRef("sharedMaterial", instance.sharedMaterial);
			writer.WriteProperty("sharedMaterials", instance.sharedMaterials, ES3Type_MaterialArray.Instance);
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
			var instance = (UnityEngine.TrailRenderer)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "time":
						instance.time = reader.Read<System.Single>(ES3Type_float.Instance);
						break;
					case "startWidth":
						instance.startWidth = reader.Read<System.Single>(ES3Type_float.Instance);
						break;
					case "endWidth":
						instance.endWidth = reader.Read<System.Single>(ES3Type_float.Instance);
						break;
					case "widthMultiplier":
						instance.widthMultiplier = reader.Read<System.Single>(ES3Type_float.Instance);
						break;
					case "autodestruct":
						instance.autodestruct = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "emitting":
						instance.emitting = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "numCornerVertices":
						instance.numCornerVertices = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "numCapVertices":
						instance.numCapVertices = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "minVertexDistance":
						instance.minVertexDistance = reader.Read<System.Single>(ES3Type_float.Instance);
						break;
					case "startColor":
						instance.startColor = reader.Read<UnityEngine.Color>(ES3Type_Color.Instance);
						break;
					case "endColor":
						instance.endColor = reader.Read<UnityEngine.Color>(ES3Type_Color.Instance);
						break;
					case "shadowBias":
						instance.shadowBias = reader.Read<System.Single>(ES3Type_float.Instance);
						break;
					case "generateLightingData":
						instance.generateLightingData = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "textureMode":
						instance.textureMode = reader.Read<UnityEngine.LineTextureMode>(ES3Type_enum.Instance);
						break;
					case "alignment":
						instance.alignment = reader.Read<UnityEngine.LineAlignment>(ES3Type_enum.Instance);
						break;
					case "widthCurve":
						instance.widthCurve = reader.Read<UnityEngine.AnimationCurve>(ES3Type_AnimationCurve.Instance);
						break;
					case "colorGradient":
						instance.colorGradient = reader.Read<UnityEngine.Gradient>(ES3Type_Gradient.Instance);
						break;
					case "enabled":
						instance.enabled = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "shadowCastingMode":
						instance.shadowCastingMode = reader.Read<UnityEngine.Rendering.ShadowCastingMode>(ES3Type_enum.Instance);
						break;
					case "receiveShadows":
						instance.receiveShadows = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "forceRenderingOff":
						instance.forceRenderingOff = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "motionVectorGenerationMode":
						instance.motionVectorGenerationMode = reader.Read<UnityEngine.MotionVectorGenerationMode>(ES3Type_enum.Instance);
						break;
					case "lightProbeUsage":
						instance.lightProbeUsage = reader.Read<UnityEngine.Rendering.LightProbeUsage>(ES3Type_enum.Instance);
						break;
					case "reflectionProbeUsage":
						instance.reflectionProbeUsage = reader.Read<UnityEngine.Rendering.ReflectionProbeUsage>(ES3Type_enum.Instance);
						break;
					case "renderingLayerMask":
						instance.renderingLayerMask = reader.Read<System.UInt32>(ES3Type_uint.Instance);
						break;
					case "rendererPriority":
						instance.rendererPriority = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "rayTracingMode":
						instance.rayTracingMode = reader.Read<UnityEngine.Experimental.Rendering.RayTracingMode>(ES3Type_enum.Instance);
						break;
					case "sortingLayerName":
						instance.sortingLayerName = reader.Read<System.String>(ES3Type_string.Instance);
						break;
					case "sortingLayerID":
						instance.sortingLayerID = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "sortingOrder":
						instance.sortingOrder = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "sortingGroupID":
					reader.SetPrivateProperty("sortingGroupID", reader.Read<System.Int32>(), instance);
					break;
					case "sortingGroupOrder":
					reader.SetPrivateProperty("sortingGroupOrder", reader.Read<System.Int32>(), instance);
					break;
					case "allowOcclusionWhenDynamic":
						instance.allowOcclusionWhenDynamic = reader.Read<System.Boolean>(ES3Type_bool.Instance);
						break;
					case "staticBatchRootTransform":
					reader.SetPrivateProperty("staticBatchRootTransform", reader.Read<UnityEngine.Transform>(), instance);
					break;
					case "lightProbeProxyVolumeOverride":
						instance.lightProbeProxyVolumeOverride = reader.Read<UnityEngine.GameObject>(ES3Type_GameObject.Instance);
						break;
					case "probeAnchor":
						instance.probeAnchor = reader.Read<UnityEngine.Transform>(ES3UserType_Transform.Instance);
						break;
					case "lightmapIndex":
						instance.lightmapIndex = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "realtimeLightmapIndex":
						instance.realtimeLightmapIndex = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					case "lightmapScaleOffset":
						instance.lightmapScaleOffset = reader.Read<UnityEngine.Vector4>(ES3Type_Vector4.Instance);
						break;
					case "realtimeLightmapScaleOffset":
						instance.realtimeLightmapScaleOffset = reader.Read<UnityEngine.Vector4>(ES3Type_Vector4.Instance);
						break;
					case "materials":
						instance.materials = reader.Read<UnityEngine.Material[]>(ES3Type_MaterialArray.Instance);
						break;
					case "material":
						instance.material = reader.Read<UnityEngine.Material>(ES3Type_Material.Instance);
						break;
					case "sharedMaterial":
						instance.sharedMaterial = reader.Read<UnityEngine.Material>(ES3Type_Material.Instance);
						break;
					case "sharedMaterials":
						instance.sharedMaterials = reader.Read<UnityEngine.Material[]>(ES3Type_MaterialArray.Instance);
						break;
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_TrailRendererArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_TrailRendererArray() : base(typeof(UnityEngine.TrailRenderer[]), ES3UserType_TrailRenderer.Instance)
		{
			Instance = this;
		}
	}
}