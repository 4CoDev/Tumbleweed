using Tumbleweed.Arrays;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars.FromArray.FromSpatial;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches.FromArray;

public sealed class BatchWithIndex : BatchEnvelope
{
	public BatchWithIndex
	(
		IArray<IBatch> array,
		ISpatial<INaturalNumber> indices
	) : base
	(
		new BatchOfScalar(
			new ScalarWithIndex<IBatch>(array, indices))
	)
	{
	}
}