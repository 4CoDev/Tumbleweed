using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.OfGodot;

public sealed class ToolWithMaterial : IScalar<SurfaceTool>
{
	public ToolWithMaterial
	(
		IScalar<SurfaceTool> origin,
		IScalar<Material> material
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

	private readonly IScalar<SurfaceTool> origin;
	
	private readonly IScalar<Material> material;
}