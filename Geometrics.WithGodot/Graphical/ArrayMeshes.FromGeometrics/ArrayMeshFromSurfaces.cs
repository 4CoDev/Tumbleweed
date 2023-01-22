using Godot;
using Tumbleweed.Geometrics.Graphical.Surfaces;
using Tumbleweed.Geometrics.WithGodot.Graphical.SurfaceTools.FromGeometrics;
using Tumbleweed.Scalars;
using Tumbleweed.WithGodot.ArrayMeshes;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.ArrayMeshes.
	FromGeometrics;

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
