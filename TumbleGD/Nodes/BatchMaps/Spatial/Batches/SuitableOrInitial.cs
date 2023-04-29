using TumbleGD.Nodes.BatchMaps.Spatial.Batches.Measurement;
using TumbleGD.Nodes.BatchMaps.Spatial.Entities;
using TumbleGD.Nodes.BatchMaps.Spatial.Occupation;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Batches;

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