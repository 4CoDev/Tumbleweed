using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using Tumbleweed.Enumerables;

namespace TumbleGD.Geometrics.Graphical.Surfaces.SurfaceTools.
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