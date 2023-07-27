using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.FromGodot.
	FromSurface;

public sealed class TrianglesOfHolistic
	: Tumbleweed.Enumerable.Envelope<IPolygon>
{
	public TrianglesOfHolistic
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface
	) : base
	(
		new Result<IPolygon>(
			() => Function(mesh, surface))
	)
	{
	}

	private static IEnumerable<IPolygon> Function
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface
	)
	{
		throw new NotImplementedException();
	}
}