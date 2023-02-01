using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Numbers;

public sealed class TriangleVerticesCount : ScalarEnvelope<int>
{
	public TriangleVerticesCount() : base
	(
		new ScalarOfValue<int>(3)
	)
	{
	}
}