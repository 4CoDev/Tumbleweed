using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Vector.Spatial.Point;

public sealed class SpatialsFromVectors3 :
	EnumerableEnvelope<IPoint<IReal>>
{
	public SpatialsFromVectors3(IEnumerable<Vector3> vectors) : base
	(
		new SelectedByExpression<Vector3, IPoint<IReal>>(
			vectors,
			vector => new PointFromVector3(vector))
	)
	{
	}
}