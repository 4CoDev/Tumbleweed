using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons.FromArrayMesh;

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