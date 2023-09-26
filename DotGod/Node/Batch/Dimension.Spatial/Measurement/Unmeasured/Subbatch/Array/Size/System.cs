using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.With.Coordinate.Definition;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Subbatch.Array.Size;

public sealed class System : Envelope<System::Int32>
{
	public System() : base
	(
		new Uniform
			<System::Int32>
			(2)
	)
	{
	}
}