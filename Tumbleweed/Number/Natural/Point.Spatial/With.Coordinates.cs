using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.With.Coordinates;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Natural.Point.Spatial.With;

public sealed class Coordinates : Envelope<Natural.Any>
{
	public Coordinates
	(
		Natural.Any x,
		Natural.Any y,
		Natural.Any z
	) : base
	(
		new Unique<Any>(x, y, z)
	)
	{
	}
}