using DotGod.Geometry.Spatial.Graphical._Mesh.PrimitiveType;
using DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.OfGodot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.ToGodot;

public sealed class InitialSurfaceToolWithMaterial
	: ScalarEnvelope<SurfaceTool>
{
	public InitialSurfaceToolWithMaterial(IScalar<Material> material) : base
	(
		new ToolWithMaterial(
			new ToolWithPrimitiveType(new TrianglesType()),
			material)
	)
	{
	}
}