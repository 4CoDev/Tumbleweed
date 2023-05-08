using Tumbleweed.Numbers.Spatial;
using INaturalNumber = Tumbleweed.Numbers.Integers.Natural.INatural;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

public sealed class SubbatchWithIndex : BatchEnvelope
{
	public SubbatchWithIndex
	(
		IBatch batch,
		ISpatial<INaturalNumber> index
	) : base
	(
		new FromArray.BatchWithIndex(
			new SubbatchesOfBatch(batch).Value,
			index)
	)
	{
	}
}