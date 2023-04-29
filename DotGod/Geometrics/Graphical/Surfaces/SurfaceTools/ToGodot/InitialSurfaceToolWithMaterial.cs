using DotGod.Geometrics.Graphical.Meshes.PrimitiveTypes;
using DotGod.Geometrics.Graphical.Surfaces.SurfaceTools.OfGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Surfaces.SurfaceTools.ToGodot;

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