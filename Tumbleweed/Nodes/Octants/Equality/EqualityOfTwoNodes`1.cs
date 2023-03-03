using Tumbleweed.Bits;
using Tumbleweed.Nodes.NAry;

namespace Tumbleweed.Nodes.Octants.Equality;

public sealed class EqualityOfTwoNodes<T> : BitEnvelope
{
	public EqualityOfTwoNodes
	(
		object first,
		object second
	) : this
	(
		new ObjectAsNAryNode<T>(first),
		new ObjectAsNAryNode<T>(second)
	)
	{
	}
	
	public EqualityOfTwoNodes
	(
		INAryNode<T> first,
		INAryNode<T> second
	) : base
	(
		new Nodes.NAry.Equality.EqualityOfTwoNodes<T>(
			new OctantFromNAry<T>(first),
			new OctantFromNAry<T>(second))
	)
	{
	}
}