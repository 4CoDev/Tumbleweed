using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Polygons.Triangles.FromGodot.
	FromSurface;

public sealed class TrianglesOfHolistic
	: EnumerableEnvelope<IPolygon>
{
	public TrianglesOfHolistic
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface
	) : base
	(
		new EnumerableOfFunction<IPolygon>(
			() => Function(mesh, surface))
	)
	{
	}

	private static IEnumerable<IPolygon> Function
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface
	)
	{
		throw new NotImplementedException();
	}
}