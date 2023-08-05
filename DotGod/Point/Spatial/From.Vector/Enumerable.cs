using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Point.Spatial.From.Vector;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Any<Any>>
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