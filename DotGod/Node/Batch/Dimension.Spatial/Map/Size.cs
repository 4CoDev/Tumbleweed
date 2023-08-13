using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;

namespace DotGod.Node.Batch.Dimension.Spatial.Map;

public sealed class Size : Envelope<Tumbleweed.Number.Real.Any>
{
	public Size(Any map) : base
	(
		new Result<Tumbleweed.Number.Real.Any>(
			() => map.Size)
	)
	{
	}
}