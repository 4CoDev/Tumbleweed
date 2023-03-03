using Tumbleweed.Hashes;
using Tumbleweed.Nodes.NAry.Equality;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Nodes.NAry;

public sealed class NAryNodeWithValues<T> : INAryNode<T>
{
	public NAryNodeWithValues
	(
		IEnumerable<INAryNode<T>> children,
		T content
	)
	{ 
		Children = children;
		Content = content;
	}

	public override bool Equals(object? @object) =>
		new EqualityOfTwoNullables<T>(this, @object).State;

	public override int GetHashCode() =>
		new CodeFromNullables(Children, Content).Value;

	public override string ToString() =>
		new StringFromNullables(Children, Content).Value;
	
	public IEnumerable<INAryNode<T>> Children { get; }

	public T Content { get; }
}