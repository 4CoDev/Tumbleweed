using DotGod.Spatial._Node.Batch;
using DotGod.Spatial._Node.Batch.Space;

namespace DotGod.Spatial._Node.Spaced.Abstract;

public interface IBatch : Any
{
	ISpace Space { get; }
}