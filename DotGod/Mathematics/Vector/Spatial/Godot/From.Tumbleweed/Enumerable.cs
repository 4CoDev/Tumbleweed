using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Enumerable = Tumbleweed.Enumerable;
using Godot = Godot;
using SCG = System.Collections.Generic;

namespace DotGod.Mathematics.Vector.Spatial.Godot.From.Tumbleweed;

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
				point => new One(point).Value
			)
	)
	{
	}
}