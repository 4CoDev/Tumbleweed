using Godot;
using TumbleGD.Geometrics.Graphical.PrimitiveTypes;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.FromGeometrics;

public sealed class InitialSurfaceToolWithMaterial
	: ScalarEnvelope<SurfaceTool>
{
	public InitialSurfaceToolWithMaterial(IScalar<Material> material) : base
	(
		new SurfaceToolWithMaterial(
			new SurfaceToolWithPrimitiveType(new Triangles()),
			material)
	)
	{
	}
}