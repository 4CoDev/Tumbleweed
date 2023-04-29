using DotGod.Nodes.BatchMaps.Spatial.Batches.Measurement;
using DotGod.Nodes.BatchMaps.Spatial.Entities;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

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