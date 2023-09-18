using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Natural.With.Coordinate.Definition;
using Tumbleweed.Point.Spatial.Real.Coordinate;
using Tumbleweed.Point.Spatial.Real.Coordinate.X;
using Tumbleweed.Point.Spatial.Real.Coordinate.Y;
using Tumbleweed.Point.Spatial.Real.Coordinate.Z;
using One = Tumbleweed.Point.Spatial.Real.Coordinate.Y.Value.One;
using SpatialPoint = Tumbleweed.Number.Natural.Point.Spatial;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Natural.Point.Spatial.From;

public sealed class Real : Envelope<Natural.Any>
{
	public Real(Any<Number.Real.Any> real) : base
	(
		new Coordinates(
			new Natural.From.Real(new Tumbleweed.Point.Spatial.Real.Coordinate.X.Value.One(real)),
			new Natural.From.Real(new One(real)),
			new Natural.From.Real(new Tumbleweed.Point.Spatial.Real.Coordinate.Z.Value.One(real)))
	)
	{
	}
}