using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial._Node.Batch.Space;

public interface ISpace
{
	Any<Tumbleweed.Number.Real.Any> From { get; }
	
	Any<Tumbleweed.Number.Real.Any> To { get; }
}