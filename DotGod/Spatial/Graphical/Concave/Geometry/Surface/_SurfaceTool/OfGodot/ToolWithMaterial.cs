using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot;

public sealed class ToolWithMaterial : Any<SurfaceTool>
{
	public ToolWithMaterial
	(
		Any<SurfaceTool> origin,
		Any<Material> material
	)
	{
		this.origin = origin;
		this.material = material;
	}

	public SurfaceTool Value
	{
		get
		{
			SurfaceTool result = origin.Value;
			result.SetMaterial(material.Value);
			return result;
		}
	}

	private readonly Any<SurfaceTool> origin;
	
	private readonly Any<Material> material;
}