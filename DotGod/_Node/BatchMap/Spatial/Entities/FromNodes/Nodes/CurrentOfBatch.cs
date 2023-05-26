using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed._Enumerable.FromStorage;
using Tumbleweed.Scalar;
using Tumbleweed.Storage.Element;

namespace DotGod._Node.BatchMap.Spatial.Entities.FromNodes.Nodes;

public sealed class CurrentOfBatch : EnumerableEnvelope<Node>
{
	public CurrentOfBatch(IScalar<Node3D> space) : base
	(
		new EnumerableOfElement<Node>(
			new GlobalWithKey<IEnumerable<Node>>(
				space, "Entities.Nodes.Current"))
	)
	{
	}
}