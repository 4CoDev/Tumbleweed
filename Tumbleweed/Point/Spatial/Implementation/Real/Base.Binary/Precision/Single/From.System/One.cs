using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using System = System;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single;

namespace Tumbleweed.Point.Spatial.Implementation.Real.Base.Binary.Precision.Single.From.System;

public sealed class One : Point::Envelope<Real::Any>
{
	public One
	(
		Point::Any<System::Single> origin
	) : base
	(
		new Point::With.Coordinates.Unique<Real::Any>(
			new Single::From.System.One(
				new Point::Coordinate.X.Actual.One<System::Single>(origin)),
			new Single::From.System.One(
				new Point::Coordinate.X.Actual.One<System::Single>(origin)),
			new Single::From.System.One(
				new Point::Coordinate.X.Actual.One<System::Single>(origin)))
	)
	{
	}
}