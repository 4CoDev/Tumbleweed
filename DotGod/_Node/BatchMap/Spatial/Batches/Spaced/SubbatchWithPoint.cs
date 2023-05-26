using DotGod._Node.BatchMap.Spatial.Spaces.Octants;
using Tumbleweed.Point.Spatial;
using IRealNumber = Tumbleweed.Number.Real.IReal;

namespace DotGod._Node.BatchMap.Spatial.Batches.Spaced;

public sealed class SubbatchWithPoint : BatchEnvelope
{
	public SubbatchWithPoint
	(
		ISpacedBatch batch,
		IPoint<IRealNumber> point
	) : base
	(
		new SubbatchWithIndex(
			batch,
			new OctantIndexWithPoint(batch, point))
	)
	{
	}
}