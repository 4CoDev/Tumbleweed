using DotGod.Nodes.BatchMaps.Spatial.Spaces.Octants;
using Tumbleweed.Points.Spatial;
using IRealNumber = Tumbleweed.Numbers.Real.IReal;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;

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