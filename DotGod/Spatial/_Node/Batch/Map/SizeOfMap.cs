using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Point.Spatial.Function;

namespace DotGod.Spatial._Node.Batch.Map;

public sealed class SizeOfMap : Envelope<Tumbleweed.Number.Real.Any>
{
	public SizeOfMap(IBatchMap map) : base
	(
		new Result<Tumbleweed.Number.Real.Any>(
			() => map.Size)
	)
	{
	}
}