using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Enumerable = Tumbleweed.Enumerable;
using Godot = Godot;
using SCG = System.Collections.Generic;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;
using Vector = DotGod.Vector.Spatial;

namespace DotGod.Vector.Spatial.From.Point;

public sealed class Enumerable : Enumerable::Envelope<Godot::Vector3>
{
	public Enumerable
	(
		SCG::IEnumerable<Any<Any>> points
	) : base
	(
		new Enumerable::Selected
			<Any<Any>, Godot::Vector3>
			(
				points,
				point => new Vector::From.Point.One(point).Value
			)
	)
	{
	}
}