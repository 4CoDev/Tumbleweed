using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Real.Base.Binary.Precision.Single.With.Coordinate.System.Definition;

namespace Tumbleweed.Mathematics.Vector.Spatial.Real.Literal;

public sealed class Unit : Envelope<Any>
{
	public Unit() : base
	(
		new Uniform(1)
	)
	{
	}
}