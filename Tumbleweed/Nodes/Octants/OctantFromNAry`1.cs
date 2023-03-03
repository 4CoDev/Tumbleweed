using Tumbleweed.Nodes.NAry;

namespace Tumbleweed.Nodes.Octants;

public sealed class OctantFromNAry<T> : NAryNodeEnvelope<T>
{
	public OctantFromNAry(INAryNode<T> node) : base
	(
		new NAry.FromSystem.NodeWithArity<T>(node, 8)
	)
	{
	}
}