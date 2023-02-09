using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools;

public sealed class SurfaceToolWithMaterial : IScalar<SurfaceTool>
{
	public SurfaceToolWithMaterial
	(
		IScalar<SurfaceTool> origin,
		IScalar<Material> material
	)
	{
		this.origin = origin;
		this.material = material;
	}
	
	public SurfaceTool Value()
	{
		SurfaceTool result = origin.Value();
		result.SetMaterial(material.Value());
		return result;
	}
	
	private readonly IScalar<SurfaceTool> origin;
	
	private readonly IScalar<Material> material;
}