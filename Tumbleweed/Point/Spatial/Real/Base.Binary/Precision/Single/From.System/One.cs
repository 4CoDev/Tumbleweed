using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.Coordinate.X.Actual;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using Real = Tumbleweed.Number.Real;
using System = System;
using Single = Tumbleweed.Number.Real.Binary.Precision.Single;

namespace Tumbleweed.Point.Spatial.Real.Base.Binary.Precision.Single.From.System;

public sealed class One : Envelope<Real::Any>
{
	public One
	(
		Any<System::Single> origin
	) : base
	(
		new Unique<Real::Any>(
			new Single::From.System.One(
				new One<System::Single>(origin)),
			new Single::From.System.One(
				new One<System::Single>(origin)),
			new Single::From.System.One(
				new One<System::Single>(origin)))
	)
	{
	}
}