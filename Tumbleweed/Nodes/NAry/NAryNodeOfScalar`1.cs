using Tumbleweed.Scalars;

namespace Tumbleweed.Nodes.NAry;

public sealed class NAryNodeOfScalar<T> : INAryNode<T>
{
	public NAryNodeOfScalar(IScalar<INAryNode<T>> node) =>
		this.node = node;

	public IEnumerable<INAryNode<T>> Children =>
		node.Value.Children;

	public T Content => node.Value.Content;

	public override bool Equals(object? @object) =>
		node.Value.Equals(@object);

	public override int GetHashCode() =>
		node.Value.GetHashCode();

	public override string? ToString() =>
		node.Value.ToString();

	private readonly IScalar<INAryNode<T>> node;
}