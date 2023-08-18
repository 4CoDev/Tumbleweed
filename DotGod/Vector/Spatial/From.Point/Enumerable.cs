using Enumerable = Tumbleweed.Enumerable;
using Godot = Godot;
using SCG = System.Collections.Generic;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using Vector = DotGod.Vector.Spatial;

namespace DotGod.Vector.Spatial.From.Point;

public sealed class Enumerable : Enumerable::Envelope<Godot::Vector3>
{
	public Enumerable
	(
		SCG::IEnumerable<Point::Any<Real::Any>> points
	) : base
	(
		new Enumerable::Selected
			<Point::Any<Real::Any>, Godot::Vector3>
			(
				points,
				point => new Vector::From.Point.One(point).Value
			)
	)
	{
	}
}