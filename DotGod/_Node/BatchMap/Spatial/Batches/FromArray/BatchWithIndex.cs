using Tumbleweed.Array;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar.FromArray.FromSpatial;
using INaturalNumber = Tumbleweed.Number.Integer.Natural.INatural;

namespace DotGod._Node.BatchMap.Spatial.Batches.FromArray;

public sealed class BatchWithIndex : BatchEnvelope
{
	public BatchWithIndex
	(
		IArray<IBatch> array,
		IPoint<INaturalNumber> indices
	) : base
	(
		new BatchOfScalar(
			new ScalarWithIndex<IBatch>(array, indices))
	)
	{
	}
}