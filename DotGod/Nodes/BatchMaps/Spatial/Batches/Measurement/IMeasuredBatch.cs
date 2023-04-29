using DotGod.Nodes.BatchMaps.Spatial.Occupation;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches.Measurement;

public interface IMeasuredBatch : ISpatialBatch
{
	IOccupiedSpace Space { get; }
}