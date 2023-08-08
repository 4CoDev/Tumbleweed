using DotGod.Node.Spatial.Batch;
using DotGod.Node.Spatial.Batch.Space;

namespace DotGod.Node.Spatial.Spaced.Abstract;

public interface IBatch : Any
{
	ISpace Space { get; }
}