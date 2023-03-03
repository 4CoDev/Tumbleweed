using Tumbleweed.Bits;
using Tumbleweed.Bits.Booleans;
using Tumbleweed.Delegates.Functions.Nullary.Equality.ByValues;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nodes.NAry.Equality;

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
		new BitAndBit(
			new EqualityOfTwoFunctions<T>(
				() => first.Content,
				() => second.Content),
			new EqualityOfTwoFunctions<IEnumerable<INAryNode<T>>>(
				() => first.Children,
				() => second.Children))
	)
	{
	}
}