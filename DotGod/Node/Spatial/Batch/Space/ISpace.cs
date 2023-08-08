using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Spatial.Batch.Space;

public interface ISpace
{
	Any<Tumbleweed.Number.Real.Any> From { get; }
	
	Any<Tumbleweed.Number.Real.Any> To { get; }
}