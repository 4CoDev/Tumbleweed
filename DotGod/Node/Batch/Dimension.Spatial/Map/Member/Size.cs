using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Function.Result;


namespace DotGod.Node.Batch.Dimension.Spatial.Map.Member;

public sealed class Size : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Size(Any map) : base
	(
		new Actual<Tumbleweed.Mathematics.Number.Real.Any>(
			() => map.Size)
	)
	{
	}
}