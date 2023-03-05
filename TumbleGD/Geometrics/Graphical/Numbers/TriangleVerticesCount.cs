using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Numbers;

public sealed class TriangleVerticesCount : ScalarEnvelope<Int32>
{
	public TriangleVerticesCount() : base
	(
		new ScalarOfValue<Int32>(3)
	)
	{
	}
}