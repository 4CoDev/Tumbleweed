using Point = Tumbleweed.Point.Spatial;
using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured.Subbatch.Array.Size;

public sealed class System : Point::Envelope<System::Int32>
{
	public System() : base
	(
		new Point::With.Coordinates.Uniform
			<System::Int32>
			(2)
	)
	{
	}
}