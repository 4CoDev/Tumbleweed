using Tumbleweed.Bits;
using Tumbleweed.Numerics.Integers.Signed.ToSystem.Ints32;

namespace Tumbleweed.Nodes.NAry;

public sealed class NodeWithArity<T> : NAryNodeEnvelope<T>
{
	public NodeWithArity
	(
		INAryNode<T> node,
		IEnumerable<IBit> arity
	) : base
	(
		new FromSystem.NodeWithArity<T>(
			node,
			new Int32FromNatural(arity))
	)
	{
	}
}