using TumbleGD.Nodes.BatchMaps.Spatial.Entities;
using TumbleGD.Nodes.BatchMaps.Spatial.FromNodes;
using TumbleGD.Nodes.BatchMaps.Spatial.Occupation;
using Tumbleweed.Arrays;
using Tumbleweed.Nullability;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Batches.Measurement;

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