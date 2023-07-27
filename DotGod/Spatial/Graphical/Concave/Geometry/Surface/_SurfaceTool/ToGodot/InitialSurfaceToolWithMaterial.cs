using DotGod.Spatial.Graphical.Concave.Geometry._Mesh.PrimitiveType;
using DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.ToGodot;

public sealed class InitialSurfaceToolWithMaterial
	: Envelope<SurfaceTool>
{
	public InitialSurfaceToolWithMaterial(Any<Material> material) : base
	(
		new ToolWithMaterial(
			new ToolWithPrimitiveType(new TrianglesType()),
			material)
	)
	{
	}
}