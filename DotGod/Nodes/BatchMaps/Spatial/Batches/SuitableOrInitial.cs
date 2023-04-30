using DotGod.Nodes.BatchMaps.Spatial.Batches.Measurement;
using DotGod.Nodes.BatchMaps.Spatial.Occupation;
using DotGod.Nodes.BatchMaps.Spatial.Entities;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches;

public sealed class SuitableOrInitial : BatchEnvelope
{
	public SuitableOrInitial
	(
		IMeasuredBatch initial,
		IOccupiedSpace space
	) : base
	(
		new BatchOfFunction(
			() => Function(initial, space))
	)
	{
	}

	private static ISpatialBatch Function
	(
		IMeasuredBatch initial,
		IOccupiedSpace space
	)
	{
		throw new NotImplementedException();
	}
}