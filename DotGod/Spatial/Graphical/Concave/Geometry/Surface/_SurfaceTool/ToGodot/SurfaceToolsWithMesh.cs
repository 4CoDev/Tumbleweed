using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Tumbleweed._Enumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.
	ToGodot;

public sealed class SurfaceToolsWithMesh
	: EnumerableEnvelope<SurfaceTool>
{
	public SurfaceToolsWithMesh(IMesh mesh) : base
	(
		new SurfaceToolsWithSurfaces(
			new EnumerableOfFunction<ISurface>(
				() => mesh.Surfaces))
	)
	{
	}
}