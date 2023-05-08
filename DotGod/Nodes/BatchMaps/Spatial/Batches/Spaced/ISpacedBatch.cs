using DotGod.Nodes.BatchMaps.Spatial.Spaces;

namespace DotGod.Nodes.BatchMaps.Spatial.Batches.Spaced;

public interface ISpacedBatch : IBatch
{
	ISpace Space { get; }
}