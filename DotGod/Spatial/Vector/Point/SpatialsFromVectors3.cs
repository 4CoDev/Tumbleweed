using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial.Vector.Point;

public sealed class SpatialsFromVectors3 : Tumbleweed.Enumerable.Envelope<Any<Any>>
{
	public SpatialsFromVectors3(IEnumerable<Vector3> vectors) : base
	(
		new Selected<Vector3, Any<Any>>(
			vectors,
			vector => new PointFromVector3(vector))
	)
	{
	}
}