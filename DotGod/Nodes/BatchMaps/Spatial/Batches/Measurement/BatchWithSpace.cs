using DotGod.Nodes.BatchMaps.Spatial.Entities;
using DotGod.Nodes.BatchMaps.Spatial.Occupation;
using DotGod.Nodes.BatchMaps.Spatial.FromNodes;
using Tumbleweed.Arrays;
using Tumbleweed.Nullability;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches.Measurement;

public sealed class BatchWithSpace : IMeasuredBatch
{
	public BatchWithSpace
	(
		ISpatialBatch batch,
		IOccupiedSpace space
	)
	{
		Subbatches = new SubbatchesOfBatch(batch);
		Entities = new EntitiesOfBatch(batch);
		Space = space;
	}
	
	public INullable<IArray<ISpatialBatch>> Subbatches { get; }

	public ICollection<ISpatialEntity> Entities { get; }
	
	public IOccupiedSpace Space { get; }
}