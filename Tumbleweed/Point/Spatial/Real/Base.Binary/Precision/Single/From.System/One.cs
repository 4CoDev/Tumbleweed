using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Spatial.Generic;
using Tumbleweed.Point.Spatial.Generic.Coordinate.X.Actual;
using Tumbleweed.Point.Spatial.Generic.With.Coordinate.Definition;
using Real = Tumbleweed.Mathematics.Number.Real;
using System = System;
using Single = Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single;

namespace Tumbleweed.Point.Spatial.Real.Base.Binary.Precision.Single.From.System;

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