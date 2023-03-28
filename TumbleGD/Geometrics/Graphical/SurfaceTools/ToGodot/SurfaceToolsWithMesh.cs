using Godot;
using TumbleGD.Geometrics.Graphical.Meshes;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.
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