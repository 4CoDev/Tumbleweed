using DotGod.Spatial._Node.Batch.Spaces.Octants;
using Tumbleweed.Spatial.Point;
using IRealNumber = Tumbleweed.Number.Real.IReal;

namespace DotGod.Spatial._Node.Spaced.Batch;

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