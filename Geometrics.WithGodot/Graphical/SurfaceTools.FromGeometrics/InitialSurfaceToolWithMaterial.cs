using Godot;
using Tumbleweed.Scalars;
using Tumbleweed.WithGodot.PrimitiveTypes;
using Tumbleweed.WithGodot.SurfaceTools;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.SurfaceTools.FromGeometrics;

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