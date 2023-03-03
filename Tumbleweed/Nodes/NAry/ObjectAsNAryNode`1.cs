namespace Tumbleweed.Nodes.NAry;

public sealed class ObjectAsNAryNode<T> : NAryNodeEnvelope<T>
{
	public ObjectAsNAryNode(object @object) : base
	(
		new NAryNodeOfDelegate<T>(
			() => (INAryNode<T>) @object)
	)
	{
	}
}