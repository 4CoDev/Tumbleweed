using TumbleGD.Nodes.BatchMaps.Spatial.Occupation;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Batches.Measurement;

public interface IMeasuredBatch : ISpatialBatch
{
	IOccupiedSpace Space { get; }
}