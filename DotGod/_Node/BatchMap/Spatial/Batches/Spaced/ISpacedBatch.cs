using DotGod._Node.BatchMap.Spatial.Spaces;

namespace DotGod._Node.BatchMap.Spatial.Batches.Spaced;

public interface ISpacedBatch : IBatch
{
	ISpace Space { get; }
}