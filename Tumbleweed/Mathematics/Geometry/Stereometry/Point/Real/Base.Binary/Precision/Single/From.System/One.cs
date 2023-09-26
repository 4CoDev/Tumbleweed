using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Coordinate.X.Actual;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.With.Coordinate.Definition;
using Tumbleweed.Mathematics.Number.Real;
using System = System;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Base.Binary.Precision.Single.From.System;

public sealed class One : Envelope<Any>
{
	public One
	(
		Any<System::Single> origin
	) : base
	(
		new Unique<Any>(
			new Mathematics.Number.Real.Binary.Precision.Single.From.System.One(
				new One<System::Single>(origin)),
			new Mathematics.Number.Real.Binary.Precision.Single.From.System.One(
				new One<System::Single>(origin)),
			new Mathematics.Number.Real.Binary.Precision.Single.From.System.One(
				new One<System::Single>(origin)))
	)
	{
	}
}