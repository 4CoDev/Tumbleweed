using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.FromGodot.
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