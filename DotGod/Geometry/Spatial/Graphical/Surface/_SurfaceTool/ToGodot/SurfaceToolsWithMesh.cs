using DotGod.Geometry.Spatial.Graphical._Mesh;
using Godot;
using Tumbleweed._Enumerable;

namespace DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.
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