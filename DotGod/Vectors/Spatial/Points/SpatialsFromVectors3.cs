using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Vectors.Spatial.Points;

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