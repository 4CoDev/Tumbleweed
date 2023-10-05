using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Coordinate.X.Actual;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;
using System = System;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Base.Binary.Precision.Single.From.System;

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