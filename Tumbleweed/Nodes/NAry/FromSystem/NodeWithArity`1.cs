using Tumbleweed.Scalars;

namespace Tumbleweed.Nodes.NAry.FromSystem;

public sealed class NodeWithArity<T> : NAryNodeEnvelope<T>
{
	public NodeWithArity
	(
		INAryNode<T> node,
		int arity
	) : this
	(
		node,
		new ScalarOfValue<int>(arity)
	)
	{
	}
	
	public NodeWithArity
	(
		INAryNode<T> node,
		IScalar<int> arity
	) : base
	(
		new NAryNodeOfDelegate<T>(() => Function(node, arity))
	)
	{
	}

	private static INAryNode<T> Function
	(
		INAryNode<T> node,
		IScalar<int> arity
	)
	{
		if (node.Children.Count() <= arity.Value) return node;
		throw new InvalidOperationException("Node arity is wrong.");
	}
}