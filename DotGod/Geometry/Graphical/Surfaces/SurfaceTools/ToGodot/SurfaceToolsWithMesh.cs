using DotGod.Geometry.Graphical.Meshes;
using Godot;
using Tumbleweed.Enumerables;

namespace DotGod.Geometry.Graphical.Surfaces.SurfaceTools.
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