using TumbleGD.Nodes.BatchMaps.Spatial.Batches.Measurement;
using TumbleGD.Nodes.BatchMaps.Spatial.Entities;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Batches;

public sealed class SuitableForEntity : BatchEnvelope
{
	public SuitableForEntity
	(
		IMeasuredBatch map,
		ISpatialEntity entity
	) : base
	(
		new SuitableForSpace(map, new SpaceOfEntity(entity))
	)
	{
	}
}