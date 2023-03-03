using Tumbleweed.Nodes.NAry;

namespace Tumbleweed.Nodes.Octants;

public sealed class OctantWithValues<T> : NAryNodeEnvelope<T>
{
	public OctantWithValues
	(
		IEnumerable<INAryNode<T>> children,
		T content
	) : base
	(
		new OctantFromNAry<T>(
			new NAryNodeWithValues<T>(children, content))
	)
	{
	}
}