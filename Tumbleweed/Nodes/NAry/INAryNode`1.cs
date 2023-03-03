namespace Tumbleweed.Nodes.NAry;

public interface INAryNode<out T>
{
	IEnumerable<INAryNode<T>> Children { get; }
	
	T Content { get; }
}