using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Vectors.Spatial.Points;

public sealed class SpatialsFromVectors3 :
	EnumerableEnvelope<ISpatial<IReal>>
{
	public SpatialsFromVectors3(IEnumerable<Vector3> vectors) : base
	(
		new SelectedByExpression<Vector3, ISpatial<IReal>>(
			vectors,
			vector => new SpatialFromVector3(vector))
	)
	{
	}
}