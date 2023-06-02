using Tumbleweed.Array;
using Tumbleweed.Scalar.FromArray.FromSpatial;
using Tumbleweed.Spatial.Point;
using INaturalNumber = Tumbleweed.Number.Integer.Natural.INatural;

namespace DotGod.Spatial._Node.Batch.FromArray;

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