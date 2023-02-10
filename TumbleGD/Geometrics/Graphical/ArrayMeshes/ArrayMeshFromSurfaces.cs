using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using TumbleGD.Geometrics.Graphical.SurfaceTools.FromGeometrics;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.ArrayMeshes;

public sealed class ArrayMeshFromSurfaces : ScalarEnvelope<ArrayMesh>
{
	public ArrayMeshFromSurfaces(IEnumerable<ISurface> surfaces) : base
	(
		new ArrayMeshWithSurfaceTools(
			new SurfaceToolsWithSurfaces(surfaces),
			new ScalarOfValue<ArrayMesh>(new ArrayMesh()))
	)
	{
	}
}
