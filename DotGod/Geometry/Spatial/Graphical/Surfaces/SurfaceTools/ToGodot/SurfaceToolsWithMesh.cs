using DotGod.Geometry.Spatial.Graphical.Meshes;
using Godot;
using Tumbleweed.Enumerables;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces.SurfaceTools.
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