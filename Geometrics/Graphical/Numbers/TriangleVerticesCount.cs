using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.Graphical.Numbers;

public sealed class TriangleVerticesCount : ScalarEnvelope<int>
{
	public TriangleVerticesCount() : base
	(
		new ScalarOfValue<int>(3)
	)
	{
	}
}