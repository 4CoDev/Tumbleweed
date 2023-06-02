using Tumbleweed.Spatial.Point;
using INaturalNumber = Tumbleweed.Number.Integer.Natural.INatural;

namespace DotGod.Spatial._Node.Batch;

public sealed class SubbatchWithIndex : BatchEnvelope
{
	public SubbatchWithIndex
	(
		IBatch batch,
		IPoint<INaturalNumber> index
	) : base
	(
		new FromArray.BatchWithIndex(
			new SubbatchesOfBatch(batch).Value,
			index)
	)
	{
	}
}