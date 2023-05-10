using DotGod.Geometry.Graphical.Meshes.PrimitiveTypes;
using DotGod.Geometry.Graphical.Surfaces.SurfaceTools.OfGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Surfaces.SurfaceTools.ToGodot;

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