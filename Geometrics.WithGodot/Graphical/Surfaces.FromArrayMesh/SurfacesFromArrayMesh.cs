using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Geometrics.Graphical.Surfaces;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.Surfaces.FromArrayMesh;

public sealed class SurfacesFromArrayMesh : EnumerableEnvelope<ISurface>
{
	public SurfacesFromArrayMesh(IScalar<ArrayMesh> mesh) : base
	(
		new EnumerableOfScalar<ISurface>(
			new Scalar.SurfacesFromArrayMesh(mesh))
	)
	{
	}
}