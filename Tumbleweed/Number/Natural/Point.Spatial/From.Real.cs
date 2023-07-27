using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using SpatialPoint = Tumbleweed.Number.Natural.Point.Spatial;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Natural.Point.Spatial.From;

public sealed class Real : Envelope<Natural.Any>
{
	public Real(Any<Number.Real.Any> real) : base
	(
		new SpatialPoint.With.Coordinates(
			new Natural.From.Real(new XOfPoint(real)),
			new Natural.From.Real(new YOfPoint(real)),
			new Natural.From.Real(new ZOfPoint(real)))
	)
	{
	}
}