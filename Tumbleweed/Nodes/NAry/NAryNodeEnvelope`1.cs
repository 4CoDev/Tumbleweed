namespace Tumbleweed.Nodes.NAry;

public abstract class NAryNodeEnvelope<T> : INAryNode<T>
{
	protected NAryNodeEnvelope(INAryNode<T> node) =>
		this.node = node;

	public IEnumerable<INAryNode<T>> Children =>
		node.Children;

	public T Content => node.Content;

	public override bool Equals(object? @object) =>
		node.Equals(@object);

	public override int GetHashCode() =>
		node.GetHashCode();

	public override string? ToString() =>
		node.ToString();

	private readonly INAryNode<T> node;
}