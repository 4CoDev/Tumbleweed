using Godot;
using TumbleGD.Geometrics.Graphical.Meshes.PrimitiveTypes;
using TumbleGD.Geometrics.Graphical.Surfaces.SurfaceTools.OfGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.SurfaceTools.ToGodot;

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