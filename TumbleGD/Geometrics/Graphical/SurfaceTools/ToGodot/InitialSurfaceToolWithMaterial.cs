using Godot;
using TumbleGD.Geometrics.Graphical.PrimitiveTypes;
using TumbleGD.Geometrics.Graphical.SurfaceTools.OfGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.ToGodot;

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