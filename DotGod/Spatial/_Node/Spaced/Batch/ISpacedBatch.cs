using DotGod.Spatial._Node.Batch;
using DotGod.Spatial._Node.Batch.Space;

namespace DotGod.Spatial._Node.Spaced.Batch;

public interface ISpacedBatch : IBatch
{
	ISpace Space { get; }
}