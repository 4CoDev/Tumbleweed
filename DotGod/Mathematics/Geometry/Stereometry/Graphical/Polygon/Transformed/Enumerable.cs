using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Polygon.Transformed;

public sealed class Enumerable
	: Tumbleweed.Enumerable.Envelope<Any>
{
	public Enumerable
	(
		IEnumerable<Any> polygons,
		Any<Transform3D> transform
	) : base
	(
		new Selected<Any>(
			polygons,
			polygon => new One(polygon, transform))
	)
	{
	}
}