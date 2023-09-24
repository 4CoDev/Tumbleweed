using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;
using Tumbleweed.Point.Spatial.Generic;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Member;

public sealed class Size : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Size(Any map) : base
	(
		new Result<Tumbleweed.Mathematics.Number.Real.Any>(
			() => map.Size)
	)
	{
	}
}