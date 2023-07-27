using DotGod.Spatial.Graphical.Concave.Geometry._Mesh;
using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.
	ToGodot;

public sealed class SurfaceToolsWithMesh
	: Envelope<SurfaceTool>
{
	public SurfaceToolsWithMesh(IMesh mesh) : base
	(
		new SurfaceToolsWithSurfaces(
			new Result<ISurface>(
				() => mesh.Surfaces))
	)
	{
	}
}