using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace DotGod.Mathematics.Vector.Spatial.Tumbleweed.From.Godot;

public sealed class Enumerable : global::Tumbleweed.Enumerable.Envelope<Any<Any>>
{
	public Enumerable(IEnumerable<Vector3> vectors) : base
	(
		new Selected<Vector3, Any<Any>>(
			vectors,
			vector => new One(vector))
	)
	{
	}
}